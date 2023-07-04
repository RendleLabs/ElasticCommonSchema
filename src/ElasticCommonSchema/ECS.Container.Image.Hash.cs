namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Container
    {
        public static partial class Image
        {
            public static partial class Hash
            {
                /// <summary>
                /// An array of digests of the image the container was built on.
                /// </summary>
                /// <example>
                /// <c>[sha256:f8fefc80e3273dc756f288a63945820d6476ad64883892c771b5e2ece6bf1b26]</c>
                /// </example>
                public const string All = "container.image.hash.all";
                
            }
        }
    }
}

