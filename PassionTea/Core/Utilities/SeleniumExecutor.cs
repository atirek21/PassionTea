using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Configuration;


namespace PassionTea.Core.Utilities
{
    public static class SeleniumExecutor
    {
        private static IWebDriver webDriver;
        private static ISearchContext => Driver();
        private static IWebDriver Driver()
        {
            return webDriver ?? (webDriver = Initialize());
        }
        public static IWebDriver Initialize()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            return webDriver = new ChromeDriver(options);
        }

        public static void Close()
        {
            webDriver.Close();
        }
    }  public static WebDriverWait GetWaitDriver(int timeout=0)
    {
        var waitTimeout = timeout == 0 ? int.Parse(ConfigurationManager.AppSettings["waitTimeout"]) : timeout;
        return new WebDriverWait(Driver(), TimeSpan.FromSeconds(waitTimeout));
    }
    public static void TakeScreenShot(string fileName)
    {
        var requiredPath = FileHelper.GetScreenshotPath();
        var dateandTime = string.Format("(0:yyyy-MM-dd_hh-mm-ss-fff", DateTime.Now);
        var filePath = string.Format(@"{0}-{1}--{2}.jpg", requiredPath, fileName, dateandTime);
        Screenshot ss = ((ITakesScreenshot)webDriver).GetScreenshot();
        ss.SaveAsFile(filePath, ScreenshotImageFormat.Png);
    }
}
