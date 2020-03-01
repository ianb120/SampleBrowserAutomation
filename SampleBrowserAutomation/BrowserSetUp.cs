using OpenQA.Selenium.Chrome;

namespace BrowserControls
{
    /// <summary>
    /// Class for the browser set up methods of the browser.
    /// </summary>
    public class BrowserSetUp
    {
        /// <summary>
        /// Creates a new instance of the web browser.
        /// </summary>
        public void LoadBrowser()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            ChromeDriver driver = new ChromeDriver(options);
            Interface.Driver = driver;
        }

        /// <summary>
        /// Navigates to a page URL.
        /// </summary>
        /// <param name="url">website URL.</param>
        public void GoTo(string url)
        {
            Interface.Driver.Navigate().GoToUrl(url);
        }

        /// <summary>
        /// Closes the current web browser.
        /// </summary>
        public void CloseBrowser()
        {
            Interface.Driver.Quit();
        }
    }
}
