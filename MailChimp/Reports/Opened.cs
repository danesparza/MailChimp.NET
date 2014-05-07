using System.Collections.Generic;
using System.Runtime.Serialization;
using MailChimp.Lists;

namespace MailChimp.Reports
{
    /// <summary>
    ///optional - various options for controlling returned data
    /// </summary>
    [DataContract]
    public class OpenedOptions : CommonOptions
    {
        /// <summary>
        /// optional the data to sort by - "opened" (order opens occurred, default) or "opens" (total number of opens). Invalid fields will fall back on the default.
        /// </summary>
        [DataMember(Name = "sort_field")]
        public string SortField { get; set; }

        /// <summary>
        /// optional the direct - ASC or DESC. defaults to ASC (case insensitive)
        /// </summary>
        [DataMember(Name = "sort_dir")]
        public string SortDirection { get; set; }

    }


    /// <summary>
    /// containing the total records matched and the specific records for this page
    /// </summary>
    [DataContract]
    public class Opened
    {
        /// <summary>
        /// the total number of records matched
        /// </summary>
        [DataMember(Name = "total")]
        public int Total { get; set; }

        /// <summary>
        /// structs for the actual opens data, including:
        /// </summary>
        [DataMember(Name = "data")]
        public List<OpenedData> Data { get; set; }
    }

    [DataContract]
    public class OpenedData
    {
        /// <summary>
        /// the member record as returned by lists/member-info()
        /// </summary>
        [DataMember(Name = "member")]
        public MemberInfo Member { get; set; }        

        /// <summary>
        /// Total number of times the campaign was opened by this email address
        /// </summary>
        [DataMember(Name = "opens")]
        public  int Opens { get; set; }
    }
}
