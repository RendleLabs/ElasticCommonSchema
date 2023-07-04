namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Http
    {
        public static partial class Request
        {
            /// <summary>
            /// Total size in bytes of the request (body and headers).
            /// </summary>
            /// <example>
            /// <c>1437</c>
            /// </example>
            public const string Bytes = "http.request.bytes";
            
            /// <summary>
            /// HTTP request ID.
            /// </summary>
            /// <example>
            /// <c>123e4567-e89b-12d3-a456-426614174000</c>
            /// </example>
            public const string Id = "http.request.id";
            
            /// <summary>
            /// HTTP request method.
            /// </summary>
            /// <example>
            /// <c>POST</c>
            /// </example>
            public const string Method = "http.request.method";
            
            /// <summary>
            /// Mime type of the body of the request.
            /// </summary>
            /// <example>
            /// <c>image/gif</c>
            /// </example>
            public const string MimeType = "http.request.mime_type";
            
            /// <summary>
            /// Referrer for this HTTP request.
            /// </summary>
            /// <example>
            /// <c>https://blog.example.com/</c>
            /// </example>
            public const string Referrer = "http.request.referrer";
            
        }
    }
}

