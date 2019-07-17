using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassionTea.PassionTeaPages.Locators
{
    public class CheckoutPageLocators
    {
        public By EmailInput => By.Id("email");
        public By NameInput => By.Id("name");
        public By AddressInput => By.Id("address");
        public By CardTypeDropdown => By.Id("card_type");
        public By CardNumberInput => By.Id("cardholder_name");
        public By VerificationCodeInput => By.Id("verification_code");
        public By PlaceOrder => By.ClassName("btn-primary");
        public By PageHeader => By.XPath($"//h1[text()='{Constants.CheckoutConfirmationPageHeaderText}'");
        

    }
}
