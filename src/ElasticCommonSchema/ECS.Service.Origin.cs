namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Service
    {
        public static partial class Origin
        {
            /// <summary>
            /// Address of this service.
            /// </summary>
            /// <example>
            /// <c>172.26.0.2:5432</c>
            /// </example>
            public const string Address = "service.origin.address";
            
            /// <summary>
            /// Environment of the service.
            /// </summary>
            /// <example>
            /// <c>production</c>
            /// </example>
            public const string Environment = "service.origin.environment";
            
            /// <summary>
            /// Ephemeral identifier of this service.
            /// </summary>
            /// <example>
            /// <c>8a4f500f</c>
            /// </example>
            public const string EphemeralId = "service.origin.ephemeral_id";
            
            /// <summary>
            /// Unique identifier of the running service.
            /// </summary>
            /// <example>
            /// <c>d37e5ebfe0ae6c4972dbe9f0174a1637bb8247f6</c>
            /// </example>
            public const string Id = "service.origin.id";
            
            /// <summary>
            /// Name of the service.
            /// </summary>
            /// <example>
            /// <c>elasticsearch-metrics</c>
            /// </example>
            public const string Name = "service.origin.name";
            
            /// <summary>
            /// Current state of the service.
            /// </summary>
            public const string State = "service.origin.state";
            
            /// <summary>
            /// The type of the service.
            /// </summary>
            /// <example>
            /// <c>elasticsearch</c>
            /// </example>
            public const string Type = "service.origin.type";
            
            /// <summary>
            /// Version of the service.
            /// </summary>
            /// <example>
            /// <c>3.2.4</c>
            /// </example>
            public const string Version = "service.origin.version";
            
        }
    }
}

