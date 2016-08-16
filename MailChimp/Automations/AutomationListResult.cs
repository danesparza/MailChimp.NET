using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.Automations
{
    [DataContract]
    public class AutomationListResult
    {
        [DataMember(Name = "total")]
        public int Total
        {
            get;
            set;
        }

        [DataMember(Name = "data")]
        public List<Automation> Data
        {
            get;
            set;
        }

        [DataMember(Name = "errors")]
        public List<AutomationError> Errors
        {
            get;
            set;
        }
    }
}
