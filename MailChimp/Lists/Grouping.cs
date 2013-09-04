using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.Lists
{
    /// <summary>
    /// Interest grouping
    /// </summary>
    [DataContract]
    public class Grouping
    {
        /// <summary>
        /// Grouping "id" from lists/interest-groupings (either this or name must be present) - 
        /// this id takes precedence and can't change (unlike the name)
        /// </summary>
        [DataMember(Name = "id")]
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// Grouping "name" from lists/interest-groupings (either this or id must be present)
        /// </summary>
        [DataMember(Name = "name")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// an array of valid group names for this grouping.
        /// </summary>
        [DataMember(Name = "groups")]
        public List<string> GroupNames
        {
            get;
            set;
        }
    }
}
