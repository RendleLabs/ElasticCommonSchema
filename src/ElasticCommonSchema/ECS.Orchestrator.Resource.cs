namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Orchestrator
    {
        public static partial class Resource
        {
            /// <summary>
            /// The list of annotations added to the resource.
            /// </summary>
            /// <example>
            /// <c>['key1:value1', 'key2:value2', 'key3:value3']</c>
            /// </example>
            public const string Annotation = "orchestrator.resource.annotation";
            
            /// <summary>
            /// Unique ID of the resource being acted upon.
            /// </summary>
            public const string Id = "orchestrator.resource.id";
            
            /// <summary>
            /// IP address assigned to the resource associated with the event being observed.
            /// </summary>
            public const string Ip = "orchestrator.resource.ip";
            
            /// <summary>
            /// The list of labels added to the resource.
            /// </summary>
            /// <example>
            /// <c>['key1:value1', 'key2:value2', 'key3:value3']</c>
            /// </example>
            public const string Label = "orchestrator.resource.label";
            
            /// <summary>
            /// Name of the resource being acted upon.
            /// </summary>
            /// <example>
            /// <c>test-pod-cdcws</c>
            /// </example>
            public const string Name = "orchestrator.resource.name";
            
            /// <summary>
            /// Type of resource being acted upon.
            /// </summary>
            /// <example>
            /// <c>service</c>
            /// </example>
            public const string Type = "orchestrator.resource.type";
            
        }
    }
}

