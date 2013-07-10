using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Lists
{
    /// <summary>
    /// Error messages from batch subscribes
    /// </summary>
    [DataContract]
    public class ListError
    {
        /// <summary>
        /// whatever was passed in the batch record's email parameter
        /// </summary>
        [DataMember(Name = "email")]
        public string Email
        {
            get;
            set;
        }

        /// <summary>
        /// the error code
        /// </summary>
        [DataMember(Name = "code")]
        public int ErrorCode
        {
            get;
            set;
        }

        /// <summary>
        /// the full error message
        /// </summary>
        [DataMember(Name = "message")]
        public string ErrorMessage
        {
            get;
            set;
        }
    }
}
