using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Helper
{
    /// <summary>
    /// Represents each order for the account
    /// </summary>
    [DataContract]
    public class Order
    {
        /// <summary>
        /// The order id
        /// </summary>
        [DataMember(Name = "order_id")]
        public int OrderId
        {
            get;
            set;
        }

        /// <summary>
        /// The order type - either "monthly" or "credits"
        /// </summary>
        [DataMember(Name = "type")]
        public string OrderType
        {
            get;
            set;
        }

        /// <summary>
        /// The order amount
        /// </summary>
        [DataMember(Name = "amount")]
        public double Amount
        {
            get;
            set;
        }

        /// <summary>
        /// The order date
        /// </summary>
        [DataMember(Name = "date")]
        public string Date
        {
            get;
            set;
        }

        /// <summary>
        /// The total credits used
        /// </summary>
        [DataMember(Name = "credits_used")]
        public double CreditsUsed
        {
            get;
            set;
        }
    }
}
