namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Faas
    {
        /// <summary>
        /// Boolean value indicating a cold start of a function.
        /// </summary>
        public const string Coldstart = "faas.coldstart";
        
        /// <summary>
        /// The execution ID of the current function execution.
        /// </summary>
        /// <example>
        /// <c>af9d5aa4-a685-4c5f-a22b-444f80b3cc28</c>
        /// </example>
        public const string Execution = "faas.execution";
        
        /// <summary>
        /// The unique identifier of a serverless function.
        /// </summary>
        /// <example>
        /// <c>arn:aws:lambda:us-west-2:123456789012:function:my-function</c>
        /// </example>
        public const string Id = "faas.id";
        
        /// <summary>
        /// The name of a serverless function.
        /// </summary>
        /// <example>
        /// <c>my-function</c>
        /// </example>
        public const string Name = "faas.name";
        
        /// <summary>
        /// Details about the function trigger.
        /// </summary>
        public const string Trigger = "faas.trigger";
        
        /// <summary>
        /// The version of a serverless function.
        /// </summary>
        /// <example>
        /// <c>123</c>
        /// </example>
        public const string Version = "faas.version";
        
        /// <summary>
        /// The ID of the trigger request , message, event, etc.
        /// </summary>
        /// <example>
        /// <c>123456789</c>
        /// </example>
        public const string TriggerRequestId = "faas.trigger.request_id";
        
        /// <summary>
        /// The trigger for the function execution.
        /// </summary>
        /// <example>
        /// <c>http</c>
        /// </example>
        public const string TriggerType = "faas.trigger.type";
        
    }
}

