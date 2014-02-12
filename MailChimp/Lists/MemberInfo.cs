using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.Lists
{
    /// <summary>
    /// List member information
    /// </summary>
    [DataContract]
    public class MemberInfo
    {
        /// <summary>
        /// The unique id (euid) for this email address on an account
        /// </summary>
        [DataMember(Name = "id")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>
        /// The email address associated with this record
        /// </summary>
        [DataMember(Name = "email")]
        public string Email
        {
            get;
            set;
        }

        /// <summary>
        /// The type of emails this customer asked to get: html or text
        /// </summary>
        [DataMember(Name = "email_type")]
        public string EmailType
        {
            get;
            set;
        }

        /// <summary>
        /// The subscription status for this email address, either pending, subscribed, unsubscribed, or cleaned
        /// </summary>
        [DataMember(Name = "status")]
        public string Status
        {
            get;
            set;
        }

        /// <summary>
        /// IP Address this address signed up from. This may be blank if single optin is used.
        /// </summary>
        [DataMember(Name = "ip_signup")]
        public string IPSignup
        {
            get;
            set;
        }

        /// <summary>
        /// The date/time the double optin was initiated. This may be blank if single optin is used.
        /// </summary>
        [DataMember(Name = "timestamp_signup")]
        public string TimestampSignup
        {
            get;
            set;
        }

        /// <summary>
        /// IP Address this address opted in from
        /// </summary>
        [DataMember(Name = "ip_opt")]
        public string IPOptIn
        {
            get;
            set;
        }

        /// <summary>
        /// The date/time the optin completed
        /// </summary>
        [DataMember(Name = "timestamp_opt")]
        public string TimestampOptIn
        {
            get;
            set;
        }

        /// <summary>
        /// the rating of the subscriber. This will be 1 - 5 as described 
        /// <a href="http://eepurl.com/f-2P" target="_blank">here</a>
        /// </summary>
        [DataMember(Name = "member_rating")]
        public int MemberRating
        {
            get;
            set;
        }

        /// <summary>
        /// If the user is unsubscribed and they unsubscribed from a specific campaign, 
        /// that campaign_id will be listed, otherwise this is not returned.
        /// </summary>
        [DataMember(Name = "campaign_id")]
        public string CampaignId
        {
            get;
            set;
        }

        /// <summary>
        /// The date/time this email address entered it's current status
        /// </summary>
        [DataMember(Name = "timestamp")]
        public string Timestamp
        {
            get;
            set;
        }

        /// <summary>
        /// The last time this record was changed. If the record is old enough, this may be blank.
        /// </summary>
        [DataMember(Name = "info_changed")]
        public string InfoChanged
        {
            get;
            set;
        }

        /// <summary>
        /// The Member id used in our web app, allows you to create a link directly to it
        /// </summary>
        [DataMember(Name = "web_id")]
        public int WebId
        {
            get;
            set;
        }

        /// <summary>
        /// The Member id used in our web app, allows you to create a link directly to it
        /// </summary>
        [DataMember(Name = "leid")]
        public int LEId
        {
            get;
            set;
        }

        /// <summary>
        /// The list id the for the member record being returned
        /// </summary>
        [DataMember(Name = "list_id")]
        public string ListId
        {
            get;
            set;
        }

        /// <summary>
        /// The list name the for the member record being returned
        /// </summary>
        [DataMember(Name = "list_name")]
        public string ListName
        {
            get;
            set;
        }

        /// <summary>
        /// if set/detected, a language code from <a href="http://kb.mailchimp.com/article/can-i-see-what-languages-my-subscribers-use#code" target="_blank">here</a>
        /// </summary>
        [DataMember(Name = "language")]
        public string Language
        {
            get;
            set;
        }

        /// <summary>
        /// Whether the member is a <a href="http://mailchimp.com/features/golden-monkeys/" target="_blank">Golden Monkey</a> or not.
        /// </summary>
        [DataMember(Name = "is_gmonkey")]
        public bool IsGoldenMonkey
        {
            get;
            set;
        }

        /// <summary>
        /// the geographic information if we have it
        /// </summary>
        [DataMember(Name = "geo")]
        public MemberGeo GeoData
        {
            get;
            set;
        }

        /// <summary>
        /// the client we've tracked the address as using
        /// </summary>
        [DataMember(Name = "clients")]
        public Client ClientInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Static segments this member belongs to
        /// </summary>
        [DataMember(Name = "static_segments")]
        public List<StaticSegment> StaticSegments {
            get;
            set;
        }

        /// <summary>
        /// Notes entered for this member
        /// </summary>
        [DataMember(Name = "notes")]
        public List<MemberNote> Notes
        {
            get;
            set;
        }

        [DataMember(Name = "merges")]
        public MemberMergeInfo MemberMergeInfo { get; set; }

    }
    
    [DataContract]
    public class MemberMergeInfo
    {
        [DataMember(Name = "EMAIL")]
        public string Email { get; set; }

        [DataMember(Name = "FNAME")]
        public string FirstName { get; set; }

        [DataMember(Name = "LNAME")]
        public string LastName { get; set; }

        [DataMember(Name = "GROUPINGS")]
        public List<MemberGroup> Groups { get; set; }

        [DataContract]
        public class MemberGroup
        {
            [DataMember(Name = "name")]
            public string Name { get; set; }

            [DataMember(Name = "groups")]
            public List<MemberInterestGroups> Groups { get; set; }

            [DataContract]
            public class MemberInterestGroups
            {
                [DataMember(Name = "name")]
                public string Name { get; set; }

                [DataMember(Name = "interested")]
                public bool Interested { get; set; }
            }
        }
    }
}
