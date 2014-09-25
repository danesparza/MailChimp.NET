using System.Collections.Generic;
using System.Runtime.Serialization;
using MailChimp.Lists;

namespace MailChimp.Reports
{
    /// <summary>
    ///optional - various options for controlling returned data
    /// </summary>
    [DataContract]
    public class BounceMessagesOptions : CommonOptions
    {
        /// <summary>
        /// optional pull only messages since this time - 24 hour format in GMT, eg "2013-12-30 20:30:00"
        /// </summary>
        [DataMember(Name = "since")]
        public string Since { get; set; }

    }

    /// <summary>
    /// data for the full bounce messages for this campaign
    /// </summary>
    [DataContract]
    public class BounceMessages
    {
        /// <summary>
        /// that total number of bounce messages for the campaign
        /// </summary>
        [DataMember(Name = "total")]
        public int Total { get; set; }

        /// <summary>
        /// structs containing the data for this page
        /// </summary>
        [DataMember(Name = "data")]
        public List<BounceMessagesData> Data { get; set; }
    }

    [DataContract]
    public class BounceMessagesData
    {
        /// <summary>
        /// the member record as returned by lists/member-info()
        /// </summary>
        [DataMember(Name = "member")]
        public MemberInfo Member { get; set; }        

        /// <summary>
        /// date the bounce was received and processed
        /// </summary>
        [DataMember(Name = "date")]
        public  string Date { get; set; }

        /// <summary>
        /// the entire bounce message received
        /// </summary>
        [DataMember(Name = "message")]
        public string Message { get; set; }
    }
}
