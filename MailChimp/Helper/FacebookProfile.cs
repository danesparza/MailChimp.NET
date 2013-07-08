using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Helper
{
    /// <summary>
    /// For Facebook, represents a user/page that can be posted to.
    /// </summary>
    [DataContract]
    public class FacebookProfile
    {
        /// <summary>
        /// the user or page id
        /// </summary>
        [DataMember(Name = "id")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>
        /// the user or page name
        /// </summary>
        [DataMember(Name = "name")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// whether this is a user or a page
        /// </summary>
        [DataMember(Name = "is_page")]
        public bool IsPage
        {
            get;
            set;
        }
    }
}
