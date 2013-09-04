using System.Runtime.Serialization;

namespace MailChimp.Webhooks
{
    [DataContract]
    public class CleanedWebhookData
    {
        /// <summary>
        /// The list ID that the email address was cleaned from
        /// </summary>
        [DataMember(Name = "list_id")]
        public string ListId
        {
            get;
            set;
        }
        /// <summary>
        /// The campaign ID that the email address was cleaned from
        /// </summary>
        [DataMember(Name = "campaign_id")]
        public string Campaign_Id
        {
            get;
            set;
        }
        /// <summary>
        /// The reason the email address was cleaned will be one of "hard" (for hard bounces) or "abuse"
        /// </summary>
        [DataMember(Name = "reason")]
        public string Reason
        {
            get;
            set;
        }
        /// <summary>
        /// Email address that was cleaned
        /// </summary>
        [DataMember(Name = "email")]
        public string Email
        {
            get;
            set;
        }

    }
}
