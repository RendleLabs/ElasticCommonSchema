namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Orchestrator
    {
        public static partial class Resource
        {
            public static partial class Parent
            {
                /// <summary>
                /// Type or kind of the parent resource associated with the event being observed.
                /// </summary>
                /// <example>
                /// <c>DaemonSet</c>
                /// </example>
                public const string Type = "orchestrator.resource.parent.type";
                
            }
        }
    }
}

