namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Event
    {
        /// <summary>
        /// The action captured by the event.
        /// </summary>
        /// <example>
        /// <c>user-password-change</c>
        /// </example>
        public const string Action = "event.action";
        
        /// <summary>
        /// Validation status of the event's agent.id field.
        /// </summary>
        /// <example>
        /// <c>verified</c>
        /// </example>
        public const string AgentIdStatus = "event.agent_id_status";
        
        /// <summary>
        /// Event category. The second categorization field in the hierarchy.
        /// </summary>
        /// <example>
        /// <c>authentication</c>
        /// </example>
        public const string Category = "event.category";
        
        /// <summary>
        /// Identification code for this event.
        /// </summary>
        /// <example>
        /// <c>4648</c>
        /// </example>
        public const string Code = "event.code";
        
        /// <summary>
        /// Time when the event was first read by an agent or by your pipeline.
        /// </summary>
        /// <example>
        /// <c>2016-05-23T08:05:34.857Z</c>
        /// </example>
        public const string Created = "event.created";
        
        /// <summary>
        /// Name of the dataset.
        /// </summary>
        /// <example>
        /// <c>apache.access</c>
        /// </example>
        public const string Dataset = "event.dataset";
        
        /// <summary>
        /// Duration of the event in nanoseconds.
        /// </summary>
        public const string Duration = "event.duration";
        
        /// <summary>
        /// `event.end` contains the date when the event ended or when the activity was last observed.
        /// </summary>
        public const string End = "event.end";
        
        /// <summary>
        /// Hash (perhaps logstash fingerprint) of raw field to be able to demonstrate log integrity.
        /// </summary>
        /// <example>
        /// <c>123456789012345678901234567890ABCD</c>
        /// </example>
        public const string Hash = "event.hash";
        
        /// <summary>
        /// Unique ID to describe the event.
        /// </summary>
        /// <example>
        /// <c>8a4f500d</c>
        /// </example>
        public const string Id = "event.id";
        
        /// <summary>
        /// Timestamp when an event arrived in the central data store.
        /// </summary>
        /// <example>
        /// <c>2016-05-23T08:05:35.101Z</c>
        /// </example>
        public const string Ingested = "event.ingested";
        
        /// <summary>
        /// The kind of the event. The highest categorization field in the hierarchy.
        /// </summary>
        /// <example>
        /// <c>alert</c>
        /// </example>
        public const string Kind = "event.kind";
        
        /// <summary>
        /// Name of the module this data is coming from.
        /// </summary>
        /// <example>
        /// <c>apache</c>
        /// </example>
        public const string Module = "event.module";
        
        /// <summary>
        /// Raw text message of entire event.
        /// </summary>
        /// <example>
        /// <c>Sep 19 08:26:10 host CEF:0&#124;Security&#124; threatmanager&#124;1.0&#124;100&#124; worm successfully stopped&#124;10&#124;src=10.0.0.1 dst=2.1.2.2spt=1232</c>
        /// </example>
        public const string Original = "event.original";
        
        /// <summary>
        /// The outcome of the event. The lowest level categorization field in the hierarchy.
        /// </summary>
        /// <example>
        /// <c>success</c>
        /// </example>
        public const string Outcome = "event.outcome";
        
        /// <summary>
        /// Source of the event.
        /// </summary>
        /// <example>
        /// <c>kernel</c>
        /// </example>
        public const string Provider = "event.provider";
        
        /// <summary>
        /// Reason why this event happened, according to the source
        /// </summary>
        /// <example>
        /// <c>Terminated an unexpected process</c>
        /// </example>
        public const string Reason = "event.reason";
        
        /// <summary>
        /// Event reference URL
        /// </summary>
        /// <example>
        /// <c>https://system.example.com/event/#0001234</c>
        /// </example>
        public const string Reference = "event.reference";
        
        /// <summary>
        /// Risk score or priority of the event (e.g. security solutions). Use your system's original value here.
        /// </summary>
        public const string RiskScore = "event.risk_score";
        
        /// <summary>
        /// Normalized risk score or priority of the event (0-100).
        /// </summary>
        public const string RiskScoreNorm = "event.risk_score_norm";
        
        /// <summary>
        /// Sequence number of the event.
        /// </summary>
        public const string Sequence = "event.sequence";
        
        /// <summary>
        /// Numeric severity of the event.
        /// </summary>
        /// <example>
        /// <c>7</c>
        /// </example>
        public const string Severity = "event.severity";
        
        /// <summary>
        /// `event.start` contains the date when the event started or when the activity was first observed.
        /// </summary>
        public const string Start = "event.start";
        
        /// <summary>
        /// Event time zone.
        /// </summary>
        public const string Timezone = "event.timezone";
        
        /// <summary>
        /// Event type. The third categorization field in the hierarchy.
        /// </summary>
        public const string Type = "event.type";
        
        /// <summary>
        /// Event investigation URL
        /// </summary>
        /// <example>
        /// <c>https://mysystem.example.com/alert/5271dedb-f5b0-4218-87f0-4ac4870a38fe</c>
        /// </example>
        public const string Url = "event.url";
        
    }
}

