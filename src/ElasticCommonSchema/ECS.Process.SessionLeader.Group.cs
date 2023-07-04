namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Process
    {
        public static partial class SessionLeader
        {
            public static partial class Group
            {
                /// <summary>
                /// Unique identifier for the group on the system/platform.
                /// </summary>
                public const string Id = "process.session_leader.group.id";
                
                /// <summary>
                /// Name of the group.
                /// </summary>
                public const string Name = "process.session_leader.group.name";
                
            }
        }
    }
}

