namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Tls
    {
        public static partial class Client
        {
            /// <summary>
            /// PEM-encoded stand-alone certificate offered by the client.
            /// </summary>
            /// <example>
            /// <c>MII...</c>
            /// </example>
            public const string Certificate = "tls.client.certificate";
            
            /// <summary>
            /// Array of PEM-encoded certificates that make up the certificate chain offered by the client.
            /// </summary>
            /// <example>
            /// <c>["MII...", "MII..."]</c>
            /// </example>
            public const string CertificateChain = "tls.client.certificate_chain";
            
            /// <summary>
            /// Distinguished name of subject of the issuer of the x.509 certificate presented by the client.
            /// </summary>
            /// <example>
            /// <c>CN=Example Root CA, OU=Infrastructure Team, DC=example, DC=com</c>
            /// </example>
            public const string Issuer = "tls.client.issuer";
            
            /// <summary>
            /// A hash that identifies clients based on how they perform an SSL/TLS handshake.
            /// </summary>
            /// <example>
            /// <c>d4e5b18d6b55c71272893221c96ba240</c>
            /// </example>
            public const string Ja3 = "tls.client.ja3";
            
            /// <summary>
            /// Date/Time indicating when client certificate is no longer considered valid.
            /// </summary>
            /// <example>
            /// <c>2021-01-01T00:00:00.000Z</c>
            /// </example>
            public const string NotAfter = "tls.client.not_after";
            
            /// <summary>
            /// Date/Time indicating when client certificate is first considered valid.
            /// </summary>
            /// <example>
            /// <c>1970-01-01T00:00:00.000Z</c>
            /// </example>
            public const string NotBefore = "tls.client.not_before";
            
            /// <summary>
            /// Hostname the client is trying to connect to. Also called the SNI.
            /// </summary>
            /// <example>
            /// <c>www.elastic.co</c>
            /// </example>
            public const string ServerName = "tls.client.server_name";
            
            /// <summary>
            /// Distinguished name of subject of the x.509 certificate presented by the client.
            /// </summary>
            /// <example>
            /// <c>CN=myclient, OU=Documentation Team, DC=example, DC=com</c>
            /// </example>
            public const string Subject = "tls.client.subject";
            
            /// <summary>
            /// Array of ciphers offered by the client during the client hello.
            /// </summary>
            /// <example>
            /// <c>["TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384", "TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384", "..."]</c>
            /// </example>
            public const string SupportedCiphers = "tls.client.supported_ciphers";
            
        }
    }
}

