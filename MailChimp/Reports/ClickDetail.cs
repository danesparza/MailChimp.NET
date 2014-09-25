using MailChimp.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MailChimp.Reports
{
    /// <summary>
    /// the list of email addresses that clicked on a given url, and how many times they clicked
    /// </summary>
    [DataContract]
    public class ClickDetail
    {
        /// <summary>
        /// the total number of records matched
        /// </summary>
        [DataMember(Name = "total")]
        public int Total { get; set; }

        /// <summary>
        /// structs for each email addresses that click the requested url
        /// </summary>
        [DataMember(Name = "data")]
        public List<MemberClicks> Data { get; set; }

    }

    [DataContract]
    public class MemberClicks
    {
        /// <summary>
        /// the member record as returned by lists/member-info()
        /// </summary>
        [DataMember(Name = "member")]
        public MemberInfo Member { get; set; }

        /// <summary>
        /// total number of times the URL was clicked by this email address
        /// </summary>
        [DataMember(Name = "clicks")]
        public int Clicks { get; set; }
    }

    /// <summary>
    ///optional - various options for controlling returned data
    /// </summary>
    [DataContract]
    public class ClickDetailOptions : CommonOptions
    {
        /// <summary>
        /// optional the data to sort by - "clicked" (order clicks occurred, default) or "clicks" (total number of opens). Invalid fields will fall back on the default.
        /// </summary>
        [DataMember(Name = "sort_field")]
        public string SortField { get; set; }

        /// <summary>
        /// optional the direct - ASC or DESC. defaults to ASC (case insensitive)
        /// </summary>
        [DataMember(Name = "sort_dir")]
        public string SortDirection { get; set; }

    }
}
