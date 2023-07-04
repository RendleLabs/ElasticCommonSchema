namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Process
    {
        public static partial class SessionLeader
        {
            public static partial class SavedGroup
            {
                /// <summary>
                /// Unique identifier for the group on the system/platform.
                /// </summary>
                public const string Id = "process.session_leader.saved_group.id";
                
                /// <summary>
                /// Name of the group.
                /// </summary>
                public const string Name = "process.session_leader.saved_group.name";
                
            }
        }
    }
}

