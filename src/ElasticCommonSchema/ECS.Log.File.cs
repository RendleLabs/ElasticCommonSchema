namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Log
    {
        public static partial class File
        {
            /// <summary>
            /// Full path to the log file this event came from.
            /// </summary>
            /// <example>
            /// <c>/var/log/fun-times.log</c>
            /// </example>
            public const string Path = "log.file.path";
            
        }
    }
}

