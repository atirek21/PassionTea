using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassionTea.PassionTeaPages.Locators
{
    public class WelcomePageLocators
    {
        public By HerbalTeaSeeCollectionButton => By.CssSelector("a[id$='000450914890']");
        public By LooseTeaSeeCollectionButton => By.CssSelector("a[id$='000450914897']");
        public By FlavoredTeaSeeCollectionButton => By.CssSelector("a[id$='000450914849']");
        public By LetsTalkTeaLink => By.LinkText($"'{Constants.LetsTalkTeaHeaderText}'");
        public By PageHeader => By.XPath($"//h1[contains(.,\"{Constants.WelcomePageHeaderText}\")]");
    
    }
}
