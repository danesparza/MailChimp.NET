using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MailChimp.Campaigns
{
    /// <summary>
    /// An individual campaign 'ready check' item
    /// </summary>
    [DataContract]
    public class CampaignReadyCheckItem
    {
        [DataMember(Name = "type")]
        public string ReadyCheckType { get; set; }

        [DataMember(Name = "heading")]
        public string Heading { get; set; }

        [DataMember(Name="details")]
        public string Details { get; set; }
    }
}
