namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Package
    {
        /// <summary>
        /// Package architecture.
        /// </summary>
        /// <example>
        /// <c>x86_64</c>
        /// </example>
        public const string Architecture = "package.architecture";
        
        /// <summary>
        /// Build version information
        /// </summary>
        /// <example>
        /// <c>36f4f7e89dd61b0988b12ee000b98966867710cd</c>
        /// </example>
        public const string BuildVersion = "package.build_version";
        
        /// <summary>
        /// Checksum of the installed package for verification.
        /// </summary>
        /// <example>
        /// <c>68b329da9893e34099c7d8ad5cb9c940</c>
        /// </example>
        public const string Checksum = "package.checksum";
        
        /// <summary>
        /// Description of the package.
        /// </summary>
        /// <example>
        /// <c>Open source programming language to build simple/reliable/efficient software.</c>
        /// </example>
        public const string Description = "package.description";
        
        /// <summary>
        /// Indicating how the package was installed, e.g. user-local, global.
        /// </summary>
        /// <example>
        /// <c>global</c>
        /// </example>
        public const string InstallScope = "package.install_scope";
        
        /// <summary>
        /// Time when package was installed.
        /// </summary>
        public const string Installed = "package.installed";
        
        /// <summary>
        /// Package license
        /// </summary>
        /// <example>
        /// <c>Apache License 2.0</c>
        /// </example>
        public const string License = "package.license";
        
        /// <summary>
        /// Package name
        /// </summary>
        /// <example>
        /// <c>go</c>
        /// </example>
        public const string Name = "package.name";
        
        /// <summary>
        /// Path where the package is installed.
        /// </summary>
        /// <example>
        /// <c>/usr/local/Cellar/go/1.12.9/</c>
        /// </example>
        public const string Path = "package.path";
        
        /// <summary>
        /// Package home page or reference URL
        /// </summary>
        /// <example>
        /// <c>https://golang.org</c>
        /// </example>
        public const string Reference = "package.reference";
        
        /// <summary>
        /// Package size in bytes.
        /// </summary>
        /// <example>
        /// <c>62231</c>
        /// </example>
        public const string Size = "package.size";
        
        /// <summary>
        /// Package type
        /// </summary>
        /// <example>
        /// <c>rpm</c>
        /// </example>
        public const string Type = "package.type";
        
        /// <summary>
        /// Package version
        /// </summary>
        /// <example>
        /// <c>1.12.9</c>
        /// </example>
        public const string Version = "package.version";
        
    }
}

