using System.Runtime.Serialization;

namespace MailChimp.Lists
{
    [DataContract]
    public class CompleteResult
    {
        /// <summary>
        /// whether the call worked. reallistically this will always be true as errors will be thrown otherwise.
        /// </summary>
        [DataMember(Name = "complete")]
        public bool Complete
        {
            get;
            set;
        }
    }
}
