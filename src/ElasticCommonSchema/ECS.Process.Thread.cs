namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Process
    {
        public static partial class Thread
        {
            /// <summary>
            /// Thread ID.
            /// </summary>
            /// <example>
            /// <c>4242</c>
            /// </example>
            public const string Id = "process.thread.id";
            
            /// <summary>
            /// Thread name.
            /// </summary>
            /// <example>
            /// <c>thread-0</c>
            /// </example>
            public const string Name = "process.thread.name";
            
        }
    }
}

