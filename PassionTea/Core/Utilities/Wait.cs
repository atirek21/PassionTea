using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using OpenQA.Selenium.Support.UI;

namespace PassionTea.Core.Utilities
{
    public static class Wait
    {
        public static void ForElementToBeVisible(By elementLocator,int timeout=0)
        {
            timeout = timeout == 0 ? int.Parse(ConfigurationManager.AppSettings["waitTimeout"]) : timeout;
            try
            {
                SeleniumExecutor.GetWaitDriver(timeout).Until(ExpectedConditions.ElementIsVisible(elementLocator));
            }
            catch(WebDriverTimeoutException e)
            {
                throw new WebDriverTimeoutException($"Element with Locator:'{elementLocator}'wasn't visible within timeout limit",e)
            }
        }
    }
}
