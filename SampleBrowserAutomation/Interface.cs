using OpenQA.Selenium;

namespace BrowserControls
{
    public static class Interface
    {
        public static IWebDriver Driver { get; set; }
        public static IWebElement Element { get; set; }
    }
}
