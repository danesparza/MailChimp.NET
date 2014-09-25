using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.Ecomm
{
    [DataContract]
    public class Order
    {
        [DataMember(Name = "id")]
        public string Id
        {
            get;
            set;
        }

        [DataMember(Name = "campaign_id")]
        public string CampaignId
        {
            get;
            set;
        }

        [DataMember(Name = "email_id")]
        public string EmailId
        {
            get;
            set;
        }

        [DataMember(Name = "email")]
        public string Email
        {
            get;
            set;
        }

        [DataMember(Name = "total")]
        public double Total
        {
            get;
            set;
        }

        [DataMember(Name = "order_date")]
        public string OrderDate
        {
            get;
            set;
        }

        [DataMember(Name = "shipping")]
        public double Shipping
        {
            get;
            set;
        }

        [DataMember(Name = "tax")]
        public double Tax
        {
            get;
            set;
        }

        [DataMember(Name = "store_id")]
        public string StoreId
        {
            get;
            set;
        }

        [DataMember(Name = "store_name")]
        public string StoreName
        {
            get;
            set;
        }

        [DataMember(Name = "items")]
        public List<OrderItem> Items
        {
            get;
            set;
        }
    }
}
