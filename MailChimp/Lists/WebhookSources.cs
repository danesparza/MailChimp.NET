using System.Runtime.Serialization;

namespace MailChimp.Lists
{
    public class WebhookSources
    {
        /// <summary>
        /// whether user/subscriber triggered actions are returned
        /// </summary>
        [DataMember(Name = "user")]
        public bool User { get; set; }
        /// <summary>
        /// whether admin (manual, in-app) triggered actions are returned
        /// </summary>
        [DataMember(Name = "admin")]
        public bool Admin { get; set; }
        /// <summary>
        /// whether api triggered actions are returned
        /// </summary>
        [DataMember(Name = "api")]
        public bool Api { get; set; }
    }

}
