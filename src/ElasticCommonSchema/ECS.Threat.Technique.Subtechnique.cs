namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Threat
    {
        public static partial class Technique
        {
            public static partial class Subtechnique
            {
                /// <summary>
                /// Threat subtechnique id.
                /// </summary>
                /// <example>
                /// <c>T1059.001</c>
                /// </example>
                public const string Id = "threat.technique.subtechnique.id";
                
                /// <summary>
                /// Threat subtechnique name.
                /// </summary>
                /// <example>
                /// <c>PowerShell</c>
                /// </example>
                public const string Name = "threat.technique.subtechnique.name";
                
                /// <summary>
                /// Threat subtechnique URL reference.
                /// </summary>
                /// <example>
                /// <c>https://attack.mitre.org/techniques/T1059/001/</c>
                /// </example>
                public const string Reference = "threat.technique.subtechnique.reference";
                
                /// <summary>
                /// Threat subtechnique name.
                /// </summary>
                /// <example>
                /// <c>PowerShell</c>
                /// </example>
                public const string NameText = "threat.technique.subtechnique.name.text";
                
            }
        }
    }
}

