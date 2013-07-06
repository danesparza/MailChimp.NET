using System;
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
            Debug.WriteLine(details.UserId);
        }
    }
}
