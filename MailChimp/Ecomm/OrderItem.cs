using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.Ecomm
{
    [DataContract]
    public class OrderItem
    {
        [DataMember(Name = "line_num")]
        public int LineNumber
        {
            get;
            set;
        }

        [DataMember(Name = "product_id")]
        public int ProductId
        {
            get;
            set;
        }

        [DataMember(Name = "sku")]
        public string SKU
        {
            get;
            set;
        }

        [DataMember(Name = "product_name")]
        public string ProductName
        {
            get;
            set;
        }

        [DataMember(Name = "category_id")]
        public int CategoryId
        {
            get;
            set;
        }

        [DataMember(Name = "category_name")]
        public string CategoryName
        {
            get;
            set;
        }

        [DataMember(Name = "qty")]
        public double Quantity
        {
            get;
            set;
        }

        [DataMember(Name = "cost")]
        public double Cost
        {
            get;
            set;
        }

    }
}
