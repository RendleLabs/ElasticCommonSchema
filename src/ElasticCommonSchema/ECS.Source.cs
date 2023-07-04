namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Source
    {
        /// <summary>
        /// Source network address.
        /// </summary>
        public const string Address = "source.address";
        
        /// <summary>
        /// Bytes sent from the source to the destination.
        /// </summary>
        /// <example>
        /// <c>184</c>
        /// </example>
        public const string Bytes = "source.bytes";
        
        /// <summary>
        /// The domain name of the source.
        /// </summary>
        /// <example>
        /// <c>foo.example.com</c>
        /// </example>
        public const string Domain = "source.domain";
        
        /// <summary>
        /// IP address of the source.
        /// </summary>
        public const string Ip = "source.ip";
        
        /// <summary>
        /// MAC address of the source.
        /// </summary>
        /// <example>
        /// <c>00-00-5E-00-53-23</c>
        /// </example>
        public const string Mac = "source.mac";
        
        /// <summary>
        /// Packets sent from the source to the destination.
        /// </summary>
        /// <example>
        /// <c>12</c>
        /// </example>
        public const string Packets = "source.packets";
        
        /// <summary>
        /// Port of the source.
        /// </summary>
        public const string Port = "source.port";
        
        /// <summary>
        /// The highest registered source domain, stripped of the subdomain.
        /// </summary>
        /// <example>
        /// <c>example.com</c>
        /// </example>
        public const string RegisteredDomain = "source.registered_domain";
        
        /// <summary>
        /// The subdomain of the domain.
        /// </summary>
        /// <example>
        /// <c>east</c>
        /// </example>
        public const string Subdomain = "source.subdomain";
        
        /// <summary>
        /// The effective top level domain (com, org, net, co.uk).
        /// </summary>
        /// <example>
        /// <c>co.uk</c>
        /// </example>
        public const string TopLevelDomain = "source.top_level_domain";
        
    }
}

