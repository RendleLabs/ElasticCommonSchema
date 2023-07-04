namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Dll
    {
        /// <summary>
        /// Name of the library.
        /// </summary>
        /// <example>
        /// <c>kernel32.dll</c>
        /// </example>
        public const string Name = "dll.name";
        
        /// <summary>
        /// Full file path of the library.
        /// </summary>
        /// <example>
        /// <c>C:\Windows\System32\kernel32.dll</c>
        /// </example>
        public const string Path = "dll.path";
        
    }
}

