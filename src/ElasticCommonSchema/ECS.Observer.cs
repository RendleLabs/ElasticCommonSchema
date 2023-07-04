namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Observer
    {
        /// <summary>
        /// Object field for egress information
        /// </summary>
        public const string Egress = "observer.egress";
        
        /// <summary>
        /// Hostname of the observer.
        /// </summary>
        public const string Hostname = "observer.hostname";
        
        /// <summary>
        /// Object field for ingress information
        /// </summary>
        public const string Ingress = "observer.ingress";
        
        /// <summary>
        /// IP addresses of the observer.
        /// </summary>
        public const string Ip = "observer.ip";
        
        /// <summary>
        /// MAC addresses of the observer.
        /// </summary>
        /// <example>
        /// <c>["00-00-5E-00-53-23", "00-00-5E-00-53-24"]</c>
        /// </example>
        public const string Mac = "observer.mac";
        
        /// <summary>
        /// Custom name of the observer.
        /// </summary>
        /// <example>
        /// <c>1_proxySG</c>
        /// </example>
        public const string Name = "observer.name";
        
        /// <summary>
        /// The product name of the observer.
        /// </summary>
        /// <example>
        /// <c>s200</c>
        /// </example>
        public const string Product = "observer.product";
        
        /// <summary>
        /// Observer serial number.
        /// </summary>
        public const string SerialNumber = "observer.serial_number";
        
        /// <summary>
        /// The type of the observer the data is coming from.
        /// </summary>
        /// <example>
        /// <c>firewall</c>
        /// </example>
        public const string Type = "observer.type";
        
        /// <summary>
        /// Vendor name of the observer.
        /// </summary>
        /// <example>
        /// <c>Symantec</c>
        /// </example>
        public const string Vendor = "observer.vendor";
        
        /// <summary>
        /// Observer version.
        /// </summary>
        public const string Version = "observer.version";
        
        /// <summary>
        /// Observer Egress zone
        /// </summary>
        /// <example>
        /// <c>Public_Internet</c>
        /// </example>
        public const string EgressZone = "observer.egress.zone";
        
        /// <summary>
        /// Observer ingress zone
        /// </summary>
        /// <example>
        /// <c>DMZ</c>
        /// </example>
        public const string IngressZone = "observer.ingress.zone";
        
    }
}

