using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MailChimp.Templates;

namespace MailChimp.Tests
{
    [TestClass]
    public class TemplateTests
    {
        [TestMethod]
        public void GetTemplates_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);

            //  Act
            TemplateListResult details = mc.GetTemplates();

            //  Assert
            Assert.IsNotNull(details);
        }
    }
}
