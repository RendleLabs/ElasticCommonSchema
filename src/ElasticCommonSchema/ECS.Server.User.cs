namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class Server
    {
        public static partial class User
        {
            /// <summary>
            /// Name of the directory the user is a member of.
            /// </summary>
            public const string Domain = "server.user.domain";
            
            /// <summary>
            /// User email address.
            /// </summary>
            public const string Email = "server.user.email";
            
            /// <summary>
            /// User's full name, if available.
            /// </summary>
            /// <example>
            /// <c>Albert Einstein</c>
            /// </example>
            public const string FullName = "server.user.full_name";
            
            /// <summary>
            /// Unique user hash to correlate information for a user in anonymized form.
            /// </summary>
            public const string Hash = "server.user.hash";
            
            /// <summary>
            /// Unique identifier of the user.
            /// </summary>
            /// <example>
            /// <c>S-1-5-21-202424912787-2692429404-2351956786-1000</c>
            /// </example>
            public const string Id = "server.user.id";
            
            /// <summary>
            /// Short name or login of the user.
            /// </summary>
            /// <example>
            /// <c>a.einstein</c>
            /// </example>
            public const string Name = "server.user.name";
            
            /// <summary>
            /// Array of user roles at the time of the event.
            /// </summary>
            /// <example>
            /// <c>["kibana_admin", "reporting_user"]</c>
            /// </example>
            public const string Roles = "server.user.roles";
            
            /// <summary>
            /// User's full name, if available.
            /// </summary>
            /// <example>
            /// <c>Albert Einstein</c>
            /// </example>
            public const string FullNameText = "server.user.full_name.text";
            
            /// <summary>
            /// Short name or login of the user.
            /// </summary>
            /// <example>
            /// <c>a.einstein</c>
            /// </example>
            public const string NameText = "server.user.name.text";
            
        }
    }
}

