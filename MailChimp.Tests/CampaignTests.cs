using System;
using System.Collections.Generic;
using MailChimp.Campaigns;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MailChimp.Lists;

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
            // Changed from IsNullOrWhiteSpace to IsNullOrEmpty for .NET 3.5 compatibility. Consider using extension method
            // for IsNullOrWhiteSpace support
            Assert.IsFalse(string.IsNullOrEmpty(details.Html));
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
        [TestMethod]
        public void CampaignSegmentTest_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            ListResult lists = mc.GetLists();
            CampaignSegmentOptions options = new CampaignSegmentOptions();
            options.Match= "All";
            string dateListCreated = lists.Data[1].DateCreated;
            List<CampaignSegmentCriteria> conditions = new List<CampaignSegmentCriteria>();
            conditions.Add(new CampaignSegmentCriteria { Field = "date", Operator = "eq", Value = dateListCreated });
            options.Conditions = conditions;
            string listId = lists.Data[1].Id;
            //  Act
            CampaignSegmentTestResult result = mc.CampaignSegmentTest(listId,options);          
            //  Assert
            Assert.IsTrue(result.Total == 1);
        }
	    [TestMethod]
        public void CampaignSavedSegmentTest_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            ListResult lists = mc.GetLists();
            Assert.IsNotNull(lists);
            Assert.IsTrue(lists.Data.Count > 0);
            string listID = lists.Data[1].Id;
            CampaignSegmentOptions options = new CampaignSegmentOptions();
            options.SavedSegmentId = "yourSavedSegmentId";

            //  Act
            CampaignSegmentTestResult result = mc.CampaignSegmentTest(listID, options);
            
            //  Assert
            Assert.IsTrue(result.Total > 0);
        }
        [TestMethod]
        public void CampaignCreate_Successful()
        {
            // Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            ListResult lists = mc.GetLists();
            string listID = lists.Data[1].Id;
            CampaignSegmentOptions segmentOptions = new CampaignSegmentOptions();
            segmentOptions.Match = "All";
            string dateListCreated = lists.Data[1].DateCreated;
            segmentOptions.Conditions = new List<CampaignSegmentCriteria>();
            segmentOptions.Conditions.Add(new CampaignSegmentCriteria { Field = "date", Operator = "eq", Value = dateListCreated });
            CampaignCreateContent content = new CampaignCreateContent();
            content.HTML = "<p>Testing</p>";
            CampaignCreateOptions options = new CampaignCreateOptions();
            options.Title = "Testing";
            options.ListId = listID;
            options.ToName = "Test Name";
            options.FromEmail = "testemails@gmail.com";
            options.FromName = "Testing Company Name";
            options.Subject = "Test Subject";

            //Act
            Campaign result = mc.CreateCampaign("regular", options, content, segmentOptions, null);
            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void CampaignDelete_Successful()
        {
            // Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            CampaignListResult campaigns = mc.GetCampaigns();
            //Act
            CampaignActionResult result = mc.DeleteCampaign(campaigns.Data[0].Id);
            // Assert
            Assert.IsTrue(result.Complete);
        }

        [TestMethod]
        public void CampaignUpdate_Successful()
        {
            // Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            CampaignListResult campaigns = mc.GetCampaigns();
            //Act
            var result = mc.UpdateCampaign(campaigns.Data[0].Id, "options", new { title = "Different Campaign Title" });
            // Assert
            Assert.IsTrue(result.Errors.Count == 0);
        }
    }
}
