namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Http
    {
        public static partial class Request
        {
            public static partial class Body
            {
                /// <summary>
                /// Size in bytes of the request body.
                /// </summary>
                /// <example>
                /// <c>887</c>
                /// </example>
                public const string Bytes = "http.request.body.bytes";
                
                /// <summary>
                /// The full HTTP request body.
                /// </summary>
                /// <example>
                /// <c>Hello world</c>
                /// </example>
                public const string Content = "http.request.body.content";
                
                /// <summary>
                /// The full HTTP request body.
                /// </summary>
                /// <example>
                /// <c>Hello world</c>
                /// </example>
                public const string ContentText = "http.request.body.content.text";
                
            }
        }
    }
}

