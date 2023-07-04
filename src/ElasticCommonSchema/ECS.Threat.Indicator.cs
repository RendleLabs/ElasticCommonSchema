namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Threat
    {
        public static partial class Indicator
        {
            /// <summary>
            /// Indicator confidence rating
            /// </summary>
            /// <example>
            /// <c>Medium</c>
            /// </example>
            public const string Confidence = "threat.indicator.confidence";
            
            /// <summary>
            /// Indicator description
            /// </summary>
            /// <example>
            /// <c>IP x.x.x.x was observed delivering the Angler EK.</c>
            /// </example>
            public const string Description = "threat.indicator.description";
            
            /// <summary>
            /// Date/time indicator was first reported.
            /// </summary>
            /// <example>
            /// <c>2020-11-05T17:25:47.000Z</c>
            /// </example>
            public const string FirstSeen = "threat.indicator.first_seen";
            
            /// <summary>
            /// Indicator IP address
            /// </summary>
            /// <example>
            /// <c>1.2.3.4</c>
            /// </example>
            public const string Ip = "threat.indicator.ip";
            
            /// <summary>
            /// Date/time indicator was last reported.
            /// </summary>
            /// <example>
            /// <c>2020-11-05T17:25:47.000Z</c>
            /// </example>
            public const string LastSeen = "threat.indicator.last_seen";
            
            /// <summary>
            /// Date/time indicator was last updated.
            /// </summary>
            /// <example>
            /// <c>2020-11-05T17:25:47.000Z</c>
            /// </example>
            public const string ModifiedAt = "threat.indicator.modified_at";
            
            /// <summary>
            /// Indicator display name
            /// </summary>
            /// <example>
            /// <c>5.2.75.227</c>
            /// </example>
            public const string Name = "threat.indicator.name";
            
            /// <summary>
            /// Indicator port
            /// </summary>
            /// <example>
            /// <c>443</c>
            /// </example>
            public const string Port = "threat.indicator.port";
            
            /// <summary>
            /// Indicator provider
            /// </summary>
            /// <example>
            /// <c>lrz_urlhaus</c>
            /// </example>
            public const string Provider = "threat.indicator.provider";
            
            /// <summary>
            /// Indicator reference URL
            /// </summary>
            /// <example>
            /// <c>https://system.example.com/indicator/0001234</c>
            /// </example>
            public const string Reference = "threat.indicator.reference";
            
            /// <summary>
            /// Scanner statistics
            /// </summary>
            /// <example>
            /// <c>4</c>
            /// </example>
            public const string ScannerStats = "threat.indicator.scanner_stats";
            
            /// <summary>
            /// Number of times indicator observed
            /// </summary>
            /// <example>
            /// <c>20</c>
            /// </example>
            public const string Sightings = "threat.indicator.sightings";
            
            /// <summary>
            /// Type of indicator
            /// </summary>
            /// <example>
            /// <c>ipv4-addr</c>
            /// </example>
            public const string Type = "threat.indicator.type";
            
        }
    }
}

