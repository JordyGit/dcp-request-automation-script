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

02/08/2022	1.0.0.1		Jordy Ampe, Skyline	Initial version
****************************************************************************
*/

using System;
using Skyline.DataMiner.Automation;
using SLChatIntegrationHelper;

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
		try
		{
			var ownerEmailParam = engine.GetScriptParam("Team Owner Email");
			if (string.IsNullOrWhiteSpace(ownerEmailParam?.Value))
			{
				engine.ExitFail("'Team Owner Email' parameter is required.");
				return;
			}

			var teamNameParam = engine.GetScriptParam("Team Name");
			if (string.IsNullOrWhiteSpace(teamNameParam?.Value))
			{
				engine.ExitFail("'Team Name' parameter is required.");
				return;
			}
			
			var teamsMemoryFile = engine.GetMemory("Teams");
			if (teamsMemoryFile == null)
			{
				engine.ExitFail("'Teams' memory file is required.");
				return;
			}
			
			if (!ChatIntegrationHelper.Teams.TryCreateTeam(engine.Log, teamNameParam.Value, ownerEmailParam.Value, out var teamId))
			{
				engine.ExitFail("Couldn't create team.");
				return;
			}

			teamsMemoryFile.Set($"{teamNameParam.Value} ({teamId})", teamId);

			engine.ExitSuccess($"The team with id {teamId} should be created soon!");
		}
		catch (ScriptAbortException)
		{
			// Also ExitSuccess is an ScriptAbortException
			throw;
		}
		catch (Exception e)
		{
			engine.ExitFail($"An exception occurred with the following message: {e.Message}");
		}
	}
}