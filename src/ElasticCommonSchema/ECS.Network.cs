namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Network
    {
        /// <summary>
        /// Application level protocol name.
        /// </summary>
        /// <example>
        /// <c>aim</c>
        /// </example>
        public const string Application = "network.application";
        
        /// <summary>
        /// Total bytes transferred in both directions.
        /// </summary>
        /// <example>
        /// <c>368</c>
        /// </example>
        public const string Bytes = "network.bytes";
        
        /// <summary>
        /// A hash of source and destination IPs and ports.
        /// </summary>
        /// <example>
        /// <c>1:hO+sN4H+MG5MY/8hIrXPqc4ZQz0=</c>
        /// </example>
        public const string CommunityId = "network.community_id";
        
        /// <summary>
        /// Direction of the network traffic.
        /// </summary>
        /// <example>
        /// <c>inbound</c>
        /// </example>
        public const string Direction = "network.direction";
        
        /// <summary>
        /// Host IP address when the source IP address is the proxy.
        /// </summary>
        /// <example>
        /// <c>192.1.1.2</c>
        /// </example>
        public const string ForwardedIp = "network.forwarded_ip";
        
        /// <summary>
        /// IANA Protocol Number.
        /// </summary>
        /// <example>
        /// <c>6</c>
        /// </example>
        public const string IanaNumber = "network.iana_number";
        
        /// <summary>
        /// Inner VLAN tag information
        /// </summary>
        public const string Inner = "network.inner";
        
        /// <summary>
        /// Name given by operators to sections of their network.
        /// </summary>
        /// <example>
        /// <c>Guest Wifi</c>
        /// </example>
        public const string Name = "network.name";
        
        /// <summary>
        /// Total packets transferred in both directions.
        /// </summary>
        /// <example>
        /// <c>24</c>
        /// </example>
        public const string Packets = "network.packets";
        
        /// <summary>
        /// Application protocol name.
        /// </summary>
        /// <example>
        /// <c>http</c>
        /// </example>
        public const string Protocol = "network.protocol";
        
        /// <summary>
        /// Protocol Name corresponding to the field `iana_number`.
        /// </summary>
        /// <example>
        /// <c>tcp</c>
        /// </example>
        public const string Transport = "network.transport";
        
        /// <summary>
        /// In the OSI Model this would be the Network Layer. ipv4, ipv6, ipsec, pim, etc
        /// </summary>
        /// <example>
        /// <c>ipv4</c>
        /// </example>
        public const string Type = "network.type";
        
    }
}

