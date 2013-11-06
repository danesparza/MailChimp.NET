using System.Runtime.Serialization;

namespace MailChimp.Reports
{
    /// <summary>
    /// optional - various extra options based on the campaign type
    /// </summary>
   [DataContract]
   public class Timewarp
    {
       /// <summary>
       ///opens for this timezone
       /// </summary>
       [DataMember(Name = "opens")]
        public int Opens { get; set; }
       /// <summary>
       ///the date/time of the last open for this timezone
       /// </summary>
       [DataMember(Name = "last_open")]
       public string last_open { get; set; }
        /// <summary>
       ///the unique opens for this timezone
       /// </summary>
       [DataMember(Name = "unique_opens")]
       public int UniqueOpens { get; set; }
        /// <summary>
       ///the total clicks for this timezone
       /// </summary>
       [DataMember(Name = "clicks")]
       public int Clicks { get; set; }
        /// <summary>
       ///the date/time of the last click for this timezone
       /// </summary>
       [DataMember(Name = "last_click")]
       public string LastClick { get; set; }
        /// <summary>
       ///the total bounces for this timezone
       /// </summary>
       [DataMember(Name = "bounces")]
       public int Bounces { get; set; }
        /// <summary>
       ///the total number of members sent to in this timezone
       /// </summary>
       [DataMember(Name = "total")]
       public int Total { get; set; }
        /// <summary>
       ///the total number of members delivered to in this timezone
       /// </summary>
       [DataMember(Name = "sent")]
       public int Sent { get; set; }
       
    }
}
