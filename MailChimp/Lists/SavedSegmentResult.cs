using System;
using System.Runtime.Serialization;

namespace MailChimp.Lists
{
    [DataContract]
    public class SavedSegmentResult
    {
        /// <summary>
        /// the id of the segment
        /// </summary>
        [DataMember(Name = "id")]
        public int Id
        {
            get;
            set;
        }
        /// <summary>
        /// the name of the segment
        /// </summary>
        [DataMember(Name = "name")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// same match+conditions struct typically used
        /// </summary>
        [DataMember(Name = "segment_opts")]
        public string SegmentOpts
        {
            get;
            set;
        }
        /// <summary>
        /// a textual description of the segment match/conditions
        /// </summary>
        [DataMember(Name = "segment_text")]
        public string SegmentText
        {
            get;
            set;
        }
        
        /// <summary>
        /// the date+time the segment was created
        /// </summary>
        [DataMember(Name = "created_date")]
        public DateTime CreatedDate
        {
            get;
            set;
        }

        /// <summary>
        /// the date+time the segment was last updated (add or del)
        /// </summary>
        [DataMember(Name = "last_update")]
        public DateTime LastUpdate
        {
            get;
            set;
        }
    }
}
