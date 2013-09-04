using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MailChimp.Lists
{
    [DataContract]
    public class StaticSegmentActionResult
    {
        /// <summary>
        /// The segment was removed
        /// </summary>
        [DataMember(Name = "complete")]
        public bool Complete
        {
            get;
            set;
        }
    }
}
