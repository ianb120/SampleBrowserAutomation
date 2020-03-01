using OpenQA.Selenium;

namespace BrowserControls
{
    /// <summary>
    /// Class which is used by the other methods in the browser controls project.
    /// </summary>
    public static class Interface
    {
        /// <summary>
        /// Fields that are used in the browser control methods.
        /// </summary>
        public static IWebDriver Driver { get; set; }
        public static IWebElement Element { get; set; }
    }
}
