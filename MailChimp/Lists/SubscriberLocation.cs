using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Lists
{
    [DataContract]
    public class SubscriberLocation
    {
        /// <summary>
        /// the country name
        /// </summary>
        [DataMember(Name = "country")]
        public string Country
        {
            get;
            set;
        }

        /// <summary>
        /// the ISO 3166 2 digit country code
        /// </summary>
        [DataMember(Name = "cc")]
        public string CountryCode
        {
            get;
            set;
        }

        /// <summary>
        /// the percent of subscribers in the country
        /// </summary>
        [DataMember(Name = "percent")]
        public double Percent
        {
            get;
            set;
        }

        /// <summary>
        /// the total number of subscribers in the country
        /// </summary>
        [DataMember(Name = "total")]
        public double Total
        {
            get;
            set;
        }
    }
}
