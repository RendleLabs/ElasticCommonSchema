namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Error
    {
        /// <summary>
        /// Error code describing the error.
        /// </summary>
        public const string Code = "error.code";
        
        /// <summary>
        /// Unique identifier for the error.
        /// </summary>
        public const string Id = "error.id";
        
        /// <summary>
        /// Error message.
        /// </summary>
        public const string Message = "error.message";
        
        /// <summary>
        /// The stack trace of this error in plain text.
        /// </summary>
        public const string StackTrace = "error.stack_trace";
        
        /// <summary>
        /// The type of the error, for example the class name of the exception.
        /// </summary>
        /// <example>
        /// <c>java.lang.NullPointerException</c>
        /// </example>
        public const string Type = "error.type";
        
        /// <summary>
        /// The stack trace of this error in plain text.
        /// </summary>
        public const string StackTraceText = "error.stack_trace.text";
        
    }
}

