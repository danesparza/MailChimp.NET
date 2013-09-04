using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MailChimp.Templates
{
    /// <summary>
    /// Template Information
    /// </summary>
    [DataContract]
    public class TemplateListInfo
    {
        /// <summary>
        /// Id of the template
        /// </summary>
        [DataMember(Name="id")]
        public int TemplateID
        {
            get;
            set;
        }
        /// <summary>
        /// Name of the template
        /// </summary>
        [DataMember(Name = "name")]
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// General description of the layout of the template
        /// </summary>
        [DataMember(Name = "layout")]
        public string Layout
        {
            get;
            set;
        }
        /// <summary>
        /// The category for the template, if there is one.
        /// </summary>
        [DataMember(Name = "category")]
        public string Category
        {
            get;
            set;
        }
        /// <summary>
        /// If we've generated it, the url of the preview image for the template. 
        /// We do out best to keep these up to date, but Preview image urls are not guaranteed to be available
        /// </summary>
        [DataMember(Name = "preview_image")]
        public string PreviewImageUrl
        {
            get;
            set;
        }
        /// <summary>
        /// The date/time the template was created
        /// </summary>
        [DataMember(Name="date_created")]
        public string DateCreated
        {
            get;
            set;
        }
        /// <summary>
        /// whether or not the template is active and available for use.
        /// </summary>
        [DataMember(Name = "active")]
        public bool Active
        {
            get;
            set;
        }
        /// <summary>
        /// Whether or not you are able to edit the source of a template.
        /// </summary>
        [DataMember(Name = "edit_source")]
        public bool EditSource
        {
            get;
            set;
        }
        /// <summary>
        /// if it's in one, the folder id -only included in User templates
        /// </summary>
        [DataMember(Name = "folder_id")]
        public int FolderId
        {
            get;
            set;
        }


    }
}
