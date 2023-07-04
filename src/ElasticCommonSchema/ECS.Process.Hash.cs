﻿namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Process
    {
        public static partial class Hash
        {
            /// <summary>
            /// MD5 hash.
            /// </summary>
            public const string Md5 = "process.hash.md5";
            
            /// <summary>
            /// SHA1 hash.
            /// </summary>
            public const string Sha1 = "process.hash.sha1";
            
            /// <summary>
            /// SHA256 hash.
            /// </summary>
            public const string Sha256 = "process.hash.sha256";
            
            /// <summary>
            /// SHA384 hash.
            /// </summary>
            public const string Sha384 = "process.hash.sha384";
            
            /// <summary>
            /// SHA512 hash.
            /// </summary>
            public const string Sha512 = "process.hash.sha512";
            
            /// <summary>
            /// SSDEEP hash.
            /// </summary>
            public const string Ssdeep = "process.hash.ssdeep";
            
            /// <summary>
            /// TLSH hash.
            /// </summary>
            public const string Tlsh = "process.hash.tlsh";
            
        }
    }
}

