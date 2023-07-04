namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Tls
    {
        /// <summary>
        /// String indicating the cipher used during the current connection.
        /// </summary>
        /// <example>
        /// <c>TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256</c>
        /// </example>
        public const string Cipher = "tls.cipher";
        
        /// <summary>
        /// String indicating the curve used for the given cipher, when applicable.
        /// </summary>
        /// <example>
        /// <c>secp256r1</c>
        /// </example>
        public const string Curve = "tls.curve";
        
        /// <summary>
        /// Boolean flag indicating if the TLS negotiation was successful and transitioned to an encrypted tunnel.
        /// </summary>
        public const string Established = "tls.established";
        
        /// <summary>
        /// String indicating the protocol being tunneled.
        /// </summary>
        /// <example>
        /// <c>http/1.1</c>
        /// </example>
        public const string NextProtocol = "tls.next_protocol";
        
        /// <summary>
        /// Boolean flag indicating if this TLS connection was resumed from an existing TLS negotiation.
        /// </summary>
        public const string Resumed = "tls.resumed";
        
        /// <summary>
        /// Numeric part of the version parsed from the original string.
        /// </summary>
        /// <example>
        /// <c>1.2</c>
        /// </example>
        public const string Version = "tls.version";
        
        /// <summary>
        /// Normalized lowercase protocol name parsed from original string.
        /// </summary>
        /// <example>
        /// <c>tls</c>
        /// </example>
        public const string VersionProtocol = "tls.version_protocol";
        
    }
}

