namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Cloud
    {
        public static partial class Origin
        {
            /// <summary>
            /// Availability zone in which this host, resource, or service is located.
            /// </summary>
            /// <example>
            /// <c>us-east-1c</c>
            /// </example>
            public const string AvailabilityZone = "cloud.origin.availability_zone";
            
            /// <summary>
            /// Name of the cloud provider.
            /// </summary>
            /// <example>
            /// <c>aws</c>
            /// </example>
            public const string Provider = "cloud.origin.provider";
            
            /// <summary>
            /// Region in which this host, resource, or service is located.
            /// </summary>
            /// <example>
            /// <c>us-east-1</c>
            /// </example>
            public const string Region = "cloud.origin.region";
            
        }
    }
}

