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
    public class ExportTests
    {
        [TestMethod]
        public void ExportGetLists_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            MailChimpExportManager mce = new MailChimpExportManager(TestGlobal.Test_APIKey);

            ListResult lists = mc.GetLists();
            Assert.IsNotNull(lists.Data);
            Assert.IsTrue(lists.Data.Any());

            string listId = lists.Data[0].Id;
            Assert.IsNotNull(lists.Data[0].Id);
            
            //  Act
            var results = mce.GetAllMembersForList(listId);

            //  Assert
            Assert.IsNotNull(results);
            Assert.IsTrue(results.Count > 0, "Export should contain at least 1 record. Make sure the list under test contains at least 1 record.");
            Assert.IsTrue(results[0].Count >= 17, "At a minimum 17 key/value pairs should be returned for each record.");
            Assert.IsTrue(results[0]["Email Address"].Contains('@'), "Email contains at least a @ character");
            Assert.IsTrue(results[0].ContainsKey("EMAIL_TYPE"), "EMAIL_TYPE should exist within exported record.");
            Assert.IsTrue(results[0].ContainsKey("MEMBER_RATING"), "MEMBER_RATING should exist within exported record.");
            Assert.IsTrue(results[0].ContainsKey("OPTIN_TIME"), "OPTIN_TIME should exist within exported record.");
            Assert.IsTrue(results[0].ContainsKey("OPTIN_IP"), "OPTIN_IP should exist within exported record.");
            Assert.IsTrue(results[0].ContainsKey("CONFIRM_TIME"), "CONFIRM_TIME should exist within exported record.");
            Assert.IsTrue(results[0].ContainsKey("CONFIRM_IP"), "CONFIRM_IP should exist within exported record.");
            Assert.IsTrue(results[0].ContainsKey("LATITUDE"), "LATITUDE should exist within exported record.");
            Assert.IsTrue(results[0].ContainsKey("LONGITUDE"), "LONGITUDE should exist within exported record.");
            Assert.IsTrue(results[0].ContainsKey("GMTOFF"), "GMTOFF should exist within exported record.");
            Assert.IsTrue(results[0].ContainsKey("DSTOFF"), "DSTOFF should exist within exported record.");
            Assert.IsTrue(results[0].ContainsKey("TIMEZONE"), "TIMEZONE should exist within exported record.");
            Assert.IsTrue(results[0].ContainsKey("CC"), "CC should exist within exported record.");
            Assert.IsTrue(results[0].ContainsKey("REGION"), "REGION should exist within exported record.");
            Assert.IsTrue(results[0].ContainsKey("LAST_CHANGED"), "LAST_CHANGED should exist within exported record.");
            Assert.IsTrue(results[0].ContainsKey("LEID"), "LEID should exist within exported record.");
            Assert.IsTrue(results[0].ContainsKey("EUID"), "EUID should exist within exported record.");
        }

        [TestMethod]
        public void ExportGetListsWithSinceFilterInThePast_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            MailChimpExportManager mce = new MailChimpExportManager(TestGlobal.Test_APIKey);

            ListResult lists = mc.GetLists();
            Assert.IsNotNull(lists.Data);
            Assert.IsTrue(lists.Data.Any());

            string listId = lists.Data[0].Id;
            Assert.IsNotNull(lists.Data[0].Id);

            //  Act
            var results = mce.GetAllMembersForList(listId, since: "1980-1-1 00:00:00");

            //  Assert
            Assert.IsNotNull(results);
            Assert.IsTrue(results.Count > 0, "Export should contain at least 1 record. Make sure the list under test contains at least 1 record.");
            Assert.IsTrue(results[0].Count >= 17, "At a minimum 17 key/value pairs should be returned for each record.");
            Assert.IsTrue(results[0]["Email Address"].Contains('@'), "Email contains at least a @ character");
        }

        [TestMethod]
        public void ExportGetListsWithSinceFilterInFuture_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            MailChimpExportManager mce = new MailChimpExportManager(TestGlobal.Test_APIKey);

            ListResult lists = mc.GetLists();
            Assert.IsNotNull(lists.Data);
            Assert.IsTrue(lists.Data.Any());

            string listId = lists.Data[0].Id;
            Assert.IsNotNull(lists.Data[0].Id);

            //  Act
            var results = mce.GetAllMembersForList(listId, since: DateTime.UtcNow.AddDays(1).ToString() );

            //  Assert
            Assert.IsNotNull(results);
            Assert.IsTrue(results.Count == 0, "Export should contain 0 records. No record should have a LAST_UPDATED date in the future.");
        }
    }
}





