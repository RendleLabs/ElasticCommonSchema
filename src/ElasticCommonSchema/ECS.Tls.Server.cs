namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Tls
    {
        public static partial class Server
        {
            /// <summary>
            /// PEM-encoded stand-alone certificate offered by the server.
            /// </summary>
            /// <example>
            /// <c>MII...</c>
            /// </example>
            public const string Certificate = "tls.server.certificate";
            
            /// <summary>
            /// Array of PEM-encoded certificates that make up the certificate chain offered by the server.
            /// </summary>
            /// <example>
            /// <c>["MII...", "MII..."]</c>
            /// </example>
            public const string CertificateChain = "tls.server.certificate_chain";
            
            /// <summary>
            /// Subject of the issuer of the x.509 certificate presented by the server.
            /// </summary>
            /// <example>
            /// <c>CN=Example Root CA, OU=Infrastructure Team, DC=example, DC=com</c>
            /// </example>
            public const string Issuer = "tls.server.issuer";
            
            /// <summary>
            /// A hash that identifies servers based on how they perform an SSL/TLS handshake.
            /// </summary>
            /// <example>
            /// <c>394441ab65754e2207b1e1b457b3641d</c>
            /// </example>
            public const string Ja3s = "tls.server.ja3s";
            
            /// <summary>
            /// Timestamp indicating when server certificate is no longer considered valid.
            /// </summary>
            /// <example>
            /// <c>2021-01-01T00:00:00.000Z</c>
            /// </example>
            public const string NotAfter = "tls.server.not_after";
            
            /// <summary>
            /// Timestamp indicating when server certificate is first considered valid.
            /// </summary>
            /// <example>
            /// <c>1970-01-01T00:00:00.000Z</c>
            /// </example>
            public const string NotBefore = "tls.server.not_before";
            
            /// <summary>
            /// Subject of the x.509 certificate presented by the server.
            /// </summary>
            /// <example>
            /// <c>CN=www.example.com, OU=Infrastructure Team, DC=example, DC=com</c>
            /// </example>
            public const string Subject = "tls.server.subject";
            
        }
    }
}

