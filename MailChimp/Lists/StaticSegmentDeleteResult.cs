using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MailChimp.Lists
{
    [DataContract]
    public class StaticSegmentDeleteResult
    {
        /// <summary>
        /// The segment was removed
        /// </summary>
        [DataMember(Name = "completed")]
        public bool Completed
        {
            get;
            set;
        }
    }
}
