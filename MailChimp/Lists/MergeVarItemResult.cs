using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.Lists
{
    /// <summary>
    /// result of the operation including valid data and any errors
    /// </summary>
    [DataContract]
    public class MergeVarItemResult
    {
        /// <summary>
        /// Name/description of the merge field 
        /// </summary>
        [DataMember(Name = "name")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Denotes whether the field is required (true) or not (false) 
        /// </summary>
        [DataMember(Name = "req")]
        public bool Required
        {
            get;
            set;
        }

        /// <summary>
        /// The "data type" of this merge var. One of: email, text, number, radio, dropdown, date, 
        /// address, phone, url, imageurl 
        /// </summary>
        [DataMember(Name = "field_type")]
        public string FieldType
        {
            get;
            set;
        }

        /// <summary>
        /// Whether or not this field is visible to list subscribers 
        /// </summary>
        [DataMember(Name = "public")]
        public bool Public
        {
            get;
            set;
        }

        /// <summary>
        /// Whether the field is displayed in thelist dashboard 
        /// </summary>
        [DataMember(Name = "public")]
        public bool Show
        {
            get;
            set;
        }

        /// <summary>
        /// The order this field displays in on forms 
        /// </summary>
        [DataMember(Name = "order")]
        public int Order
        {
            get;
            set;
        }

        /// <summary>
        /// The default value for this field 
        /// </summary>
        [DataMember(Name = "default")]
        public string DefaultValue
        {
            get;
            set;
        }

        /// <summary>
        /// The helptext for this field 
        /// </summary>
        [DataMember(Name = "helptext")]
        public string HelpText
        {
            get;
            set;
        }

        /// <summary>
        /// The width of the field to be used 
        /// </summary>
        [DataMember(Name = "size")]
        public string Size
        {
            get;
            set;
        }

        /// <summary>
        /// The merge tag that's used for forms and lists/subscribe() and lists/update-member() 
        /// </summary>
        [DataMember(Name = "tag")]
        public string Tag
        {
            get;
            set;
        }

        /// <summary>
        /// the options available for radio and dropdown field types 
        /// </summary>
        [DataMember(Name = "choices")]
        public string[] Choices
        {
            get;
            set;
        }
        /// <summary>
        /// an unchanging id for the merge var 
        /// </summary>
        public int Id
        {
            get;
            set;
        }
    }
}
