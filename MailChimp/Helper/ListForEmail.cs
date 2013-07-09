using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Helper
{
    /// <summary>
    /// Describes a list that a member is subscribed to
    /// </summary>
    [DataContract]
    public class ListForEmail
    {
        /// <summary>
        /// the list unique id
        /// </summary>
        [DataMember(Name = "id")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>
        /// id referenced in web interface urls
        /// </summary>
        [DataMember(Name = "web_id")]
        public string WebId
        {
            get;
            set;
        }

        /// <summary>
        /// list name
        /// </summary>
        [DataMember(Name = "name")]
        public string Name
        {
            get;
            set;
        }
    }
}
