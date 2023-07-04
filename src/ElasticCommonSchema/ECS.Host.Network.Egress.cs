namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Host
    {
        public static partial class Network
        {
            public static partial class Egress
            {
                /// <summary>
                /// The number of bytes sent on all network interfaces.
                /// </summary>
                public const string Bytes = "host.network.egress.bytes";
                
                /// <summary>
                /// The number of packets sent on all network interfaces.
                /// </summary>
                public const string Packets = "host.network.egress.packets";
                
            }
        }
    }
}

