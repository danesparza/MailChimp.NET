using System;
using MailChimp.Lists;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
