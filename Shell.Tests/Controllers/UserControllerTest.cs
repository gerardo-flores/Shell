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
    ///This is a test class for UserControllerTest and is intended
    ///to contain all UserControllerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class UserControllerTest
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
        ///A test for UserController Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Gerardo Flores\\repos\\Shell\\Shell", "/")]
        [UrlToTest("http://localhost:54959/")]
        public void UserControllerConstructorTest()
        {
            IIdStore idStore = null; // TODO: Initialize to an appropriate value
            ILogger logger = null; // TODO: Initialize to an appropriate value
            UserController target = new UserController(idStore, logger);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Activate
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Gerardo Flores\\repos\\Shell\\Shell", "/")]
        [UrlToTest("http://localhost:54959/")]
        public void ActivateTest()
        {
            IIdStore idStore = null; // TODO: Initialize to an appropriate value
            ILogger logger = null; // TODO: Initialize to an appropriate value
            UserController target = new UserController(idStore, logger); // TODO: Initialize to an appropriate value
            string id = string.Empty; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Activate(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Create
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Gerardo Flores\\repos\\Shell\\Shell", "/")]
        [UrlToTest("http://localhost:54959/")]
        public void CreateTest()
        {
            IIdStore idStore = null; // TODO: Initialize to an appropriate value
            ILogger logger = null; // TODO: Initialize to an appropriate value
            UserController target = new UserController(idStore, logger); // TODO: Initialize to an appropriate value
            string email = string.Empty; // TODO: Initialize to an appropriate value
            string password = string.Empty; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Create(email, password);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Create
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Gerardo Flores\\repos\\Shell\\Shell", "/")]
        [UrlToTest("http://localhost:54959/")]
        public void CreateTest1()
        {
            IIdStore idStore = null; // TODO: Initialize to an appropriate value
            ILogger logger = null; // TODO: Initialize to an appropriate value
            UserController target = new UserController(idStore, logger); // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Create();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Gerardo Flores\\repos\\Shell\\Shell", "/")]
        [UrlToTest("http://localhost:54959/")]
        public void DeleteTest()
        {
            IIdStore idStore = null; // TODO: Initialize to an appropriate value
            ILogger logger = null; // TODO: Initialize to an appropriate value
            UserController target = new UserController(idStore, logger); // TODO: Initialize to an appropriate value
            string id = string.Empty; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Delete(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Index
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Gerardo Flores\\repos\\Shell\\Shell", "/")]
        [UrlToTest("http://localhost:54959/")]
        public void IndexTest()
        {
            IIdStore idStore = null; // TODO: Initialize to an appropriate value
            ILogger logger = null; // TODO: Initialize to an appropriate value
            UserController target = new UserController(idStore, logger); // TODO: Initialize to an appropriate value
            int pageNum = 0; // TODO: Initialize to an appropriate value
            string searchTerms = string.Empty; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Index(pageNum, searchTerms);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MakeAdmin
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Gerardo Flores\\repos\\Shell\\Shell", "/")]
        [UrlToTest("http://localhost:54959/")]
        public void MakeAdminTest()
        {
            IIdStore idStore = null; // TODO: Initialize to an appropriate value
            ILogger logger = null; // TODO: Initialize to an appropriate value
            UserController target = new UserController(idStore, logger); // TODO: Initialize to an appropriate value
            string id = string.Empty; // TODO: Initialize to an appropriate value
            bool status = false; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.MakeAdmin(id, status);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Search
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Gerardo Flores\\repos\\Shell\\Shell", "/")]
        [UrlToTest("http://localhost:54959/")]
        public void SearchTest()
        {
            IIdStore idStore = null; // TODO: Initialize to an appropriate value
            ILogger logger = null; // TODO: Initialize to an appropriate value
            UserController target = new UserController(idStore, logger); // TODO: Initialize to an appropriate value
            string search = string.Empty; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Search(search);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Suspend
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Gerardo Flores\\repos\\Shell\\Shell", "/")]
        [UrlToTest("http://localhost:54959/")]
        public void SuspendTest()
        {
            IIdStore idStore = null; // TODO: Initialize to an appropriate value
            ILogger logger = null; // TODO: Initialize to an appropriate value
            UserController target = new UserController(idStore, logger); // TODO: Initialize to an appropriate value
            string id = string.Empty; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Suspend(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
