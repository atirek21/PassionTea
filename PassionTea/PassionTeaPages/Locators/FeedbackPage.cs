using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassionTea.PassionTeaPages.Locators
{
    public class FeedbackPageLocators
    {
        public By EmailInput => By.Name("email");
        public By NameInput => By.Name("name");
        public By SubjectInput => By.Name("subject");
        public By MessageInput => By.Name("message");
        public By SubmitButton => By.ClassName("form-submit");
        public By FeedbackConfirmationHeader => By.XPath($"//h1[text()='{Constants.FeedbackConfirmationHeaderText}']");
        public By PageHeader => By.XPath($"//h1[contains(.,\"{Constants.LetsTalkTeaHeaderText}\"]");
        public By PageSectionHeader(string text) => By.XPath($"//label[@class='form_label'and text()='{text}']");
    }
}
