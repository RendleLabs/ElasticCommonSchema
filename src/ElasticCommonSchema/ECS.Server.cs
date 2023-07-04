namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Server
    {
        /// <summary>
        /// Server network address.
        /// </summary>
        public const string Address = "server.address";
        
        /// <summary>
        /// Bytes sent from the server to the client.
        /// </summary>
        /// <example>
        /// <c>184</c>
        /// </example>
        public const string Bytes = "server.bytes";
        
        /// <summary>
        /// The domain name of the server.
        /// </summary>
        /// <example>
        /// <c>foo.example.com</c>
        /// </example>
        public const string Domain = "server.domain";
        
        /// <summary>
        /// IP address of the server.
        /// </summary>
        public const string Ip = "server.ip";
        
        /// <summary>
        /// MAC address of the server.
        /// </summary>
        /// <example>
        /// <c>00-00-5E-00-53-23</c>
        /// </example>
        public const string Mac = "server.mac";
        
        /// <summary>
        /// Packets sent from the server to the client.
        /// </summary>
        /// <example>
        /// <c>12</c>
        /// </example>
        public const string Packets = "server.packets";
        
        /// <summary>
        /// Port of the server.
        /// </summary>
        public const string Port = "server.port";
        
        /// <summary>
        /// The highest registered server domain, stripped of the subdomain.
        /// </summary>
        /// <example>
        /// <c>example.com</c>
        /// </example>
        public const string RegisteredDomain = "server.registered_domain";
        
        /// <summary>
        /// The subdomain of the domain.
        /// </summary>
        /// <example>
        /// <c>east</c>
        /// </example>
        public const string Subdomain = "server.subdomain";
        
        /// <summary>
        /// The effective top level domain (com, org, net, co.uk).
        /// </summary>
        /// <example>
        /// <c>co.uk</c>
        /// </example>
        public const string TopLevelDomain = "server.top_level_domain";
        
    }
}

