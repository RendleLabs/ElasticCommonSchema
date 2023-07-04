namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Network
    {
        public static partial class Vlan
        {
            /// <summary>
            /// VLAN ID as reported by the observer.
            /// </summary>
            /// <example>
            /// <c>10</c>
            /// </example>
            public const string Id = "network.vlan.id";
            
            /// <summary>
            /// Optional VLAN name as reported by the observer.
            /// </summary>
            /// <example>
            /// <c>outside</c>
            /// </example>
            public const string Name = "network.vlan.name";
            
        }
    }
}

