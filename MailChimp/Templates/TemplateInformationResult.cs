using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MailChimp.Templates
{
    /// <summary>
    /// Info to be used when editing
    /// </summary>
    [DataContract]
    public class TemplateInformationResult
    {
        /// <summary>
        /// The default content broken down into the named editable sections for the template - dependant upon template, so not documented
        /// </summary>
        [DataMember(Name = "default_content")]
        public Dictionary<string,string> DefaultContent
        {
            get;
            set;
        }

        /// <summary>
        /// The valid editable section names - dependant upon template, so not documented
        /// </summary>
        [DataMember(Name = "sections")]
        public Dictionary<string,string> Sections
        {
            get;
            set;
        }

        /// <summary>
        /// The full source of the template as if you exported it via our template editor.
        /// </summary>
        [DataMember(Name = "source")]
        public string Source
        {
            get;
            set;
        }

        [DataMember(Name = "preview")]
        public string Preview
        {
            get;
            set;
        }
    }
}
