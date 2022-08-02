// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: protos/CloudGatewayDcpRequestResponses.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Skyline.Dataminer.Proto.CloudGatewayDcpRequestResponses {

  /// <summary>Holder for reflection information generated from protos/CloudGatewayDcpRequestResponses.proto</summary>
  public static partial class CloudGatewayDcpRequestResponsesReflection {

    #region Descriptor
    /// <summary>File descriptor for protos/CloudGatewayDcpRequestResponses.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CloudGatewayDcpRequestResponsesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cixwcm90b3MvQ2xvdWRHYXRld2F5RGNwUmVxdWVzdFJlc3BvbnNlcy5wcm90",
            "bxI3U2t5bGluZS5EYXRhbWluZXIuUHJvdG8uQ2xvdWRHYXRld2F5RGNwUmVx",
            "dWVzdFJlc3BvbnNlcyJ1ChlEY3BSZXF1ZXN0UmVzcG9uc2VSZXF1ZXN0ElgK",
            "C2RjcF9yZXF1ZXN0GAEgASgLMkMuU2t5bGluZS5EYXRhbWluZXIuUHJvdG8u",
            "Q2xvdWRHYXRld2F5RGNwUmVxdWVzdFJlc3BvbnNlcy5EY3BSZXF1ZXN0Ip8B",
            "ChpEY3BSZXF1ZXN0UmVzcG9uc2VSZXNwb25zZRIWCg5jb250YWluc19lcnJv",
            "chgBIAEoCBINCgVlcnJvchgCIAEoCRJaCgxkY3BfcmVzcG9uc2UYAyABKAsy",
            "RC5Ta3lsaW5lLkRhdGFtaW5lci5Qcm90by5DbG91ZEdhdGV3YXlEY3BSZXF1",
            "ZXN0UmVzcG9uc2VzLkRjcFJlc3BvbnNlIlEKCkRjcFJlcXVlc3QSDQoFdG9r",
            "ZW4YASABKAkSDAoEcGF0aBgCIAEoCRIRCglqc29uX2JvZHkYAyABKAkSEwoL",
            "aHR0cF9tZXRob2QYBCABKAkiLwoLRGNwUmVzcG9uc2USEgoKc3RhdHVzQ29k",
            "ZRgBIAEoBRIMCgRib2R5GAIgASgJYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Skyline.Dataminer.Proto.CloudGatewayDcpRequestResponses.DcpRequestResponseRequest), global::Skyline.Dataminer.Proto.CloudGatewayDcpRequestResponses.DcpRequestResponseRequest.Parser, new[]{ "DcpRequest" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Skyline.Dataminer.Proto.CloudGatewayDcpRequestResponses.DcpRequestResponseResponse), global::Skyline.Dataminer.Proto.CloudGatewayDcpRequestResponses.DcpRequestResponseResponse.Parser, new[]{ "ContainsError", "Error", "DcpResponse" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Skyline.Dataminer.Proto.CloudGatewayDcpRequestResponses.DcpRequest), global::Skyline.Dataminer.Proto.CloudGatewayDcpRequestResponses.DcpRequest.Parser, new[]{ "Token", "Path", "JsonBody", "HttpMethod" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Skyline.Dataminer.Proto.CloudGatewayDcpRequestResponses.DcpResponse), global::Skyline.Dataminer.Proto.CloudGatewayDcpRequestResponses.DcpResponse.Parser, new[]{ "StatusCode", "Body" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DcpRequestResponseRequest : pb::IMessage<DcpRequestResponseRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DcpRequestResponseRequest> _parser = new pb::MessageParser<DcpRequestResponseRequest>(() => new DcpRequestResponseRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DcpRequestResponseRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Skyline.Dataminer.Proto.CloudGatewayDcpRequestResponses.CloudGatewayDcpRequestResponsesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DcpRequestResponseRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DcpRequestResponseRequest(DcpRequestResponseRequest other) : this() {
      dcpRequest_ = other.dcpRequest_ != null ? other.dcpRequest_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DcpRequestResponseRequest Clone() {
      return new DcpRequestResponseRequest(this);
    }

    /// <summary>Field number for the "dcp_request" field.</summary>
    public const int DcpRequestFieldNumber = 1;
    private global::Skyline.Dataminer.Proto.CloudGatewayDcpRequestResponses.DcpRequest dcpRequest_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Skyline.Dataminer.Proto.CloudGatewayDcpRequestResponses.DcpRequest DcpRequest {
      get { return dcpRequest_; }
      set {
        dcpRequest_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DcpRequestResponseRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DcpRequestResponseRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(DcpRequest, other.DcpRequest)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (dcpRequest_ != null) hash ^= DcpRequest.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (dcpRequest_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(DcpRequest);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (dcpRequest_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(DcpRequest);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (dcpRequest_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DcpRequest);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DcpRequestResponseRequest other) {
      if (other == null) {
        return;
      }
      if (other.dcpRequest_ != null) {
        if (dcpRequest_ == null) {
          DcpRequest = new global::Skyline.Dataminer.Proto.CloudGatewayDcpRequestResponses.DcpRequest();
        }
        DcpRequest.MergeFrom(other.DcpRequest);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (dcpRequest_ == null) {
              DcpRequest = new global::Skyline.Dataminer.Proto.CloudGatewayDcpRequestResponses.DcpRequest();
            }
            input.ReadMessage(DcpRequest);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (dcpRequest_ == null) {
              DcpRequest = new global::Skyline.Dataminer.Proto.CloudGatewayDcpRequestResponses.DcpRequest();
            }
            input.ReadMessage(DcpRequest);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class DcpRequestResponseResponse : pb::IMessage<DcpRequestResponseResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DcpRequestResponseResponse> _parser = new pb::MessageParser<DcpRequestResponseResponse>(() => new DcpRequestResponseResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DcpRequestResponseResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Skyline.Dataminer.Proto.CloudGatewayDcpRequestResponses.CloudGatewayDcpRequestResponsesReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DcpRequestResponseResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DcpRequestResponseResponse(DcpRequestResponseResponse other) : this() {
      containsError_ = other.containsError_;
      error_ = other.error_;
      dcpResponse_ = other.dcpResponse_ != null ? other.dcpResponse_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DcpRequestResponseResponse Clone() {
      return new DcpRequestResponseResponse(this);
    }

    /// <summary>Field number for the "contains_error" field.</summary>
    public const int ContainsErrorFieldNumber = 1;
    private bool containsError_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool ContainsError {
      get { return containsError_; }
      set {
        containsError_ = value;
      }
    }

    /// <summary>Field number for the "error" field.</summary>
    public const int ErrorFieldNumber = 2;
    private string error_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Error {
      get { return error_; }
      set {
        error_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "dcp_response" field.</summary>
    public const int DcpResponseFieldNumber = 3;
    private global::Skyline.Dataminer.Proto.CloudGatewayDcpRequestResponses.DcpResponse dcpResponse_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Skyline.Dataminer.Proto.CloudGatewayDcpRequestResponses.DcpResponse DcpResponse {
      get { return dcpResponse_; }
      set {
        dcpResponse_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DcpRequestResponseResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DcpRequestResponseResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ContainsError != other.ContainsError) return false;
      if (Error != other.Error) return false;
      if (!object.Equals(DcpResponse, other.DcpResponse)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ContainsError != false) hash ^= ContainsError.GetHashCode();
      if (Error.Length != 0) hash ^= Error.GetHashCode();
      if (dcpResponse_ != null) hash ^= DcpResponse.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ContainsError != false) {
        output.WriteRawTag(8);
        output.WriteBool(ContainsError);
      }
      if (Error.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Error);
      }
      if (dcpResponse_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(DcpResponse);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ContainsError != false) {
        output.WriteRawTag(8);
        output.WriteBool(ContainsError);
      }
      if (Error.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Error);
      }
      if (dcpResponse_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(DcpResponse);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ContainsError != false) {
        size += 1 + 1;
      }
      if (Error.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Error);
      }
      if (dcpResponse_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DcpResponse);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DcpRequestResponseResponse other) {
      if (other == null) {
        return;
      }
      if (other.ContainsError != false) {
        ContainsError = other.ContainsError;
      }
      if (other.Error.Length != 0) {
        Error = other.Error;
      }
      if (other.dcpResponse_ != null) {
        if (dcpResponse_ == null) {
          DcpResponse = new global::Skyline.Dataminer.Proto.CloudGatewayDcpRequestResponses.DcpResponse();
        }
        DcpResponse.MergeFrom(other.DcpResponse);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            ContainsError = input.ReadBool();
            break;
          }
          case 18: {
            Error = input.ReadString();
            break;
          }
          case 26: {
            if (dcpResponse_ == null) {
              DcpResponse = new global::Skyline.Dataminer.Proto.CloudGatewayDcpRequestResponses.DcpResponse();
            }
            input.ReadMessage(DcpResponse);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            ContainsError = input.ReadBool();
            break;
          }
          case 18: {
            Error = input.ReadString();
            break;
          }
          case 26: {
            if (dcpResponse_ == null) {
              DcpResponse = new global::Skyline.Dataminer.Proto.CloudGatewayDcpRequestResponses.DcpResponse();
            }
            input.ReadMessage(DcpResponse);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class DcpRequest : pb::IMessage<DcpRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DcpRequest> _parser = new pb::MessageParser<DcpRequest>(() => new DcpRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DcpRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Skyline.Dataminer.Proto.CloudGatewayDcpRequestResponses.CloudGatewayDcpRequestResponsesReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DcpRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DcpRequest(DcpRequest other) : this() {
      token_ = other.token_;
      path_ = other.path_;
      jsonBody_ = other.jsonBody_;
      httpMethod_ = other.httpMethod_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DcpRequest Clone() {
      return new DcpRequest(this);
    }

    /// <summary>Field number for the "token" field.</summary>
    public const int TokenFieldNumber = 1;
    private string token_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Token {
      get { return token_; }
      set {
        token_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "path" field.</summary>
    public const int PathFieldNumber = 2;
    private string path_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Path {
      get { return path_; }
      set {
        path_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "json_body" field.</summary>
    public const int JsonBodyFieldNumber = 3;
    private string jsonBody_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string JsonBody {
      get { return jsonBody_; }
      set {
        jsonBody_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "http_method" field.</summary>
    public const int HttpMethodFieldNumber = 4;
    private string httpMethod_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string HttpMethod {
      get { return httpMethod_; }
      set {
        httpMethod_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DcpRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DcpRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Token != other.Token) return false;
      if (Path != other.Path) return false;
      if (JsonBody != other.JsonBody) return false;
      if (HttpMethod != other.HttpMethod) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Token.Length != 0) hash ^= Token.GetHashCode();
      if (Path.Length != 0) hash ^= Path.GetHashCode();
      if (JsonBody.Length != 0) hash ^= JsonBody.GetHashCode();
      if (HttpMethod.Length != 0) hash ^= HttpMethod.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Token.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Token);
      }
      if (Path.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Path);
      }
      if (JsonBody.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(JsonBody);
      }
      if (HttpMethod.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(HttpMethod);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Token.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Token);
      }
      if (Path.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Path);
      }
      if (JsonBody.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(JsonBody);
      }
      if (HttpMethod.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(HttpMethod);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Token.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Token);
      }
      if (Path.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Path);
      }
      if (JsonBody.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(JsonBody);
      }
      if (HttpMethod.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(HttpMethod);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DcpRequest other) {
      if (other == null) {
        return;
      }
      if (other.Token.Length != 0) {
        Token = other.Token;
      }
      if (other.Path.Length != 0) {
        Path = other.Path;
      }
      if (other.JsonBody.Length != 0) {
        JsonBody = other.JsonBody;
      }
      if (other.HttpMethod.Length != 0) {
        HttpMethod = other.HttpMethod;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Token = input.ReadString();
            break;
          }
          case 18: {
            Path = input.ReadString();
            break;
          }
          case 26: {
            JsonBody = input.ReadString();
            break;
          }
          case 34: {
            HttpMethod = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Token = input.ReadString();
            break;
          }
          case 18: {
            Path = input.ReadString();
            break;
          }
          case 26: {
            JsonBody = input.ReadString();
            break;
          }
          case 34: {
            HttpMethod = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class DcpResponse : pb::IMessage<DcpResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DcpResponse> _parser = new pb::MessageParser<DcpResponse>(() => new DcpResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DcpResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Skyline.Dataminer.Proto.CloudGatewayDcpRequestResponses.CloudGatewayDcpRequestResponsesReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DcpResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DcpResponse(DcpResponse other) : this() {
      statusCode_ = other.statusCode_;
      body_ = other.body_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DcpResponse Clone() {
      return new DcpResponse(this);
    }

    /// <summary>Field number for the "statusCode" field.</summary>
    public const int StatusCodeFieldNumber = 1;
    private int statusCode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int StatusCode {
      get { return statusCode_; }
      set {
        statusCode_ = value;
      }
    }

    /// <summary>Field number for the "body" field.</summary>
    public const int BodyFieldNumber = 2;
    private string body_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Body {
      get { return body_; }
      set {
        body_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DcpResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DcpResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StatusCode != other.StatusCode) return false;
      if (Body != other.Body) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (StatusCode != 0) hash ^= StatusCode.GetHashCode();
      if (Body.Length != 0) hash ^= Body.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (StatusCode != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(StatusCode);
      }
      if (Body.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Body);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (StatusCode != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(StatusCode);
      }
      if (Body.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Body);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (StatusCode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(StatusCode);
      }
      if (Body.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Body);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DcpResponse other) {
      if (other == null) {
        return;
      }
      if (other.StatusCode != 0) {
        StatusCode = other.StatusCode;
      }
      if (other.Body.Length != 0) {
        Body = other.Body;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            StatusCode = input.ReadInt32();
            break;
          }
          case 18: {
            Body = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            StatusCode = input.ReadInt32();
            break;
          }
          case 18: {
            Body = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code