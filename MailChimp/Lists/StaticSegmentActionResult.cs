using System.Runtime.Serialization;

namespace MailChimp.Lists
{
    [DataContract]
    public class StaticSegmentActionResult
    {
        /// <summary>
        /// The segment was removed
        /// </summary>
        [DataMember(Name = "complete")]
        public bool Complete
        {
            get;
            set;
        }
    }
}
