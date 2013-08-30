using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MailChimp.Campaigns
{
    /// <summary>
    /// For RSS Campaigns 
    /// </summary>
    [DataContract]
    public class CampaignTypeRssOptions
    {
        public CampaignTypeRssOptions()
        {
            Schedule = "daily";
            ScheduledHour = "4";
            ScheduledWeekday = "1";
        }
        /// <summary>
        /// The URL to pull RSS content from - it will be verified and must exist
        /// </summary>
        [DataMember(Name = "url")]
        public string URL
        {
            get;
            set;
        }
        /// <summary>
        /// optional one of "daily", "weekly", "monthly" - defaults to "daily"
        /// </summary>
        [DataMember(Name = "schedule")]
        public string Schedule
        {
            get;
            set;
        }
        /// <summary>
        /// optional an hour between 0 and 24 - default to 4 (4am local time) - applies to all schedule types
        /// </summary>
        [DataMember(Name = "schedule_hour")]
        public string ScheduledHour
        {
            get;
            set;
        }
        /// <summary>
        /// optional for "weekly" only, a number specifying the day of the week to send: 0 (Sunday) - 6 (Saturday) - defaults to 1 (Monday)
        /// </summary>
        [DataMember(Name = "schedule_weedkday")]
        public string ScheduledWeekday
        {
            get;
            set;
        }
        /// <summary>
        ///optional for "monthly" only, a number specifying the day of the month to send (1 - 28) or "last" for the last day of a given month. Defaults to the 1st day of the month
        /// </summary>
        [DataMember(Name = "schedule_monthday")]
        public string ScheduledMonthday
        {
            get;
            set;
        }
        /// <summary>
        ///optional used for "daily" schedules only, an array of the ISO-8601 weekday numbers to send on
        /// </summary>
        [DataMember(Name = "days")]
        public CampaignScheduleDays ScheduledDays
        {
            get;
            set;
        }
      

    }
}
