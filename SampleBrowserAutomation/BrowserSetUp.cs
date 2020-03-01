using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace BrowserControls
{
    public class BrowserSetUp
    {
        public void LoadBrowser()
        {
            ChromeDriver driver = new ChromeDriver();
            Interface.Driver = driver;
        }

        public void LoadUrl(string url)
        {
            Interface.Driver.Navigate().GoToUrl(url);
        }

        public void CloseBrowser()
        {
            Interface.Driver.Quit();
        }
    }
}
