using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.Lists
{
    [DataContract]
    public class StaticSegmentMembersAddResult
    {
       
        /// <summary>
        /// the total number of successful updates (will include members already in the segment)
        /// </summary>
        [DataMember(Name = "success_count")]
        public int successCount
        {
            get;
            set;
        }
        /// <summary>
        /// Error information
        /// </summary>
        [DataMember(Name = "errors")]
        public List<ListError> Errors
        {
            get;
            set;
        }
    }
}
