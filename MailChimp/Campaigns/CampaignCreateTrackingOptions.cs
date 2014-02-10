using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.Campaigns
{
    [DataContract]
    public class CampaignCreateTrackingOptions
    {
        public CampaignCreateTrackingOptions()
        {
            //set the default values based upon the documentation
            Opens = true;
            HTMLClicks = true;
            TextClicks = false;
        }
        /// <summary>
        /// whether to track opens, defaults to true
        /// </summary>
        [DataMember(Name="opens")]
        public bool Opens
        {
            get;
            set;
        }
        /// <summary>
        /// whether to track clicks in HTML content, defaults to true
        /// </summary>
        [DataMember(Name = "html_clicks")]
        public bool HTMLClicks
        {
            get;
            set;
        }
        /// <summary>
        /// the From: email address for your campaign message
        /// </summary>
        [DataMember(Name = "text_clicks")]
        public bool TextClicks
        {
            get;
            set;
        }
    }
}
