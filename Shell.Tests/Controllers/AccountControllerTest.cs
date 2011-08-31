using Shell.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using Shell.Infrastructure.IdStore;
using Shell.Infrastructure.Logging;
using System.Web.Mvc;

namespace Shell.Tests
{
    
    
    /// <summary>
    ///This is a test class for AccountControllerTest and is intended
    ///to contain all AccountControllerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AccountControllerTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for AccountController Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Gerardo Flores\\repos\\Shell\\Shell", "/")]
        [UrlToTest("http://localhost:54959/")]
        public void AccountControllerConstructorTest()
        {
            IIdStore idStore = null; // TODO: Initialize to an appropriate value
            ILogger logger = null; // TODO: Initialize to an appropriate value
            AccountController target = new AccountController(idStore, logger);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ChangePassword
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Gerardo Flores\\repos\\Shell\\Shell", "/")]
        [UrlToTest("http://localhost:54959/")]
        public void ChangePasswordTest()
        {
            IIdStore idStore = null; // TODO: Initialize to an appropriate value
            ILogger logger = null; // TODO: Initialize to an appropriate value
            AccountController target = new AccountController(idStore, logger); // TODO: Initialize to an appropriate value
            string email = string.Empty; // TODO: Initialize to an appropriate value
            string password = string.Empty; // TODO: Initialize to an appropriate value
            string newPassword = string.Empty; // TODO: Initialize to an appropriate value
            string confirmNewPassword = string.Empty; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.ChangePassword(email, password, newPassword, confirmNewPassword);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ChangePassword
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Gerardo Flores\\repos\\Shell\\Shell", "/")]
        [UrlToTest("http://localhost:54959/")]
        public void ChangePasswordTest1()
        {
            IIdStore idStore = null; // TODO: Initialize to an appropriate value
            ILogger logger = null; // TODO: Initialize to an appropriate value
            AccountController target = new AccountController(idStore, logger); // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.ChangePassword();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ChangePasswordSuccess
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Gerardo Flores\\repos\\Shell\\Shell", "/")]
        [UrlToTest("http://localhost:54959/")]
        public void ChangePasswordSuccessTest()
        {
            IIdStore idStore = null; // TODO: Initialize to an appropriate value
            ILogger logger = null; // TODO: Initialize to an appropriate value
            AccountController target = new AccountController(idStore, logger); // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.ChangePasswordSuccess();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ClickThru
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Gerardo Flores\\repos\\Shell\\Shell", "/")]
        [UrlToTest("http://localhost:54959/")]
        public void ClickThruTest()
        {
            IIdStore idStore = null; // TODO: Initialize to an appropriate value
            ILogger logger = null; // TODO: Initialize to an appropriate value
            AccountController target = new AccountController(idStore, logger); // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.ClickThru();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ClickThru
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Gerardo Flores\\repos\\Shell\\Shell", "/")]
        [UrlToTest("http://localhost:54959/")]
        public void ClickThruTest1()
        {
            IIdStore idStore = null; // TODO: Initialize to an appropriate value
            ILogger logger = null; // TODO: Initialize to an appropriate value
            AccountController target = new AccountController(idStore, logger); // TODO: Initialize to an appropriate value
            string accept = string.Empty; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.ClickThru(accept);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LogOff
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Gerardo Flores\\repos\\Shell\\Shell", "/")]
        [UrlToTest("http://localhost:54959/")]
        public void LogOffTest()
        {
            IIdStore idStore = null; // TODO: Initialize to an appropriate value
            ILogger logger = null; // TODO: Initialize to an appropriate value
            AccountController target = new AccountController(idStore, logger); // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.LogOff();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LogOn
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Gerardo Flores\\repos\\Shell\\Shell", "/")]
        [UrlToTest("http://localhost:54959/")]
        public void LogOnTest()
        {
            IIdStore idStore = null; // TODO: Initialize to an appropriate value
            ILogger logger = null; // TODO: Initialize to an appropriate value
            AccountController target = new AccountController(idStore, logger); // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.LogOn();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LogOn
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Gerardo Flores\\repos\\Shell\\Shell", "/")]
        [UrlToTest("http://localhost:54959/")]
        public void LogOnTest1()
        {
            IIdStore idStore = null; // TODO: Initialize to an appropriate value
            ILogger logger = null; // TODO: Initialize to an appropriate value
            AccountController target = new AccountController(idStore, logger); // TODO: Initialize to an appropriate value
            string email = string.Empty; // TODO: Initialize to an appropriate value
            string password = string.Empty; // TODO: Initialize to an appropriate value
            string ReturnUrl = string.Empty; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.LogOn(email, password, ReturnUrl);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Register
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Gerardo Flores\\repos\\Shell\\Shell", "/")]
        [UrlToTest("http://localhost:54959/")]
        public void RegisterTest()
        {
            IIdStore idStore = null; // TODO: Initialize to an appropriate value
            ILogger logger = null; // TODO: Initialize to an appropriate value
            AccountController target = new AccountController(idStore, logger); // TODO: Initialize to an appropriate value
            string email = string.Empty; // TODO: Initialize to an appropriate value
            string password = string.Empty; // TODO: Initialize to an appropriate value
            string confirmation = string.Empty; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Register(email, password, confirmation);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Register
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Gerardo Flores\\repos\\Shell\\Shell", "/")]
        [UrlToTest("http://localhost:54959/")]
        public void RegisterTest1()
        {
            IIdStore idStore = null; // TODO: Initialize to an appropriate value
            ILogger logger = null; // TODO: Initialize to an appropriate value
            AccountController target = new AccountController(idStore, logger); // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Register();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
