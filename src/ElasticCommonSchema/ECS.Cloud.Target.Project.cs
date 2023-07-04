﻿namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Cloud
    {
        public static partial class Target
        {
            public static partial class Project
            {
                /// <summary>
                /// The cloud project id.
                /// </summary>
                /// <example>
                /// <c>my-project</c>
                /// </example>
                public const string Id = "cloud.target.project.id";
                
                /// <summary>
                /// The cloud project name.
                /// </summary>
                /// <example>
                /// <c>my project</c>
                /// </example>
                public const string Name = "cloud.target.project.name";
                
            }
        }
    }
}

