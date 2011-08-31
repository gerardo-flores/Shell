using Shell.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using Shell.Infrastructure.IdStore;
using Shell.Infrastructure.Logging;

namespace Shell.Tests
{
    
    
    /// <summary>
    ///This is a test class for ApplicationControllerTest and is intended
    ///to contain all ApplicationControllerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ApplicationControllerTest
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
        ///A test for ApplicationController Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Gerardo Flores\\repos\\Shell\\Shell", "/")]
        [UrlToTest("http://localhost:54959/")]
        public void ApplicationControllerConstructorTest()
        {
            IIdStore idStore = null; // TODO: Initialize to an appropriate value
            ILogger logger = null; // TODO: Initialize to an appropriate value
            ApplicationController target = new ApplicationController(idStore, logger);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ApplicationController Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Gerardo Flores\\repos\\Shell\\Shell", "/")]
        [UrlToTest("http://localhost:54959/")]
        public void ApplicationControllerConstructorTest1()
        {
            ApplicationController target = new ApplicationController();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CurrentUser
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Gerardo Flores\\repos\\Shell\\Shell", "/")]
        [UrlToTest("http://localhost:54959/")]
        public void CurrentUserTest()
        {
            ApplicationController target = new ApplicationController(); // TODO: Initialize to an appropriate value
            object actual;
            actual = target.CurrentUser;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsAdmin
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Gerardo Flores\\repos\\Shell\\Shell", "/")]
        [UrlToTest("http://localhost:54959/")]
        public void IsAdminTest()
        {
            ApplicationController target = new ApplicationController(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsAdmin;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsLoggedIn
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Gerardo Flores\\repos\\Shell\\Shell", "/")]
        [UrlToTest("http://localhost:54959/")]
        public void IsLoggedInTest()
        {
            ApplicationController target = new ApplicationController(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsLoggedIn;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
