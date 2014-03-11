using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.Campaigns
{
    /// <summary>
    /// A list of criteria on which to segment a list
    /// </summary>
    [DataContract]
    public class CampaignSegmentOptions
    {
	    /// <summary>
        /// a saved segment id from lists/segments() - this will take precendence, otherwise the match+conditions are required.
        /// </summary>
        [DataMember(Name = "saved_segment_id")]
        public string SavedSegmentId
        {
            get;
            set;
        }
        /// <summary>
        /// Controls whether to use AND or OR when applying your options - expects "any" (for OR) or "all" (for AND)
        /// </summary>
        [DataMember(Name="match")]
        public string Match
        {
            get;
            set;
        }
        /// <summary>
        /// Collection of up to 5 structs for different criteria to apply while segmenting. 
        /// Each criteria row must contain 3 keys - "field", "op", and "value" - and possibly a fourth, "extra", based on these definitions: http://apidocs.mailchimp.com/api/2.0/campaigns/segment-test.php
        /// </summary>
        [DataMember(Name="conditions")]
        public List<CampaignSegmentCriteria> Conditions
        {
          get;
          set;
        }
    }
}
