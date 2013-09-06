using System.Runtime.Serialization;

namespace MailChimp.Templates
{
    /// <summary>
    /// optional - the types of templates to return
    /// </summary>
    [DataContract]
    public class TemplateTypes
    {
        public TemplateTypes()
        {
            User = true;
            Gallery = false;
            Base = false;
        }
        /// <summary>
        ///Custom templates for this user account. Defaults to true.
        /// </summary>
        [DataMember(Name="user")]
        public bool User
        {
            get;
            set;
        }
        /// <summary>
        ///Templates from our Gallery. Note that some templates that require extra configuration are withheld. (eg, the Etsy template). Defaults to false.
        /// </summary>
        [DataMember(Name = "gallery")]
        public bool Gallery
        {
            get;
            set;
        }
        /// <summary>
        /// Our "start from scratch" extremely basic templates. Defaults to false.
        /// </summary>
        [DataMember(Name = "base")]
        public bool Base
        {
            get;
            set;
        }
    }
}
