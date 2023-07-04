namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Cloud
    {
        public static partial class Target
        {
            /// <summary>
            /// Availability zone in which this host, resource, or service is located.
            /// </summary>
            /// <example>
            /// <c>us-east-1c</c>
            /// </example>
            public const string AvailabilityZone = "cloud.target.availability_zone";
            
            /// <summary>
            /// Name of the cloud provider.
            /// </summary>
            /// <example>
            /// <c>aws</c>
            /// </example>
            public const string Provider = "cloud.target.provider";
            
            /// <summary>
            /// Region in which this host, resource, or service is located.
            /// </summary>
            /// <example>
            /// <c>us-east-1</c>
            /// </example>
            public const string Region = "cloud.target.region";
            
        }
    }
}

