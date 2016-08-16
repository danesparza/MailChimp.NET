using System.Runtime.Serialization;

namespace MailChimp.Automations
{
    [DataContract]
    public class AutomationSocialCard
    {
        [DataMember(Name = "title")]
        public string Title
        {
            get;
            set;
        }

        [DataMember(Name = "description")]
        public string Description
        {
            get;
            set;
        }

        [DataMember(Name = "image_url")]
        public string ImageUrl
        {
            get;
            set;
        }

        [DataMember(Name = "enabled")]
        public string Enabled
        {
            get;
            set;
        }

    }
}
