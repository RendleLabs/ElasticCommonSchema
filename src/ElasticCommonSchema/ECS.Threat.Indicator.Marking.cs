namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Threat
    {
        public static partial class Indicator
        {
            public static partial class Marking
            {
                /// <summary>
                /// Indicator TLP marking
                /// </summary>
                /// <example>
                /// <c>CLEAR</c>
                /// </example>
                public const string Tlp = "threat.indicator.marking.tlp";
                
                /// <summary>
                /// Indicator TLP version
                /// </summary>
                /// <example>
                /// <c>2.0</c>
                /// </example>
                public const string TlpVersion = "threat.indicator.marking.tlp_version";
                
            }
        }
    }
}

