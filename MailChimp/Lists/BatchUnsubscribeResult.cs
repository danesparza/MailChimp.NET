using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Lists
{
    /// <summary>
    /// The results of a batch unsubscribe
    /// </summary>
    [DataContract]
    public class BatchUnsubscribeResult
    {
        /// <summary>
        /// Number of email addresses that were successfully removed
        /// </summary>
        [DataMember(Name = "success_count")]
        public int SuccessCount
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
        /// List of errors encountered
        /// </summary>
        [DataMember(Name = "errors")]
        public List<ListError> Errors
        {
            get;
            set;
        }
    }
}
