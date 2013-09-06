using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.Lists
{
    /// <summary>
    /// result of the operation including valid data and any errors
    /// </summary>
    [DataContract]
    public class ListResult
    {
        /// <summary>
        /// the total number of lists which matched the provided filters
        /// </summary>
        [DataMember(Name = "total")]
        public int Total
        {
            get;
            set;
        }

        /// <summary>
        /// lists which matched the provided filters
        /// </summary>
        [DataMember(Name = "data")]
        public List<ListInfo> Data
        {
            get;
            set;
        }
    }
}
