using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.Helper
{
    /// <summary>
    /// Account information including payments made, plan info, 
    /// some account stats, installed modules, contact info, and more. No private 
    /// information like Credit Card numbers is available.
    /// More information: http://apidocs.mailchimp.com/api/2.0/helper/account-details.php
    /// </summary>
    [DataContract]
    public class AccountDetails
    {
        /// <summary>
        /// The Account username
        /// </summary>
        [DataMember(Name = "username")]
        public string Username
        {
            get;
            set;
        }

        /// <summary>
        /// The Account user unique id (for building some links)
        /// </summary>
        [DataMember(Name = "user_id")]
        public string UserId
        {
            get;
            set;
        }

        /// <summary>
        /// Whether the Account is in Trial mode (can only send campaigns to less than 100 emails)
        /// </summary>
        [DataMember(Name = "is_trial")]
        public bool IsTrial
        {
            get;
            set;
        }

        /// <summary>
        /// Whether the Account has been approved for purchases
        /// </summary>
        [DataMember(Name = "is_approved")]
        public bool IsApproved
        {
            get;
            set;
        }

        /// <summary>
        /// Whether the Account has been activated
        /// </summary>
        [DataMember(Name = "has_activated")]
        public bool HasActivated
        {
            get;
            set;
        }

        /// <summary>
        /// The timezone for the Account - default is "US/Eastern"
        /// </summary>
        [DataMember(Name = "timezone")]
        public string TimeZone
        {
            get;
            set;
        }

        /// <summary>
        /// Plan Type - "monthly", "payasyougo", or "free"
        /// </summary>
        [DataMember(Name = "plan_type")]
        public string PlanType
        {
            get;
            set;
        }

        /// <summary>
        /// only for Monthly plans - the lower tier for list size
        /// </summary>
        [DataMember(Name = "plan_low")]
        public int PlanLow
        {
            get;
            set;
        }

        /// <summary>
        /// only for Monthly plans - the upper tier for list size
        /// </summary>
        [DataMember(Name = "plan_high")]
        public int PlanHigh
        {
            get;
            set;
        }

        /// <summary>
        /// only for Monthly plans - the start date for a monthly plan
        /// </summary>
        [DataMember(Name = "plan_start_date")]
        public string PlanStartDate
        {
            get;
            set;
        }

        /// <summary>
        /// only for Free and Pay-as-you-go plans - emails credits left for the account
        /// </summary>
        [DataMember(Name = "emails_left")]
        public int EmailsLeft
        {
            get;
            set;
        }

        /// <summary>
        /// Whether the account is finishing Pay As You Go credits before switching to a Monthly plan
        /// </summary>
        [DataMember(Name = "pending_monthly")]
        public bool PendingMonthly
        {
            get;
            set;
        }

        /// <summary>
        /// date of first payment
        /// </summary>
        [DataMember(Name = "first_payment")]
        public string FirstPayment
        {
            get;
            set;
        }

        /// <summary>
        /// date of most recent payment
        /// </summary>
        [DataMember(Name = "last_payment")]
        public string LastPayment
        {
            get;
            set;
        }

        /// <summary>
        /// total number of times the account has been logged into via the web
        /// </summary>
        [DataMember(Name = "times_logged_in")]
        public int TimesLoggedIn
        {
            get;
            set;
        }

        /// <summary>
        /// date/time of last login via the web
        /// </summary>
        [DataMember(Name = "last_login")]
        public string LastLogin
        {
            get;
            set;
        }

        /// <summary>
        /// Monkey Rewards link for our Affiliate program
        /// </summary>
        [DataMember(Name = "affilate_link")]
        public string AffiliateLink
        {
            get;
            set;
        }

        /// <summary>
        /// Contact details for the account
        /// </summary>
        [DataMember(Name = "contact")]
        public Contact ContactInfo
        {
            get;
            set;
        }

        /// <summary>
        /// A list of addon modules installed in the account
        /// </summary>
        [DataMember(Name = "modules")]
        public List<Module> ModuleInfo
        {
            get;
            set;
        }

        /// <summary>
        /// A list of orders for the account
        /// </summary>
        [DataMember(Name = "orders")]
        public List<Order> OrderInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Rewards details for the account including credits and inspections earned, 
        /// number of referrals, referral details, and rewards used
        /// </summary>
        [DataMember(Name = "rewards")]
        public Rewards RewardInfo
        {
            get;
            set;
        }

        /// <summary>
        /// A list of each connected integration that can be used with campaigns
        /// </summary>
        [DataMember(Name = "integrations")]
        public List<Integration> IntegrationInfo
        {
            get;
            set;
        }
    }
}
