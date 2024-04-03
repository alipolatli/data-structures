class WebBrowser
{
    private Stack<string> historyStack;
    private string currentPage;

    public string CurrentPage
    {
        get { return currentPage; }
    }

    public WebBrowser()
    {
        historyStack = new();
        currentPage = "";
    }

    public void Navigate(string url)
    {
        // Add current page to history
        if (currentPage != "")
        {
            historyStack.Push(currentPage);
        }

        // Navigate to new page
        currentPage = url;
        Console.WriteLine("Navigated to: " + url);
    }

    public void GoBack()
    {
        if (historyStack.Count > 0)
        {
            currentPage = historyStack.Pop();
        }
        else
        {
            Console.WriteLine("No page to go back to.");
        }
    }
}
