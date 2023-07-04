namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Threat
    {
        public static partial class Indicator
        {
            public static partial class Registry
            {
                /// <summary>
                /// Abbreviated name for the hive.
                /// </summary>
                /// <example>
                /// <c>HKLM</c>
                /// </example>
                public const string Hive = "threat.indicator.registry.hive";
                
                /// <summary>
                /// Hive-relative path of keys.
                /// </summary>
                /// <example>
                /// <c>SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\winword.exe</c>
                /// </example>
                public const string Key = "threat.indicator.registry.key";
                
                /// <summary>
                /// Full path, including hive, key and value
                /// </summary>
                /// <example>
                /// <c>HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\winword.exe\Debugger</c>
                /// </example>
                public const string Path = "threat.indicator.registry.path";
                
                /// <summary>
                /// Name of the value written.
                /// </summary>
                /// <example>
                /// <c>Debugger</c>
                /// </example>
                public const string Value = "threat.indicator.registry.value";
                
            }
        }
    }
}

