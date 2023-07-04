namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Process
    {
        public static partial class EntryLeader
        {
            public static partial class Parent
            {
                public static partial class SessionLeader
                {
                    /// <summary>
                    /// Unique identifier for the process.
                    /// </summary>
                    /// <example>
                    /// <c>c2c455d9f99375d</c>
                    /// </example>
                    public const string EntityId = "process.entry_leader.parent.session_leader.entity_id";
                    
                    /// <summary>
                    /// Process id.
                    /// </summary>
                    /// <example>
                    /// <c>4242</c>
                    /// </example>
                    public const string Pid = "process.entry_leader.parent.session_leader.pid";
                    
                    /// <summary>
                    /// The time the process started.
                    /// </summary>
                    /// <example>
                    /// <c>2016-05-23T08:05:34.853Z</c>
                    /// </example>
                    public const string Start = "process.entry_leader.parent.session_leader.start";
                    
                }
            }
        }
    }
}

