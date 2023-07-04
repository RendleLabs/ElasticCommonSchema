namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Email
    {
        /// <summary>
        /// List of objects describing the attachments.
        /// </summary>
        public const string Attachments = "email.attachments";
        
        /// <summary>
        /// MIME type of the email message.
        /// </summary>
        /// <example>
        /// <c>text/plain</c>
        /// </example>
        public const string ContentType = "email.content_type";
        
        /// <summary>
        /// Date and time when message was delivered.
        /// </summary>
        /// <example>
        /// <c>2020-11-10T22:12:34.8196921Z</c>
        /// </example>
        public const string DeliveryTimestamp = "email.delivery_timestamp";
        
        /// <summary>
        /// Direction of the message.
        /// </summary>
        /// <example>
        /// <c>inbound</c>
        /// </example>
        public const string Direction = "email.direction";
        
        /// <summary>
        /// Unique identifier given by the source.
        /// </summary>
        /// <example>
        /// <c>c26dbea0-80d5-463b-b93c-4e8b708219ce</c>
        /// </example>
        public const string LocalId = "email.local_id";
        
        /// <summary>
        /// Value from the Message-ID header.
        /// </summary>
        /// <example>
        /// <c>81ce15$8r2j59@mail01.example.com</c>
        /// </example>
        public const string MessageId = "email.message_id";
        
        /// <summary>
        /// Date and time the email was composed.
        /// </summary>
        /// <example>
        /// <c>2020-11-10T22:12:34.8196921Z</c>
        /// </example>
        public const string OriginationTimestamp = "email.origination_timestamp";
        
        /// <summary>
        /// The subject of the email message.
        /// </summary>
        /// <example>
        /// <c>Please see this important message.</c>
        /// </example>
        public const string Subject = "email.subject";
        
        /// <summary>
        /// Application that drafted email.
        /// </summary>
        /// <example>
        /// <c>Spambot v2.5</c>
        /// </example>
        public const string XMailer = "email.x_mailer";
        
        /// <summary>
        /// The subject of the email message.
        /// </summary>
        /// <example>
        /// <c>Please see this important message.</c>
        /// </example>
        public const string SubjectText = "email.subject.text";
        
    }
}

