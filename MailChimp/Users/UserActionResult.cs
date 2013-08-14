using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Users
{
    [DataContract]
    public class UserActionResult
    {
        /// <summary>
        /// The status (success) of the call if it completed. 
        /// Otherwise an error is thrown.
        /// </summary>
        [DataMember(Name = "status")]
        public string Status
        {
            get;
            set;
        }
    }
}
