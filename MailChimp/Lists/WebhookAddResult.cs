using System.Runtime.Serialization;

namespace MailChimp.Lists
{
    [DataContract]
    public class WebhookAddResult
    {
        /// <summary>
        /// the id of the new webhook
        /// </summary>
        [DataMember(Name = "id")]
        public int WebhookId
        {
            get;
            set;
        }
    }
}
