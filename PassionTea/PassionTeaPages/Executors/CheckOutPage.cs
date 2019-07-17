using PassionTea.PassionTeaPages.Locators;
using OpenQA.Selenium;
using PassionTea.Core.Extensions;
using PassionTea.Form_Data.Objects;

namespace PassionTea.PassionTeaPages.Executors
{
    public class CheckOutPage:CheckoutPageLocators
    
    {
        public void FillCheckoutFormAndSubmit(CheckOutFormModel model)
        {
            EmailInput.SendKeysWithWait(model.Email);
            NameInput.SendKeysWithWait(model.Name);
            AddressInput.SendKeysWithWait(model.Address);
            CardTypeDropdown.SelectText(model.CardType);
            CardNumberInput.SendKeysWithWait(model.CardNumber.ToString());
            CardholderNameInput.SendKeysWithWait(model.CardholderName);
            VerificationCodeInput.SendKeysWithWait(model.VerificationCode.ToString());
            PlaceOrder.ClickWithWait();


        }
    }
}
