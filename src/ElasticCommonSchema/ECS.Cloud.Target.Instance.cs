namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Cloud
    {
        public static partial class Target
        {
            public static partial class Instance
            {
                /// <summary>
                /// Instance ID of the host machine.
                /// </summary>
                /// <example>
                /// <c>i-1234567890abcdef0</c>
                /// </example>
                public const string Id = "cloud.target.instance.id";
                
                /// <summary>
                /// Instance name of the host machine.
                /// </summary>
                public const string Name = "cloud.target.instance.name";
                
            }
        }
    }
}

