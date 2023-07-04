namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Container
    {
        public static partial class Image
        {
            /// <summary>
            /// Name of the image the container was built on.
            /// </summary>
            public const string Name = "container.image.name";
            
            /// <summary>
            /// Container image tags.
            /// </summary>
            public const string Tag = "container.image.tag";
            
        }
    }
}

