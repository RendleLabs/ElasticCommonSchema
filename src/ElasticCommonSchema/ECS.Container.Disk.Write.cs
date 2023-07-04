namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Container
    {
        public static partial class Disk
        {
            public static partial class Write
            {
                /// <summary>
                /// The number of bytes written on all disks.
                /// </summary>
                public const string Bytes = "container.disk.write.bytes";
                
            }
        }
    }
}

