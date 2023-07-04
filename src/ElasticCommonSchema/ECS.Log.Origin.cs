namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Log
    {
        public static partial class Origin
        {
            /// <summary>
            /// The function which originated the log event.
            /// </summary>
            /// <example>
            /// <c>init</c>
            /// </example>
            public const string Function = "log.origin.function";
            
        }
    }
}

