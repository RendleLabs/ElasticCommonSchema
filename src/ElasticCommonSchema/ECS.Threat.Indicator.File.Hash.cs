namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Threat
    {
        public static partial class Indicator
        {
            public static partial class File
            {
                public static partial class Hash
                {
                    /// <summary>
                    /// MD5 hash.
                    /// </summary>
                    public const string Md5 = "threat.indicator.file.hash.md5";
                    
                    /// <summary>
                    /// SHA1 hash.
                    /// </summary>
                    public const string Sha1 = "threat.indicator.file.hash.sha1";
                    
                    /// <summary>
                    /// SHA256 hash.
                    /// </summary>
                    public const string Sha256 = "threat.indicator.file.hash.sha256";
                    
                    /// <summary>
                    /// SHA384 hash.
                    /// </summary>
                    public const string Sha384 = "threat.indicator.file.hash.sha384";
                    
                    /// <summary>
                    /// SHA512 hash.
                    /// </summary>
                    public const string Sha512 = "threat.indicator.file.hash.sha512";
                    
                    /// <summary>
                    /// SSDEEP hash.
                    /// </summary>
                    public const string Ssdeep = "threat.indicator.file.hash.ssdeep";
                    
                    /// <summary>
                    /// TLSH hash.
                    /// </summary>
                    public const string Tlsh = "threat.indicator.file.hash.tlsh";
                    
                }
            }
        }
    }
}

