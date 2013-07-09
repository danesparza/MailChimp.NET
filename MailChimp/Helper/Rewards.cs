using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Helper
{
    /// <summary>
    /// Includes details for the account including credits and
    /// inspections earned, number of referrals, referral details, 
    /// and rewards used
    /// </summary>
    [DataContract]
    public class Rewards
    {
        /// <summary>
        /// the total number of referrals this month
        /// </summary>
        [DataMember(Name = "referrals_this_month")]
        public int ReferralsThisMonth
        {
            get;
            set;
        }

        /// <summary>
        /// whether or not we notify the user when rewards are earned
        /// </summary>
        [DataMember(Name = "notify_on")]
        public string NotifyOn
        {
            get;
            set;
        }

        /// <summary>
        /// the email address address used for rewards notifications
        /// </summary>
        [DataMember(Name = "notify_email")]
        public string NotifyEmail
        {
            get;
            set;
        }

        /// <summary>
        /// Email credits earned
        /// </summary>
        [DataMember(Name = "credits")]
        public RewardEarnings Credits
        {
            get;
            set;
        }

        /// <summary>
        /// Inbox Inspections earned
        /// </summary>
        [DataMember(Name = "inspections")]
        public RewardEarnings Inspections
        {
            get;
            set;
        }

        /// <summary>
        /// A list of referrals
        /// </summary>
        [DataMember(Name = "referrals")]
        public List<RewardReferrals> Referrals
        {
            get;
            set;
        }

        /// <summary>
        /// A list of applied rewards
        /// </summary>
        [DataMember(Name = "applied")]
        public List<RewardApplied> AppliedRewards
        {
            get;
            set;
        }
    }

    /// <summary>
    /// Describes credits / inspections earnings
    /// </summary>
    public class RewardEarnings
    {
        /// <summary>
        /// credits earned this month
        /// </summary>
        [DataMember(Name = "this_month")]
        public int ThisMonth
        {
            get;
            set;
        }

        /// <summary>
        /// credits earned all time
        /// </summary>
        [DataMember(Name = "total_earned")]
        public int TotalEarned
        {
            get;
            set;
        }

        /// <summary>
        /// credits remaining
        /// </summary>
        [DataMember(Name = "remaining")]
        public int Remaining
        {
            get;
            set;
        }
    }

    /// <summary>
    /// Describes each reward referral
    /// </summary>
    public class RewardReferrals
    {
        /// <summary>
        /// the name of the account
        /// </summary>
        [DataMember(Name = "name")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// the email address associated with the account
        /// </summary>
        [DataMember(Name = "email")]
        public string Email
        {
            get;
            set;
        }

        /// <summary>
        /// the signup date for the account
        /// </summary>
        [DataMember(Name = "signup_date")]
        public string SignupDate
        {
            get;
            set;
        }

        /// <summary>
        /// the source for the referral
        /// </summary>
        [DataMember(Name = "type")]
        public string ReferralType
        {
            get;
            set;
        }
    }

    /// <summary>
    /// Describes each applied reward
    /// </summary>
    public class RewardApplied
    {
        /// <summary>
        /// the number of credits user
        /// </summary>
        [DataMember(Name = "value")]
        public int Value
        {
            get;
            set;
        }

        /// <summary>
        /// the date appplied
        /// </summary>
        [DataMember(Name = "date")]
        public string Date
        {
            get;
            set;
        }

        /// <summary>
        /// the order number credits were applied to
        /// </summary>
        [DataMember(Name = "order_id")]
        public int OrderId
        {
            get;
            set;
        }

        /// <summary>
        /// the order description
        /// </summary>
        [DataMember(Name = "order_desc")]
        public string OrderDescription
        {
            get;
            set;
        }
    }
}
