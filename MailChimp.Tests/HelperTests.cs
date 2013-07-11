using System.Collections.Generic;
using System.Diagnostics;
using MailChimp.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailChimp.Tests
{
    [TestClass]
    public class HelperTests
    {
        [TestMethod]
        public void GetAccountDetails_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);

            //  Act
            AccountDetails details = mc.GetAccountDetails();

            //  Assert
            Assert.IsNotNull(details.UserId);
            Assert.IsNotNull(details.ContactInfo.FirstName);
        }

        [TestMethod]
        public void GetCampaignsForEmail_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);

            //  Act
            List<CampaignForEmail> details = mc.GetCampaignsForEmail(new EmailParameter()
            {
                Email = "customeremail@righthere.com"
            });

            //  Assert
            Debug.WriteLine(details.Count);
        }

        [TestMethod]
        public void GetListsForEmail_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);

            //  Act
            List<ListForEmail> details = mc.GetListsForEmail(new EmailParameter()
            {
                Email = "customeremail@righthere.com"
            });

            //  Assert
            Debug.WriteLine(details.Count);
        }

        [TestMethod]
        public void GetChimpChatter_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);

            //  Act
            List<ChimpChatterMessage> details = mc.GetChimpChatter();

            //  Assert
            Debug.WriteLine(details.Count);
        }

        [TestMethod]
        public void Ping_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);

            //  Act
            PingMessage details = mc.Ping();

            //  Assert
            Assert.AreEqual<string>("Everything's Chimpy!", details.Message);
        }
    }
}
