using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Lists
{
    [DataContract]
    public class ListActivity
    {
        [DataMember(Name = "user_id")]
        public string UserId
        {
            get;
            set;
        }

        [DataMember(Name = "day")]
        public string Date
        {
            get;
            set;
        }

        [DataMember(Name = "emails_sent")]
        public int EmailSent
        {
            get;
            set;
        }

        [DataMember(Name = "unique_opens")]
        public int UniqueOpens
        {
            get;
            set;
        }

        [DataMember(Name = "recipient_clicks")]
        public int RecipientClicks
        {
            get;
            set;
        }

        [DataMember(Name = "hard_bounce")]
        public int HardBounce
        {
            get;
            set;
        }

        [DataMember(Name = "soft_bounce")]
        public int SoftBounce
        {
            get;
            set;
        }

        [DataMember(Name = "abuse_reports")]
        public int AbuseReports
        {
            get;
            set;
        }

        [DataMember(Name = "subs")]
        public int Subscriptions
        {
            get;
            set;
        }

        [DataMember(Name = "unsubs")]
        public int Unsubscriptions
        {
            get;
            set;
        }

        [DataMember(Name = "other_adds")]
        public int OtherAdds
        {
            get;
            set;
        }

        [DataMember(Name = "other_removes")]
        public int OtherRemoves
        {
            get;
            set;
        }
    }
}
