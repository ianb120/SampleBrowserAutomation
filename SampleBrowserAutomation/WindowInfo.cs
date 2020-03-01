namespace BrowserControls
{
    /// <summary>
    /// Class of the window of the browser, getting the current window info.
    /// </summary>
    public class WindowInfo
    {
        /// <summary>
        /// Will get the current page title.
        /// </summary>
        /// <returns>The current page title.</returns>
        public string Title()
        {
            return Interface.Driver.Title;
        }
    }
}
