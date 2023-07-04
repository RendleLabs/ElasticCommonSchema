namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Threat
    {
        /// <summary>
        /// List of objects containing indicators enriching the event.
        /// </summary>
        public const string Enrichments = "threat.enrichments";
        
        /// <summary>
        /// Threat classification framework.
        /// </summary>
        /// <example>
        /// <c>MITRE ATT&CK</c>
        /// </example>
        public const string Framework = "threat.framework";
        
        /// <summary>
        /// Object containing indicators enriching the event.
        /// </summary>
        public const string EnrichmentsIndicator = "threat.enrichments.indicator";
        
    }
}

