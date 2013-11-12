using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.Helper
{
    [DataContract]
    public class Matches
    {
        /// <summary>
        /// containing the total matches and current results
        /// </summary>
        [DataMember(Name = "exact_matches")]
        public Match ExactMatches
        {
            get;
            set;
        }

        /// <summary>
        /// containing the total matches and current results
        /// </summary>
        [DataMember(Name = "full_search")]
        public Match FullSearch
        {
            get;
            set;
        }
    }
}

