namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class User
    {
        public static partial class Effective
        {
            public static partial class Group
            {
                /// <summary>
                /// Name of the directory the group is a member of.
                /// </summary>
                public const string Domain = "user.effective.group.domain";
                
                /// <summary>
                /// Unique identifier for the group on the system/platform.
                /// </summary>
                public const string Id = "user.effective.group.id";
                
                /// <summary>
                /// Name of the group.
                /// </summary>
                public const string Name = "user.effective.group.name";
                
            }
        }
    }
}

