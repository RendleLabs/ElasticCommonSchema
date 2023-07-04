namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Client
    {
        /// <summary>
        /// Client network address.
        /// </summary>
        public const string Address = "client.address";
        
        /// <summary>
        /// Bytes sent from the client to the server.
        /// </summary>
        /// <example>
        /// <c>184</c>
        /// </example>
        public const string Bytes = "client.bytes";
        
        /// <summary>
        /// The domain name of the client.
        /// </summary>
        /// <example>
        /// <c>foo.example.com</c>
        /// </example>
        public const string Domain = "client.domain";
        
        /// <summary>
        /// IP address of the client.
        /// </summary>
        public const string Ip = "client.ip";
        
        /// <summary>
        /// MAC address of the client.
        /// </summary>
        /// <example>
        /// <c>00-00-5E-00-53-23</c>
        /// </example>
        public const string Mac = "client.mac";
        
        /// <summary>
        /// Packets sent from the client to the server.
        /// </summary>
        /// <example>
        /// <c>12</c>
        /// </example>
        public const string Packets = "client.packets";
        
        /// <summary>
        /// Port of the client.
        /// </summary>
        public const string Port = "client.port";
        
        /// <summary>
        /// The highest registered client domain, stripped of the subdomain.
        /// </summary>
        /// <example>
        /// <c>example.com</c>
        /// </example>
        public const string RegisteredDomain = "client.registered_domain";
        
        /// <summary>
        /// The subdomain of the domain.
        /// </summary>
        /// <example>
        /// <c>east</c>
        /// </example>
        public const string Subdomain = "client.subdomain";
        
        /// <summary>
        /// The effective top level domain (com, org, net, co.uk).
        /// </summary>
        /// <example>
        /// <c>co.uk</c>
        /// </example>
        public const string TopLevelDomain = "client.top_level_domain";
        
    }
}

