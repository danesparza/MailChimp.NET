using MailChimp.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MailChimp.Reports
{
    /// <summary>
    /// containing the total records matched and the specific records for this page
    /// </summary>
    [DataContract]
    public class NotOpened
    {
        /// <summary>
        /// the total number of members who didn't open the campaign
        /// </summary>
        [DataMember(Name = "total")]
        public int Total { get; set; }

        /// <summary>
        /// structs for each campaign member matching as returned by lists/member-info()
        /// </summary>
        [DataMember(Name = "data")]
        public List<MemberInfo> Data { get; set; }
    }
}
