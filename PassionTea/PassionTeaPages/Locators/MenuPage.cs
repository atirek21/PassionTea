using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassionTea.PassionTeaPages.Locators
{
    public class MenuPageLocators
    {
        public By GreenTeaButton => By.Id("wsb-button-00000000-00000000-0000-000451955168");
        public By RedTeaButton => By.Id("wsb-button-00000000-0000-0000-0000-000451959280");
        public By OolongTeaButton => By.Id("wsb-button-00000000-0000-0000-0000-0000451961556");
        public By PageHeader => By.XPath("//h1[.='Menu']");
        public By PageSectionHeader(string text) => By.XPath($"//span/strong[.='{text}']");
    }
}
