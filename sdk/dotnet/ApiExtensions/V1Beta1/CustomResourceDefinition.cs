// *** WARNING: this file was generated by the Pulumi Kubernetes codegen tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.ApiExtensions.V1Beta1
{
    /// <summary>
    /// CustomResourceDefinition represents a resource that should be exposed on the API server.
    /// Its name MUST be in the format &amp;lt;.spec.name&amp;gt;.&amp;lt;.spec.group&amp;gt;.
    /// Deprecated in v1.16, planned for removal in v1.19. Use apiextensions.k8s.io/v1
    /// CustomResourceDefinition instead.
    /// </summary>
    public partial class CustomResourceDefinition : KubernetesResource
    {
        /// <summary>
        /// APIVersion defines the versioned schema of this representation of an object. Servers
        /// should convert recognized schemas to the latest internal value, and may reject
        /// unrecognized values. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </summary>
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        /// <summary>
        /// Kind is a string value representing the REST resource this object represents. Servers
        /// may infer this from the endpoint the client submits requests to. Cannot be updated. In
        /// CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </summary>
        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        
        [Output("metadata")]
        public Output<Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// spec describes how the user wants the resources to appear
        /// </summary>
        [Output("spec")]
        public Output<Types.Outputs.ApiExtensions.V1Beta1.CustomResourceDefinitionSpec> Spec { get; private set; } = null!;

        /// <summary>
        /// status indicates the actual state of the CustomResourceDefinition
        /// </summary>
        [Output("status")]
        public Output<Types.Outputs.ApiExtensions.V1Beta1.CustomResourceDefinitionStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a CustomResourceDefinition resource with the given unique name, arguments, and options.
        /// </summary>
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CustomResourceDefinition(string name, Types.Inputs.ApiExtensions.V1Beta1.CustomResourceDefinitionArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:apiextensions.k8s.io/v1beta1:CustomResourceDefinition", name, SetAPIKindAndVersion(args), options)
        {
        }

        internal CustomResourceDefinition(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:apiextensions.k8s.io/v1beta1:CustomResourceDefinition", name, dictionary, options)
        {
        }

        private static ResourceArgs SetAPIKindAndVersion(Types.Inputs.ApiExtensions.V1Beta1.CustomResourceDefinitionArgs? args)
        {
            args ??= new Types.Inputs.ApiExtensions.V1Beta1.CustomResourceDefinitionArgs();
            args.ApiVersion = "apiextensions.k8s.io/v1beta1";
            args.Kind = "CustomResourceDefinition";
            return args;
        }

        /// <summary>
        /// Get an existing CustomResourceDefinition resource's state with the given name and ID.
        /// </summary>
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CustomResourceDefinition Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new CustomResourceDefinition(name, default(Types.Inputs.ApiExtensions.V1Beta1.CustomResourceDefinitionArgs),
                CustomResourceOptions.Merge(options, new CustomResourceOptions {Id = id}));
        }

    }
}
