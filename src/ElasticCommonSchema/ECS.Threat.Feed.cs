namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Threat
    {
        public static partial class Feed
        {
            /// <summary>
            /// Feed dashboard ID.
            /// </summary>
            /// <example>
            /// <c>5ba16340-72e6-11eb-a3e3-b3cc7c78a70f</c>
            /// </example>
            public const string DashboardId = "threat.feed.dashboard_id";
            
            /// <summary>
            /// Description of the threat feed.
            /// </summary>
            /// <example>
            /// <c>Threat feed from the AlienVault Open Threat eXchange network.</c>
            /// </example>
            public const string Description = "threat.feed.description";
            
            /// <summary>
            /// Name of the threat feed.
            /// </summary>
            /// <example>
            /// <c>AlienVault OTX</c>
            /// </example>
            public const string Name = "threat.feed.name";
            
            /// <summary>
            /// Reference for the threat feed.
            /// </summary>
            /// <example>
            /// <c>https://otx.alienvault.com</c>
            /// </example>
            public const string Reference = "threat.feed.reference";
            
        }
    }
}

