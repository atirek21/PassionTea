using NUnit.Framework;
using PassionTea.Cards;
using PassionTea.Core.Extensions;
using PassionTea.Core.Utilities;
using PassionTea.FormData.Builders;
using PassionTea.PassionTeaPages.Executors;
using System;
using TechTalk.SpecFlow;
using System.Configuration;

namespace PassionTea
{
    [Binding]
    public class PassionTeaWebsiteSteps
    {
        private readonly MenuPage menupage = new MenuPage();
        private readonly WelcomePage welcomePage = new WelcomePage();
        private readonly CheckOutPage checkOutPage = new CheckOutPage();
        private readonly FeedbackPage feedbackPage = new FeedbackPage();
        [Given(@"I am on the Passion Tea Website")]
        public void GivenIAmOnThePassionTeaWebsite()
        {
            Browser.GoToUrl(ConfigurationManager.AppSettings["PassionTea"]);
        }
        
        [Given(@"I go to Herbal Tea Section")]
        public void GivenIGoToHerbalTeaSection()
        {
            this.welcomePage.ClickHerbalTeaSeeCollectionButton();
        }
        
        [Given(@"I click on Let's Talk Tea link in the homepage")]
        public void GivenIClickOnLetSTalkTeaLinkInTheHomepage()
        {
            this.welcomePage.LetsTalkTeaLink.ClickWithWait();
        }
        
        [When(@"I select Red Tea")]
        public void WhenISelectRedTea()
        {
            this.menupage.ClickRedTeaButton();
        }
        
        [When(@"place order")]
        public void WhenPlaceOrder()
        {
            var checkoutDetails = CheckOutFormBuilder.BuildCheckOutDetails(CardType.Visa);
            this.checkOutPage.FillCheckoutFormAndSubmit(checkoutDetails);
        }
        
        [When(@"I select Green Tea")]
        public void WhenISelectGreenTea()
        {
            this.menupage.ClickGreenTeaButton();
        }
        
        [When(@"I fill the Feedback Form")]
        public void WhenIFillTheFeedbackForm()
        {
            var feedbackDetails = FeedbackFormBuilder.BuildFeedbackDetails();
            this.feedbackPage.FillFeedbackForm(feedbackDetails);
        }
        
        [Then(@"I am able to see the Welcome Page")]
        public void ThenIAmAbleToSeeTheWelcomePage()
        {
            Assert.IsTrue(this.welcomePage.PageHeader.IsDisplayedAfterWait(), $"{Constants.WelcomePageHeaderText}Header is not displayed");
        }
        
        [Then(@"I should see the Order Confirmation Page")]
        public void ThenIShouldSeeTheOrderConfirmationPage()
        {
            Assert.IsTrue(this.checkOutPage.PageHeader.IsDisplayedAfterWait(), $"Page Header{Constants.CheckoutConfirmationPageHeaderText}is not displayed";
        }
        
        [Then(@"I submit the Feedback form")]
        public void ThenISubmitTheFeedbackForm()
        {
            this.feedbackPage.SubmitButton.ClickWithWait();
        }
        
        [Then(@"I should see a Feedback Confirmation Page")]
        public void ThenIShouldSeeAFeedbackConfirmationPage()
        {
            Assert.IsTrue(this.feedbackPage.FeedbackConfirmationHeader.IsDisplayedAfterWait(), $"{Constants.FeedbackConfirmationHeaderText}Header is not displayed");
        }
    }
}
