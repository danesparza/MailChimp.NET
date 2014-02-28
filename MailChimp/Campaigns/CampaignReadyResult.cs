using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MailChimp.Campaigns
{
    [DataContract]
    class CampaignReadyResult
    {
        public bool IsReady { get; set; }

        public List<CampaignReadyCheckItem> Items { get; set; }
    }
}
