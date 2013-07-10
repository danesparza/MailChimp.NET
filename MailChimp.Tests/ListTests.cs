using System;
using System.Collections.Generic;
using MailChimp.Lists;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using MailChimp.Helper;

namespace MailChimp.Tests
{
    [TestClass]
    public class ListTests
    {
        [TestMethod]
        public void GetLists_Successful()
        {
            //  Arrange
            MailChimp mc = new MailChimp(TestGlobal.Test_APIKey);

            //  Act
            ListResult details = mc.GetLists();

            //  Assert
            Assert.IsNotNull(details.Data);
        }

        [TestMethod]
        public void GetAbuseReport_Successful()
        {
            //  Arrange
            MailChimp mc = new MailChimp(TestGlobal.Test_APIKey);
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
            MailChimp mc = new MailChimp(TestGlobal.Test_APIKey);
            ListResult lists = mc.GetLists();

            //  Act
            List<ListActivity> results = mc.GetListActivity(lists.Data[1].Id);

            //  Assert
            Assert.IsNotNull(results);
            Assert.IsTrue(results.Any());
        }

        [TestMethod]
        public void Subscribe_Successful()
        {
            //  Arrange
            MailChimp mc = new MailChimp(TestGlobal.Test_APIKey);
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

        [TestMethod]
        public void BatchSubscribe_Successful()
        {
            //  Arrange
            MailChimp mc = new MailChimp(TestGlobal.Test_APIKey);
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
            ListAddResult results = mc.BatchSubscribe(lists.Data[1].Id, emails);

            //  Assert
            Assert.IsNotNull(results);
            Assert.IsTrue(results.AddCount == 2);
        }

        [TestMethod]
        public void Unsubscribe_Successful()
        {
            //  Arrange
            MailChimp mc = new MailChimp(TestGlobal.Test_APIKey);
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
    }
}
