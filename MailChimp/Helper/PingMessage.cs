using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Helper
{
    /// <summary>
    /// Message from 'Ping' call
    /// </summary>
    [DataContract]
    public class PingMessage
    {
        /// <summary>
        /// containing "Everything's Chimpy!" if everything is chimpy, otherwise returns an error message
        /// </summary>
        [DataMember(Name = "msg")]
        public string Message
        {
            get;
            set;
        }
    }
}
