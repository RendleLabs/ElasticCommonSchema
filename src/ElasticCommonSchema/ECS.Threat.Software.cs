namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Threat
    {
        public static partial class Software
        {
            /// <summary>
            /// Alias of the software
            /// </summary>
            /// <example>
            /// <c>[ "X-Agent" ]</c>
            /// </example>
            public const string Alias = "threat.software.alias";
            
            /// <summary>
            /// ID of the software
            /// </summary>
            /// <example>
            /// <c>S0552</c>
            /// </example>
            public const string Id = "threat.software.id";
            
            /// <summary>
            /// Name of the software.
            /// </summary>
            /// <example>
            /// <c>AdFind</c>
            /// </example>
            public const string Name = "threat.software.name";
            
            /// <summary>
            /// Platforms of the software.
            /// </summary>
            /// <example>
            /// <c>[ "Windows" ]</c>
            /// </example>
            public const string Platforms = "threat.software.platforms";
            
            /// <summary>
            /// Software reference URL.
            /// </summary>
            /// <example>
            /// <c>https://attack.mitre.org/software/S0552/</c>
            /// </example>
            public const string Reference = "threat.software.reference";
            
            /// <summary>
            /// Software type.
            /// </summary>
            /// <example>
            /// <c>Tool</c>
            /// </example>
            public const string Type = "threat.software.type";
            
        }
    }
}

