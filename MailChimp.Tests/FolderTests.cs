using System;
using System.Collections.Generic;
using MailChimp.Folders;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailChimp.Tests
{
    [TestClass]
    public class FolderTests
    {
        [TestMethod]
        public void GetFolders_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);

            //  Act
            List<FolderListResult> details = mc.GetFolders("campaign");

            //  Assert
            Assert.IsNotNull(details);
        }

        [TestMethod]
        public void AddFolder_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);

            //  Act
            FolderAddResult details = mc.AddFolder("TestFolder", "campaign");

            //  Assert
            Assert.IsNotNull(details);
            Assert.AreNotEqual<int>(0, details.NewFolderId);
        }

        [TestMethod]
        public void UpdateFolder_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            int testFolderId = 42; /* Update with your folderId */

            //  Act
            FolderActionResult details = mc.UpdateFolder(testFolderId, "New Test folder updated", "campaign");

            //  Assert
            Assert.IsNotNull(details);
            Assert.IsTrue(details.Complete);
        }

        [TestMethod]
        public void DeleteFolder_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            int testFolderId = 42; /* Update with your folderId */

            //  Act
            FolderActionResult details = mc.DeleteFolder(testFolderId, "campaign");

            //  Assert
            Assert.IsNotNull(details);
            Assert.IsTrue(details.Complete);
        }
    }
}
