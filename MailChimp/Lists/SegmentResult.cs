using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.Lists
{
    [DataContract]
    public class SegmentResult
    {
        /// <summary>
        /// array of structs with data for each segment
        /// </summary>
        [DataMember(Name = "static")]
        public List<StaticSegmentResult> StaticResult
        {
            get;
            set;
        }

        /// <summary>
        /// array of structs with data for each segment
        /// </summary>
        [DataMember(Name = "saved")]
        public List<SavedSegmentResult> SavedResult
        {
            get;
            set;
        }
    }
}
