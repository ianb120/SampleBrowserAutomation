using BrowserControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects;

namespace SimpleTests
{
    /// <summary>
    /// Test class for some simple tests.
    /// </summary>
    [TestClass]
    public class BrowserTest
    {
        /// <summary>
        /// Creates a new instance of the classes to interact with the browser.
        /// </summary>
        private BrowserSetUp currentBrowser = new BrowserSetUp();
        private PageActions action = new PageActions();
        private WindowInfo window = new WindowInfo();

        /// <summary>
        /// Sets up the pre conditons before the test is run.
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            currentBrowser.LoadBrowser();
        }

        /// <summary>
        /// Post conditions that run once the test has finished.
        /// </summary>
        [TestCleanup]
        public void TearDown()
        {
            currentBrowser.CloseBrowser();
        }

        /// <summary>
        /// Simple test that asserts the page title is as expected.
        /// </summary>
        [TestMethod]
        public void TitleCheck()
        {
            // loads the google home page
            currentBrowser.GoTo(PageReferences.url);

            // clicks the how it works link
            action.PageClick(PageReferences.howItWorksLink);

            // checks the page title is as expected
            Assert.AreEqual(PageReferences.expectedResults, window.Title());

        }
    }
}
