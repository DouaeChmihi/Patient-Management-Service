// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/greet.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace PatientMgmt.PatientGrpcService {
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
    static readonly grpc::Marshaller<global::PatientMgmt.PatientGrpcService.GetPatientByIdRequest> __Marshaller_patient_GetPatientByIdRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PatientMgmt.PatientGrpcService.GetPatientByIdRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PatientMgmt.PatientGrpcService.GetPatientByIdResponse> __Marshaller_patient_GetPatientByIdResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PatientMgmt.PatientGrpcService.GetPatientByIdResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PatientMgmt.PatientGrpcService.Empty> __Marshaller_patient_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PatientMgmt.PatientGrpcService.Empty.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PatientMgmt.PatientGrpcService.GetAllPatientsResponse> __Marshaller_patient_GetAllPatientsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PatientMgmt.PatientGrpcService.GetAllPatientsResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PatientMgmt.PatientGrpcService.AddPatientRequest> __Marshaller_patient_AddPatientRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PatientMgmt.PatientGrpcService.AddPatientRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PatientMgmt.PatientGrpcService.UpdatePatientRequest> __Marshaller_patient_UpdatePatientRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PatientMgmt.PatientGrpcService.UpdatePatientRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::PatientMgmt.PatientGrpcService.DeletePatientRequest> __Marshaller_patient_DeletePatientRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::PatientMgmt.PatientGrpcService.DeletePatientRequest.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PatientMgmt.PatientGrpcService.GetPatientByIdRequest, global::PatientMgmt.PatientGrpcService.GetPatientByIdResponse> __Method_GetPatientById = new grpc::Method<global::PatientMgmt.PatientGrpcService.GetPatientByIdRequest, global::PatientMgmt.PatientGrpcService.GetPatientByIdResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPatientById",
        __Marshaller_patient_GetPatientByIdRequest,
        __Marshaller_patient_GetPatientByIdResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PatientMgmt.PatientGrpcService.Empty, global::PatientMgmt.PatientGrpcService.GetAllPatientsResponse> __Method_GetAllPatients = new grpc::Method<global::PatientMgmt.PatientGrpcService.Empty, global::PatientMgmt.PatientGrpcService.GetAllPatientsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAllPatients",
        __Marshaller_patient_Empty,
        __Marshaller_patient_GetAllPatientsResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PatientMgmt.PatientGrpcService.AddPatientRequest, global::PatientMgmt.PatientGrpcService.Empty> __Method_AddPatient = new grpc::Method<global::PatientMgmt.PatientGrpcService.AddPatientRequest, global::PatientMgmt.PatientGrpcService.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddPatient",
        __Marshaller_patient_AddPatientRequest,
        __Marshaller_patient_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PatientMgmt.PatientGrpcService.UpdatePatientRequest, global::PatientMgmt.PatientGrpcService.Empty> __Method_UpdatePatient = new grpc::Method<global::PatientMgmt.PatientGrpcService.UpdatePatientRequest, global::PatientMgmt.PatientGrpcService.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdatePatient",
        __Marshaller_patient_UpdatePatientRequest,
        __Marshaller_patient_Empty);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::PatientMgmt.PatientGrpcService.DeletePatientRequest, global::PatientMgmt.PatientGrpcService.Empty> __Method_DeletePatient = new grpc::Method<global::PatientMgmt.PatientGrpcService.DeletePatientRequest, global::PatientMgmt.PatientGrpcService.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeletePatient",
        __Marshaller_patient_DeletePatientRequest,
        __Marshaller_patient_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::PatientMgmt.PatientGrpcService.GreetReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PatientProto</summary>
    [grpc::BindServiceMethod(typeof(PatientProto), "BindService")]
    public abstract partial class PatientProtoBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PatientMgmt.PatientGrpcService.GetPatientByIdResponse> GetPatientById(global::PatientMgmt.PatientGrpcService.GetPatientByIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PatientMgmt.PatientGrpcService.GetAllPatientsResponse> GetAllPatients(global::PatientMgmt.PatientGrpcService.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PatientMgmt.PatientGrpcService.Empty> AddPatient(global::PatientMgmt.PatientGrpcService.AddPatientRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PatientMgmt.PatientGrpcService.Empty> UpdatePatient(global::PatientMgmt.PatientGrpcService.UpdatePatientRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::PatientMgmt.PatientGrpcService.Empty> DeletePatient(global::PatientMgmt.PatientGrpcService.DeletePatientRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
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
          .AddMethod(__Method_DeletePatient, serviceImpl.DeletePatient).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, PatientProtoBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetPatientById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PatientMgmt.PatientGrpcService.GetPatientByIdRequest, global::PatientMgmt.PatientGrpcService.GetPatientByIdResponse>(serviceImpl.GetPatientById));
      serviceBinder.AddMethod(__Method_GetAllPatients, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PatientMgmt.PatientGrpcService.Empty, global::PatientMgmt.PatientGrpcService.GetAllPatientsResponse>(serviceImpl.GetAllPatients));
      serviceBinder.AddMethod(__Method_AddPatient, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PatientMgmt.PatientGrpcService.AddPatientRequest, global::PatientMgmt.PatientGrpcService.Empty>(serviceImpl.AddPatient));
      serviceBinder.AddMethod(__Method_UpdatePatient, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PatientMgmt.PatientGrpcService.UpdatePatientRequest, global::PatientMgmt.PatientGrpcService.Empty>(serviceImpl.UpdatePatient));
      serviceBinder.AddMethod(__Method_DeletePatient, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::PatientMgmt.PatientGrpcService.DeletePatientRequest, global::PatientMgmt.PatientGrpcService.Empty>(serviceImpl.DeletePatient));
    }

  }
}
#endregion
