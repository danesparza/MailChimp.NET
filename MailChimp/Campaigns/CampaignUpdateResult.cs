using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MailChimp.Campaigns
{
    public class CampaignUpdateResult
    {
        /// <summary>
        /// The updated campaign details
        /// </summary>
        [DataMember(Name = "data")]
        public Campaign Data
        {
            get;
            set;
        }

        /// <summary>
        /// any errors found while updating
        /// </summary>
        [DataMember(Name = "errors")]
        public List<CampaignUpdateError> Errors
        {
            get;
            set;
        }
    }
}