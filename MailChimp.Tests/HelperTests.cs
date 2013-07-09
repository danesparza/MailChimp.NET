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
            MailChimp mc = new MailChimp(TestGlobal.Test_APIKey);

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
            MailChimp mc = new MailChimp(TestGlobal.Test_APIKey);

            //  Act
            List<CampaignForEmail> details = mc.GetCampaignsForEmail(new EmailParameter()
            {
                Email = "customeremail@righthere.com"
            });

            //  Assert
            Debug.WriteLine(details.Count);
        }
    }
}
