using System.Runtime.Serialization;

namespace MailChimp.Campaigns
{
    /// <summary>
    /// optional - one or more of these keys set to the tag to use - that can be any custom text (up to 50 bytes)
    /// </summary>
    [DataContract]
    public class CampaignAnalyticsOptions
    {
        
        /// <summary>
        /// for Google Analytics tracking
        /// </summary>
        [DataMember(Name="google")]
        public string Google
        {
            get;
            set;
        }
        /// <summary>
        /// for ClickTale tracking
        /// </summary>
        [DataMember(Name = "clicktale")]
        public string Clicktale
        {
            get;
            set;
        }
         /// <summary>
        ///for Goo.al tracking
        /// </summary>
        [DataMember(Name = "gooal")]
        public string Gooal
        {
            get;
            set;
        }
    }
}
