using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MailChimp.Campaigns
{
    /// <summary>
    /// For AutoResponder campaigns
    /// </summary>
    [DataContract]
    public class CampaignTypeAutoResponderOptions
    {
        /// <summary>
        /// one of "hourly", "day", "week", "month", "year" - required
        /// </summary>
        [DataMember(Name="offset-units")]
        public string OffsetUnits
        {
            get;
            set;
        }
        /// <summary>
        /// optional, sort of - the number of units must be a number greater than 0 for signup based autoresponders, ignored for "hourly"
        /// </summary>
        [DataMember(Name = "offset-time")]
        public string OffsetTime
        {
            get;
            set;
        }
        /// <summary>
        /// either "before" or "after", ignored for "hourly"
        /// </summary>
        [DataMember(Name = "offset-dir")]
        public string OffsetDir
        {
            get;
            set;
        }
        /// <summary>
        /// optional "signup" (default) to base this members added to a list, "date", "annual", or "birthday" to base this on merge field in the list,
        /// "campaignOpen" or "campaignClicka" to base this on any activity for a campaign, 
        /// "campaignClicko" to base this on clicks on a specific URL in a campaign, 
        /// "mergeChanged" to base this on a specific merge field being changed to a specific value
        /// </summary>
        [DataMember(Name = "event")]
        public string Event
        {
            get;
            set;
        }
        /// <summary>
        /// optional sort of, this is required if the event is "date", "annual", "birthday", or "mergeChanged"
        /// </summary>
        [DataMember(Name = "event-datemerge")]
        public string EventDateMerge
        {
            get;
            set;
        }
        /// <summary>
        /// optional sort of, required for "campaignOpen", "campaignClicka", or "campaignClicko"
        /// </summary>
        [DataMember(Name = "campaign_id")]
        public string CampaignID
        {
            get;
            set;
        }
        /// <summary>
        /// optional sort of, required for "campaignClicko"
        /// </summary>
        [DataMember(Name = "campaign_url")]
        public string CampaignUrl
        {
            get;
            set;
        }
        /// <summary>
        ///The hour of the day - 24 hour format in GMT - the autoresponder should be triggered, ignored for "hourly"
        /// </summary>
        [DataMember(Name = "schedule_hour")]
        public string ScheduledHour
        {
            get;
            set;
        }
        /// <summary>
        ///whether or not imported subscribers (ie, any non-double optin subscribers) will receive
        /// </summary>
        [DataMember(Name = "schedule_hour")]
        public bool UseImportTime
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
