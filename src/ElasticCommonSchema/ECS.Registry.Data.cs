namespace ElasticCommonSchema;

public static partial class ECS
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
            public const string Bytes = "registry.data.bytes";
            
            /// <summary>
            /// List of strings representing what was written to the registry.
            /// </summary>
            /// <example>
            /// <c>["C:\rta\red_ttp\bin\myapp.exe"]</c>
            /// </example>
            public const string Strings = "registry.data.strings";
            
            /// <summary>
            /// Standard registry type for encoding contents
            /// </summary>
            /// <example>
            /// <c>REG_SZ</c>
            /// </example>
            public const string Type = "registry.data.type";
            
        }
    }
}

