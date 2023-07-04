namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Process
    {
        public static partial class Parent
        {
            public static partial class Group
            {
                /// <summary>
                /// Unique identifier for the group on the system/platform.
                /// </summary>
                public const string Id = "process.parent.group.id";
                
                /// <summary>
                /// Name of the group.
                /// </summary>
                public const string Name = "process.parent.group.name";
                
            }
        }
    }
}

