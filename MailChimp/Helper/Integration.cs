using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Helper
{
    /// <summary>
    /// Class to represent each connected integration that can be used with campaigns
    /// </summary>
    [DataContract]
    public class Integration
    {
        /// <summary>
        /// an internal id for the integration
        /// </summary>
        [DataMember(Name = "id")]
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// the integration name
        /// </summary>
        [DataMember(Name = "name")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// either "_any_" when globally accessible or the list id it's valid for use against
        /// </summary>
        [DataMember(Name = "list_id")]
        public string ListId
        {
            get;
            set;
        }

        /// <summary>
        /// if applicable, the user id for the integrated system
        /// </summary>
        [DataMember(Name = "user_id")]
        public string UserId
        {
            get;
            set;
        }

        /// <summary>
        /// if applicable, the user/account name for the integrated system
        /// </summary>
        [DataMember(Name = "account")]
        public string Account
        {
            get;
            set;
        }

        /// <summary>
        /// For Facebook, users/pages that can be posted to
        /// </summary>
        [DataMember(Name = "profiles")]
        public List<FacebookProfile> Profiles
        {
            get;
            set;
        }
    }
}
