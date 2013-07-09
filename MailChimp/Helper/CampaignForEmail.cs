using System.Runtime.Serialization;

namespace MailChimp.Helper
{
    /// <summary>
    /// Campaign data for each matching campaign
    /// </summary>
    [DataContract]
    public class CampaignForEmail
    {
        /// <summary>
        /// the campaign unique id
        /// </summary>
        [DataMember(Name = "id")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>
        /// the campaign's title
        /// </summary>
        [DataMember(Name = "title")]
        public string Title
        {
            get;
            set;
        }

        /// <summary>
        /// the campaign's subject
        /// </summary>
        [DataMember(Name = "subject")]
        public string Subject
        {
            get;
            set;
        }

        /// <summary>
        /// the time the campaign was sent
        /// </summary>
        [DataMember(Name = "send_time")]
        public string SendTime
        {
            get;
            set;
        }

        /// <summary>
        /// the campaign type
        /// </summary>
        [DataMember(Name = "type")]
        public string CampaignType
        {
            get;
            set;
        }
    }
}
