namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Log
    {
        public static partial class Origin
        {
            public static partial class File
            {
                /// <summary>
                /// The line number of the file which originated the log event.
                /// </summary>
                /// <example>
                /// <c>42</c>
                /// </example>
                public const string Line = "log.origin.file.line";
                
                /// <summary>
                /// The code file which originated the log event.
                /// </summary>
                /// <example>
                /// <c>Bootstrap.java</c>
                /// </example>
                public const string Name = "log.origin.file.name";
                
            }
        }
    }
}

