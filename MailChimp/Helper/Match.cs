using System.Collections.Generic;
using System.Runtime.Serialization;
using MailChimp.Lists;

namespace MailChimp.Helper
{
    [DataContract]
    public class Match
    {
        /// <summary>
        /// total members matching
        /// </summary>
        [DataMember(Name = "total")]
        public int Total
        {
            get;
            set;
        }

        /// <summary>
        /// each entry will be struct matching the data format for a single member as returned by lists/member-info()
        /// </summary>
        [DataMember(Name = "members")]
        public List<MemberInfo> Members
        {
            get;
            set;
        }
    }
}
