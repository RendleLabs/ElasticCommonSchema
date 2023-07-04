namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Orchestrator
    {
        public static partial class Cluster
        {
            /// <summary>
            /// Unique ID of the cluster.
            /// </summary>
            public const string Id = "orchestrator.cluster.id";
            
            /// <summary>
            /// Name of the cluster.
            /// </summary>
            public const string Name = "orchestrator.cluster.name";
            
            /// <summary>
            /// URL of the API used to manage the cluster.
            /// </summary>
            public const string Url = "orchestrator.cluster.url";
            
            /// <summary>
            /// The version of the cluster.
            /// </summary>
            public const string Version = "orchestrator.cluster.version";
            
        }
    }
}

