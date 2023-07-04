namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Tls
    {
        public static partial class Client
        {
            public static partial class Hash
            {
                /// <summary>
                /// Certificate fingerprint using the MD5 digest of DER-encoded version of certificate offered by the client.
                /// </summary>
                /// <example>
                /// <c>0F76C7F2C55BFD7D8E8B8F4BFBF0C9EC</c>
                /// </example>
                public const string Md5 = "tls.client.hash.md5";
                
                /// <summary>
                /// Certificate fingerprint using the SHA1 digest of DER-encoded version of certificate offered by the client.
                /// </summary>
                /// <example>
                /// <c>9E393D93138888D288266C2D915214D1D1CCEB2A</c>
                /// </example>
                public const string Sha1 = "tls.client.hash.sha1";
                
                /// <summary>
                /// Certificate fingerprint using the SHA256 digest of DER-encoded version of certificate offered by the client.
                /// </summary>
                /// <example>
                /// <c>0687F666A054EF17A08E2F2162EAB4CBC0D265E1D7875BE74BF3C712CA92DAF0</c>
                /// </example>
                public const string Sha256 = "tls.client.hash.sha256";
                
            }
        }
    }
}

