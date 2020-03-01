namespace BrowserControls
{
    using OpenQA.Selenium;

    public class PageActions
    {
        public void PageClick(string selector)
        {
            Interface.Driver.FindElement(By.CssSelector(selector)).Click();
        }
    }
}
