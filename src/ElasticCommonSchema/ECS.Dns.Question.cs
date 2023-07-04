namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Dns
    {
        public static partial class Question
        {
            /// <summary>
            /// The class of records being queried.
            /// </summary>
            /// <example>
            /// <c>IN</c>
            /// </example>
            public const string Class = "dns.question.class";
            
            /// <summary>
            /// The name being queried.
            /// </summary>
            /// <example>
            /// <c>www.example.com</c>
            /// </example>
            public const string Name = "dns.question.name";
            
            /// <summary>
            /// The highest registered domain, stripped of the subdomain.
            /// </summary>
            /// <example>
            /// <c>example.com</c>
            /// </example>
            public const string RegisteredDomain = "dns.question.registered_domain";
            
            /// <summary>
            /// The subdomain of the domain.
            /// </summary>
            /// <example>
            /// <c>www</c>
            /// </example>
            public const string Subdomain = "dns.question.subdomain";
            
            /// <summary>
            /// The effective top level domain (com, org, net, co.uk).
            /// </summary>
            /// <example>
            /// <c>co.uk</c>
            /// </example>
            public const string TopLevelDomain = "dns.question.top_level_domain";
            
            /// <summary>
            /// The type of record being queried.
            /// </summary>
            /// <example>
            /// <c>AAAA</c>
            /// </example>
            public const string Type = "dns.question.type";
            
        }
    }
}

