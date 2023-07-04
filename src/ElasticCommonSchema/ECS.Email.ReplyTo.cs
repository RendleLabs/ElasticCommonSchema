namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Email
    {
        public static partial class ReplyTo
        {
            /// <summary>
            /// Address replies should be delivered to.
            /// </summary>
            /// <example>
            /// <c>reply.here@example.com</c>
            /// </example>
            public const string Address = "email.reply_to.address";
            
        }
    }
}

