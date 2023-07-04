namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Host
    {
        public static partial class Risk
        {
            /// <summary>
            /// A risk classification level calculated by an internal system as part of entity analytics and entity risk scoring.
            /// </summary>
            /// <example>
            /// <c>High</c>
            /// </example>
            public const string CalculatedLevel = "host.risk.calculated_level";
            
            /// <summary>
            /// A risk classification score calculated by an internal system as part of entity analytics and entity risk scoring.
            /// </summary>
            /// <example>
            /// <c>880.73</c>
            /// </example>
            public const string CalculatedScore = "host.risk.calculated_score";
            
            /// <summary>
            /// A normalized risk score calculated by an internal system.
            /// </summary>
            /// <example>
            /// <c>88.73</c>
            /// </example>
            public const string CalculatedScoreNorm = "host.risk.calculated_score_norm";
            
            /// <summary>
            /// A risk classification level obtained from outside the system, such as from some external Threat Intelligence Platform.
            /// </summary>
            /// <example>
            /// <c>High</c>
            /// </example>
            public const string StaticLevel = "host.risk.static_level";
            
            /// <summary>
            /// A risk classification score obtained from outside the system, such as from some external Threat Intelligence Platform.
            /// </summary>
            /// <example>
            /// <c>830.0</c>
            /// </example>
            public const string StaticScore = "host.risk.static_score";
            
            /// <summary>
            /// A normalized risk score calculated by an external system.
            /// </summary>
            /// <example>
            /// <c>83.0</c>
            /// </example>
            public const string StaticScoreNorm = "host.risk.static_score_norm";
            
        }
    }
}

