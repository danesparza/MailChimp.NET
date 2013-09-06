using System.Runtime.Serialization;

namespace MailChimp.Webhooks
{
    /// <summary>
    /// Response from an Unsubscribe Webhook
    /// </summary>
    [DataContract]
    public class UnsubscribeWebhookResult
    {
        /// <summary>
        /// The type of Webhook e.g. "unsubscribe"
        /// </summary>
        [DataMember(Name = "type")]
        public string Type
        {
            get;
            set;
        }
        /// <summary>
        /// The timestamp of Webhook e.g. "2009-09-26 21:40:57"
        /// </summary>
        [DataMember(Name = "fired_at")]
        public string FiredAt
        {
            get;
            set;
        }
        /// <summary>
        /// The data from the webhook
        /// </summary>
        [DataMember(Name = "data")] 
        public UnsubscribeWebhookData Data
        {
            get;
            set;
        }
    }
}
