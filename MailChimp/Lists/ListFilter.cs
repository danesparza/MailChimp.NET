using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Lists
{
    /// <summary>
    /// Optional list filters
    /// </summary>
    [DataContract]
    public class ListFilter
    {
        /// <summary>
        /// optional - return a single list using a known list_id. Accepts 
        /// multiples separated by commas when not using exact matching
        /// </summary>
        [DataMember(Name = "list_id")]
        public string ListId
        {
            get;
            set;
        }

        /// <summary>
        /// optional - only lists that match this name
        /// </summary>
        [DataMember(Name = "list_name")]
        public string ListName
        {
            get;
            set;
        }

        /// <summary>
        /// optional - only lists that have a default from name matching this
        /// </summary>
        [DataMember(Name = "from_name")]
        public string FromName
        {
            get;
            set;
        }

        /// <summary>
        /// optional - only lists that have a default from email matching this
        /// </summary>
        [DataMember(Name = "from_email")]
        public string FromEmail
        {
            get;
            set;
        }

        /// <summary>
        /// optional - only lists that have a default from email matching this
        /// </summary>
        [DataMember(Name = "from_subject")]
        public string FromSubject
        {
            get;
            set;
        }

        /// <summary>
        /// optional - only show lists that were created before this date/time - 
        /// 24 hour format in GMT, eg "2013-12-30 20:30:00"
        /// </summary>
        [DataMember(Name = "created_before")]
        public string CreatedBefore
        {
            get;
            set;
        }

        /// <summary>
        /// optional - only show lists that were created since this date/time - 
        /// 24 hour format in GMT, eg "2013-12-30 20:30:00"
        /// </summary>
        [DataMember(Name = "created_after")]
        public string CreatedAfter
        {
            get;
            set;
        }

        /// <summary>
        /// optional - flag for whether to filter on exact values when filtering, 
        /// or search within content for filter values - defaults to true
        /// </summary>
        [DataMember(Name = "exact")]
        public bool Exact
        {
            get;
            set;
        }
    }
}
