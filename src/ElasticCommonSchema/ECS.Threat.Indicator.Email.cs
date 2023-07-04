namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Threat
    {
        public static partial class Indicator
        {
            public static partial class Email
            {
                /// <summary>
                /// Indicator email address
                /// </summary>
                /// <example>
                /// <c>phish@example.com</c>
                /// </example>
                public const string Address = "threat.indicator.email.address";
                
            }
        }
    }
}

