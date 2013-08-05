using System;
using System.Collections.Generic;
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
            string campaignId = "yourcampaignidhere";

            //  Act
            CampaignContent details = mc.GetCampaignContent(campaignId);

            //  Assert
            Assert.IsFalse(string.IsNullOrWhiteSpace(details.Html));
        }

        [TestMethod]
        public void SendCampaignTest_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            List<string> testEmails = new List<string>()
            {
                "testemails@domain.com"
            };
            string campaignId = "yourcampaignidhere";

            //  Act
            CampaignActionResult details = mc.SendCampaignTest(campaignId, testEmails);

            //  Assert
            Assert.IsTrue(details.Complete);
        }

        [TestMethod]
        public void ReplicateCampaign_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            CampaignListResult cl = mc.GetCampaigns();
            string campaignId = cl.Data[0].Id;

            //  Act
            Campaign details = mc.ReplicateCampaign(campaignId);

            //  Assert
            Assert.IsNotNull(details);
        }
    }
}
