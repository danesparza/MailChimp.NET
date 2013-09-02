using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MailChimp.Webhooks
{
    /// <summary>
    /// The result of a "Cleaned" webhook, when an email fails in mailchimp
    /// </summary>
    [DataContract]
    public class CleanedWebhookResult
    {
        /// <summary>
        /// The type of Webhook e.g. "cleaned"
        /// </summary>
        [DataMember(Name="type")]
        public string Type
        {
            get;
            set;
        }
        /// <summary>
        /// The timestamp of Webhook e.g. "2009-09-26 21:40:57"
        /// </summary>
        [DataMember(Name = "firedAt")]
        public string FiredAt
        {
            get;
            set;
        }
        /// <summary>
        /// The data from the webhook
        /// </summary>
        [DataMember(Name = "data")]
        public CleanedWebhookData Data
        {
            get;
            set;
        }
    }
}
