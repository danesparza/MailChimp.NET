using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.Ecomm
{
    [DataContract]
    public class OrderItemResult
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

        [DataMember(Name = "product_name")]
        public string ProductName
        {
            get;
            set;
        }

        [DataMember(Name = "product_sku")]
        public string ProductSKU
        {
            get;
            set;
        }

        [DataMember(Name = "product_category_id")]
        public int ProductCategoryId
        {
            get;
            set;
        }

        [DataMember(Name = "product_category_name")]
        public string ProductCategoryName
        {
            get;
            set;
        }

        [DataMember(Name = "qty")]
        public int Quantity
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
