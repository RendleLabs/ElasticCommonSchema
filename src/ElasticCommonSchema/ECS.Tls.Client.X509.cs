namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Tls
    {
        public static partial class Client
        {
            public static partial class X509
            {
                /// <summary>
                /// List of subject alternative names (SAN).
                /// </summary>
                /// <example>
                /// <c>*.elastic.co</c>
                /// </example>
                public const string AlternativeNames = "tls.client.x509.alternative_names";
                
                /// <summary>
                /// Time at which the certificate is no longer considered valid.
                /// </summary>
                /// <example>
                /// <c>2020-07-16T03:15:39Z</c>
                /// </example>
                public const string NotAfter = "tls.client.x509.not_after";
                
                /// <summary>
                /// Time at which the certificate is first considered valid.
                /// </summary>
                /// <example>
                /// <c>2019-08-16T01:40:25Z</c>
                /// </example>
                public const string NotBefore = "tls.client.x509.not_before";
                
                /// <summary>
                /// Algorithm used to generate the public key.
                /// </summary>
                /// <example>
                /// <c>RSA</c>
                /// </example>
                public const string PublicKeyAlgorithm = "tls.client.x509.public_key_algorithm";
                
                /// <summary>
                /// The curve used by the elliptic curve public key algorithm. This is algorithm specific.
                /// </summary>
                /// <example>
                /// <c>nistp521</c>
                /// </example>
                public const string PublicKeyCurve = "tls.client.x509.public_key_curve";
                
                /// <summary>
                /// Exponent used to derive the public key. This is algorithm specific.
                /// </summary>
                /// <example>
                /// <c>65537</c>
                /// </example>
                public const string PublicKeyExponent = "tls.client.x509.public_key_exponent";
                
                /// <summary>
                /// The size of the public key space in bits.
                /// </summary>
                /// <example>
                /// <c>2048</c>
                /// </example>
                public const string PublicKeySize = "tls.client.x509.public_key_size";
                
                /// <summary>
                /// Unique serial number issued by the certificate authority.
                /// </summary>
                /// <example>
                /// <c>55FBB9C7DEBF09809D12CCAA</c>
                /// </example>
                public const string SerialNumber = "tls.client.x509.serial_number";
                
                /// <summary>
                /// Identifier for certificate signature algorithm.
                /// </summary>
                /// <example>
                /// <c>SHA256-RSA</c>
                /// </example>
                public const string SignatureAlgorithm = "tls.client.x509.signature_algorithm";
                
                /// <summary>
                /// Version of x509 format.
                /// </summary>
                /// <example>
                /// <c>3</c>
                /// </example>
                public const string VersionNumber = "tls.client.x509.version_number";
                
            }
        }
    }
}

