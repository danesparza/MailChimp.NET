using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MailChimp.Lists
{
    [DataContract]
    public class StaticSegmentResult
    {
        /// <summary>
        /// the id of the segment
        /// </summary>
        [DataMember(Name = "id")]
        public int StaticSegmentId
        {
            get;
            set;
        }
        /// <summary>
        /// the name of the segment
        /// </summary>
        [DataMember(Name = "name")]
        public string SegmentName
        {
            get;
            set;
        }
        /// <summary>
        /// the total number of subscribed members currently in a segment 
        /// </summary>
        [DataMember(Name = "member_count")]
        public string memberCount
        {
            get;
            set;
        }
        /// <summary>
        /// the date/time the segment was created 
        /// </summary>
        [DataMember(Name = "created_date")]
        public DateTime createdDate
        {
            get;
            set;
        }
        /// <summary>
        /// the date/time the segment was last updated (add or del)
        /// </summary>
        [DataMember(Name = "last_update")]
        public DateTime lastUpdate
        {
            get;
            set;
        }
        /// <summary>
        /// the date/time the segment was last reset (ie had all members cleared from it)
        /// </summary>
        [DataMember(Name = "last_reset")]
        public DateTime lastReset
        {
            get;
            set;
        }

    }
}
