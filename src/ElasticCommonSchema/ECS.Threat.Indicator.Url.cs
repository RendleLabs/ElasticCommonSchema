namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Threat
    {
        public static partial class Indicator
        {
            public static partial class Url
            {
                /// <summary>
                /// Domain of the url.
                /// </summary>
                /// <example>
                /// <c>www.elastic.co</c>
                /// </example>
                public const string Domain = "threat.indicator.url.domain";
                
                /// <summary>
                /// File extension from the request url, excluding the leading dot.
                /// </summary>
                /// <example>
                /// <c>png</c>
                /// </example>
                public const string Extension = "threat.indicator.url.extension";
                
                /// <summary>
                /// Portion of the url after the `#`.
                /// </summary>
                public const string Fragment = "threat.indicator.url.fragment";
                
                /// <summary>
                /// Full unparsed URL.
                /// </summary>
                /// <example>
                /// <c>https://www.elastic.co:443/search?q=elasticsearch#top</c>
                /// </example>
                public const string Full = "threat.indicator.url.full";
                
                /// <summary>
                /// Unmodified original url as seen in the event source.
                /// </summary>
                /// <example>
                /// <c>https://www.elastic.co:443/search?q=elasticsearch#top or /search?q=elasticsearch</c>
                /// </example>
                public const string Original = "threat.indicator.url.original";
                
                /// <summary>
                /// Password of the request.
                /// </summary>
                public const string Password = "threat.indicator.url.password";
                
                /// <summary>
                /// Path of the request, such as "/search".
                /// </summary>
                public const string Path = "threat.indicator.url.path";
                
                /// <summary>
                /// Port of the request, such as 443.
                /// </summary>
                /// <example>
                /// <c>443</c>
                /// </example>
                public const string Port = "threat.indicator.url.port";
                
                /// <summary>
                /// Query string of the request.
                /// </summary>
                public const string Query = "threat.indicator.url.query";
                
                /// <summary>
                /// The highest registered url domain, stripped of the subdomain.
                /// </summary>
                /// <example>
                /// <c>example.com</c>
                /// </example>
                public const string RegisteredDomain = "threat.indicator.url.registered_domain";
                
                /// <summary>
                /// Scheme of the url.
                /// </summary>
                /// <example>
                /// <c>https</c>
                /// </example>
                public const string Scheme = "threat.indicator.url.scheme";
                
                /// <summary>
                /// The subdomain of the domain.
                /// </summary>
                /// <example>
                /// <c>east</c>
                /// </example>
                public const string Subdomain = "threat.indicator.url.subdomain";
                
                /// <summary>
                /// The effective top level domain (com, org, net, co.uk).
                /// </summary>
                /// <example>
                /// <c>co.uk</c>
                /// </example>
                public const string TopLevelDomain = "threat.indicator.url.top_level_domain";
                
                /// <summary>
                /// Username of the request.
                /// </summary>
                public const string Username = "threat.indicator.url.username";
                
                /// <summary>
                /// Full unparsed URL.
                /// </summary>
                /// <example>
                /// <c>https://www.elastic.co:443/search?q=elasticsearch#top</c>
                /// </example>
                public const string FullText = "threat.indicator.url.full.text";
                
                /// <summary>
                /// Unmodified original url as seen in the event source.
                /// </summary>
                /// <example>
                /// <c>https://www.elastic.co:443/search?q=elasticsearch#top or /search?q=elasticsearch</c>
                /// </example>
                public const string OriginalText = "threat.indicator.url.original.text";
                
            }
        }
    }
}

