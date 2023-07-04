namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Host
    {
        public static partial class Network
        {
            public static partial class Ingress
            {
                /// <summary>
                /// The number of bytes received on all network interfaces.
                /// </summary>
                public const string Bytes = "host.network.ingress.bytes";
                
                /// <summary>
                /// The number of packets received on all network interfaces.
                /// </summary>
                public const string Packets = "host.network.ingress.packets";
                
            }
        }
    }
}

