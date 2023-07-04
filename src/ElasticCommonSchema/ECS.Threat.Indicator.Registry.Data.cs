namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Threat
    {
        public static partial class Indicator
        {
            public static partial class Registry
            {
                public static partial class Data
                {
                    /// <summary>
                    /// Original bytes written with base64 encoding.
                    /// </summary>
                    /// <example>
                    /// <c>ZQBuAC0AVQBTAAAAZQBuAAAAAAA=</c>
                    /// </example>
                    public const string Bytes = "threat.indicator.registry.data.bytes";
                    
                    /// <summary>
                    /// List of strings representing what was written to the registry.
                    /// </summary>
                    /// <example>
                    /// <c>["C:\rta\red_ttp\bin\myapp.exe"]</c>
                    /// </example>
                    public const string Strings = "threat.indicator.registry.data.strings";
                    
                    /// <summary>
                    /// Standard registry type for encoding contents
                    /// </summary>
                    /// <example>
                    /// <c>REG_SZ</c>
                    /// </example>
                    public const string Type = "threat.indicator.registry.data.type";
                    
                }
            }
        }
    }
}

