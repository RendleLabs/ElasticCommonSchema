namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Threat
    {
        public static partial class Tactic
        {
            /// <summary>
            /// Threat tactic id.
            /// </summary>
            /// <example>
            /// <c>TA0002</c>
            /// </example>
            public const string Id = "threat.tactic.id";
            
            /// <summary>
            /// Threat tactic.
            /// </summary>
            /// <example>
            /// <c>Execution</c>
            /// </example>
            public const string Name = "threat.tactic.name";
            
            /// <summary>
            /// Threat tactic URL reference.
            /// </summary>
            /// <example>
            /// <c>https://attack.mitre.org/tactics/TA0002/</c>
            /// </example>
            public const string Reference = "threat.tactic.reference";
            
        }
    }
}

