namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Host
    {
        /// <summary>
        /// Operating system architecture.
        /// </summary>
        /// <example>
        /// <c>x86_64</c>
        /// </example>
        public const string Architecture = "host.architecture";
        
        /// <summary>
        /// Name of the directory the group is a member of.
        /// </summary>
        /// <example>
        /// <c>CONTOSO</c>
        /// </example>
        public const string Domain = "host.domain";
        
        /// <summary>
        /// Hostname of the host.
        /// </summary>
        public const string Hostname = "host.hostname";
        
        /// <summary>
        /// Unique host id.
        /// </summary>
        public const string Id = "host.id";
        
        /// <summary>
        /// Host ip addresses.
        /// </summary>
        public const string Ip = "host.ip";
        
        /// <summary>
        /// Host MAC addresses.
        /// </summary>
        /// <example>
        /// <c>["00-00-5E-00-53-23", "00-00-5E-00-53-24"]</c>
        /// </example>
        public const string Mac = "host.mac";
        
        /// <summary>
        /// Name of the host.
        /// </summary>
        public const string Name = "host.name";
        
        /// <summary>
        /// Pid namespace inode
        /// </summary>
        /// <example>
        /// <c>256383</c>
        /// </example>
        public const string PidNsIno = "host.pid_ns_ino";
        
        /// <summary>
        /// Type of host.
        /// </summary>
        public const string Type = "host.type";
        
        /// <summary>
        /// Seconds the host has been up.
        /// </summary>
        /// <example>
        /// <c>1325</c>
        /// </example>
        public const string Uptime = "host.uptime";
        
    }
}

