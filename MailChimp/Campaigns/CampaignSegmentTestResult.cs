using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MailChimp
{
    [DataContract]
    public class CampaignSegmentTestResult
    {
        /// <summary>
        /// The total number of subscribers matching your segmentation options
        /// </summary>
        [DataMember(Name = "total")]
        public int Total
        {
            get;
            set;
        }
    }
}
