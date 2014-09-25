using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.Ecomm
{
    [DataContract]
    public class OrderResult
    {
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

        [DataMember(Name = "order_id")]
        public string OrderId
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

        [DataMember(Name = "order_total")]
        public double OrderTotal
        {
            get;
            set;
        }

        [DataMember(Name = "tax_total")]
        public double TaxTotal
        {
            get;
            set;
        }

        [DataMember(Name = "ship_total")]
        public double ShipTotal
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

        [DataMember(Name = "items")]
        public List<OrderItemResult> Items
        {
            get;
            set;
        }

    }
}
