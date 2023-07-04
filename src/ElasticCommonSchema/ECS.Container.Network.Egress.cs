namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Container
    {
        public static partial class Network
        {
            public static partial class Egress
            {
                /// <summary>
                /// The number of bytes sent on all network interfaces.
                /// </summary>
                public const string Bytes = "container.network.egress.bytes";
                
            }
        }
    }
}

