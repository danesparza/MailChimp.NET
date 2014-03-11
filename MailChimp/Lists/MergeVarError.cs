using System.Runtime.Serialization;

namespace MailChimp.Lists
{
    public class MergeVarError
    {
        /// <summary>
        /// the passed list id that failed 
        /// </summary>
        [DataMember(Name = "id")]
        public string Id
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
        [DataMember(Name = "msg")]
        public string ErrorMessage
        {
            get;
            set;
        }
    }
}
