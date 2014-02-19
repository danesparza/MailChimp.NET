using System.Runtime.Serialization;

namespace MailChimp.Users
{
    /// <summary>
    /// The current user's details
    /// </summary>
    [DataContract]
    public class UserProfile
    {
        /// <summary>
        /// the login id for this login
        /// </summary>
        [DataMember(Name = "id")]
        public int Id { get; set; }

        /// <summary>
        /// the username used to log in
        /// </summary>
        [DataMember(Name = "username")]
        public string Username { get; set; }

        /// <summary>
        /// a display name for the account - empty first/last names will return the username
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// the email tied to the account used for passwords resets and the ilk
        /// </summary>
        [DataMember(Name = "email")]
        public string Email { get; set; }

        /// <summary>
        /// the role assigned to the account
        /// </summary>
        [DataMember(Name = "role")]
        public string Role { get; set; }

        /// <summary>
        /// if available, the url for the login's avatar
        /// </summary>
        [DataMember(Name = "avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// the globally unique user id for the user account connected to
        /// </summary>
        [DataMember(Name = "global_user_id")]
        public string GlobalUserId { get; set; }

        /// <summary>
        /// the datacenter unique id for the user account connected to, like helper/account-details
        /// </summary>
        [DataMember(Name = "dc_unique_id")]
        public string DCUniqueId { get; set; }

        /// <summary>
        /// The name of the account to which the API key belongs
        /// </summary>
        [DataMember(Name = "account_name")]
        public string AccountName { get; set; }
    }
}
