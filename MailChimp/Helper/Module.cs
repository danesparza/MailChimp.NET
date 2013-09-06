using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.Helper
{
    /// <summary>
    /// Provides information about a Mailchimp addon module
    /// </summary>
    [DataContract]
    public class Module
    {
        /// <summary>
        /// An internal module id
        /// </summary>
        [DataMember(Name = "id")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>
        /// The module name
        /// </summary>
        [DataMember(Name = "name")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// The date the module was added
        /// </summary>
        [DataMember(Name = "added")]
        public string Added
        {
            get;
            set;
        }

        /// <summary>
        /// Any extra data associated with this module as key=>value pairs
        /// </summary>
        [DataMember(Name = "data")]
        public Dictionary<string, string> Data
        {
            get;
            set;
        }
    }
}
