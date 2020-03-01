namespace BrowserControls
{
    using OpenQA.Selenium;

    /// <summary>
    /// Class of the page user actions.
    /// </summary>
    public class PageActions
    {
        /// <summary>
        /// Clicks a selector on the page.
        /// </summary>
        /// <param name="selector">CSS selector that will be clicked.</param>
        public void PageClick(string selector)
        {
            Interface.Driver.FindElement(By.CssSelector(selector)).Click();
        }
    }
}
