namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Process
    {
        public static partial class GroupLeader
        {
            public static partial class SavedGroup
            {
                /// <summary>
                /// Unique identifier for the group on the system/platform.
                /// </summary>
                public const string Id = "process.group_leader.saved_group.id";
                
                /// <summary>
                /// Name of the group.
                /// </summary>
                public const string Name = "process.group_leader.saved_group.name";
                
            }
        }
    }
}

