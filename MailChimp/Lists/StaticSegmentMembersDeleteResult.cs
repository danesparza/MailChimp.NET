using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.Lists
{
    [DataContract]
   public class StaticSegmentMembersDeleteResult
    {
            /// <summary>
            /// the total number of successful removals
            /// </summary>
            [DataMember(Name = "success_count")]
            public int successCount
            {
                get;
                set;
            }
            /// <summary>
            /// the total number of unsuccessful removals
            /// </summary>
            [DataMember(Name = "error_count")]
            public int errorCount
            {
                get;
                set;
            }
            /// <summary>
            /// Error information
            /// </summary>
            [DataMember(Name = "errors")]
            public List<ListError> Errors
            {
                get;
                set;
            }
        }
}
