namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Log
    {
        /// <summary>
        /// Log level of the log event.
        /// </summary>
        /// <example>
        /// <c>error</c>
        /// </example>
        public const string Level = "log.level";
        
        /// <summary>
        /// Name of the logger.
        /// </summary>
        /// <example>
        /// <c>org.elasticsearch.bootstrap.Bootstrap</c>
        /// </example>
        public const string Logger = "log.logger";
        
        /// <summary>
        /// Syslog metadata
        /// </summary>
        public const string Syslog = "log.syslog";
        
        /// <summary>
        /// The device or application that originated the Syslog message.
        /// </summary>
        /// <example>
        /// <c>sshd</c>
        /// </example>
        public const string SyslogAppname = "log.syslog.appname";
        
        /// <summary>
        /// The host that originated the Syslog message.
        /// </summary>
        /// <example>
        /// <c>example-host</c>
        /// </example>
        public const string SyslogHostname = "log.syslog.hostname";
        
        /// <summary>
        /// An identifier for the type of Syslog message.
        /// </summary>
        /// <example>
        /// <c>ID47</c>
        /// </example>
        public const string SyslogMsgid = "log.syslog.msgid";
        
        /// <summary>
        /// Syslog priority of the event.
        /// </summary>
        /// <example>
        /// <c>135</c>
        /// </example>
        public const string SyslogPriority = "log.syslog.priority";
        
        /// <summary>
        /// The process name or ID that originated the Syslog message.
        /// </summary>
        /// <example>
        /// <c>12345</c>
        /// </example>
        public const string SyslogProcid = "log.syslog.procid";
        
        /// <summary>
        /// Structured data expressed in RFC 5424 messages.
        /// </summary>
        public const string SyslogStructuredData = "log.syslog.structured_data";
        
        /// <summary>
        /// Syslog protocol version.
        /// </summary>
        /// <example>
        /// <c>1</c>
        /// </example>
        public const string SyslogVersion = "log.syslog.version";
        
    }
}

