namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Tls
    {
        public static partial class Server
        {
            public static partial class X509
            {
                public static partial class Issuer
                {
                    /// <summary>
                    /// List of common name (CN) of issuing certificate authority.
                    /// </summary>
                    /// <example>
                    /// <c>Example SHA2 High Assurance Server CA</c>
                    /// </example>
                    public const string CommonName = "tls.server.x509.issuer.common_name";
                    
                    /// <summary>
                    /// List of country \(C) codes
                    /// </summary>
                    /// <example>
                    /// <c>US</c>
                    /// </example>
                    public const string Country = "tls.server.x509.issuer.country";
                    
                    /// <summary>
                    /// Distinguished name (DN) of issuing certificate authority.
                    /// </summary>
                    /// <example>
                    /// <c>C=US, O=Example Inc, OU=www.example.com, CN=Example SHA2 High Assurance Server CA</c>
                    /// </example>
                    public const string DistinguishedName = "tls.server.x509.issuer.distinguished_name";
                    
                    /// <summary>
                    /// List of locality names (L)
                    /// </summary>
                    /// <example>
                    /// <c>Mountain View</c>
                    /// </example>
                    public const string Locality = "tls.server.x509.issuer.locality";
                    
                    /// <summary>
                    /// List of organizations (O) of issuing certificate authority.
                    /// </summary>
                    /// <example>
                    /// <c>Example Inc</c>
                    /// </example>
                    public const string Organization = "tls.server.x509.issuer.organization";
                    
                    /// <summary>
                    /// List of organizational units (OU) of issuing certificate authority.
                    /// </summary>
                    /// <example>
                    /// <c>www.example.com</c>
                    /// </example>
                    public const string OrganizationalUnit = "tls.server.x509.issuer.organizational_unit";
                    
                    /// <summary>
                    /// List of state or province names (ST, S, or P)
                    /// </summary>
                    /// <example>
                    /// <c>California</c>
                    /// </example>
                    public const string StateOrProvince = "tls.server.x509.issuer.state_or_province";
                    
                }
            }
        }
    }
}

