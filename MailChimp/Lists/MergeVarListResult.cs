using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.Lists
{
    [DataContract]
    public class MergeVarListResult
    {
        /// <summary>
        /// The list id 
        /// </summary>
        [DataMember(Name = "id")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>
        /// the list name 
        /// </summary>
        [DataMember(Name = "name")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// list of each merge var 
        /// </summary>
        [DataMember(Name = "merge_vars")]
        public List<MergeVarItemResult> MergeVars
        {
            get;
            set;
        }
    }
}
