using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MailChimp.Templates
{
    /// <summary>
    /// Create a new user template, NOT campaign content. These templates can then be applied while creating campaigns.
    /// </summary>
    [DataContract]
    public class TemplateAddResult
    {
        /// <summary>
        /// The new template id, otherwise an error is thrown.
        /// </summary>
        [DataMember(Name="template_id")]
        public int TemplateId
        {
            get;
            set;
        }
    }
}
