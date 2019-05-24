// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: taxonomyservice.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace TTI.TTF.Taxonomy {
  public static partial class TaxonomyService
  {
    static readonly string __ServiceName = "taxonomy.service.TaxonomyService";

    static readonly grpc::Marshaller<global::TTI.TTF.Taxonomy.Model.TaxonomyVersion> __Marshaller_taxonomy_model_TaxonomyVersion = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TTI.TTF.Taxonomy.Model.TaxonomyVersion.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::TTI.TTF.Taxonomy.Model.Taxonomy> __Marshaller_taxonomy_model_Taxonomy = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TTI.TTF.Taxonomy.Model.Taxonomy.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactSymbol> __Marshaller_taxonomy_model_artifact_ArtifactSymbol = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactSymbol.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::TTI.TTF.Taxonomy.Model.Core.Base> __Marshaller_taxonomy_model_core_Base = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TTI.TTF.Taxonomy.Model.Core.Base.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::TTI.TTF.Taxonomy.Model.Core.Behavior> __Marshaller_taxonomy_model_core_Behavior = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TTI.TTF.Taxonomy.Model.Core.Behavior.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::TTI.TTF.Taxonomy.Model.Core.BehaviorGroup> __Marshaller_taxonomy_model_core_BehaviorGroup = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TTI.TTF.Taxonomy.Model.Core.BehaviorGroup.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::TTI.TTF.Taxonomy.Model.Core.PropertySet> __Marshaller_taxonomy_model_core_PropertySet = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TTI.TTF.Taxonomy.Model.Core.PropertySet.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::TTI.TTF.Taxonomy.Model.Artifact.TaxonomyFormula> __Marshaller_taxonomy_model_artifact_TaxonomyFormula = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TTI.TTF.Taxonomy.Model.Artifact.TaxonomyFormula.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::TTI.TTF.Taxonomy.Model.Core.TokenTemplate> __Marshaller_taxonomy_model_core_TokenTemplate = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TTI.TTF.Taxonomy.Model.Core.TokenTemplate.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::TTI.TTF.Taxonomy.Model.Artifact.NewArtifactRequest> __Marshaller_taxonomy_model_artifact_NewArtifactRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TTI.TTF.Taxonomy.Model.Artifact.NewArtifactRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::TTI.TTF.Taxonomy.Model.Artifact.NewArtifactResponse> __Marshaller_taxonomy_model_artifact_NewArtifactResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TTI.TTF.Taxonomy.Model.Artifact.NewArtifactResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::TTI.TTF.Taxonomy.Model.Artifact.UpdateArtifactRequest> __Marshaller_taxonomy_model_artifact_UpdateArtifactRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TTI.TTF.Taxonomy.Model.Artifact.UpdateArtifactRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::TTI.TTF.Taxonomy.Model.Artifact.UpdateArtifactResponse> __Marshaller_taxonomy_model_artifact_UpdateArtifactResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TTI.TTF.Taxonomy.Model.Artifact.UpdateArtifactResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::TTI.TTF.Taxonomy.Model.Artifact.DeleteArtifactRequest> __Marshaller_taxonomy_model_artifact_DeleteArtifactRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TTI.TTF.Taxonomy.Model.Artifact.DeleteArtifactRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::TTI.TTF.Taxonomy.Model.Artifact.DeleteArtifactResponse> __Marshaller_taxonomy_model_artifact_DeleteArtifactResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::TTI.TTF.Taxonomy.Model.Artifact.DeleteArtifactResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::TTI.TTF.Taxonomy.Model.TaxonomyVersion, global::TTI.TTF.Taxonomy.Model.Taxonomy> __Method_GetFullTaxonomy = new grpc::Method<global::TTI.TTF.Taxonomy.Model.TaxonomyVersion, global::TTI.TTF.Taxonomy.Model.Taxonomy>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetFullTaxonomy",
        __Marshaller_taxonomy_model_TaxonomyVersion,
        __Marshaller_taxonomy_model_Taxonomy);

    static readonly grpc::Method<global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactSymbol, global::TTI.TTF.Taxonomy.Model.Core.Base> __Method_GetBaseArtifact = new grpc::Method<global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactSymbol, global::TTI.TTF.Taxonomy.Model.Core.Base>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetBaseArtifact",
        __Marshaller_taxonomy_model_artifact_ArtifactSymbol,
        __Marshaller_taxonomy_model_core_Base);

    static readonly grpc::Method<global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactSymbol, global::TTI.TTF.Taxonomy.Model.Core.Behavior> __Method_GetBehaviorArtifact = new grpc::Method<global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactSymbol, global::TTI.TTF.Taxonomy.Model.Core.Behavior>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetBehaviorArtifact",
        __Marshaller_taxonomy_model_artifact_ArtifactSymbol,
        __Marshaller_taxonomy_model_core_Behavior);

    static readonly grpc::Method<global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactSymbol, global::TTI.TTF.Taxonomy.Model.Core.BehaviorGroup> __Method_GetBehaviorGroupArtifact = new grpc::Method<global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactSymbol, global::TTI.TTF.Taxonomy.Model.Core.BehaviorGroup>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetBehaviorGroupArtifact",
        __Marshaller_taxonomy_model_artifact_ArtifactSymbol,
        __Marshaller_taxonomy_model_core_BehaviorGroup);

    static readonly grpc::Method<global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactSymbol, global::TTI.TTF.Taxonomy.Model.Core.PropertySet> __Method_GetPropertySetArtifact = new grpc::Method<global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactSymbol, global::TTI.TTF.Taxonomy.Model.Core.PropertySet>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetPropertySetArtifact",
        __Marshaller_taxonomy_model_artifact_ArtifactSymbol,
        __Marshaller_taxonomy_model_core_PropertySet);

    static readonly grpc::Method<global::TTI.TTF.Taxonomy.Model.Artifact.TaxonomyFormula, global::TTI.TTF.Taxonomy.Model.Core.TokenTemplate> __Method_GetTokenTemplateArtifact = new grpc::Method<global::TTI.TTF.Taxonomy.Model.Artifact.TaxonomyFormula, global::TTI.TTF.Taxonomy.Model.Core.TokenTemplate>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetTokenTemplateArtifact",
        __Marshaller_taxonomy_model_artifact_TaxonomyFormula,
        __Marshaller_taxonomy_model_core_TokenTemplate);

    static readonly grpc::Method<global::TTI.TTF.Taxonomy.Model.Artifact.NewArtifactRequest, global::TTI.TTF.Taxonomy.Model.Artifact.NewArtifactResponse> __Method_CreateArtifact = new grpc::Method<global::TTI.TTF.Taxonomy.Model.Artifact.NewArtifactRequest, global::TTI.TTF.Taxonomy.Model.Artifact.NewArtifactResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateArtifact",
        __Marshaller_taxonomy_model_artifact_NewArtifactRequest,
        __Marshaller_taxonomy_model_artifact_NewArtifactResponse);

    static readonly grpc::Method<global::TTI.TTF.Taxonomy.Model.Artifact.UpdateArtifactRequest, global::TTI.TTF.Taxonomy.Model.Artifact.UpdateArtifactResponse> __Method_UpdateArtifact = new grpc::Method<global::TTI.TTF.Taxonomy.Model.Artifact.UpdateArtifactRequest, global::TTI.TTF.Taxonomy.Model.Artifact.UpdateArtifactResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateArtifact",
        __Marshaller_taxonomy_model_artifact_UpdateArtifactRequest,
        __Marshaller_taxonomy_model_artifact_UpdateArtifactResponse);

    static readonly grpc::Method<global::TTI.TTF.Taxonomy.Model.Artifact.DeleteArtifactRequest, global::TTI.TTF.Taxonomy.Model.Artifact.DeleteArtifactResponse> __Method_DeleteArtifact = new grpc::Method<global::TTI.TTF.Taxonomy.Model.Artifact.DeleteArtifactRequest, global::TTI.TTF.Taxonomy.Model.Artifact.DeleteArtifactResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteArtifact",
        __Marshaller_taxonomy_model_artifact_DeleteArtifactRequest,
        __Marshaller_taxonomy_model_artifact_DeleteArtifactResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::TTI.TTF.Taxonomy.TaxonomyserviceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for TaxonomyService</summary>
    public partial class TaxonomyServiceClient : grpc::ClientBase<TaxonomyServiceClient>
    {
      /// <summary>Creates a new client for TaxonomyService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public TaxonomyServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for TaxonomyService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public TaxonomyServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected TaxonomyServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected TaxonomyServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      ///gets
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::TTI.TTF.Taxonomy.Model.Taxonomy GetFullTaxonomy(global::TTI.TTF.Taxonomy.Model.TaxonomyVersion request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetFullTaxonomy(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///gets
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::TTI.TTF.Taxonomy.Model.Taxonomy GetFullTaxonomy(global::TTI.TTF.Taxonomy.Model.TaxonomyVersion request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetFullTaxonomy, null, options, request);
      }
      /// <summary>
      ///gets
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::TTI.TTF.Taxonomy.Model.Taxonomy> GetFullTaxonomyAsync(global::TTI.TTF.Taxonomy.Model.TaxonomyVersion request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetFullTaxonomyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///gets
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::TTI.TTF.Taxonomy.Model.Taxonomy> GetFullTaxonomyAsync(global::TTI.TTF.Taxonomy.Model.TaxonomyVersion request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetFullTaxonomy, null, options, request);
      }
      public virtual global::TTI.TTF.Taxonomy.Model.Core.Base GetBaseArtifact(global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactSymbol request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetBaseArtifact(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::TTI.TTF.Taxonomy.Model.Core.Base GetBaseArtifact(global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactSymbol request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetBaseArtifact, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::TTI.TTF.Taxonomy.Model.Core.Base> GetBaseArtifactAsync(global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactSymbol request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetBaseArtifactAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::TTI.TTF.Taxonomy.Model.Core.Base> GetBaseArtifactAsync(global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactSymbol request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetBaseArtifact, null, options, request);
      }
      public virtual global::TTI.TTF.Taxonomy.Model.Core.Behavior GetBehaviorArtifact(global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactSymbol request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetBehaviorArtifact(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::TTI.TTF.Taxonomy.Model.Core.Behavior GetBehaviorArtifact(global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactSymbol request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetBehaviorArtifact, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::TTI.TTF.Taxonomy.Model.Core.Behavior> GetBehaviorArtifactAsync(global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactSymbol request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetBehaviorArtifactAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::TTI.TTF.Taxonomy.Model.Core.Behavior> GetBehaviorArtifactAsync(global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactSymbol request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetBehaviorArtifact, null, options, request);
      }
      public virtual global::TTI.TTF.Taxonomy.Model.Core.BehaviorGroup GetBehaviorGroupArtifact(global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactSymbol request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetBehaviorGroupArtifact(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::TTI.TTF.Taxonomy.Model.Core.BehaviorGroup GetBehaviorGroupArtifact(global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactSymbol request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetBehaviorGroupArtifact, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::TTI.TTF.Taxonomy.Model.Core.BehaviorGroup> GetBehaviorGroupArtifactAsync(global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactSymbol request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetBehaviorGroupArtifactAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::TTI.TTF.Taxonomy.Model.Core.BehaviorGroup> GetBehaviorGroupArtifactAsync(global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactSymbol request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetBehaviorGroupArtifact, null, options, request);
      }
      public virtual global::TTI.TTF.Taxonomy.Model.Core.PropertySet GetPropertySetArtifact(global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactSymbol request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPropertySetArtifact(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::TTI.TTF.Taxonomy.Model.Core.PropertySet GetPropertySetArtifact(global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactSymbol request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetPropertySetArtifact, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::TTI.TTF.Taxonomy.Model.Core.PropertySet> GetPropertySetArtifactAsync(global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactSymbol request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetPropertySetArtifactAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::TTI.TTF.Taxonomy.Model.Core.PropertySet> GetPropertySetArtifactAsync(global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactSymbol request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetPropertySetArtifact, null, options, request);
      }
      public virtual global::TTI.TTF.Taxonomy.Model.Core.TokenTemplate GetTokenTemplateArtifact(global::TTI.TTF.Taxonomy.Model.Artifact.TaxonomyFormula request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetTokenTemplateArtifact(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::TTI.TTF.Taxonomy.Model.Core.TokenTemplate GetTokenTemplateArtifact(global::TTI.TTF.Taxonomy.Model.Artifact.TaxonomyFormula request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetTokenTemplateArtifact, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::TTI.TTF.Taxonomy.Model.Core.TokenTemplate> GetTokenTemplateArtifactAsync(global::TTI.TTF.Taxonomy.Model.Artifact.TaxonomyFormula request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetTokenTemplateArtifactAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::TTI.TTF.Taxonomy.Model.Core.TokenTemplate> GetTokenTemplateArtifactAsync(global::TTI.TTF.Taxonomy.Model.Artifact.TaxonomyFormula request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetTokenTemplateArtifact, null, options, request);
      }
      /// <summary>
      ///sets
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::TTI.TTF.Taxonomy.Model.Artifact.NewArtifactResponse CreateArtifact(global::TTI.TTF.Taxonomy.Model.Artifact.NewArtifactRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateArtifact(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///sets
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::TTI.TTF.Taxonomy.Model.Artifact.NewArtifactResponse CreateArtifact(global::TTI.TTF.Taxonomy.Model.Artifact.NewArtifactRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateArtifact, null, options, request);
      }
      /// <summary>
      ///sets
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::TTI.TTF.Taxonomy.Model.Artifact.NewArtifactResponse> CreateArtifactAsync(global::TTI.TTF.Taxonomy.Model.Artifact.NewArtifactRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateArtifactAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///sets
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::TTI.TTF.Taxonomy.Model.Artifact.NewArtifactResponse> CreateArtifactAsync(global::TTI.TTF.Taxonomy.Model.Artifact.NewArtifactRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateArtifact, null, options, request);
      }
      public virtual global::TTI.TTF.Taxonomy.Model.Artifact.UpdateArtifactResponse UpdateArtifact(global::TTI.TTF.Taxonomy.Model.Artifact.UpdateArtifactRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateArtifact(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::TTI.TTF.Taxonomy.Model.Artifact.UpdateArtifactResponse UpdateArtifact(global::TTI.TTF.Taxonomy.Model.Artifact.UpdateArtifactRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateArtifact, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::TTI.TTF.Taxonomy.Model.Artifact.UpdateArtifactResponse> UpdateArtifactAsync(global::TTI.TTF.Taxonomy.Model.Artifact.UpdateArtifactRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateArtifactAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::TTI.TTF.Taxonomy.Model.Artifact.UpdateArtifactResponse> UpdateArtifactAsync(global::TTI.TTF.Taxonomy.Model.Artifact.UpdateArtifactRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateArtifact, null, options, request);
      }
      public virtual global::TTI.TTF.Taxonomy.Model.Artifact.DeleteArtifactResponse DeleteArtifact(global::TTI.TTF.Taxonomy.Model.Artifact.DeleteArtifactRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteArtifact(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::TTI.TTF.Taxonomy.Model.Artifact.DeleteArtifactResponse DeleteArtifact(global::TTI.TTF.Taxonomy.Model.Artifact.DeleteArtifactRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteArtifact, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::TTI.TTF.Taxonomy.Model.Artifact.DeleteArtifactResponse> DeleteArtifactAsync(global::TTI.TTF.Taxonomy.Model.Artifact.DeleteArtifactRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteArtifactAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::TTI.TTF.Taxonomy.Model.Artifact.DeleteArtifactResponse> DeleteArtifactAsync(global::TTI.TTF.Taxonomy.Model.Artifact.DeleteArtifactRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteArtifact, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override TaxonomyServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new TaxonomyServiceClient(configuration);
      }
    }

  }
}
#endregion
