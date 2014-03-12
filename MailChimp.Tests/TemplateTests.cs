using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MailChimp.Templates;
using System.IO;

namespace MailChimp.Tests
{
    [TestClass]
    public class TemplateTests
    {
        [TestMethod]
        public void TemplateMethods_Sucessful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);

            TemplateAddResult addTemplateResult = null;
            try
            {
                //  Act
                addTemplateResult = mc.AddTemplate("Test Name " + Path.GetRandomFileName(), "Test Html");

                //  Assert
                Assert.IsNotNull(addTemplateResult);

                // Act
                var templateInformation = mc.GetTemplateInformation(addTemplateResult.TemplateId);

                // Assert
                Assert.IsNotNull(templateInformation);

                var templateUpdateValue = new TemplateUpdateValue
                {
                    Html = "Test Html Updated",
                    Name = "Test Name Updated " + Path.GetRandomFileName()
                };

                // Act
                var templateUpdate = mc.UpdateTemplate(addTemplateResult.TemplateId, templateUpdateValue);

                // Assert
                Assert.IsNotNull(templateUpdate);
            }
            finally
            {
                // Cleanup
                if (addTemplateResult != null)
                {
                    // Act
                    var deletedTemplate = mc.DeleteTemplate(addTemplateResult.TemplateId);

                    // Note: this might override a different assert.
                    // Assert
                    Assert.IsNotNull(deletedTemplate);

                    // Act
                    var undeletedTemplate = mc.UndeleteTemplate(addTemplateResult.TemplateId);

                    // Note: this might override a different assert.
                    // Assert
                    Assert.IsNotNull(undeletedTemplate);

                    // Act
                    var deletedTemplate2 = mc.DeleteTemplate(addTemplateResult.TemplateId);

                    // Note: this might override a different assert.
                    // Assert
                    Assert.IsNotNull(deletedTemplate2);
                }
            }
        }


        [TestMethod]
        public void GetTemplates_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            var types = new TemplateTypes()
            {
                User = true
            };
            var filters = new TemplateFilters()
            {
                IncludeInactive = false
            };
            //  Act
            TemplateListResult details = mc.GetTemplates(types, filters);

            //  Assert
            Assert.IsNotNull(details);
        }

        
    }
}
