using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.Lists
{
    [DataContract]
    public class MergeVarResult
    {
        /// <summary>
        /// The number of subscribers successfully found on the list
        /// </summary>
        [DataMember(Name = "success_count")]
        public int SuccessCount
        {
            get;
            set;
        }

        /// <summary>
        /// The number of subscribers who were not found on the list
        /// </summary>
        [DataMember(Name = "error_count")]
        public int ErrorCount
        {
            get;
            set;
        }

        /// <summary>
        ///LList of each merge var
        /// </summary>
        [DataMember(Name = "data")]
        public List<MergeVarListResult> Data
        {
            get;
            set;
        }

        /// <summary>
        /// List of errors
        /// </summary>
        [DataMember(Name = "errors")]
        public List<MergeVarError> Errors
        {
            get;
            set;
        }
    }
}
