﻿namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Process
    {
        public static partial class User
        {
            /// <summary>
            /// Unique identifier of the user.
            /// </summary>
            /// <example>
            /// <c>S-1-5-21-202424912787-2692429404-2351956786-1000</c>
            /// </example>
            public const string Id = "process.user.id";
            
            /// <summary>
            /// Short name or login of the user.
            /// </summary>
            /// <example>
            /// <c>a.einstein</c>
            /// </example>
            public const string Name = "process.user.name";
            
            /// <summary>
            /// Short name or login of the user.
            /// </summary>
            /// <example>
            /// <c>a.einstein</c>
            /// </example>
            public const string NameText = "process.user.name.text";
            
        }
    }
}

