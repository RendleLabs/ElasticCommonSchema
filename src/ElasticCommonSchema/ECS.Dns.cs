namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Dns
    {
        /// <summary>
        /// Array of DNS answers.
        /// </summary>
        public const string Answers = "dns.answers";
        
        /// <summary>
        /// Array of DNS header flags.
        /// </summary>
        /// <example>
        /// <c>["RD", "RA"]</c>
        /// </example>
        public const string HeaderFlags = "dns.header_flags";
        
        /// <summary>
        /// The DNS packet identifier assigned by the program that generated the query. The identifier is copied to the response.
        /// </summary>
        /// <example>
        /// <c>62111</c>
        /// </example>
        public const string Id = "dns.id";
        
        /// <summary>
        /// The DNS operation code that specifies the kind of query in the message.
        /// </summary>
        /// <example>
        /// <c>QUERY</c>
        /// </example>
        public const string OpCode = "dns.op_code";
        
        /// <summary>
        /// Array containing all IPs seen in answers.data
        /// </summary>
        /// <example>
        /// <c>["10.10.10.10", "10.10.10.11"]</c>
        /// </example>
        public const string ResolvedIp = "dns.resolved_ip";
        
        /// <summary>
        /// The DNS response code.
        /// </summary>
        /// <example>
        /// <c>NOERROR</c>
        /// </example>
        public const string ResponseCode = "dns.response_code";
        
        /// <summary>
        /// The type of DNS event captured, query or answer.
        /// </summary>
        /// <example>
        /// <c>answer</c>
        /// </example>
        public const string Type = "dns.type";
        
        /// <summary>
        /// The class of DNS data contained in this resource record.
        /// </summary>
        /// <example>
        /// <c>IN</c>
        /// </example>
        public const string AnswersClass = "dns.answers.class";
        
        /// <summary>
        /// The data describing the resource.
        /// </summary>
        /// <example>
        /// <c>10.10.10.10</c>
        /// </example>
        public const string AnswersData = "dns.answers.data";
        
        /// <summary>
        /// The domain name to which this resource record pertains.
        /// </summary>
        /// <example>
        /// <c>www.example.com</c>
        /// </example>
        public const string AnswersName = "dns.answers.name";
        
        /// <summary>
        /// The time interval in seconds that this resource record may be cached before it should be discarded.
        /// </summary>
        /// <example>
        /// <c>180</c>
        /// </example>
        public const string AnswersTtl = "dns.answers.ttl";
        
        /// <summary>
        /// The type of data contained in this resource record.
        /// </summary>
        /// <example>
        /// <c>CNAME</c>
        /// </example>
        public const string AnswersType = "dns.answers.type";
        
    }
}

