using System.Runtime.Serialization;
using System.Collections.Generic;

namespace MailChimp.Campaigns
{
    /// <summary>
    /// the content for this campaign - use a struct with the one of the following keys:
    /// </summary>
    [DataContract]
    public class CampaignCreateContent
    {
        /// <summary>
        /// for raw/pasted HTML content
        /// </summary>
        [DataMember(Name="html")]
        public string HTML
        {
            get;
            set;
        }
        /// <summary>
        /// when using a template instead of raw HTML, each key should be the unique mc:edit area name from the template.
        /// </summary>
        [DataMember(Name = "sections")]
        public Dictionary<string, string> Sections
        {
            get;
            set;
        }
        /// <summary>
        /// for the plain-text version
        /// </summary>
        [DataMember(Name = "text")]
        public string Text
        {
            get;
            set;
        }
        /// <summary>
        /// to have us pull in content from a URL. Note, this will override any other content options - for lists with Email Format options, you'll need to turn on generate_text as well
        /// </summary>
        [DataMember(Name = "url")]
        public string Url
        {
            get;
            set;
        }
        /// <summary>
        /// to send a Base64 encoded archive file for us to import all media from. Note, this will override any other content options - for lists with Email Format options, you'll need to turn on generate_text as well
        /// </summary>
        [DataMember(Name = "archive")]
        public string Archive
        {
            get;
            set;
        }
        /// <summary>
        ///optional - only necessary for the "archive" option. Supported formats are: zip, tar.gz, tar.bz2, tar, tgz, tbz . If not included, we will default to zip
        /// </summary>
        [DataMember(Name = "archive_type")]
        public string ArchiveType
        {
            get;
            set;
        }
    }
}
