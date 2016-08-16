using System.Collections.Generic;
using System.Runtime.Serialization;
using MailChimp.Lists;

namespace MailChimp.Reports
{
    /// <summary>
    /// a total of all unsubscribed emails and the specific members for this page
    /// </summary>
    [DataContract]
    public class Unsubscribes
    {
        /// <summary>
        /// the total number of unsubscribes for the campaign
        /// </summary>
        [DataMember(Name = "total")]
        public int Total { get; set; }

        /// <summary>
        /// structs for the email addresses that unsubscribed
        /// </summary>
        [DataMember(Name = "data")]
        public List<UnsubscribesData> Data { get; set; }
    }

    [DataContract]
    public class UnsubscribesData
    {
        /// <summary>
        /// the member record as returned by lists/member-info()
        /// </summary>
        [DataMember(Name = "member")]
        public MemberInfo Member { get; set; }

        /// <summary>
        /// the reason collected for the unsubscribe. If populated, one of 'NORMAL','NOSIGNUP','INAPPROPRIATE','SPAM','OTHER'
        /// </summary>
        [DataMember(Name = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// if the reason is OTHER, the text entered.
        /// </summary>
        [DataMember(Name = "reason_text")]
        public string ReasonText { get; set; }
    }
}
