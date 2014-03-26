using System;
using System.Collections.Generic;
using MailChimp.Lists;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using MailChimp.Helper;
using System.Diagnostics;

namespace MailChimp.Tests
{
    [TestClass]
    public class ListTests
    {
        [TestMethod]
        public void GetLists_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);

            //  Act
            ListResult details = mc.GetLists();

            //  Assert
            Assert.IsNotNull(details.Data);
        }

        [TestMethod]
        public void GetAbuseReport_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            ListResult lists = mc.GetLists();

            //  Act
            AbuseResult details = mc.GetListAbuseReports(lists.Data[0].Id);

            //  Assert
            Assert.IsNotNull(details.Data);
        }

        [TestMethod]
        public void GetListActivity_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            ListResult lists = mc.GetLists();

            //  Act
            List<ListActivity> results = mc.GetListActivity(lists.Data[1].Id);

            //  Assert
            Assert.IsNotNull(results);
            Assert.IsTrue(results.Any());
        }

        [TestMethod]
        public void GetMemberActivity_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            
            ListResult lists = mc.GetLists();
            Assert.IsNotNull(lists.Data);
            Assert.IsTrue(lists.Data.Any());

            MembersResult members = mc.GetAllMembersForList(lists.Data[0].Id);
            Assert.IsNotNull(members.Data);
            Assert.IsTrue(members.Data.Any());

            List<EmailParameter> memberEmails = new List<EmailParameter>();

            foreach (MemberInfo member in members.Data)
            {
                memberEmails.Add(new EmailParameter() { Email = member.Email });
            }

            //  Act
            MemberActivityResult results = mc.GetMemberActivity(lists.Data[0].Id, memberEmails);

            //  Assert
            Assert.IsNotNull(results);
            Assert.IsTrue(results.Data.Any());
        }

        [TestMethod]
        public void GetListInterestGroupings_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager("efb48a02f2f56120e2f3f6e2fef71803-us6");
            ListResult lists = mc.GetLists(new ListFilter(){ListName = "TestAPIGetInterestGroup"});
            Assert.IsNotNull(lists);
            Assert.IsTrue(lists.Data.Any());
            //  Act
            List<InterestGrouping> results = mc.GetListInterestGroupings(lists.Data.FirstOrDefault().Id);

            //  Assert
            Assert.IsNotNull(results);
            Assert.IsTrue(results.Any());
        }

        [TestMethod]
        public void Subscribe_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            ListResult lists = mc.GetLists();
            EmailParameter email = new EmailParameter()
            {
                Email = "customeremail@righthere.com"
            };

            //  Act
            EmailParameter results = mc.Subscribe(lists.Data[1].Id, email);

            //  Assert
            Assert.IsNotNull(results);
            Assert.IsTrue(!string.IsNullOrEmpty(results.LEId));
        }

        [System.Runtime.Serialization.DataContract] 
        public class MyMergeVar : MergeVar
        {
            [System.Runtime.Serialization.DataMember(Name = "FNAME")]
            public string FirstName
            {
                get;
                set;
            }
            [System.Runtime.Serialization.DataMember(Name = "LNAME")]
            public string LastName
            {
                get;
                set;
            }
        }

        [TestMethod]
        public void SubscribeWithGroupSelection_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            ListResult lists = mc.GetLists();
            EmailParameter email = new EmailParameter()
            {
                Email = "customeremail@righthere.com"
            };

            // find a list with interest groups...
            string strListID = null;
            int nGroupingID = 0;
            string strGroupName = null;
            foreach (ListInfo li in lists.Data) {
                List<InterestGrouping> interests = mc.GetListInterestGroupings(li.Id);
                if (interests != null) {
                    if (interests.Count > 0) {
                        if (interests[0].GroupNames.Count > 0) {
                            strListID = li.Id;
                            nGroupingID = interests[0].Id;
                            strGroupName = interests[0].GroupNames[0].Name;
                            break;
                        }
                    }
                }
            }
            Assert.IsNotNull(strListID,"no lists found in this account with groupings / group names");
            Assert.AreNotEqual(0,nGroupingID);
            Assert.IsNotNull(strGroupName);

            MyMergeVar mvso = new MyMergeVar();
            mvso.Groupings = new List<Grouping>();
            mvso.Groupings.Add(new Grouping());
            mvso.Groupings[0].Id = nGroupingID;
            mvso.Groupings[0].GroupNames = new List<string>();
            mvso.Groupings[0].GroupNames.Add(strGroupName);
            mvso.FirstName = "Testy";
            mvso.LastName = "Testerson";

            //  Act
            EmailParameter results = mc.Subscribe(strListID, email, mvso);

            //  Assert
            Assert.IsNotNull(results);
            Assert.IsTrue(!string.IsNullOrEmpty(results.LEId));
        }

        [TestMethod]
        public void BatchSubscribe_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            ListResult lists = mc.GetLists();

            List<BatchEmailParameter> emails = new List<BatchEmailParameter>();

            BatchEmailParameter email1 = new BatchEmailParameter()
            {
                Email = new EmailParameter()
                {
                    Email = "customeremail1@righthere.com"
                }
            };

            BatchEmailParameter email2 = new BatchEmailParameter()
            {
                Email = new EmailParameter()
                {
                    Email = "customeremail2@righthere.com"
                }
            };

            emails.Add(email1);
            emails.Add(email2);

            //  Act
            BatchSubscribeResult results = mc.BatchSubscribe(lists.Data[1].Id, emails);

            //  Assert
            Assert.IsNotNull(results);
            Assert.IsTrue(results.AddCount == 2);
        }

        [TestMethod]
        public void Unsubscribe_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            ListResult lists = mc.GetLists();
            EmailParameter email = new EmailParameter()
            {
                Email = "customeremail@righthere.com"
            };

            //  Act
            UnsubscribeResult results = mc.Unsubscribe(lists.Data[1].Id, email);

            //  Assert
            Assert.IsNotNull(results);
            Assert.IsTrue(results.Complete);
        }

        [TestMethod]
        public void BatchUnsubscribe_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            ListResult lists = mc.GetLists();

            List<EmailParameter> emails = new List<EmailParameter>();

            EmailParameter email1 = new EmailParameter()
            {
                Email = "customeremail1@righthere.com"
            };

            EmailParameter email2 = new EmailParameter()
            {
                Email = "customeremail2@righthere.com"
            };

            emails.Add(email1);
            emails.Add(email2);

            //  Act
            BatchUnsubscribeResult results = mc.BatchUnsubscribe(lists.Data[1].Id, emails);

            //  Assert
            Assert.IsNotNull(results);
            Assert.IsTrue(results.SuccessCount == 2);
        }

        [TestMethod]
        public void GetMemberInfo_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            ListResult lists = mc.GetLists();

            List<EmailParameter> emails = new List<EmailParameter>();

            EmailParameter email1 = new EmailParameter()
            {
                Email = "customeremail1@righthere.com"
            };

            EmailParameter email2 = new EmailParameter()
            {
                Email = "customeremail2@righthere.com"
            };

            emails.Add(email1);
            emails.Add(email2);

            //  Act
            MemberInfoResult results = mc.GetMemberInfo(lists.Data[1].Id, emails);

            //  Assert
            Assert.IsNotNull(results);
        }

        [TestMethod]
        public void GetAllMembersForList_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            ListResult lists = mc.GetLists();

            //  For each list
            foreach(var list in lists.Data)
            {
                //  Write out the list name:
                Debug.WriteLine("Users for the list " + list.Name);

                //  Get the first 100 members of each list:
                MembersResult results = mc.GetAllMembersForList(list.Id, "subscribed", 0, 100);

                //  Write out each member's email address:
                foreach(var member in results.Data)
                {
                    Debug.WriteLine(member.Email);
                }
            }
        }

        [TestMethod]
        public void GetLocationsForList_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            ListResult lists = mc.GetLists();

            //  For each list
            foreach(var list in lists.Data)
            {
                Debug.WriteLine("Information for " + list.Name);

                //  Get the location data for each list:
                List<SubscriberLocation> locations = mc.GetLocationsForList(list.Id);

                //  Write out each of the locations:
                foreach(var location in locations)
                {
                    Debug.WriteLine("Country: {0} - {2} users, accounts for {1}% of list subscribers", location.Country, location.Percent, location.Total);
                }
            }
        }

        [TestMethod]
        public void GetMergeVars_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            ListResult lists = mc.GetLists();
            // we don't want to have an existing merge var interfere
            try { mc.DeleteMergeVar(lists.Data.First().Id, "TESTGETVAR"); } 
            catch { }
            MergeVarOptions options = new MergeVarOptions()
            {
                FieldType = "url",
                HelpText = "A url, such as https://github.com/danesparza/MailChimp.NET"
            };
            mc.AddMergeVar(lists.Data.First().Id, "TESTGETVAR", "Test Value", options);

            // Act
            MergeVarResult result = mc.GetMergeVars(lists.Data.Select(l => l.Id));

            // Assert
            Assert.IsNotNull(result.Data);
            Assert.IsTrue(result.Data.Any(d => d.MergeVars.Any(m => m.Tag == "TESTGETVAR")));

            // Clean up
            mc.DeleteMergeVar(lists.Data.First().Id, "TESTGETVAR");
        }

        [TestMethod]
        public void AddMergeVar_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            ListResult lists = mc.GetLists();
            // we don't want to have an existing merge var interfere
            try { mc.DeleteMergeVar(lists.Data.First().Id, "TESTADDVAR"); }
            catch { }
            MergeVarOptions options = new MergeVarOptions()
            {
                FieldType = "url",
                HelpText = "A url, such as https://github.com/danesparza/MailChimp.NET"
            };

            // Act
            MergeVarItemResult result = mc.AddMergeVar(lists.Data.First().Id, "TESTADDVAR", "Test Value", options);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.FieldType == "url");

            // Clean up
            mc.DeleteMergeVar(lists.Data.First().Id, "TESTADDVAR");
        }

        [TestMethod]
        public void UpdateMergeVar_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            ListResult lists = mc.GetLists();
            MergeVarOptions options = new MergeVarOptions()
            {
                FieldType = "url",
                HelpText = "A url, such as https://github.com/danesparza/MailChimp.NET"
            };
            // we don't want to have existing merge vars interfere
            try { mc.DeleteMergeVar(lists.Data.First().Id, "TESTUPDVAR"); }
            catch { }
            try { mc.DeleteMergeVar(lists.Data.First().Id, "UPDATEDVAR"); }
            catch { }
            mc.AddMergeVar(lists.Data.First().Id, "TESTUPDVAR", "Test Value", options);

            // Act
            options = new MergeVarOptions()
            {
                Tag = "UPDATEDVAR",
                HelpText = "Any url you like"
            };
            MergeVarItemResult result = mc.UpdateMergeVar(lists.Data.First().Id, "TESTUPDVAR", options);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Tag == "UPDATEDVAR");

            // Clean up
            mc.DeleteMergeVar(lists.Data.First().Id, "UPDATEDVAR");
        }

        [TestMethod]
        public void DeleteMergeVar_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            ListResult lists = mc.GetLists();

            mc.AddMergeVar(lists.Data.First().Id, "TESTDELETE", "Test Value");

            // Act
            CompleteResult result = mc.DeleteMergeVar(lists.Data.First().Id, "TESTDELETE");

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Complete);
        }

        [TestMethod]
        public void ResetMergeVar_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            ListResult lists = mc.GetLists();
            // we don't want to have an existing merge var interfere
            try { mc.DeleteMergeVar(lists.Data.First().Id, "TESTRESET"); }
            catch { }
            mc.AddMergeVar(lists.Data.First().Id, "TESTRESET", "Test Value");

            // Act
            CompleteResult result = mc.ResetMergeVar(lists.Data.First().Id, "TESTRESET");

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Complete);

            // Clean up
            mc.DeleteMergeVar(lists.Data.First().Id, "TESTRESET");
        }

        [TestMethod]
        public void SetMergeVar_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            ListResult lists = mc.GetLists();
            // we don't want to have an existing merge var interfere
            try { mc.DeleteMergeVar(lists.Data.First().Id, "TESTSET"); }
            catch { }
            mc.AddMergeVar(lists.Data.First().Id, "TESTSET", "Test Value");

            // Act
            CompleteResult result = mc.SetMergeVar(lists.Data.First().Id, "TESTSET", "Set");

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Complete);


            // Clean up
            mc.DeleteMergeVar(lists.Data.First().Id, "TESTSET");
        }

        [TestMethod]
        public void AddStaticSegment_Successful()
        {
            // Arrange 
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            ListResult lists = mc.GetLists();
            // Act
            StaticSegmentAddResult result = mc.AddStaticSegment(lists.Data[1].Id, "Test Segment");
            // Assert
            Assert.IsNotNull(result.NewStaticSegmentID);
        }

        [TestMethod]
        public void GetStaticSegmentsForList_Successful()
        {
            // Arrange 
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            ListResult lists = mc.GetLists();
            // Act
            List<StaticSegmentResult> result = mc.GetStaticSegmentsForList(lists.Data[1].Id);
            // Assert
            Assert.IsTrue(result.Count > 0);
        }
        [TestMethod]
        public void DeleteStaticSegment_Succesful()
        {
            // Arrange 
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            ListResult lists = mc.GetLists();
            List<StaticSegmentResult> segments = mc.GetStaticSegmentsForList(lists.Data[1].Id);
            // Act
            StaticSegmentActionResult result = mc.DeleteStaticSegment(lists.Data[1].Id, segments[1].StaticSegmentId);
            Assert.IsTrue(result.Complete);
        }
        [TestMethod] 
        public void AddStaticSegmentMembers_Successful()
        {
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            ListResult lists = mc.GetLists();
            List<StaticSegmentResult> segments = mc.GetStaticSegmentsForList(lists.Data[1].Id);
            EmailParameter email1 = new EmailParameter()
            {
                Email = "customeremail@righthere.com"
            };
            List<EmailParameter> emails = new List<EmailParameter>();
            emails.Add(email1);
            StaticSegmentMembersAddResult result = mc.AddStaticSegmentMembers(lists.Data[1].Id,segments[0].StaticSegmentId,emails);
            Assert.IsTrue(result.successCount == 1);
        }
        [TestMethod]
        public void DeleteStaticSegmentMembers_Successful()
        {
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            ListResult lists = mc.GetLists();
            List<StaticSegmentResult> segments = mc.GetStaticSegmentsForList(lists.Data[1].Id);
            EmailParameter email1 = new EmailParameter()
            {
                Email = "customeremail1@righthere.com"
            };
            List<EmailParameter> emails = new List<EmailParameter>();
            emails.Add(email1);
            StaticSegmentMembersDeleteResult result = mc.DeleteStaticSegmentMembers(lists.Data[1].Id, segments[0].StaticSegmentId, emails);
            Assert.IsTrue(result.successCount == 1);
            Assert.IsTrue(result.errorCount == 0);
        }
        [TestMethod]
        public void ResetStaticSegment_Successful()
        {
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            ListResult lists = mc.GetLists();
            List<StaticSegmentResult> segments = mc.GetStaticSegmentsForList(lists.Data[1].Id);
            StaticSegmentActionResult result = mc.ResetStaticSegment(lists.Data[1].Id, segments[0].StaticSegmentId);
            Assert.IsTrue(result.Complete);
        }
	    [TestMethod]
        public void GetSavedSegmentsForList_Successful()
        {
            // Arrange 
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            ListResult lists = mc.GetLists();
            
            // Act
            SegmentResult result = mc.GetSegmentsForList(lists.Data[1].Id, "saved");
            
            // Assert
            Assert.IsTrue(result.SavedResult.Any());
        }
    }
}
