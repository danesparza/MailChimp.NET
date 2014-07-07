using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailChimp.Tests
{
    [TestClass]
    public class APIKeyTests
    {
        [TestMethod]
        public void ValidAPIKey_ReturnsCorrectDataCenter()
        {
            //  Arrange
            string apiKey = "testapikey-us2";

            //  Act
            MailChimpManager mc = new MailChimpManager(apiKey);

            PrivateObject po = new PrivateObject(mc);
            string dataCenterPrefix = po.GetField("_dataCenterPrefix").ToString();

            //  Assert
            Assert.AreEqual<string>("us2", dataCenterPrefix);

        }

        [TestMethod]
        public void ValidOAuthKeys_ReturnsCorrectDataCenter()
        {
            //  Arrange
            string accessToken = "testaccesstoken";
            string dataCenter = "us2";

            //  Act
            MailChimpManager mc = new MailChimpManager(accessToken, dataCenter);

            PrivateObject po = new PrivateObject(mc);
            string dataCenterPrefix = po.GetField("_dataCenterPrefix").ToString();

            //  Assert
            Assert.AreEqual<string>("us2", dataCenterPrefix);

        }
    }
}
