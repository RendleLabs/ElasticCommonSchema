namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Threat
    {
        public static partial class Group
        {
            /// <summary>
            /// Alias of the group.
            /// </summary>
            /// <example>
            /// <c>[ "Magecart Group 6" ]</c>
            /// </example>
            public const string Alias = "threat.group.alias";
            
            /// <summary>
            /// ID of the group.
            /// </summary>
            /// <example>
            /// <c>G0037</c>
            /// </example>
            public const string Id = "threat.group.id";
            
            /// <summary>
            /// Name of the group.
            /// </summary>
            /// <example>
            /// <c>FIN6</c>
            /// </example>
            public const string Name = "threat.group.name";
            
            /// <summary>
            /// Reference URL of the group.
            /// </summary>
            /// <example>
            /// <c>https://attack.mitre.org/groups/G0037/</c>
            /// </example>
            public const string Reference = "threat.group.reference";
            
        }
    }
}

