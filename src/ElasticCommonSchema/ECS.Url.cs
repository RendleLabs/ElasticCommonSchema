namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Url
    {
        /// <summary>
        /// Domain of the url.
        /// </summary>
        /// <example>
        /// <c>www.elastic.co</c>
        /// </example>
        public const string Domain = "url.domain";
        
        /// <summary>
        /// File extension from the request url, excluding the leading dot.
        /// </summary>
        /// <example>
        /// <c>png</c>
        /// </example>
        public const string Extension = "url.extension";
        
        /// <summary>
        /// Portion of the url after the `#`.
        /// </summary>
        public const string Fragment = "url.fragment";
        
        /// <summary>
        /// Full unparsed URL.
        /// </summary>
        /// <example>
        /// <c>https://www.elastic.co:443/search?q=elasticsearch#top</c>
        /// </example>
        public const string Full = "url.full";
        
        /// <summary>
        /// Unmodified original url as seen in the event source.
        /// </summary>
        /// <example>
        /// <c>https://www.elastic.co:443/search?q=elasticsearch#top or /search?q=elasticsearch</c>
        /// </example>
        public const string Original = "url.original";
        
        /// <summary>
        /// Password of the request.
        /// </summary>
        public const string Password = "url.password";
        
        /// <summary>
        /// Path of the request, such as "/search".
        /// </summary>
        public const string Path = "url.path";
        
        /// <summary>
        /// Port of the request, such as 443.
        /// </summary>
        /// <example>
        /// <c>443</c>
        /// </example>
        public const string Port = "url.port";
        
        /// <summary>
        /// Query string of the request.
        /// </summary>
        public const string Query = "url.query";
        
        /// <summary>
        /// The highest registered url domain, stripped of the subdomain.
        /// </summary>
        /// <example>
        /// <c>example.com</c>
        /// </example>
        public const string RegisteredDomain = "url.registered_domain";
        
        /// <summary>
        /// Scheme of the url.
        /// </summary>
        /// <example>
        /// <c>https</c>
        /// </example>
        public const string Scheme = "url.scheme";
        
        /// <summary>
        /// The subdomain of the domain.
        /// </summary>
        /// <example>
        /// <c>east</c>
        /// </example>
        public const string Subdomain = "url.subdomain";
        
        /// <summary>
        /// The effective top level domain (com, org, net, co.uk).
        /// </summary>
        /// <example>
        /// <c>co.uk</c>
        /// </example>
        public const string TopLevelDomain = "url.top_level_domain";
        
        /// <summary>
        /// Username of the request.
        /// </summary>
        public const string Username = "url.username";
        
        /// <summary>
        /// Full unparsed URL.
        /// </summary>
        /// <example>
        /// <c>https://www.elastic.co:443/search?q=elasticsearch#top</c>
        /// </example>
        public const string FullText = "url.full.text";
        
        /// <summary>
        /// Unmodified original url as seen in the event source.
        /// </summary>
        /// <example>
        /// <c>https://www.elastic.co:443/search?q=elasticsearch#top or /search?q=elasticsearch</c>
        /// </example>
        public const string OriginalText = "url.original.text";
        
    }
}

