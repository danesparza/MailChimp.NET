using System.Runtime.Serialization;

namespace MailChimp.Webhooks
{
    /// <summary>
    /// Data returned from an Unsubscribe Webhook
    /// </summary>
    [DataContract]
    public class UnsubscribeWebhookData
    {
        /// <summary>
        /// The action performed
        /// </summary>
        [DataMember(Name = "action")]
        public string Action
        {
            get;
            set;
        }
        /// <summary>
        /// The unsubscribe reason if given
        /// </summary>
        [DataMember(Name = "reason")]
        public string Reason
        {
            get;
            set;
        }
        /// <summary>
        /// The ID of the member
        /// </summary>
        [DataMember(Name = "id")]
        public string ID
        {
            get;
            set;
        }
        /// <summary>
        /// The ID of the list they unsubscribed from
        /// </summary>
        [DataMember(Name = "list_id")]
        public string ListId
        {
            get;
            set;
        }
        /// <summary>
        /// The email address that was unsubscribed
        /// </summary>
        [DataMember(Name = "email")]
        public string Email
        {
            get;
            set;
        }
        /// <summary>
        /// The type of email e.g. "Html"
        /// </summary>
        [DataMember(Name = "email_type")]
        public string EmailType
        {
            get;
            set;
        }
        /// <summary>
        /// The merges supplied
        /// </summary>
        [DataMember(Name = "merges")]
        public WebhookMerges Merges
        {
            get;
            set;
        }
        /// <summary>
        /// IP address
        /// </summary>
        [DataMember(Name = "ip_opt")]
        public string IPOpt
        {
            get;
            set;
        }
        /// <summary>
        /// Campaign ID
        /// </summary>
        [DataMember(Name = "campaign_id")]
        public string CampaignID
        {
            get;
            set;
        }

    }
}
