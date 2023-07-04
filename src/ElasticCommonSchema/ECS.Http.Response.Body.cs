namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Http
    {
        public static partial class Response
        {
            public static partial class Body
            {
                /// <summary>
                /// Size in bytes of the response body.
                /// </summary>
                /// <example>
                /// <c>887</c>
                /// </example>
                public const string Bytes = "http.response.body.bytes";
                
                /// <summary>
                /// The full HTTP response body.
                /// </summary>
                /// <example>
                /// <c>Hello world</c>
                /// </example>
                public const string Content = "http.response.body.content";
                
                /// <summary>
                /// The full HTTP response body.
                /// </summary>
                /// <example>
                /// <c>Hello world</c>
                /// </example>
                public const string ContentText = "http.response.body.content.text";
                
            }
        }
    }
}

