using MailChimp.Campaigns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MailChimp.Lists
{
    [DataContract]
    public class SegmentTestOptions
    {
        /// <summary>
        /// a unique name per list for the segment - 100 byte maximum length, anything longer will throw an error 
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// various options for the new segment 
        /// </summary>
        [DataMember(Name = "segment_opts")]
        public CampaignSegmentOptions SegmentOptions { get; set; }
    }
}