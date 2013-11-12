using System.Runtime.Serialization;

namespace MailChimp.Reports
{
    /// <summary>
    /// optional - various extra options based on the campaign type
    /// </summary>
   [DataContract]
   public class Timeseries
    {
       /// <summary>
       ///The timestemp in Y-m-d H:00:00 format
       /// </summary>
       [DataMember(Name = "timestamp")]
       public string Timestamp { get; set; }
       /// <summary>
       ///the total emails sent during the hour
       /// </summary>
       [DataMember(Name = "emails_sent")]
       public int EmailsSent { get; set; }
        /// <summary>
       ///unique opens seen during the hour
       /// </summary>
       [DataMember(Name = "unique_opens")]
       public int UniqueOpens { get; set; }
        /// <summary>
       ///unique clicks seen during the hour
       /// </summary>
       [DataMember(Name = "recipients_click")]
       public int RecipientsClick { get; set; }
    }
}
