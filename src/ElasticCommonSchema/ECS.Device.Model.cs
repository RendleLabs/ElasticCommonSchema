namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Device
    {
        public static partial class Model
        {
            /// <summary>
            /// The machine readable identifier of the device model.
            /// </summary>
            /// <example>
            /// <c>SM-G920F</c>
            /// </example>
            public const string Identifier = "device.model.identifier";
            
            /// <summary>
            /// The human readable marketing name of the device model.
            /// </summary>
            /// <example>
            /// <c>Samsung Galaxy S6</c>
            /// </example>
            public const string Name = "device.model.name";
            
        }
    }
}

