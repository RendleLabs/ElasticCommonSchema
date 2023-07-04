namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Observer
    {
        public static partial class Os
        {
            /// <summary>
            /// OS family (such as redhat, debian, freebsd, windows).
            /// </summary>
            /// <example>
            /// <c>debian</c>
            /// </example>
            public const string Family = "observer.os.family";
            
            /// <summary>
            /// Operating system name, including the version or code name.
            /// </summary>
            /// <example>
            /// <c>Mac OS Mojave</c>
            /// </example>
            public const string Full = "observer.os.full";
            
            /// <summary>
            /// Operating system kernel version as a raw string.
            /// </summary>
            /// <example>
            /// <c>4.4.0-112-generic</c>
            /// </example>
            public const string Kernel = "observer.os.kernel";
            
            /// <summary>
            /// Operating system name, without the version.
            /// </summary>
            /// <example>
            /// <c>Mac OS X</c>
            /// </example>
            public const string Name = "observer.os.name";
            
            /// <summary>
            /// Operating system platform (such centos, ubuntu, windows).
            /// </summary>
            /// <example>
            /// <c>darwin</c>
            /// </example>
            public const string Platform = "observer.os.platform";
            
            /// <summary>
            /// Which commercial OS family (one of: linux, macos, unix, windows, ios or android).
            /// </summary>
            /// <example>
            /// <c>macos</c>
            /// </example>
            public const string Type = "observer.os.type";
            
            /// <summary>
            /// Operating system version as a raw string.
            /// </summary>
            /// <example>
            /// <c>10.14.1</c>
            /// </example>
            public const string Version = "observer.os.version";
            
            /// <summary>
            /// Operating system name, including the version or code name.
            /// </summary>
            /// <example>
            /// <c>Mac OS Mojave</c>
            /// </example>
            public const string FullText = "observer.os.full.text";
            
            /// <summary>
            /// Operating system name, without the version.
            /// </summary>
            /// <example>
            /// <c>Mac OS X</c>
            /// </example>
            public const string NameText = "observer.os.name.text";
            
        }
    }
}

