using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Helper
{
    /// <summary>
    /// Retrieve lots of account information including payments made, plan info, 
    /// some account stats, installed modules, contact info, and more. No private 
    /// information like Credit Card numbers is available.
    /// More information: http://apidocs.mailchimp.com/api/2.0/helper/account-details.php
    /// </summary>
    [DataContract]
    public class AccountDetails
    {
        [DataMember(Name = "username")]
        public string Username
        {
            get;
            set;
        }

        [DataMember(Name = "user_id")]
        public string UserId
        {
            get;
            set;
        }

        [DataMember(Name = "is_trial")]
        public bool IsTrial
        {
            get;
            set;
        }

        [DataMember(Name = "is_approved")]
        public bool IsApproved
        {
            get;
            set;
        }

        [DataMember(Name = "has_activated")]
        public bool HasActivated
        {
            get;
            set;
        }

        [DataMember(Name = "plan_type")]
        public string PlanType
        {
            get;
            set;
        }
    }
}
