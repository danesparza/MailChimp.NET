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
    }
}
