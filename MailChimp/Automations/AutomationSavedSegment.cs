using System.Runtime.Serialization;

namespace MailChimp.Automations
{
    [DataContract]
    public class AutomationSavedSegment
    {
        [DataMember(Name = "id")]
        public int Id
        {
            get;
            set;
        }

        [DataMember(Name = "type")]
        public string Type
        {
            get;
            set;
        }

        [DataMember(Name = "name")]
        public string Name
        {
            get;
            set;
        }

    }
}
