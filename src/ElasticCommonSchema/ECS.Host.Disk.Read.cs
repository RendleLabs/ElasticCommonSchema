namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Host
    {
        public static partial class Disk
        {
            public static partial class Read
            {
                /// <summary>
                /// The number of bytes read by all disks.
                /// </summary>
                public const string Bytes = "host.disk.read.bytes";
                
            }
        }
    }
}

