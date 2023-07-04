﻿namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Cloud
    {
        public static partial class Origin
        {
            public static partial class Project
            {
                /// <summary>
                /// The cloud project id.
                /// </summary>
                /// <example>
                /// <c>my-project</c>
                /// </example>
                public const string Id = "cloud.origin.project.id";
                
                /// <summary>
                /// The cloud project name.
                /// </summary>
                /// <example>
                /// <c>my project</c>
                /// </example>
                public const string Name = "cloud.origin.project.name";
                
            }
        }
    }
}

