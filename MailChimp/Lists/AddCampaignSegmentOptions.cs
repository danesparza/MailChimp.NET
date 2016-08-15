using System.Runtime.Serialization;
using MailChimp.Campaigns;

namespace MailChimp.Lists
{
    [DataContract]
    public class AddCampaignSegmentOptions : SegmentTestOptions
    {
        /// <summary>
        /// either "static" or "saved" 
        /// </summary>
        [DataMember(Name = "type")]
        public string SegmentType { get; set; }
    }
}