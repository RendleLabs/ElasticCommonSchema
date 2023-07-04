namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Container
    {
        /// <summary>
        /// Unique container id.
        /// </summary>
        public const string Id = "container.id";
        
        /// <summary>
        /// Image labels.
        /// </summary>
        public const string Labels = "container.labels";
        
        /// <summary>
        /// Container name.
        /// </summary>
        public const string Name = "container.name";
        
        /// <summary>
        /// Runtime managing this container.
        /// </summary>
        /// <example>
        /// <c>docker</c>
        /// </example>
        public const string Runtime = "container.runtime";
        
    }
}

