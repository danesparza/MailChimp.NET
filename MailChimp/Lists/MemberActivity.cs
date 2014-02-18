using MailChimp.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MailChimp.Lists
{
    [DataContract]
    public class MemberActivity
    {
        /// <summary>
        /// THe email address of the list member
        /// </summary>
        [DataMember(Name = "email")]
        public EmailParameter Email
        {
            get;
            set;
        }

        /// <summary>
        /// A collection containing the activity for a list member
        /// </summary>
        [DataMember(Name = "activity")]
        public List<MemberActivityItem> Activity
        {
            get;
            set;
        }
    }
}
