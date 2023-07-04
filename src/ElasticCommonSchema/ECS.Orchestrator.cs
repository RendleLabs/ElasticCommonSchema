namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Orchestrator
    {
        /// <summary>
        /// API version being used to carry out the action
        /// </summary>
        /// <example>
        /// <c>v1beta1</c>
        /// </example>
        public const string ApiVersion = "orchestrator.api_version";
        
        /// <summary>
        /// Namespace in which the action is taking place.
        /// </summary>
        /// <example>
        /// <c>kube-system</c>
        /// </example>
        public const string Namespace = "orchestrator.namespace";
        
        /// <summary>
        /// Organization affected by the event (for multi-tenant orchestrator setups).
        /// </summary>
        /// <example>
        /// <c>elastic</c>
        /// </example>
        public const string Organization = "orchestrator.organization";
        
        /// <summary>
        /// Orchestrator cluster type (e.g. kubernetes, nomad or cloudfoundry).
        /// </summary>
        /// <example>
        /// <c>kubernetes</c>
        /// </example>
        public const string Type = "orchestrator.type";
        
    }
}

