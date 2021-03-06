// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: findMax.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace FindMax {
  public static partial class FindMaxService
  {
    static readonly string __ServiceName = "findMax.FindMaxService";

    static readonly grpc::Marshaller<global::FindMax.FindMaxRequest> __Marshaller_findMax_FindMaxRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::FindMax.FindMaxRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::FindMax.FindMaxResponse> __Marshaller_findMax_FindMaxResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::FindMax.FindMaxResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::FindMax.FindMaxRequest, global::FindMax.FindMaxResponse> __Method_FindMax = new grpc::Method<global::FindMax.FindMaxRequest, global::FindMax.FindMaxResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "FindMax",
        __Marshaller_findMax_FindMaxRequest,
        __Marshaller_findMax_FindMaxResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::FindMax.FindMaxReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of FindMaxService</summary>
    [grpc::BindServiceMethod(typeof(FindMaxService), "BindService")]
    public abstract partial class FindMaxServiceBase
    {
      public virtual global::System.Threading.Tasks.Task FindMax(grpc::IAsyncStreamReader<global::FindMax.FindMaxRequest> requestStream, grpc::IServerStreamWriter<global::FindMax.FindMaxResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for FindMaxService</summary>
    public partial class FindMaxServiceClient : grpc::ClientBase<FindMaxServiceClient>
    {
      /// <summary>Creates a new client for FindMaxService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public FindMaxServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for FindMaxService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public FindMaxServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected FindMaxServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected FindMaxServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncDuplexStreamingCall<global::FindMax.FindMaxRequest, global::FindMax.FindMaxResponse> FindMax(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return FindMax(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::FindMax.FindMaxRequest, global::FindMax.FindMaxResponse> FindMax(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_FindMax, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override FindMaxServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new FindMaxServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(FindMaxServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_FindMax, serviceImpl.FindMax).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, FindMaxServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_FindMax, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::FindMax.FindMaxRequest, global::FindMax.FindMaxResponse>(serviceImpl.FindMax));
    }

  }
}
#endregion
