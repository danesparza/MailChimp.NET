using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Users
{
    [DataContract]
    public class UserInvite
    {
        /// <summary>
        /// the email address the invitation was sent to
        /// </summary>
        [DataMember(Name = "email")]
        public string Email
        {
            get;
            set;
        }

        /// <summary>
        /// the role that will be assigned if they accept
        /// </summary>
        [DataMember(Name = "role")]
        public string Role
        {
            get;
            set;
        }

        /// <summary>
        /// the time the invitation was sent. this will change if it's resent.
        /// </summary>
        [DataMember(Name = "sent_at")]
        public string SentAt
        {
            get;
            set;
        }

        /// <summary>
        /// the expiration time for the invitation. this will change if it's resent.
        /// </summary>
        [DataMember(Name = "expiration")]
        public string Expiration
        {
            get;
            set;
        }

        /// <summary>
        /// the welcome message included with the invitation
        /// </summary>
        [DataMember(Name = "msg")]
        public string Message
        {
            get;
            set;
        }
    }
}
