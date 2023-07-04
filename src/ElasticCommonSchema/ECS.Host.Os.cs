namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Host
    {
        public static partial class Os
        {
            /// <summary>
            /// OS family (such as redhat, debian, freebsd, windows).
            /// </summary>
            /// <example>
            /// <c>debian</c>
            /// </example>
            public const string Family = "host.os.family";
            
            /// <summary>
            /// Operating system name, including the version or code name.
            /// </summary>
            /// <example>
            /// <c>Mac OS Mojave</c>
            /// </example>
            public const string Full = "host.os.full";
            
            /// <summary>
            /// Operating system kernel version as a raw string.
            /// </summary>
            /// <example>
            /// <c>4.4.0-112-generic</c>
            /// </example>
            public const string Kernel = "host.os.kernel";
            
            /// <summary>
            /// Operating system name, without the version.
            /// </summary>
            /// <example>
            /// <c>Mac OS X</c>
            /// </example>
            public const string Name = "host.os.name";
            
            /// <summary>
            /// Operating system platform (such centos, ubuntu, windows).
            /// </summary>
            /// <example>
            /// <c>darwin</c>
            /// </example>
            public const string Platform = "host.os.platform";
            
            /// <summary>
            /// Which commercial OS family (one of: linux, macos, unix, windows, ios or android).
            /// </summary>
            /// <example>
            /// <c>macos</c>
            /// </example>
            public const string Type = "host.os.type";
            
            /// <summary>
            /// Operating system version as a raw string.
            /// </summary>
            /// <example>
            /// <c>10.14.1</c>
            /// </example>
            public const string Version = "host.os.version";
            
            /// <summary>
            /// Operating system name, including the version or code name.
            /// </summary>
            /// <example>
            /// <c>Mac OS Mojave</c>
            /// </example>
            public const string FullText = "host.os.full.text";
            
            /// <summary>
            /// Operating system name, without the version.
            /// </summary>
            /// <example>
            /// <c>Mac OS X</c>
            /// </example>
            public const string NameText = "host.os.name.text";
            
        }
    }
}

