namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Device
    {
        /// <summary>
        /// The unique identifier of a device.
        /// </summary>
        /// <example>
        /// <c>00000000-54b3-e7c7-0000-000046bffd97</c>
        /// </example>
        public const string Id = "device.id";
        
        /// <summary>
        /// The vendor name of the device manufacturer.
        /// </summary>
        /// <example>
        /// <c>Samsung</c>
        /// </example>
        public const string Manufacturer = "device.manufacturer";
        
    }
}

