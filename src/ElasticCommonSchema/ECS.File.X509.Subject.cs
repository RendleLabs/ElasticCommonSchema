namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class File
    {
        public static partial class X509
        {
            public static partial class Subject
            {
                /// <summary>
                /// List of common names (CN) of subject.
                /// </summary>
                /// <example>
                /// <c>shared.global.example.net</c>
                /// </example>
                public const string CommonName = "file.x509.subject.common_name";
                
                /// <summary>
                /// List of country \(C) code
                /// </summary>
                /// <example>
                /// <c>US</c>
                /// </example>
                public const string Country = "file.x509.subject.country";
                
                /// <summary>
                /// Distinguished name (DN) of the certificate subject entity.
                /// </summary>
                /// <example>
                /// <c>C=US, ST=California, L=San Francisco, O=Example, Inc., CN=shared.global.example.net</c>
                /// </example>
                public const string DistinguishedName = "file.x509.subject.distinguished_name";
                
                /// <summary>
                /// List of locality names (L)
                /// </summary>
                /// <example>
                /// <c>San Francisco</c>
                /// </example>
                public const string Locality = "file.x509.subject.locality";
                
                /// <summary>
                /// List of organizations (O) of subject.
                /// </summary>
                /// <example>
                /// <c>Example, Inc.</c>
                /// </example>
                public const string Organization = "file.x509.subject.organization";
                
                /// <summary>
                /// List of organizational units (OU) of subject.
                /// </summary>
                public const string OrganizationalUnit = "file.x509.subject.organizational_unit";
                
                /// <summary>
                /// List of state or province names (ST, S, or P)
                /// </summary>
                /// <example>
                /// <c>California</c>
                /// </example>
                public const string StateOrProvince = "file.x509.subject.state_or_province";
                
            }
        }
    }
}

