namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Cloud
    {
        public static partial class Target
        {
            public static partial class Account
            {
                /// <summary>
                /// The cloud account or organization id.
                /// </summary>
                /// <example>
                /// <c>666777888999</c>
                /// </example>
                public const string Id = "cloud.target.account.id";
                
                /// <summary>
                /// The cloud account name.
                /// </summary>
                /// <example>
                /// <c>elastic-dev</c>
                /// </example>
                public const string Name = "cloud.target.account.name";
                
            }
        }
    }
}

