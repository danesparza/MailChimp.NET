using System.Runtime.Serialization;
using System.Collections.Generic;

namespace MailChimp.Reports
{
    [DataContract]
    public class Clicks
    {
        /// <summary>
        ///the url being tracked - urls are tracked individually, so duplicates can exist with vastly different stats
        /// </summary>
        [DataMember(Name = "total")]
        public List<Total> Total { get; set; }
    }

   [DataContract]
   public class Total
    {
       /// <summary>
       ///the url being tracked - urls are tracked individually, so duplicates can exist with vastly different stats
       /// </summary>
       [DataMember(Name = "url")]
        public string Url { get; set; }
       /// <summary>
       ///Number of times the specific link was clicked
       /// </summary>
       [DataMember(Name = "clicks")]
       public int Clicks { get; set; }
       /// <summary>
       ///the percentage of total clicks "clicks" represents
       /// </summary>
       [DataMember(Name = "clicks_percent")]
       public double ClicksPercent { get; set; }
        /// <summary>
       ///Number of unique people who clicked on the specific link
       /// </summary>
       [DataMember(Name = "unique")]
       public int Unique { get; set; }
       /// <summary>
       ///the percentage of unique clicks "unique" represents
       /// </summary>
       [DataMember(Name = "unique_percent")]
       public double UniquePercent { get; set; }
       /// <summary>
       ///the tracking id used in campaign links - used primarily for reports/click-activity. also can be used to order urls by the order they appeared in the campaign to recreate our heat map.
       /// </summary>
       [DataMember(Name = "tid")]
       public int Tid { get; set; }
    }
}
