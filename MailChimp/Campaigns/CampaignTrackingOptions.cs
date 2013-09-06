using System.Runtime.Serialization;

namespace MailChimp.Campaigns
{
    /// <summary>
    /// optional - set which recipient actions will be tracked. Click tracking can not be disabled for Free accounts.
    /// </summary>
   [DataContract]
   public class CampaignTrackingOptions
    {
       public CampaignTrackingOptions()
       {
           Opens = true;
           HtmlClicks = true;
           TextClicks = false;
       }
        /// <summary>
        /// whether to track opens, defaults to true
        /// </summary>
       [DataMember(Name = "opens")]
       public bool Opens
       {
           get;
           set;
       }
       /// <summary>
       /// whether to track clicks in HTML content, defaults to true
       /// </summary>
       [DataMember(Name = "html_clicks")]
       public bool HtmlClicks
       {
           get;
           set;
       }
       /// <summary>
       /// whether to track clicks in Text content, defaults to false
       /// </summary>
       [DataMember(Name = "text_clicks")]
       public bool TextClicks
       {
           get;
           set;
       }
    }
}
