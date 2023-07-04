namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Related
    {
        /// <summary>
        /// All the hashes seen on your event.
        /// </summary>
        public const string Hash = "related.hash";
        
        /// <summary>
        /// All the host identifiers seen on your event.
        /// </summary>
        public const string Hosts = "related.hosts";
        
        /// <summary>
        /// All of the IPs seen on your event.
        /// </summary>
        public const string Ip = "related.ip";
        
        /// <summary>
        /// All the user names or other user identifiers seen on the event.
        /// </summary>
        public const string User = "related.user";
        
    }
}

