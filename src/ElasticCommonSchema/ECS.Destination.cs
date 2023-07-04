namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Destination
    {
        /// <summary>
        /// Destination network address.
        /// </summary>
        public const string Address = "destination.address";
        
        /// <summary>
        /// Bytes sent from the destination to the source.
        /// </summary>
        /// <example>
        /// <c>184</c>
        /// </example>
        public const string Bytes = "destination.bytes";
        
        /// <summary>
        /// The domain name of the destination.
        /// </summary>
        /// <example>
        /// <c>foo.example.com</c>
        /// </example>
        public const string Domain = "destination.domain";
        
        /// <summary>
        /// IP address of the destination.
        /// </summary>
        public const string Ip = "destination.ip";
        
        /// <summary>
        /// MAC address of the destination.
        /// </summary>
        /// <example>
        /// <c>00-00-5E-00-53-23</c>
        /// </example>
        public const string Mac = "destination.mac";
        
        /// <summary>
        /// Packets sent from the destination to the source.
        /// </summary>
        /// <example>
        /// <c>12</c>
        /// </example>
        public const string Packets = "destination.packets";
        
        /// <summary>
        /// Port of the destination.
        /// </summary>
        public const string Port = "destination.port";
        
        /// <summary>
        /// The highest registered destination domain, stripped of the subdomain.
        /// </summary>
        /// <example>
        /// <c>example.com</c>
        /// </example>
        public const string RegisteredDomain = "destination.registered_domain";
        
        /// <summary>
        /// The subdomain of the domain.
        /// </summary>
        /// <example>
        /// <c>east</c>
        /// </example>
        public const string Subdomain = "destination.subdomain";
        
        /// <summary>
        /// The effective top level domain (com, org, net, co.uk).
        /// </summary>
        /// <example>
        /// <c>co.uk</c>
        /// </example>
        public const string TopLevelDomain = "destination.top_level_domain";
        
    }
}

