﻿using Shell.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using Shell.Infrastructure.Logging;
using Shell.Infrastructure.BackgroundJobs;
using Shell.Infrastructure.IdStore;
using System.Web.Mvc;

namespace Shell.Tests
{
    
    
    /// <summary>
    ///This is a test class for QueueControllerTest and is intended
    ///to contain all QueueControllerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class QueueControllerTest
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
        ///A test for QueueController Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Gerardo Flores\\repos\\Shell\\Shell", "/")]
        [UrlToTest("http://localhost:54959/")]
        public void QueueControllerConstructorTest()
        {
            ILogger logger = null; // TODO: Initialize to an appropriate value
            IBackgroundJobManager manager = null; // TODO: Initialize to an appropriate value
            IIdStore store = null; // TODO: Initialize to an appropriate value
            QueueController target = new QueueController(logger, manager, store);
            Assert.Inconclusive("TODO: Implement code to verify target");
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
            ILogger logger = null; // TODO: Initialize to an appropriate value
            IBackgroundJobManager manager = null; // TODO: Initialize to an appropriate value
            IIdStore store = null; // TODO: Initialize to an appropriate value
            QueueController target = new QueueController(logger, manager, store); // TODO: Initialize to an appropriate value
            int pageNum = 0; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Index(pageNum);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
