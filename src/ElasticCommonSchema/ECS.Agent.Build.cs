namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Agent
    {
        public static partial class Build
        {
            /// <summary>
            /// Extended build information for the agent.
            /// </summary>
            /// <example>
            /// <c>metricbeat version 7.6.0 (amd64), libbeat 7.6.0 [6a23e8f8f30f5001ba344e4e54d8d9cb82cb107c built 2020-02-05 23:10:10 +0000 UTC]</c>
            /// </example>
            public const string Original = "agent.build.original";
            
        }
    }
}

