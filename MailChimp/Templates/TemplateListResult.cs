using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.Templates
{
    /// <summary>
    /// Retrieve various templates available in the system, allowing some thing similar to our template gallery to be created.
    /// </summary>
    [DataContract]
    public class TemplateListResult
    {
        /// <summary>
        /// matching user templates
        /// </summary>
        [DataMember(Name="user")]
        public List<TemplateListInfo> UserTemplates
        {
            get;
            set;
        }
        /// <summary>
        /// matching Gallery templates
        /// </summary>
        [DataMember(Name = "gallery")]
        public List<TemplateListInfo> GalleryTemplates
        {
            get;
            set;
        }
        /// <summary>
        /// matching Base templates
        /// </summary>
        [DataMember(Name = "base")]
        public List<TemplateListInfo> BaseTemplates
        {
            get;
            set;
        }
    }
}
