using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.Helper
{
    /// <summary>
    /// Send your HTML content to have the CSS inlined and optionally remove the original styles.
    /// More information: http://apidocs.mailchimp.com/api/2.0/helper/inline-css.php
    /// </summary>
    [DataContract]
    public class InlineCss
    {
        /// <summary>
        /// Your HTML content with all CSS inlined, just like if we sent it.
        /// </summary>
        [DataMember(Name = "html")]
        public string Html
        {
            get;
            set;
        }
    }
}
