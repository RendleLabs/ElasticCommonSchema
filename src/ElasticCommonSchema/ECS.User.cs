﻿namespace ElasticCommonSchema;

public static partial class ECS
{
    public static partial class User
    {
        /// <summary>
        /// Name of the directory the user is a member of.
        /// </summary>
        public const string Domain = "user.domain";
        
        /// <summary>
        /// User email address.
        /// </summary>
        public const string Email = "user.email";
        
        /// <summary>
        /// User's full name, if available.
        /// </summary>
        /// <example>
        /// <c>Albert Einstein</c>
        /// </example>
        public const string FullName = "user.full_name";
        
        /// <summary>
        /// Unique user hash to correlate information for a user in anonymized form.
        /// </summary>
        public const string Hash = "user.hash";
        
        /// <summary>
        /// Unique identifier of the user.
        /// </summary>
        /// <example>
        /// <c>S-1-5-21-202424912787-2692429404-2351956786-1000</c>
        /// </example>
        public const string Id = "user.id";
        
        /// <summary>
        /// Short name or login of the user.
        /// </summary>
        /// <example>
        /// <c>a.einstein</c>
        /// </example>
        public const string Name = "user.name";
        
        /// <summary>
        /// Array of user roles at the time of the event.
        /// </summary>
        /// <example>
        /// <c>["kibana_admin", "reporting_user"]</c>
        /// </example>
        public const string Roles = "user.roles";
        
        /// <summary>
        /// User's full name, if available.
        /// </summary>
        /// <example>
        /// <c>Albert Einstein</c>
        /// </example>
        public const string FullNameText = "user.full_name.text";
        
        /// <summary>
        /// Short name or login of the user.
        /// </summary>
        /// <example>
        /// <c>a.einstein</c>
        /// </example>
        public const string NameText = "user.name.text";
        
    }
}

