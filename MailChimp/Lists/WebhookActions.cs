using System.Runtime.Serialization;

namespace MailChimp.Lists
{
    public class WebhookActions
    {
        /// <summary>
        /// triggered when subscribes happen
        /// </summary>
        [DataMember(Name = "subscribe")]
        public bool Subscribe { get; set; }
        /// <summary>
        /// triggered when unsubscribes happen
        /// </summary>
        [DataMember(Name = "unsubscribe")]
        public bool Unsubscribe { get; set; }
        /// <summary>
        /// triggered when profile updates happen
        /// </summary>
        [DataMember(Name = "profile")]
        public bool Profile { get; set; }
        /// <summary>
        /// triggered when a subscriber is cleaned (bounced) from a list
        /// </summary>
        [DataMember(Name = "cleaned")]
        public bool Cleaned { get; set; }
        /// <summary>
        /// triggered when a subscriber's email address is changed
        /// </summary>
        [DataMember(Name = "upemail")]
        public bool Upemail { get; set; }
        /// <summary>
        /// triggered when a campaign is sent or canceled
        /// </summary>
        [DataMember(Name = "campaign")]
        public bool Campaign { get; set; }
    }

}
