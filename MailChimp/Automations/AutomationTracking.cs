using System.Runtime.Serialization;

namespace MailChimp.Automations
{
    [DataContract]
    public class AutomationTracking
    {
        [DataMember(Name = "html_clicks")]
        public bool HtmlClicks
        {
            get;
            set;
        }

        [DataMember(Name = "text_clicks")]
        public bool TextClicks
        {
            get;
            set;
        }

        [DataMember(Name = "opens")]
        public bool Opens
        {
            get;
            set;
        }

    }
}
