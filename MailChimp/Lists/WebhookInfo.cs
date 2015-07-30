using System.Runtime.Serialization;

namespace MailChimp.Lists
{
    /// <summary>
    /// result of the operation including valid data and any errors
    /// </summary>
    [DataContract]
    public class WebhookInfo
    {
        /// <summary>
        /// the URL for this Webhook
        /// </summary>
        [DataMember(Name = "url")]
        public string Url
        {
            get;
            set;
        }

        /// <summary>
        /// the possible actions and whether they are enabled
        /// </summary>
        [DataMember(Name = "actions")]
        public WebhookActions Actions
        {
            get;
            set;
        }

        /// <summary>
        /// the possible sources and whether they are enabled
        /// </summary>
        [DataMember(Name = "sources")]
        public WebhookSources Sources
        {
            get;
            set;
        }
    }

}
