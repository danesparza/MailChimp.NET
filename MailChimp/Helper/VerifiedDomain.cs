using System.Runtime.Serialization;

namespace MailChimp.Helper
{
    [DataContract]
    public class VerifiedDomain
    {
        /// <summary>
        /// The verified domain
        /// </summary>
        [DataMember(Name = "domain")]
        public string Domain
        {
            get;
            set;
        }

        /// <summary>
        /// The status of the verification - either "verified" or "pending"
        /// </summary>
        [DataMember(Name = "status")]
        public string Status
        {
            get;
            set;
        }

        /// <summary>
        /// The email address used for verification - "pre-existing" if we automatically backfilled it at some point 
        /// </summary>
        [DataMember(Name = "email")]
        public string Email
        {
            get;
            set;
        }
    }
}
