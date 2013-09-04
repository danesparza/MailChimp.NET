using System.Runtime.Serialization;

namespace MailChimp.Helper
{
    /// <summary>
    /// Contact details for the account
    /// </summary>
    [DataContract]
    public class Contact
    {
        /// <summary>
        /// First Name
        /// </summary>
        [DataMember(Name = "fname")]
        public string FirstName
        {
            get;
            set;
        }

        /// <summary>
        /// Last Name
        /// </summary>
        [DataMember(Name = "lname")]
        public string LastName
        {
            get;
            set;
        }

        /// <summary>
        /// Email Address
        /// </summary>
        [DataMember(Name = "email")]
        public string Email
        {
            get;
            set;
        }

        /// <summary>
        /// Company Name
        /// </summary>
        [DataMember(Name = "company")]
        public string Company
        {
            get;
            set;
        }

        /// <summary>
        /// Address Line 1
        /// </summary>
        [DataMember(Name = "address1")]
        public string Address1
        {
            get;
            set;
        }

        /// <summary>
        /// Address Line 2
        /// </summary>
        [DataMember(Name = "address2")]
        public string Address2
        {
            get;
            set;
        }

        /// <summary>
        /// City
        /// </summary>
        [DataMember(Name = "city")]
        public string City
        {
            get;
            set;
        }

        /// <summary>
        /// State or Province
        /// </summary>
        [DataMember(Name = "state")]
        public string State
        {
            get;
            set;
        }

        /// <summary>
        /// Zip or Postal Code
        /// </summary>
        [DataMember(Name = "zip")]
        public string Zip
        {
            get;
            set;
        }

        /// <summary>
        /// Country name
        /// </summary>
        [DataMember(Name = "country")]
        public string Country
        {
            get;
            set;
        }

        /// <summary>
        /// Website URL
        /// </summary>
        [DataMember(Name = "url")]
        public string Url
        {
            get;
            set;
        }

        /// <summary>
        /// Phone number
        /// </summary>
        [DataMember(Name = "phone")]
        public string Phone
        {
            get;
            set;
        }

        /// <summary>
        /// Fax number
        /// </summary>
        [DataMember(Name = "fax")]
        public string Fax
        {
            get;
            set;
        }

    }
}
