using System.Runtime.Serialization;

namespace MailChimp.Reports
{
    /// <summary>
    /// optional - various extra options based on the campaign type
    /// </summary>
   [DataContract]
   public class Absplit
    {
       /// <summary>
       ///bounces for the A group
       /// </summary>
       [DataMember(Name = "bounces_a")]
       public int BouncesA { get; set; }
        /// <summary>
       ///bounces for the B group
       /// </summary>
       [DataMember(Name = "bounces_b")]
       public int BouncesB { get; set; }
        /// <summary>
       ///forwards for the A group
       /// </summary>
       [DataMember(Name = "forwards_a")]
       public int ForwardsA { get; set; }
        /// <summary>
       ///forwards for the B group
       /// </summary>
       [DataMember(Name = "forwards_b")]
       public int ForwardsB { get; set; }
        /// <summary>
       ///abuse reports for the A group
       /// </summary>
       [DataMember(Name = "abuse_reports_a")]
       public int AbuseReportsA { get; set; }
        /// <summary>
       ///abuse reports for the B group
       /// </summary>
       [DataMember(Name = "abuse_reports_b")]
       public int AbuseReportsB { get; set; }
        /// <summary>
       ///unsubs for the A group
       /// </summary>
       [DataMember(Name = "unsubs_a")]
       public int UnsubsA { get; set; }
        /// <summary>
       ///unsubs for the B group
       /// </summary>
       [DataMember(Name = "unsubs_b")]
       public int UnsubsB { get; set; }
        /// <summary>
       ///clicks for the A group
       /// </summary>
       [DataMember(Name = "recipients_click_a")]
       public int RecipientsClickA { get; set; }
        /// <summary>
       ///clicks for the B group
       /// </summary>
       [DataMember(Name = "recipients_click_b")]
       public int RecipientsClickB { get; set; }
        /// <summary>
       ///opened forwards for the A group
       /// </summary>
       [DataMember(Name = "forwards_opens_a")]
       public int ForwardsOpensA { get; set; }
        /// <summary>
       ///opened forwards for the B group
       /// </summary>
       [DataMember(Name = "forwards_opens_b")]
       public int ForwardsOpensB { get; set; }
        /// <summary>
       ///total opens for the A group
       /// </summary>
       [DataMember(Name = "opens_a")]
       public int OpensA { get; set; }
        /// <summary>
       ///total opens for the B group
       /// </summary>
       [DataMember(Name = "opens_b")]
       public int OpensB { get; set; }
        /// <summary>
       ///date/time of last open for the A group
       /// </summary>
       [DataMember(Name = "last_open_a")]
       public string LastOpenA { get; set; }
        /// <summary>
       ///date/time of last open for the B group
       /// </summary>
       [DataMember(Name = "last_open_b")]
       public string LastOpenB { get; set; }
        /// <summary>
       ///unique opens for the A group
       /// </summary>
       [DataMember(Name = "unique_opens_a")]
       public int UniqueOpensA { get; set; }
        /// <summary>
       ///unique opens for the B group
       /// </summary>
       [DataMember(Name = "unique_opens_b")]
       public int UniqueOpensB { get; set; }
    }
}
