using System;
using MailChimp.Campaigns;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailChimp.Tests
{
    [TestClass]
    public class CampaignTests
    {
        [TestMethod]
        public void GetCampaigns_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);

            //  Act
            CampaignListResult details = mc.GetCampaigns();

            //  Assert
            Assert.IsNotNull(details.Data);
        }

        [TestMethod]
        public void GetCampaignContent_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);

            //  Act
            CampaignContent details = mc.GetCampaignContent("875485faba");

            //  Assert
            Assert.IsFalse(string.IsNullOrWhiteSpace(details.Html));
        }
    }
}
