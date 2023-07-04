namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class File
    {
        public static partial class Hash
        {
            /// <summary>
            /// MD5 hash.
            /// </summary>
            public const string Md5 = "file.hash.md5";
            
            /// <summary>
            /// SHA1 hash.
            /// </summary>
            public const string Sha1 = "file.hash.sha1";
            
            /// <summary>
            /// SHA256 hash.
            /// </summary>
            public const string Sha256 = "file.hash.sha256";
            
            /// <summary>
            /// SHA384 hash.
            /// </summary>
            public const string Sha384 = "file.hash.sha384";
            
            /// <summary>
            /// SHA512 hash.
            /// </summary>
            public const string Sha512 = "file.hash.sha512";
            
            /// <summary>
            /// SSDEEP hash.
            /// </summary>
            public const string Ssdeep = "file.hash.ssdeep";
            
            /// <summary>
            /// TLSH hash.
            /// </summary>
            public const string Tlsh = "file.hash.tlsh";
            
        }
    }
}

