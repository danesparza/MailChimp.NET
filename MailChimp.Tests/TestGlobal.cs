using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailChimp.Tests
{
    /// <summary>
    /// Global test information is set in this class
    /// </summary>
    [TestClass]
    public class TestGlobal
    {
        /// <summary>
        /// The global mailchimp API key
        /// </summary>
        public static string Test_APIKey = string.Empty;

        [AssemblyInitialize()]
        public static void AllTestInit(TestContext testContext)
        {
            //  Set this to your Mailchimp API key for testing
            //  See http://kb.mailchimp.com/article/where-can-i-find-my-api-key
            //  for help finding your API key
            Test_APIKey = "yourapikeyhere-us2";
        }
    }
}
