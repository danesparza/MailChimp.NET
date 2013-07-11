using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Lists
{
    [DataContract]
    public class MembersResult
    {
        /// <summary>
        /// the total matching records
        /// </summary>
        [DataMember(Name = "total")]
        public int Total
        {
            get;
            set;
        }

        /// <summary>
        /// The list of members
        /// </summary>
        [DataMember(Name = "data")]
        public List<MemberInfo> Data
        {
            get;
            set;
        }
    }
}
