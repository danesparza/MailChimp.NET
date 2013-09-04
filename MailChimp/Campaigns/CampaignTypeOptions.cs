using System.Runtime.Serialization;

namespace MailChimp.Campaigns
{
    /// <summary>
    /// optional - various extra options based on the campaign type
    /// </summary>
   [DataContract]
   public class CampaignTypeOptions
    {
        /// <summary>
        ///For RSS Campaigns
        /// </summary>
       [DataMember(Name="rss")]
       public CampaignTypeRssOptions RssOptions
       {
           get;
           set;
       }
       /// <summary>
       ///For A/B Split campaigns
       /// </summary>
       [DataMember(Name = "absplit")]
       public CampaignTypeAbsplitOptions ABSplitOption
       {
           get;
           set;
       }
       /// <summary>
       ///For AutoResponder campaigns
       /// </summary>
       [DataMember(Name = "auto")]
       public CampaignTypeAutoResponderOptions AutoResponder
       {
           get;
           set;
       }

    }
}
