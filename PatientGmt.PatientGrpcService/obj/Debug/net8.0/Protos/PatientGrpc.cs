// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/patient.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace PatientGmt.PatientGrpcService {
  public static partial class PatientProto
  {
    static readonly string __ServiceName = "patient.PatientProto";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PatientGmt.PatientGrpcService.GetPatientByIdRequest> __Marshaller_patient_GetPatientByIdRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PatientGmt.PatientGrpcService.GetPatientByIdRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PatientGmt.PatientGrpcService.GetPatientByIdResponse> __Marshaller_patient_GetPatientByIdResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PatientGmt.PatientGrpcService.GetPatientByIdResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PatientGmt.PatientGrpcService.Empty> __Marshaller_patient_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PatientGmt.PatientGrpcService.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PatientGmt.PatientGrpcService.GetAllPatientsResponse> __Marshaller_patient_GetAllPatientsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PatientGmt.PatientGrpcService.GetAllPatientsResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PatientGmt.PatientGrpcService.AddPatientRequest> __Marshaller_patient_AddPatientRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PatientGmt.PatientGrpcService.AddPatientRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PatientGmt.PatientGrpcService.AddPatientResponse> __Marshaller_patient_AddPatientResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PatientGmt.PatientGrpcService.AddPatientResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PatientGmt.PatientGrpcService.UpdatePatientRequest> __Marshaller_patient_UpdatePatientRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PatientGmt.PatientGrpcService.UpdatePatientRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PatientGmt.PatientGrpcService.UpdatePatientResponse> __Marshaller_patient_UpdatePatientResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PatientGmt.PatientGrpcService.UpdatePatientResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PatientGmt.PatientGrpcService.DeletePatientRequest> __Marshaller_patient_DeletePatientRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PatientGmt.PatientGrpcService.DeletePatientRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PatientGmt.PatientGrpcService.DeletePatientResponse> __Marshaller_patient_DeletePatientResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PatientGmt.PatientGrpcService.DeletePatientResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PatientGmt.PatientGrpcService.GetPatientRendezVousRequest> __Marshaller_patient_GetPatientRendezVousRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PatientGmt.PatientGrpcService.GetPatientRendezVousRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PatientGmt.PatientGrpcService.GetPatientRendezVousResponse> __Marshaller_patient_GetPatientRendezVousResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PatientGmt.PatientGrpcService.GetPatientRendezVousResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PatientGmt.PatientGrpcService.GetPatientByIdRequest, global::PatientGmt.PatientGrpcService.GetPatientByIdResponse> __Method_GetPatientById = new grpc::Method<global::PatientGmt.PatientGrpcService.GetPatientByIdRequest, global::PatientGmt.PatientGrpcService.GetPatientByIdResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPatientById",
        __Marshaller_patient_GetPatientByIdRequest,
        __Marshaller_patient_GetPatientByIdResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PatientGmt.PatientGrpcService.Empty, global::PatientGmt.PatientGrpcService.GetAllPatientsResponse> __Method_GetAllPatients = new grpc::Method<global::PatientGmt.PatientGrpcService.Empty, global::PatientGmt.PatientGrpcService.GetAllPatientsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllPatients",
        __Marshaller_patient_Empty,
        __Marshaller_patient_GetAllPatientsResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PatientGmt.PatientGrpcService.AddPatientRequest, global::PatientGmt.PatientGrpcService.AddPatientResponse> __Method_AddPatient = new grpc::Method<global::PatientGmt.PatientGrpcService.AddPatientRequest, global::PatientGmt.PatientGrpcService.AddPatientResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddPatient",
        __Marshaller_patient_AddPatientRequest,
        __Marshaller_patient_AddPatientResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PatientGmt.PatientGrpcService.UpdatePatientRequest, global::PatientGmt.PatientGrpcService.UpdatePatientResponse> __Method_UpdatePatient = new grpc::Method<global::PatientGmt.PatientGrpcService.UpdatePatientRequest, global::PatientGmt.PatientGrpcService.UpdatePatientResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdatePatient",
        __Marshaller_patient_UpdatePatientRequest,
        __Marshaller_patient_UpdatePatientResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PatientGmt.PatientGrpcService.DeletePatientRequest, global::PatientGmt.PatientGrpcService.DeletePatientResponse> __Method_DeletePatient = new grpc::Method<global::PatientGmt.PatientGrpcService.DeletePatientRequest, global::PatientGmt.PatientGrpcService.DeletePatientResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeletePatient",
        __Marshaller_patient_DeletePatientRequest,
        __Marshaller_patient_DeletePatientResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PatientGmt.PatientGrpcService.GetPatientRendezVousRequest, global::PatientGmt.PatientGrpcService.GetPatientRendezVousResponse> __Method_GetPatientRendezVous = new grpc::Method<global::PatientGmt.PatientGrpcService.GetPatientRendezVousRequest, global::PatientGmt.PatientGrpcService.GetPatientRendezVousResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPatientRendezVous",
        __Marshaller_patient_GetPatientRendezVousRequest,
        __Marshaller_patient_GetPatientRendezVousResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::PatientGmt.PatientGrpcService.PatientReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PatientProto</summary>
    [grpc::BindServiceMethod(typeof(PatientProto), "BindService")]
    public abstract partial class PatientProtoBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PatientGmt.PatientGrpcService.GetPatientByIdResponse> GetPatientById(global::PatientGmt.PatientGrpcService.GetPatientByIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PatientGmt.PatientGrpcService.GetAllPatientsResponse> GetAllPatients(global::PatientGmt.PatientGrpcService.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PatientGmt.PatientGrpcService.AddPatientResponse> AddPatient(global::PatientGmt.PatientGrpcService.AddPatientRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PatientGmt.PatientGrpcService.UpdatePatientResponse> UpdatePatient(global::PatientGmt.PatientGrpcService.UpdatePatientRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PatientGmt.PatientGrpcService.DeletePatientResponse> DeletePatient(global::PatientGmt.PatientGrpcService.DeletePatientRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PatientGmt.PatientGrpcService.GetPatientRendezVousResponse> GetPatientRendezVous(global::PatientGmt.PatientGrpcService.GetPatientRendezVousRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for PatientProto</summary>
    public partial class PatientProtoClient : grpc::ClientBase<PatientProtoClient>
    {
      /// <summary>Creates a new client for PatientProto</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public PatientProtoClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PatientProto that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public PatientProtoClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected PatientProtoClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected PatientProtoClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PatientGmt.PatientGrpcService.GetPatientByIdResponse GetPatientById(global::PatientGmt.PatientGrpcService.GetPatientByIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPatientById(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PatientGmt.PatientGrpcService.GetPatientByIdResponse GetPatientById(global::PatientGmt.PatientGrpcService.GetPatientByIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetPatientById, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PatientGmt.PatientGrpcService.GetPatientByIdResponse> GetPatientByIdAsync(global::PatientGmt.PatientGrpcService.GetPatientByIdRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPatientByIdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PatientGmt.PatientGrpcService.GetPatientByIdResponse> GetPatientByIdAsync(global::PatientGmt.PatientGrpcService.GetPatientByIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetPatientById, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PatientGmt.PatientGrpcService.GetAllPatientsResponse GetAllPatients(global::PatientGmt.PatientGrpcService.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllPatients(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PatientGmt.PatientGrpcService.GetAllPatientsResponse GetAllPatients(global::PatientGmt.PatientGrpcService.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAllPatients, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PatientGmt.PatientGrpcService.GetAllPatientsResponse> GetAllPatientsAsync(global::PatientGmt.PatientGrpcService.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllPatientsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PatientGmt.PatientGrpcService.GetAllPatientsResponse> GetAllPatientsAsync(global::PatientGmt.PatientGrpcService.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAllPatients, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PatientGmt.PatientGrpcService.AddPatientResponse AddPatient(global::PatientGmt.PatientGrpcService.AddPatientRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddPatient(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PatientGmt.PatientGrpcService.AddPatientResponse AddPatient(global::PatientGmt.PatientGrpcService.AddPatientRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddPatient, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PatientGmt.PatientGrpcService.AddPatientResponse> AddPatientAsync(global::PatientGmt.PatientGrpcService.AddPatientRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddPatientAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PatientGmt.PatientGrpcService.AddPatientResponse> AddPatientAsync(global::PatientGmt.PatientGrpcService.AddPatientRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddPatient, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PatientGmt.PatientGrpcService.UpdatePatientResponse UpdatePatient(global::PatientGmt.PatientGrpcService.UpdatePatientRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdatePatient(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PatientGmt.PatientGrpcService.UpdatePatientResponse UpdatePatient(global::PatientGmt.PatientGrpcService.UpdatePatientRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdatePatient, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PatientGmt.PatientGrpcService.UpdatePatientResponse> UpdatePatientAsync(global::PatientGmt.PatientGrpcService.UpdatePatientRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdatePatientAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PatientGmt.PatientGrpcService.UpdatePatientResponse> UpdatePatientAsync(global::PatientGmt.PatientGrpcService.UpdatePatientRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdatePatient, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PatientGmt.PatientGrpcService.DeletePatientResponse DeletePatient(global::PatientGmt.PatientGrpcService.DeletePatientRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeletePatient(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PatientGmt.PatientGrpcService.DeletePatientResponse DeletePatient(global::PatientGmt.PatientGrpcService.DeletePatientRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeletePatient, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PatientGmt.PatientGrpcService.DeletePatientResponse> DeletePatientAsync(global::PatientGmt.PatientGrpcService.DeletePatientRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeletePatientAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PatientGmt.PatientGrpcService.DeletePatientResponse> DeletePatientAsync(global::PatientGmt.PatientGrpcService.DeletePatientRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeletePatient, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PatientGmt.PatientGrpcService.GetPatientRendezVousResponse GetPatientRendezVous(global::PatientGmt.PatientGrpcService.GetPatientRendezVousRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPatientRendezVous(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::PatientGmt.PatientGrpcService.GetPatientRendezVousResponse GetPatientRendezVous(global::PatientGmt.PatientGrpcService.GetPatientRendezVousRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetPatientRendezVous, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PatientGmt.PatientGrpcService.GetPatientRendezVousResponse> GetPatientRendezVousAsync(global::PatientGmt.PatientGrpcService.GetPatientRendezVousRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPatientRendezVousAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::PatientGmt.PatientGrpcService.GetPatientRendezVousResponse> GetPatientRendezVousAsync(global::PatientGmt.PatientGrpcService.GetPatientRendezVousRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetPatientRendezVous, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override PatientProtoClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PatientProtoClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(PatientProtoBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetPatientById, serviceImpl.GetPatientById)
          .AddMethod(__Method_GetAllPatients, serviceImpl.GetAllPatients)
          .AddMethod(__Method_AddPatient, serviceImpl.AddPatient)
          .AddMethod(__Method_UpdatePatient, serviceImpl.UpdatePatient)
          .AddMethod(__Method_DeletePatient, serviceImpl.DeletePatient)
          .AddMethod(__Method_GetPatientRendezVous, serviceImpl.GetPatientRendezVous).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PatientProtoBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetPatientById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PatientGmt.PatientGrpcService.GetPatientByIdRequest, global::PatientGmt.PatientGrpcService.GetPatientByIdResponse>(serviceImpl.GetPatientById));
      serviceBinder.AddMethod(__Method_GetAllPatients, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PatientGmt.PatientGrpcService.Empty, global::PatientGmt.PatientGrpcService.GetAllPatientsResponse>(serviceImpl.GetAllPatients));
      serviceBinder.AddMethod(__Method_AddPatient, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PatientGmt.PatientGrpcService.AddPatientRequest, global::PatientGmt.PatientGrpcService.AddPatientResponse>(serviceImpl.AddPatient));
      serviceBinder.AddMethod(__Method_UpdatePatient, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PatientGmt.PatientGrpcService.UpdatePatientRequest, global::PatientGmt.PatientGrpcService.UpdatePatientResponse>(serviceImpl.UpdatePatient));
      serviceBinder.AddMethod(__Method_DeletePatient, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PatientGmt.PatientGrpcService.DeletePatientRequest, global::PatientGmt.PatientGrpcService.DeletePatientResponse>(serviceImpl.DeletePatient));
      serviceBinder.AddMethod(__Method_GetPatientRendezVous, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PatientGmt.PatientGrpcService.GetPatientRendezVousRequest, global::PatientGmt.PatientGrpcService.GetPatientRendezVousResponse>(serviceImpl.GetPatientRendezVous));
    }

  }
}
#endregion