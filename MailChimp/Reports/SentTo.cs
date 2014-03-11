using System.Runtime.Serialization;
using System.Collections.Generic;
using MailChimp.Lists;

namespace MailChimp.Reports
{
    
     /// <summary>
    ///optional - various options for controlling returned data
    /// </summary>
    [DataContract]
    public class SentToLimits
    {
       /// <summary>
       /// optional the status to pull - one of 'sent', 'hard' (bounce), or 'soft' (bounce). By default, all records are returned
       /// </summary>
        [DataMember(Name = "status")]
        public string Status { get; set; }
        /// <summary>
        /// optional for large data sets, the page number to start at - defaults to 1st page of data (page 0)
        /// </summary>
        [DataMember(Name = "start")]
        public int Start { get; set; }
        /// <summary>
        /// optional for large data sets, the number of results to return - defaults to 25, upper limit set at 100
        /// </summary>
        [DataMember(Name = "limit")]
        public int Limit { get; set; }
    }

    /// <summary>
    ///  a total of all matching emails and the specific emails for this page
    /// </summary>
    [DataContract]
    public class SentToMembers
    {
        /// <summary>
        /// the total number of members for the campaign and status
        /// </summary>
        [DataMember(Name = "total")]
        public int Total { get; set; }

        /// <summary>
        /// structs for each campaign member matching
        /// </summary>
        [DataMember(Name = "data")]
        public List<SentToMemberData> Data { get; set; }
    }

    [DataContract]
    public class SentToMemberData
    {
        /// <summary>
        /// the member record as returned by lists/member-info()
        /// </summary>
        [DataMember(Name = "member")]
        public MemberInfo Member { get; set; }

        /// <summary>
        /// the status of the send - one of 'sent', 'hard', 'soft'
        /// </summary>
        [DataMember(Name = "status")]
        public string Status { get; set; }

        /// <summary>
        /// if this was an absplit campaign, one of 'a','b', or 'winner'
        /// </summary>
        [DataMember(Name = "absplit_group")]
        public string AbsplitGroup { get; set; }

        /// <summary>
        /// if this was an timewarp campaign the timezone GMT offset the member was included in
        /// </summary>
        [DataMember(Name = "tz_group")]
        public string TZGroup { get; set; }
    }
}
