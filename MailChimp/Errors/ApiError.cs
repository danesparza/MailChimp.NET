using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Errors
{
    /// <summary>
    /// Class for API error information from the Mailchimp API
    /// </summary>
    [DataContract]
    public class ApiError
    {
        [DataMember(Name = "status")]
        public string Status
        {
            get;
            set;
        }

        [DataMember(Name = "code")]
        public string Code
        {
            get;
            set;
        }

        [DataMember(Name = "name")]
        public string Name
        {
            get;
            set;
        }

        [DataMember(Name = "error")]
        public string Error
        {
            get;
            set;
        }
    }
}
