namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Transaction
    {
        /// <summary>
        /// Unique identifier of the transaction within the scope of its trace.
        /// </summary>
        /// <example>
        /// <c>00f067aa0ba902b7</c>
        /// </example>
        public const string Id = "transaction.id";
        
    }
}

