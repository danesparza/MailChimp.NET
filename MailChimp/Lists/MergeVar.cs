using System.Collections.Generic;
using System.Runtime.Serialization;


namespace MailChimp.Lists
{
    /// <summary>
    /// optional merges for the email (FNAME, LNAME, etc.) 
    /// Note that a merge field can only hold up to 255 bytes. Also, there are a few "special" keys
    /// </summary>
    [DataContract]
    public class MergeVar
    {
        /// <summary>
        /// set this to change the email address. This is only respected on calls using update_existing or 
        /// when passed to listUpdateMember().
        /// </summary>
        [DataMember(Name = "new-email")]
        public string NewEmail
        {
            get;
            set;
        }

        /// <summary>
        /// Interest Groupings 
        /// </summary>
        [DataMember(Name = "groupings")]
        public List<Grouping> Groupings
        {
            get;
            set;
        }

        /// <summary>
        /// Set the Opt-in IP field. Abusing this may cause your account to 
        /// be suspended. We do validate this and it must not 
        /// be a private IP address.
        /// </summary>
        [DataMember(Name = "optin_ip")]
        public string OptInIP
        {
            get;
            set;
        }

        /// <summary>
        /// Set the Opt-in Time field. Abusing this may cause your account to be 
        /// suspended. We do validate this and it must be a valid date. 
        /// Use - 24 hour format in GMT, eg "2013-12-30 20:30:00" to be safe. 
        /// Generally, though, anything strtotime() understands we'll understand - http://us2.php.net/strtotime
        /// </summary>
        [DataMember(Name = "optin_time")]
        public string OptInTime
        {
            get;
            set;
        }

        /// <summary>
        /// Set the member's geographic location either by optin_ip or geo data.
        /// </summary>
        [DataMember(Name = "mc_location")]
        public MCLocation LocationData
        {
            get;
            set;
        }

        /// <summary>
        /// Set the member's language preference. Supported codes are fully 
        /// case-sensitive and can be found here: 
        /// http://kb.mailchimp.com/article/can-i-see-what-languages-my-subscribers-use#code
        /// </summary>
        [DataMember(Name = "mc_language")]
        public string Language
        {
            get;
            set;
        }

        /// <summary>
        /// List of notes
        /// </summary>
        [DataMember(Name = "mc_notes")]
        public List<MCNote> Notes
        {
            get;
            set;
        }

    }
}
