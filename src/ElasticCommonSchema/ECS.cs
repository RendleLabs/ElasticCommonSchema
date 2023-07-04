namespace ElasticCommonSchema;

public static partial class ECS
{
    /// <summary>
    /// Date/time when the event originated.
    /// </summary>
    /// <example>
    /// <c>2016-05-23T08:05:34.853Z</c>
    /// </example>
    public const string Timestamp = "@timestamp";
    
    /// <summary>
    /// Custom key/value pairs.
    /// </summary>
    /// <example>
    /// <c>{"application": "foo-bar", "env": "production"}</c>
    /// </example>
    public const string Labels = "labels";
    
    /// <summary>
    /// Log message optimized for viewing in a log viewer.
    /// </summary>
    /// <example>
    /// <c>Hello World</c>
    /// </example>
    public const string Message = "message";
    
    /// <summary>
    /// List of keywords used to tag each event.
    /// </summary>
    /// <example>
    /// <c>["production", "env2"]</c>
    /// </example>
    public const string Tags = "tags";
    
}

