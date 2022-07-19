/*
****************************************************************************
*  Copyright (c) 2022,  Skyline Communications NV  All Rights Reserved.    *
****************************************************************************

By using this script, you expressly agree with the usage terms and
conditions set out below.
This script and all related materials are protected by copyrights and
other intellectual property rights that exclusively belong
to Skyline Communications.

A user license granted for this script is strictly for personal use only.
This script may not be used in any way by anyone without the prior
written consent of Skyline Communications. Any sublicensing of this
script is forbidden.

Any modifications to this script by the user are only allowed for
personal use and within the intended purpose of the script,
and will remain the sole responsibility of the user.
Skyline Communications will not be responsible for any damages or
malfunctions whatsoever of the script resulting from a modification
or adaptation by the user.

The content of this script is confidential information.
The user hereby agrees to keep this confidential information strictly
secret and confidential and not to disclose or reveal it, in whole
or in part, directly or indirectly to any person, entity, organization
or administration without the prior written consent of
Skyline Communications.

Any inquiries can be addressed to:

	Skyline Communications NV
	Ambachtenstraat 33
	B-8870 Izegem
	Belgium
	Tel.	: +32 51 31 35 69
	Fax.	: +32 51 31 01 29
	E-mail	: info@skyline.be
	Web		: www.skyline.be
	Contact	: Ben Vandenberghe

****************************************************************************
Revision History:

DATE		VERSION		AUTHOR			COMMENTS

dd/mm/2022	1.0.0.1		XXX, Skyline	Initial version
****************************************************************************
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Skyline.DataMiner.Automation;
using Skyline.DataMiner.MessageBroker;
using Skyline.DataMiner.MessageBroker.ProtoHelpers;
using Skyline.Dataminer.Proto.CcaGatewayTypes;
using Skyline.Dataminer.Proto.CloudGatewayDcpRequestResponses;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

/// <summary>
/// DataMiner Script Class.
/// </summary>
public class Script
{
	/// <summary>
	/// The Script entry point.
	/// </summary>
	/// <param name="engine">Link with SLAutomation process.</param>
	public void Run(Engine engine)
	{
		// Connect to NATS
		engine.Log("Connecting to NATS...");

		//SLMessageBrokerFactorySingleton.XmlPath = "C:\\Skyline DataMiner\\SLCloud.xml"; is already the default value

		var broker = SLMessageBrokerFactorySingleton.Instance.Create();

		int i;
		for (i = 0; i < 3 && broker == null; i++)
		{
			broker = SLMessageBrokerFactorySingleton.Instance.Create();

			if (broker != null)
			{
				break;
			}

			engine.Log($"Failed to connect to NATS, retrying later... ({i+1})");

			Task.Delay(2000).Wait();
		}

		if (broker == null)
		{
			engine.ExitFail($"Couldn't connect to NATs within {i+1} retries.");
			return;
		}

		engine.Log("Connected to NATS.");

		// Fetch dms authentication token from CloudGateway using NATS
		engine.Log("Fetching DMS Authentication token...");
		
		var tokenResponse = broker.ProtoReqReply(new GetCloudAccessTokenRequest()
		{
			Scopes = "6091cf86-293d-40ae-ba35-8378f60db93e/.default"
		}, GetCloudAccessTokenResponse.Parser);

		if (tokenResponse.Error != null && tokenResponse.Error.ContainsError)
		{
			engine.ExitFail($"Couldn't fetch DMS Authentication token because of {string.Join(";", tokenResponse.Error.Errors.Select(e => $"{e.Type}: {e.Message}"))}.");
			return;
		}

		if (tokenResponse.ExpirationDate.ToDateTimeOffset() <= DateTimeOffset.UtcNow)
		{
			engine.ExitFail("Received an expired DMS Authentication token.");
			return;
		}

		engine.Log("Fetched DMS Authentication token.");

		// Send request over NATS (via CloudGateway DxM to the cloud)
		engine.Log("Sending request to DCP...");

		var requestBody = new JObject();
		requestBody.Add("team_name", "JordyGitIsHere");
		requestBody.Add("team_owner", "jordy.ampe@skyline.be");
		requestBody.Add("tenant_id", "3e20f27a-3ed5-4aad-83bc-335836538d60");
		var response = broker.ProtoReqReply(new DcpRequestResponseRequest()
		{
			DcpRequest = new DcpRequest()
			{
				Token = tokenResponse.AccessToken,
				Path = "/dms-teams/v1-0/team",
				HttpMethod = HttpMethod.Post.ToString(),
				JsonBody = JsonConvert.SerializeObject(requestBody)
			}
		}, DcpRequestResponseResponse.Parser);

		if (response.ContainsError)
		{
			engine.ExitFail($"Couldn't send the request to DCP because of {response.Error}.");
			return;
		}

		engine.Log("Sent request to DCP.");

		// Cleanup
		broker.Dispose();

		// Respond
		engine.ExitSuccess($"Done, all good. Response was: Code: {response.DcpResponse.StatusCode} Body: {response.DcpResponse.JsonBody}");
	}
}