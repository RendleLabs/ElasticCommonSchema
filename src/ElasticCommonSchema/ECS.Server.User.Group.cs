namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Server
    {
        public static partial class User
        {
            public static partial class Group
            {
                /// <summary>
                /// Name of the directory the group is a member of.
                /// </summary>
                public const string Domain = "server.user.group.domain";
                
                /// <summary>
                /// Unique identifier for the group on the system/platform.
                /// </summary>
                public const string Id = "server.user.group.id";
                
                /// <summary>
                /// Name of the group.
                /// </summary>
                public const string Name = "server.user.group.name";
                
            }
        }
    }
}

