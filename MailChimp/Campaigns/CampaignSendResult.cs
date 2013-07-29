using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Campaigns
{
    [DataContract]
    public class CampaignSendResult
    {
        [DataMember(Name="complete")]
        public bool Complete
        {
            get;
            set;
        }
    }
}
