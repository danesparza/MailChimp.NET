using System.Runtime.Serialization;

namespace MailChimp.Automations
{
    [DataContract]
    public class AutomationError
    {
        /// <summary>
        /// the filter that caused the failure
        /// </summary>
        [DataMember(Name = "filter")]
        public string Filter
        {
            get;
            set;
        }

        /// <summary>
        /// the filter value that caused the failure
        /// </summary>
        [DataMember(Name = "value")]
        public string Value
        {
            get;
            set;
        }

        /// <summary>
        /// the error code
        /// </summary>
        [DataMember(Name = "code")]
        public int Code
        {
            get;
            set;
        }

        /// <summary>
        /// the error message
        /// </summary>
        [DataMember(Name = "msg")]
        public string Message
        {
            get;
            set;
        }
    }
}
