using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Campaigns
{
    [DataContract]
    public class Campaign
    {
        /// <summary>
        /// Campaign Id (used for all other campaign functions)
        /// </summary>
        [DataMember(Name="")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>
        /// The Campaign id used in our web app, allows you to create a link directly to it
        /// </summary>
        [DataMember(Name = "")]
        public int WebId
        {
            get;
            set;
        }

        /// <summary>
        /// The List used for this campaign
        /// </summary>
        [DataMember(Name = "")]
        public string ListId
        {
            get;
            set;
        }

        /// <summary>
        /// The Folder this campaign is in
        /// </summary>
        [DataMember(Name = "")]
        public int FolderId
        {
            get;
            set;
        }

        /// <summary>
        /// The Template this campaign uses
        /// </summary>
        [DataMember(Name = "")]
        public int TemplateId
        {
            get;
            set;
        }

        /// <summary>
        /// How the campaign's content is put together - one of 'template', 'html', 'url'
        /// </summary>
        [DataMember(Name = "")]
        public string ContentType
        {
            get;
            set;
        }

        /// <summary>
        /// Title of the campaign
        /// </summary>
        [DataMember(Name = "")]
        public string Title
        {
            get;
            set;
        }

        /// <summary>
        /// The type of campaign this is (regular,plaintext,absplit,rss,inspection,auto)
        /// </summary>
        [DataMember(Name = "")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>
        /// Creation time for the campaign
        /// </summary>
        [DataMember(Name = "")]
        public string CreateTime
        {
            get;
            set;
        }

        /// <summary>
        /// Send time for the campaign - also the scheduled time for scheduled campaigns.
        /// </summary>
        [DataMember(Name = "")]
        public string SendTime
        {
            get;
            set;
        }

        /// <summary>
        /// Number of emails email was sent to
        /// </summary>
        [DataMember(Name = "")]
        public int EmailsSent
        {
            get;
            set;
        }

        /// <summary>
        /// Status of the given campaign (save,paused,schedule,sending,sent)
        /// </summary>
        [DataMember(Name = "")]
        public string Status
        {
            get;
            set;
        }

        /// <summary>
        /// From name of the given campaign
        /// </summary>
        [DataMember(Name = "")]
        public string FromName
        {
            get;
            set;
        }

        /// <summary>
        /// Reply-to email of the given campaign
        /// </summary>
        [DataMember(Name = "")]
        public string FromEmail
        {
            get;
            set;
        }

        /// <summary>
        /// Subject of the given campaign
        /// </summary>
        [DataMember(Name = "")]
        public string Subject
        {
            get;
            set;
        }

        /// <summary>
        /// Custom "To:" email string using merge variables
        /// </summary>
        [DataMember(Name = "")]
        public string ToName
        {
            get;
            set;
        }

        /// <summary>
        /// Archive link for the given campaign
        /// </summary>
        [DataMember(Name = "")]
        public string ArchiveUrl
        {
            get;
            set;
        }

        /// <summary>
        /// Whether or not the campaign content's css was auto-inlined
        /// </summary>
        [DataMember(Name = "")]
        public bool InlineCSS
        {
            get;
            set;
        }

        /// <summary>
        /// Either "google" if enabled or "N" if disabled
        /// </summary>
        [DataMember(Name = "")]
        public string Analytics
        {
            get;
            set;
        }

        /// <summary>
        /// The name/tag the campaign's links were tagged with if analytics were enabled.
        /// </summary>
        [DataMember(Name = "")]
        public string AnalyticsTag
        {
            get;
            set;
        }

        /// <summary>
        /// Whether or not the campaign was authenticated
        /// </summary>
        [DataMember(Name = "")]
        public bool Authenticate
        {
            get;
            set;
        }

        /// <summary>
        /// Whether or not ecomm360 tracking was appended to links
        /// </summary>
        [DataMember(Name = "")]
        public bool Ecomm360
        {
            get;
            set;
        }

        /// <summary>
        /// Whether or not the campaign was auto tweeted after sending
        /// </summary>
        [DataMember(Name = "")]
        public bool AutoTweet
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "")]
        public string AutoFacebookPost
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "")]
        public bool AutoFooter
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "")]
        public bool Timewarp
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "")]
        public string TimewarpSchedule
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "")]
        public string ParentId
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember(Name = "")]
        public string SegmentText
        {
            get;
            set;
        }
    }
}
