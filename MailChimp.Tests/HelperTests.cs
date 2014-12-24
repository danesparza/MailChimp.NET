using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using MailChimp.Helper;
using MailChimp.Lists;
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

        [TestMethod]
        public void SearchMembers_FindsExactMatchMember()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            ListResult lists = mc.GetLists();
            string listId = lists.Data[1].Id;

            //  Act
            Matches matches = mc.SearchMembers("customeremail@righthere.com", listId);

            //  Assert
            Assert.AreEqual(matches.ExactMatches.Total, 1);
            Assert.AreEqual(matches.ExactMatches.Members[0].Email, "customeremail@righthere.com");
            Assert.AreEqual(matches.FullSearch.Total, -1);
        }

        [TestMethod]
        public void SearchMembers_FindsPartialMatchMember()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            ListResult lists = mc.GetLists();
            string listId = lists.Data[1].Id;

            //  Act
            Matches matches = mc.SearchMembers("customeremail", listId);

            //  Assert
            Assert.IsTrue(matches.FullSearch.Total > 0);
            Assert.IsTrue(matches.FullSearch.Members.Any(member => member.Email == "customeremail@righthere.com"));
        }

        [TestMethod]
        public void InlineCss_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);

            //  Act
            string html = @"<html>
	                            <style type=""text/css"">
                                .style1 {
                                    color: red;
		                            font-weight: bold;
                                }
                            </style>
	                            <body>
		                            <p class=""style1"">Test</p>
	                            </body>
                            </html>";
            InlineCss details = mc.InlineCss(html, false);

            //  Assert
            Assert.IsNotNull(details.Html);
        }

        [TestMethod]
        public void GetVerifiedDomains_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);

            //  Act
            List<VerifiedDomain> domains = mc.GetVerifiedDomains();

            //  Assert
            Debug.WriteLine(domains.Count);
            Assert.AreNotEqual(0, domains.Count);
        }

    }
}
