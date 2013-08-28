using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MailChimp.Lists
{
    /// <summary>
    ///  
    /// </summary>
    [DataContract]
    public class StaticSegmentAddResult
    {
        /// <summary>
        /// The ID of the new Static Segment
        /// </summary>
        [DataMember(Name = "id")]
        public int NewStaticSegmentID
        {
            get;
            set;
        }
    }
}
