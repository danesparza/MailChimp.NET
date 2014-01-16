using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MailChimp.Lists
{
    [DataContract]
    public class MemberActivityItem
    {
        /// <summary>
        /// The action type of the activity item (i.e. sub, unsub, etc)
        /// </summary>
        [DataMember(Name = "action")]
        public string Action
        {
            get;
            set;
        }

        /// <summary>
        /// The time and date the action occurred
        /// </summary>
        [DataMember(Name = "timestamp")]
        public string Timestamp
        {
            get;
            set;
        }

        /// <summary>
        /// The url assoicated with the acitivity item
        /// </summary>
        [DataMember(Name = "url")]
        public string Url
        {
            get;
            set;
        }

        /// <summary>
        /// The type of the action. Not every action will have this set.
        /// </summary>
        [DataMember(Name = "type")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>
        /// The campaign id this activity item was associated with.
        /// </summary>
        [DataMember(Name = "campaign_id")]
        public string CampaignId
        {
            get;
            set;
        }
    }
}
