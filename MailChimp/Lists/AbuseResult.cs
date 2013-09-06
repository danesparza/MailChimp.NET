using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.Lists
{
    /// <summary>
    /// the total of all reports and the specific reports 
    /// </summary>
    [DataContract]
    public class AbuseResult
    {
        /// <summary>
        /// the total number of matching abuse reports
        /// </summary>
        [DataMember(Name = "total")]
        public int Total
        {
            get;
            set;
        }

        /// <summary>
        /// the actual data for each report
        /// </summary>
        [DataMember(Name = "data")]
        public List<AbuseReport> Data
        {
            get;
            set;
        }
    }
}
