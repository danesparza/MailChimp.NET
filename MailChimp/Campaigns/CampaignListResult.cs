using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Campaigns
{
    /// <summary>
    /// a count of all matching campaigns, the specific ones for the current page, 
    /// and any errors from the filters provided
    /// </summary>
    [DataContract]
    public class CampaignListResult
    {
        /// <summary>
        /// the total number of campaigns matching the filters passed in
        /// </summary>
        [DataMember(Name = "total")]
        public int Total
        {
            get;
            set;
        }

        /// <summary>
        /// A list of campaigns returned
        /// </summary>
        [DataMember(Name = "data")]
        public List<Campaign> Data
        {
            get;
            set;
        }

        /// <summary>
        /// any errors found while loading lists [sic] - usually 
        /// just from providing invalid list ids
        /// </summary>
        [DataMember(Name = "errors")]
        public List<CampaignError> Errors
        {
            get;
            set;
        }
    }
}
