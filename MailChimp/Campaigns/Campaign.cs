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
        [DataMember(Name="id")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>
        /// The Campaign id used in our web app, allows you to create a link directly to it
        /// </summary>
        [DataMember(Name = "web_id")]
        public int WebId
        {
            get;
            set;
        }

        /// <summary>
        /// The List used for this campaign
        /// </summary>
        [DataMember(Name = "list_id")]
        public string ListId
        {
            get;
            set;
        }

        /// <summary>
        /// The Folder this campaign is in
        /// </summary>
        [DataMember(Name = "folder_id")]
        public int FolderId
        {
            get;
            set;
        }

        /// <summary>
        /// The Template this campaign uses
        /// </summary>
        [DataMember(Name = "template_id")]
        public int TemplateId
        {
            get;
            set;
        }

        /// <summary>
        /// How the campaign's content is put together - one of 'template', 'html', 'url'
        /// </summary>
        [DataMember(Name = "content_type")]
        public string ContentType
        {
            get;
            set;
        }

        /// <summary>
        /// Title of the campaign
        /// </summary>
        [DataMember(Name = "title")]
        public string Title
        {
            get;
            set;
        }

        /// <summary>
        /// The type of campaign this is (regular,plaintext,absplit,rss,inspection,auto)
        /// </summary>
        [DataMember(Name = "type")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>
        /// Creation time for the campaign
        /// </summary>
        [DataMember(Name = "create_time")]
        public string CreateTime
        {
            get;
            set;
        }

        /// <summary>
        /// Send time for the campaign - also the scheduled time for scheduled campaigns.
        /// </summary>
        [DataMember(Name = "send_time")]
        public string SendTime
        {
            get;
            set;
        }

        /// <summary>
        /// Number of emails email was sent to
        /// </summary>
        [DataMember(Name = "emails_sent")]
        public int EmailsSent
        {
            get;
            set;
        }

        /// <summary>
        /// Status of the given campaign (save,paused,schedule,sending,sent)
        /// </summary>
        [DataMember(Name = "status")]
        public string Status
        {
            get;
            set;
        }

        /// <summary>
        /// From name of the given campaign
        /// </summary>
        [DataMember(Name = "from_name")]
        public string FromName
        {
            get;
            set;
        }

        /// <summary>
        /// Reply-to email of the given campaign
        /// </summary>
        [DataMember(Name = "from_email")]
        public string FromEmail
        {
            get;
            set;
        }

        /// <summary>
        /// Subject of the given campaign
        /// </summary>
        [DataMember(Name = "subject")]
        public string Subject
        {
            get;
            set;
        }

        /// <summary>
        /// Custom "To:" email string using merge variables
        /// </summary>
        [DataMember(Name = "to_name")]
        public string ToName
        {
            get;
            set;
        }

        /// <summary>
        /// Archive link for the given campaign
        /// </summary>
        [DataMember(Name = "archive_url")]
        public string ArchiveUrl
        {
            get;
            set;
        }

        /// <summary>
        /// Whether or not the campaign content's css was auto-inlined
        /// </summary>
        [DataMember(Name = "inline_css")]
        public bool InlineCSS
        {
            get;
            set;
        }

        /// <summary>
        /// Either "google" if enabled or "N" if disabled
        /// </summary>
        [DataMember(Name = "analytics")]
        public string Analytics
        {
            get;
            set;
        }

        /// <summary>
        /// The name/tag the campaign's links were tagged with if analytics were enabled.
        /// </summary>
        [DataMember(Name = "analytics_tag")]
        public string AnalyticsTag
        {
            get;
            set;
        }

        /// <summary>
        /// Whether or not the campaign was authenticated
        /// </summary>
        [DataMember(Name = "authenticate")]
        public bool Authenticate
        {
            get;
            set;
        }

        /// <summary>
        /// Whether or not ecomm360 tracking was appended to links
        /// </summary>
        [DataMember(Name = "ecomm360")]
        public bool Ecomm360
        {
            get;
            set;
        }

        /// <summary>
        /// Whether or not the campaign was auto tweeted after sending
        /// </summary>
        [DataMember(Name = "auto_tweet")]
        public bool AutoTweet
        {
            get;
            set;
        }

        /// <summary>
        /// A comma delimited list of Facebook Profile/Page Ids the 
        /// campaign was posted to after sending. If not used, blank.
        /// </summary>
        [DataMember(Name = "auto_fb_post")]
        public string AutoFacebookPost
        {
            get;
            set;
        }

        /// <summary>
        /// Whether or not the auto_footer was manually turned on
        /// </summary>
        [DataMember(Name = "auto_footer")]
        public bool AutoFooter
        {
            get;
            set;
        }

        /// <summary>
        /// Whether or not the campaign used Timewarp
        /// </summary>
        [DataMember(Name = "timewarp")]
        public bool Timewarp
        {
            get;
            set;
        }

        /// <summary>
        /// The time, in GMT, that the Timewarp campaign is being sent. 
        /// For A/B Split campaigns, this is blank and is instead in 
        /// their schedule_a and schedule_b in the type_opts array
        /// </summary>
        [DataMember(Name = "timewarp_schedule")]
        public string TimewarpSchedule
        {
            get;
            set;
        }

        /// <summary>
        /// the unique id of the parent campaign 
        /// (currently only valid for rss children)
        /// </summary>
        [DataMember(Name = "parent_id")]
        public string ParentId
        {
            get;
            set;
        }

        /// <summary>
        /// a string marked-up with HTML explaining the segment 
        /// used for the campaign in plain English
        /// </summary>
        [DataMember(Name = "segment_text")]
        public string SegmentText
        {
            get;
            set;
        }

        /// <summary>
        /// total number of comments left on this campaign
        /// </summary>
        [DataMember(Name = "comments_total")]
        public int CommentsTotal
        {
            get;
            set;
        }

        /// <summary>
        /// total number of unread comments for this campaign 
        /// based on the login the apikey belongs to
        /// </summary>
        [DataMember(Name = "comments_unread")]
        public int CommentsUnread
        {
            get;
            set;
        }
    }
}
