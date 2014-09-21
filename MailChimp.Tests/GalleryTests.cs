using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MailChimp.Gallery;

namespace MailChimp.Tests
{
    [TestClass]
    public class GalleryTests
    {
        [TestMethod]
        public void GalleryFolderAddFileTo_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            int testFolderId = 3145; /* Update with your folderId */
            int testFileId = 905; /* Update with your fileId */

            //  Act
            bool result = mc.GalleryFolderAddFileTo(testFileId, testFolderId);

            //  Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GalleryFolderAdd_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);

            //  Act
            AddGalleryFolderResult result = mc.GalleryFolderAdd("test-api");

            //  Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Id > 0);
        }

        [TestMethod]
        public void GetGalleries_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);

            //  Act
            GalleryListResult result = mc.GetGalleries("test-api");

            //  Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetGalleryFolders_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);

            //  Act
            GalleryFoldersResult result = mc.GetGalleryFolders();

            //  Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GalleryFolderRemoveAllFilesFrom_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            int testFolderId = 3141; /* Update with your folderId */

            //  Act
            bool result = mc.GalleryFolderRemoveAllFilesFrom(testFolderId);

            //  Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GalleryFolderRemoveFileFrom_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            int testFolderId = 3141; /* Update with your folderId */
            int testFileId = 540877; /* Update with your fileId */

            //  Act
            bool result = mc.GalleryFolderRemoveFileFrom(testFileId, testFolderId);

            //  Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GalleryFolderRemove_Successful()
        {
            //  Arrange
            MailChimpManager mc = new MailChimpManager(TestGlobal.Test_APIKey);
            int testFolderId = 3141; /* Update with your folderId */

            //  Act
            bool result = mc.GalleryFolderRemove(testFolderId);

            //  Assert
            Assert.IsTrue(result);
        }
    }
}
