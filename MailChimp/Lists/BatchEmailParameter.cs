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
    public class BatchEmailParameter
    {
        public BatchEmailParameter()
        {
            this.EmailType = "html";
        }

        /// <summary>
        /// Email information for the customer
        /// </summary>
        [DataMember(Name = "email")]
        public EmailParameter Email
        {
            get;
            set;
        }

        /// <summary>
        /// for the email type option (html or text).  Defaults to html
        /// </summary>
        [DataMember(Name = "email_type")]
        public string EmailType
        {
            get;
            set;
        }

        /// <summary>
        /// data for the various list specific and special merge vars
        /// </summary>
        [DataMember(Name = "merge_vars")]
        public MergeVar MergVars
        {
            get;
            set;
        }
    }
}
