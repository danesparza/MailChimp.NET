using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Lists
{
    /// <summary>
    /// Information about a given list
    /// </summary>
    [DataContract]
    public class ListInfo
    {
        /// <summary>
        /// The list id for this list. This will be used for all other list management functions.
        /// </summary>
        [DataMember(Name = "id")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>
        /// The list id used in our web app, allows you to create a link directly to it
        /// </summary>
        [DataMember(Name = "web_id")]
        public int WebId
        {
            get;
            set;
        }

        /// <summary>
        /// The name of the list.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// The date that this list was created.
        /// </summary>
        [DataMember(Name = "date_created")]
        public string DateCreated
        {
            get;
            set;
        }

        /// <summary>
        /// Whether or not the List supports multiple formats for emails or just HTML
        /// </summary>
        [DataMember(Name = "email_type_option")]
        public bool EmailTypeOption
        {
            get;
            set;
        }

        /// <summary>
        /// Whether or not campaigns for this list use the Awesome Bar in archives by default
        /// </summary>
        [DataMember(Name = "use_awesomebar")]
        public bool UseAwesomebar
        {
            get;
            set;
        }

        /// <summary>
        /// Default From Name for campaigns using this list
        /// </summary>
        [DataMember(Name = "default_from_name")]
        public string DefaultFromName
        {
            get;
            set;
        }

        /// <summary>
        /// Default From Email for campaigns using this list
        /// </summary>
        [DataMember(Name = "default_from_email")]
        public string DefaultFromEmail
        {
            get;
            set;
        }

        /// <summary>
        /// Default Subject Line for campaigns using this list
        /// </summary>
        [DataMember(Name = "default_subject")]
        public string DefaultSubject
        {
            get;
            set;
        }

        /// <summary>
        /// Default Language for this list's forms
        /// </summary>
        [DataMember(Name = "default_language")]
        public string DefaultLanguage
        {
            get;
            set;
        }

        /// <summary>
        /// An auto-generated activity score for the list (0 - 5)
        /// </summary>
        [DataMember(Name = "list_rating")]
        public double ListRating
        {
            get;
            set;
        }

        /// <summary>
        /// Our eepurl shortened version of this list's subscribe form (will not change)
        /// </summary>
        [DataMember(Name = "subscribe_url_short")]
        public string SubscribeUrlShort
        {
            get;
            set;
        }

        /// <summary>
        /// The full version of this list's subscribe form (host will vary)
        /// </summary>
        [DataMember(Name = "subscribe_url_long")]
        public string SubscribeUrlLong
        {
            get;
            set;
        }

        /// <summary>
        /// The email address to use for this list's <a href="http://kb.mailchimp.com/article/how-do-i-import-a-campaign-via-email-email-beamer/">Email Beamer</a>
        /// </summary>
        [DataMember(Name = "beamer_address")]
        public string BeamerAddress
        {
            get;
            set;
        }

        /// <summary>
        /// Whether this list is Public (pub) or Private (prv). Used internally for projects like <a href="http://blog.mailchimp.com/introducing-wavelength/" target="_blank">Wavelength</a>
        /// </summary>
        [DataMember(Name = "visibility")]
        public string Visibility
        {
            get;
            set;
        }

    }
}
