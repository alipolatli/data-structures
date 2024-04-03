class Program
{
    static void Main(string[] args)
    {
        WebBrowser browser = new WebBrowser();
        browser.Navigate("https://www.google.com");
        browser.Navigate("https://www.wikipedia.org");
        browser.Navigate("https://www.github.com");

        Console.WriteLine("Current Page: " + browser.CurrentPage); 
        browser.GoBack();
        Console.WriteLine("Current Page after GoBack(): " + browser.CurrentPage);
        browser.GoBack();
        Console.WriteLine("Current Page after GoBack(): " + browser.CurrentPage);
    }
}
