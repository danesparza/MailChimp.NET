using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Helper;

namespace MailChimp.Lists
{
    [DataContract]
    public class ListAddResult
    {
        /// <summary>
        /// Number of email addresses that were successfully added
        /// </summary>
        [DataMember(Name = "add_count")]
        public int AddCount
        {
            get;
            set;
        }

        /// <summary>
        /// Email addresses for each add
        /// </summary>
        [DataMember(Name = "adds")]
        public List<EmailParameter> Adds
        {
            get;
            set;
        }

        /// <summary>
        /// Number of email addresses that were successfully updated
        /// </summary>
        [DataMember(Name = "update_count")]
        public int UpdateCount
        {
            get;
            set;
        }

        /// <summary>
        /// Email addresses for each update
        /// </summary>
        [DataMember(Name = "updates")]
        public List<EmailParameter> Updates
        {
            get;
            set;
        }

        /// <summary>
        /// Number of email addresses that failed during addition/updating
        /// </summary>
        [DataMember(Name = "error_count")]
        public int ErrorCount
        {
            get;
            set;
        }

        /// <summary>
        /// Error information
        /// </summary>
        [DataMember(Name = "errors")]
        public List<ListError> Errors
        {
            get;
            set;
        }
    }
}
