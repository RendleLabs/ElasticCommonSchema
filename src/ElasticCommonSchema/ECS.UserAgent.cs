namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class UserAgent
    {
        /// <summary>
        /// Name of the user agent.
        /// </summary>
        /// <example>
        /// <c>Safari</c>
        /// </example>
        public const string Name = "user_agent.name";
        
        /// <summary>
        /// Unparsed user_agent string.
        /// </summary>
        /// <example>
        /// <c>Mozilla/5.0 (iPhone; CPU iPhone OS 12_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.0 Mobile/15E148 Safari/604.1</c>
        /// </example>
        public const string Original = "user_agent.original";
        
        /// <summary>
        /// Version of the user agent.
        /// </summary>
        /// <example>
        /// <c>12.0</c>
        /// </example>
        public const string Version = "user_agent.version";
        
        /// <summary>
        /// Unparsed user_agent string.
        /// </summary>
        /// <example>
        /// <c>Mozilla/5.0 (iPhone; CPU iPhone OS 12_1 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/12.0 Mobile/15E148 Safari/604.1</c>
        /// </example>
        public const string OriginalText = "user_agent.original.text";
        
    }
}

