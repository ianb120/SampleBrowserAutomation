using BrowserControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleTests
{
    [TestClass]
    public class BrowserTest
    {
        private BrowserSetUp currentBrowser = new BrowserSetUp();
        private PageActions action = new PageActions();
        private WindowInfo window = new WindowInfo();

        [TestInitialize]
        public void SetUp()
        {
            currentBrowser.LoadBrowser();
        }

        [TestCleanup]
        public void TearDown()
        {
            currentBrowser.CloseBrowser();
        }

        [TestMethod]
        public void TitleCheck()
        {
            currentBrowser.LoadUrl("http://www.google.com");
            action.PageClick("#fsl > a:nth-child(3)");

            Assert.AreEqual("How Google Search works | Overview", window.Title());

        }
    }
}
