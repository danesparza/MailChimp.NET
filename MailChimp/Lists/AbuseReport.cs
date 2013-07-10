using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Lists
{
    [DataContract]
    public class AbuseReport
    {
        /// <summary>
        /// date/time the abuse report was received and processed
        /// </summary>
        [DataMember(Name = "date")]
        public string Date
        {
            get;
            set;
        }

        /// <summary>
        /// the email address that reported abuse
        /// </summary>
        [DataMember(Name = "email")]
        public string Email
        {
            get;
            set;
        }

        /// <summary>
        /// the unique id for the campaign that report was made against
        /// </summary>
        [DataMember(Name = "campaign_id")]
        public string CampaignId
        {
            get;
            set;
        }

        /// <summary>
        /// an internal type generally specifying the orginating mail provider - 
        /// may not be useful outside of filling report views
        /// </summary>
        [DataMember(Name = "type")]
        public string Type
        {
            get;
            set;
        }
    }
}
