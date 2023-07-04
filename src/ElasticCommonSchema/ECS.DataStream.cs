namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class DataStream
    {
        /// <summary>
        /// The field can contain anything that makes sense to signify the source of the data.
        /// </summary>
        /// <example>
        /// <c>nginx.access</c>
        /// </example>
        public const string Dataset = "data_stream.dataset";
        
        /// <summary>
        /// A user defined namespace. Namespaces are useful to allow grouping of data.
        /// </summary>
        /// <example>
        /// <c>production</c>
        /// </example>
        public const string Namespace = "data_stream.namespace";
        
        /// <summary>
        /// An overarching type for the data stream.
        /// </summary>
        /// <example>
        /// <c>logs</c>
        /// </example>
        public const string Type = "data_stream.type";
        
    }
}

