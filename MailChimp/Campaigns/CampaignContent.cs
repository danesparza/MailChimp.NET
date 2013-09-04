using System.Runtime.Serialization;

namespace MailChimp.Campaigns
{
    /// <summary>
    /// All content for the campaign
    /// </summary>
    [DataContract]
    public class CampaignContent
    {
        /// <summary>
        /// The HTML content used for the campaign with merge tags intact
        /// </summary>
        [DataMember(Name="html")]
        public string Html
        {
            get;
            set;
        }

        /// <summary>
        /// The Text content used for the campaign with merge tags intact
        /// </summary>
        [DataMember(Name = "text")]
        public string Text
        {
            get;
            set;
        }
    }
}
