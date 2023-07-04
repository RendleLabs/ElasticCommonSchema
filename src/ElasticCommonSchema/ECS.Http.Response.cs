namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Http
    {
        public static partial class Response
        {
            /// <summary>
            /// Total size in bytes of the response (body and headers).
            /// </summary>
            /// <example>
            /// <c>1437</c>
            /// </example>
            public const string Bytes = "http.response.bytes";
            
            /// <summary>
            /// Mime type of the body of the response.
            /// </summary>
            /// <example>
            /// <c>image/gif</c>
            /// </example>
            public const string MimeType = "http.response.mime_type";
            
            /// <summary>
            /// HTTP response status code.
            /// </summary>
            /// <example>
            /// <c>404</c>
            /// </example>
            public const string StatusCode = "http.response.status_code";
            
        }
    }
}

