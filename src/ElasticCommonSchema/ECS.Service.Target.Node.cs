namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Service
    {
        public static partial class Target
        {
            public static partial class Node
            {
                /// <summary>
                /// Name of the service node.
                /// </summary>
                /// <example>
                /// <c>instance-0000000016</c>
                /// </example>
                public const string Name = "service.target.node.name";
                
                /// <summary>
                /// Deprecated role (singular) of the service node.
                /// </summary>
                /// <example>
                /// <c>background_tasks</c>
                /// </example>
                public const string Role = "service.target.node.role";
                
                /// <summary>
                /// Roles of the service node.
                /// </summary>
                /// <example>
                /// <c>["ui", "background_tasks"]</c>
                /// </example>
                public const string Roles = "service.target.node.roles";
                
            }
        }
    }
}

