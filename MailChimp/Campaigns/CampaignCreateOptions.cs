using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.Campaigns
{
    [DataContract]
    public class CampaignCreateOptions
    {
        public CampaignCreateOptions()
        {
            //set the default values based upon the documentation
            FacebookComments = true;
            AutoFooter = false;
            InlineCSS = false;
            GenerateText = false;
            AutoTweet = false;
            Ecommerce360Tracking = false;
        }
        /// <summary>
        /// the list to send this campaign to- get lists using lists()
        /// </summary>
        [DataMember(Name="list_id")]
        public string ListId
        {
            get;
            set;
        }
        /// <summary>
        /// the subject line for your campaign message 
        /// </summary>
        [DataMember(Name = "subject")]
        public string Subject
        {
            get;
            set;
        }
        /// <summary>
        /// the From: email address for your campaign message
        /// </summary>
        [DataMember(Name = "from_email")]
        public string FromEmail
        {
            get;
            set;
        }
        /// <summary>
        /// the From: name for your campaign message (not an email address)
        /// </summary>
        [DataMember(Name = "from_name")]
        public string FromName
        {
            get;
            set;
        }
        /// <summary>
        /// the To: name recipients will see (not email address)
        /// </summary>
        [DataMember(Name = "to_name")]
        public string ToName
        {
            get;
            set;
        }
        /// <summary>
        /// optional - use this user-created template to generate the HTML content of the campaign (takes precendence over other template options)
        /// </summary>
        [DataMember(Name = "template_id")]
        public int TemplateID
        {
            get;
            set;
        }
        /// <summary>
        /// optional - use a template from the public gallery to generate the HTML content of the campaign (takes precendence over base template options)
        /// </summary>
        [DataMember(Name = "gallery_template_id")]
        public int GalleryTemplateId
        {
            get;
            set;
        }
        /// <summary>
        /// optional - use a template from the public gallery to generate the HTML content of the campaign (takes precendence over base template options)
        /// </summary>
        [DataMember(Name="gallery_template_id")]
        public int BaseTemplateId
        {
            get;
            set;
        }
        /// <summary>
        ///optional - automatically file the new campaign in the folder_id passed. Get using folders() - note that Campaigns and Autoresponders have separate folder setup
        /// </summary>
        [DataMember(Name="folder_id")]
        public int FolderId
        {
            get;
            set;
        }
        /// <summary>
        ///optional - set which recipient actions will be tracked. Click tracking can not be disabled for Free accounts.
        /// </summary>
        [DataMember(Name="tracking")]
        public CampaignCreateOptions Tracking
        {
            get;
            set;
        }
        /// <summary>
        ///optional - an internal name to use for this campaign. By default, the campaign subject will be used.
        /// </summary>
        [DataMember(Name = "title")]
        public string Title
        {
            get;
            set;
        }
        /// <summary>
        ///optional - set to true to enable SenderID, DomainKeys, and DKIM authentication, defaults to false.
        /// </summary>
        [DataMember(Name = "authenticate")]
        public bool Authenticate
        {
            get;
            set;
        }
        /// <summary>
        ///optional - one or more of these keys set to the tag to use - that can be any custom text (up to 50 bytes)
        /// </summary>
        [DataMember(Name = "analytics")]
        public CampaignAnalyticsOptions Analytics
        {
            get;
            set;
        }
        /// <summary>
        ///optional Whether or not we should auto-generate the footer for your content. Mostly useful for content from URLs or Imports
        /// </summary>
        [DataMember(Name = "auto_footer")]
        public bool AutoFooter
        {
            get;
            set;
        }
        /// <summary>
        /// optional Whether or not css should be automatically inlined when this campaign is sent, defaults to false.
        /// </summary>
        [DataMember(Name = "inline_css")]
        public bool InlineCSS
        {
            get;
            set;
        }
        /// <summary>
        /// optional Whether of not to auto-generate your Text content from the HTML content. Note that this will be ignored if the Text part of the content passed is not empty, defaults to false.
        /// </summary>
        [DataMember(Name = "generate_text")]
        public bool GenerateText
        {
            get;
            set;
        }
        /// <summary>
        /// optional If set, this campaign will be auto-tweeted when it is sent - defaults to false. Note that if a Twitter account isn't linked, this will be silently ignored.
        /// </summary>
        [DataMember(Name = "auto_tweet")]
        public bool AutoTweet
        {
            get;
            set;
        }
        /// <summary>
        /// optional If set, this campaign will be auto-posted to the page_ids contained in the array. If a Facebook account isn't linked or the account does not have permission to post to the page_ids requested, those failures will be silently ignored.
        /// </summary>
        [DataMember(Name = "auto_fb_post")]
        public List<string> AutoFacebookPost
        {
            get;
            set;
        }
        /// <summary>
        /// optional If true, the Facebook comments (and thus the archive bar will be displayed. If false, Facebook comments will not be enable. Defaults to "true".
        /// </summary>
        [DataMember(Name = "fb_comments")]
        public bool FacebookComments
        {
            get;
            set;
        }
        /// <summary>
        /// optional If set, this campaign must be scheduled 24 hours in advance of sending - default to false. Only valid for "regular" campaigns and "absplit" campaigns that split on schedule_time.
        /// </summary>
        [DataMember(Name = "timewarp")]
        public bool Timewarp
        {
            get;
            set;
        }
        /// <summary>
        /// optional If set, our Ecommerce360 tracking will be enabled for links in the campaign
        /// </summary>
        [DataMember(Name = "ecomm360")]
        public bool Ecommerce360Tracking
        {
            get;
            set;
        }
         /// <summary>
        /// optional If set, an array of structs to enable CRM tracking for
        /// 
        /// </summary>
        /// 
        [DataMember(Name="crm_tracking")]
        public object CRMTracking
        {
            get;
            set;
        }

    }
}
