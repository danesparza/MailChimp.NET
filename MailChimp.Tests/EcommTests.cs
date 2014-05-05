using MailChimp.Ecomm;
using MailChimp.Lists;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MailChimp.Tests
{
    [TestClass]
    public class EcommTests
    {
        [TestMethod]
        public void AddOrder_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);

            //  Act
            Order order = new Order();

            // Create a list and a Campaign with Ecommerce360 enabled.
            // A link from this campaign mail will contain:
            // ?mc_cid=06a8d1eea7&mc_eid=461b47eac7
            // mc_cid = CampaignId
            // mc_eid = EmailId
            order.CampaignId = "";
            order.EmailId = "";

            order.Id = "12345";
            order.StoreId = "abcde";
            order.StoreName = "My Sports Store";
            order.Total = 100;
            order.Tax = 30;
            order.Items = new List<OrderItem>();

            OrderItem item = new OrderItem();
            item.ProductId = 1;
            item.ProductName = "Tennis Ball";
            item.CategoryId = 1;
            item.CategoryName = "Balls";
            item.Quantity = 2;
            item.Cost = 50;

            order.Items.Add(item);

            CompleteResult result = mc.AddOrder(order);

            //  Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Complete);
        }

        [TestMethod]
        public void DeleteOrder_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);

            //  Act
            CompleteResult result = mc.DeleteOrder("abcde", "12345");

            //  Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Complete);
        }

        [TestMethod]
        public void GetOrders_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);

            //  Act
            OrderListResult result = mc.GetOrders();

            //  Assert
            Assert.IsNotNull(result);
        }

    }
}
