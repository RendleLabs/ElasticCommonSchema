namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Threat
    {
        public static partial class Indicator
        {
            public static partial class File
            {
                public static partial class CodeSignature
                {
                    /// <summary>
                    /// Hashing algorithm used to sign the process.
                    /// </summary>
                    /// <example>
                    /// <c>sha256</c>
                    /// </example>
                    public const string DigestAlgorithm = "threat.indicator.file.code_signature.digest_algorithm";
                    
                    /// <summary>
                    /// Boolean to capture if a signature is present.
                    /// </summary>
                    /// <example>
                    /// <c>true</c>
                    /// </example>
                    public const string Exists = "threat.indicator.file.code_signature.exists";
                    
                    /// <summary>
                    /// The identifier used to sign the process.
                    /// </summary>
                    /// <example>
                    /// <c>com.apple.xpc.proxy</c>
                    /// </example>
                    public const string SigningId = "threat.indicator.file.code_signature.signing_id";
                    
                    /// <summary>
                    /// Additional information about the certificate status.
                    /// </summary>
                    /// <example>
                    /// <c>ERROR_UNTRUSTED_ROOT</c>
                    /// </example>
                    public const string Status = "threat.indicator.file.code_signature.status";
                    
                    /// <summary>
                    /// Subject name of the code signer
                    /// </summary>
                    /// <example>
                    /// <c>Microsoft Corporation</c>
                    /// </example>
                    public const string SubjectName = "threat.indicator.file.code_signature.subject_name";
                    
                    /// <summary>
                    /// The team identifier used to sign the process.
                    /// </summary>
                    /// <example>
                    /// <c>EQHXZ8M8AV</c>
                    /// </example>
                    public const string TeamId = "threat.indicator.file.code_signature.team_id";
                    
                    /// <summary>
                    /// When the signature was generated and signed.
                    /// </summary>
                    /// <example>
                    /// <c>2021-01-01T12:10:30Z</c>
                    /// </example>
                    public const string Timestamp = "threat.indicator.file.code_signature.timestamp";
                    
                    /// <summary>
                    /// Stores the trust status of the certificate chain.
                    /// </summary>
                    /// <example>
                    /// <c>true</c>
                    /// </example>
                    public const string Trusted = "threat.indicator.file.code_signature.trusted";
                    
                    /// <summary>
                    /// Boolean to capture if the digital signature is verified against the binary content.
                    /// </summary>
                    /// <example>
                    /// <c>true</c>
                    /// </example>
                    public const string Valid = "threat.indicator.file.code_signature.valid";
                    
                }
            }
        }
    }
}

