using System.Runtime.Serialization;

namespace MailChimp.Templates
{
    /// <summary>
    /// optional - optional options to control how inactive templates are returned, if at all
    /// </summary>
    [DataContract]
    public class TemplateFilters
    {
        /// <summary>
        /// optional for Gallery templates only, limit to a specific template category
        /// </summary>
        [DataMember(Name = "category")]
        public string Category
        {
            get;
            set;
        }
        /// <summary>
        /// user templates, limit to this folder_id
        /// </summary>
        [DataMember(Name = "folder_id")]
        public string FolderID
        {
            get;
            set;
        }
        /// <summary>
        /// user templates are not deleted, only set inactive. defaults to false.
        /// </summary>
        [DataMember(Name = "include_inactive")]
        public bool IncludeInactive
        {
            get;
            set;
        }
        /// <summary>
        /// only include inactive user templates. defaults to false.
        /// </summary>
        [DataMember(Name = "inactive_only")]
        public bool InactiveOnly
        {
            get;
            set;
        }

        /// <summary>
        /// Include templates created and saved using the new Drag & Drop editor. 
        /// Note: You will not be able to edit or create new drag & drop templates via this API. 
        /// This is useful only for creating a new campaign based on a drag & drop template.
        /// </summary>
        [DataMember(Name = "include_drag_and_drop")]
        public bool IncludeDragAndDrop
        {
            get;
            set;
        }
    }
}
