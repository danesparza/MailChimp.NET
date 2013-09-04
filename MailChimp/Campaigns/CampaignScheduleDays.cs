using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MailChimp.Campaigns
{
    /// <summary>
    /// optional used for "daily" schedules only, an array of the ISO-8601 weekday numbers to send on
    /// </summary>
    [DataContract]
    public class CampaignScheduleDays
    {
        public CampaignScheduleDays()
        {
            Monday = true;
            Tuesday = true;
            Wednesday = true;
            Thursday = true;
            Friday = true;
            Saturday = true;
            Sunday = true;
        }
        /// <summary>
        /// optional Monday, defaults to true
        /// </summary>
        [DataMember(Name = "1")]
        public bool Monday
        {
            get;
            set;
        }
        /// <summary>
        /// optional Tuesday, defaults to true
        /// </summary>
        [DataMember(Name = "2")]
        public bool Tuesday
        {
            get;
            set;
        }
        /// <summary>
        /// optional Wednesday, defaults to true
        /// </summary>
        [DataMember(Name = "3")]
        public bool Wednesday
        {
            get;
            set;
        }
        /// <summary>
        /// optional Thursday, defaults to true
        /// </summary>
        [DataMember(Name = "4")]
        public bool Thursday
        {
            get;
            set;
        }
        /// <summary>
        /// optional Friday, defaults to true
        /// </summary>
        [DataMember(Name = "5")]
        public bool Friday
        {
            get;
            set;
        }
        /// <summary>
        /// optional Saturday, defaults to true
        /// </summary>
        [DataMember(Name = "6")]
        public bool Saturday
        {
            get;
            set;
        }
        /// <summary>
        /// optional Sunday, defaults to true
        /// </summary>
        [DataMember(Name = "7")]
        public bool Sunday
        {
            get;
            set;
        }
    }
}
