namespace PageObjects
{
    /// <summary>
    /// Class which holds the refernces of the page.
    /// </summary>
    public static class PageReferences
    {
        /// <summary>
        /// URL of the page to go to.
        /// </summary>
        public static string url = "http://www.google.com";

        /// <summary>
        /// How it works page selector.
        /// </summary>
        public static string howItWorksLink = "[href=\"//google.com/search/howsearchworks/?fg=1\"]";

        /// <summary>
        /// Expected results of the tested page title.
        /// </summary>
        public static string expectedResults = "How Google Search works | Overview";
    }
}
