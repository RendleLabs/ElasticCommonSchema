namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Process
    {
        public static partial class Parent
        {
            public static partial class Thread
            {
                /// <summary>
                /// Thread ID.
                /// </summary>
                /// <example>
                /// <c>4242</c>
                /// </example>
                public const string Id = "process.parent.thread.id";
                
                /// <summary>
                /// Thread name.
                /// </summary>
                /// <example>
                /// <c>thread-0</c>
                /// </example>
                public const string Name = "process.parent.thread.name";
                
            }
        }
    }
}

