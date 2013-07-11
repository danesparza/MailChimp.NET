using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Lists
{
    /// <summary>
    /// Member geographic information (if present)
    /// </summary>
    [DataContract]
    public class MemberGeo
    {
        /// <summary>
        /// the latitude
        /// </summary>
        [DataMember(Name = "latitude")]
        public string Latitude
        {
            get;
            set;
        }

        /// <summary>
        /// the longitude
        /// </summary>
        [DataMember(Name = "longitude")]
        public string Longitude
        {
            get;
            set;
        }

        /// <summary>
        /// GMT offset
        /// </summary>
        [DataMember(Name = "gmtoff")]
        public string GMTOffset
        {
            get;
            set;
        }

        /// <summary>
        /// GMT offset during daylight savings (if DST not observered, will be same as gmtoff)
        /// </summary>
        [DataMember(Name = "dstoff")]
        public string DSTOffset
        {
            get;
            set;
        }

        /// <summary>
        /// the timezone we've place them in
        /// </summary>
        [DataMember(Name = "timezone")]
        public string Timezone
        {
            get;
            set;
        }

        /// <summary>
        /// 2 digit ISO-3166 country code
        /// </summary>
        [DataMember(Name = "cc")]
        public string CountryCode
        {
            get;
            set;
        }

        /// <summary>
        /// generally state, province, or similar
        /// </summary>
        [DataMember(Name = "region")]
        public string Region
        {
            get;
            set;
        }
    }
}
