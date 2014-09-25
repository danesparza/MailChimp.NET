using System.Runtime.Serialization;
using MailChimp.Campaigns;

namespace MailChimp.Lists
{
    [DataContract]
    public class AddCampaignSegmentOptions
    {
        /// <summary>
        /// either "static" or "saved" 
        /// </summary>
        [DataMember(Name = "type")]
        public string SegmentType { get; set; }

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