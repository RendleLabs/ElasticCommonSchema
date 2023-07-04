namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Threat
    {
        public static partial class Technique
        {
            /// <summary>
            /// Threat technique id.
            /// </summary>
            /// <example>
            /// <c>T1059</c>
            /// </example>
            public const string Id = "threat.technique.id";
            
            /// <summary>
            /// Threat technique name.
            /// </summary>
            /// <example>
            /// <c>Command and Scripting Interpreter</c>
            /// </example>
            public const string Name = "threat.technique.name";
            
            /// <summary>
            /// Threat technique URL reference.
            /// </summary>
            /// <example>
            /// <c>https://attack.mitre.org/techniques/T1059/</c>
            /// </example>
            public const string Reference = "threat.technique.reference";
            
            /// <summary>
            /// Threat technique name.
            /// </summary>
            /// <example>
            /// <c>Command and Scripting Interpreter</c>
            /// </example>
            public const string NameText = "threat.technique.name.text";
            
        }
    }
}

