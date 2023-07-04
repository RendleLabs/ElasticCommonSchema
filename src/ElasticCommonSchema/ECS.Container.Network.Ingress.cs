namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Container
    {
        public static partial class Network
        {
            public static partial class Ingress
            {
                /// <summary>
                /// The number of bytes received on all network interfaces.
                /// </summary>
                public const string Bytes = "container.network.ingress.bytes";
                
            }
        }
    }
}

