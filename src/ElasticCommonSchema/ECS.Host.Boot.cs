namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Host
    {
        public static partial class Boot
        {
            /// <summary>
            /// Linux boot uuid taken from /proc/sys/kernel/random/boot_id
            /// </summary>
            /// <example>
            /// <c>88a1f0ed-5ae5-41ee-af6b-41921c311872</c>
            /// </example>
            public const string Id = "host.boot.id";
            
        }
    }
}

