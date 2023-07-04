namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Agent
    {
        /// <summary>
        /// Ephemeral identifier of this agent.
        /// </summary>
        /// <example>
        /// <c>8a4f500f</c>
        /// </example>
        public const string EphemeralId = "agent.ephemeral_id";
        
        /// <summary>
        /// Unique identifier of this agent.
        /// </summary>
        /// <example>
        /// <c>8a4f500d</c>
        /// </example>
        public const string Id = "agent.id";
        
        /// <summary>
        /// Custom name of the agent.
        /// </summary>
        /// <example>
        /// <c>foo</c>
        /// </example>
        public const string Name = "agent.name";
        
        /// <summary>
        /// Type of the agent.
        /// </summary>
        /// <example>
        /// <c>filebeat</c>
        /// </example>
        public const string Type = "agent.type";
        
        /// <summary>
        /// Version of the agent.
        /// </summary>
        /// <example>
        /// <c>6.0.0-rc2</c>
        /// </example>
        public const string Version = "agent.version";
        
    }
}

