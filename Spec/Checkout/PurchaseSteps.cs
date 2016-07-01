using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using PageObjects.PageObjects;
using TechTalk.SpecFlow;

namespace Spec.Checkout
{
	[Binding]
	public class PurchaseSteps
	{
		[Given(@"I selected one year subscription")]
		public void GivenISelectedOneYearSubscription()
		{
			CheckoutSelectionPage checkoutSelectionPage = new HomePage()
			.Header
			.NavigateToCheckoutSsubscriptionSelectionPage();
		}

		[When(@"I select number of subscriptions (.*)")]
		public void WhenISelectNumberOfSubscriptions(int quantity)
		{
			ScenarioContext.Current.Add("Quantity", quantity);
			LoginRegisterPage loginRegisterPage = new CheckoutSelectionPage().SelectBasicSubscription(quantity);
		}

		[Then(@"quantity on should be the same as at the beginning")]
		public void ThenQuantityOnShouldBeTheSameAsAtTheBeginning()
		{
			Assert.AreEqual(ScenarioContext.Current["Quantity"], new PaymentPage().GetNumberOfOrderedSubscriptions(), "Quantity has changed!");
		}

		[When(@"I pay for the subscription")]
		public void WhenIPayForTheSubscription()
		{
			ConfirmationPage confirmationPage = new PaymentPage()
				.PaySuccesfully("MasterCard", "5555555555554444", "111", "2020");
		}

		[Then(@"number of purchased subscriptions should be the same on the receipt")]
		public void ThenNumberOfPurchasedSubscriptionsShouldBeTheSameOnTheReceipt()
		{
			Assert.AreEqual(ScenarioContext.Current["Quantity"], new ConfirmationPage().GetNumberOfOrderedSubscriptions(), "Quantity has changed!");
		}

		[When(@"I go to payment page")]
		public void WhenIGoToPaymentPage()
		{
			PaymentPage paymentPage = new YourDetailsPage()
			.EnterDetailsAndGoNext("Mr", "Bob", "Tester", "Engineer", "QACorp.", "9876543", string.Empty, "United Kingdom", "Tester Road", string.Empty, string.Empty, "Tester City", string.Empty, string.Empty, string.Empty, "12345")
			.GoNext()
			.ProceedToPaymentPage();
		}

		[When(@"I subscribe successfully with following card type (.*) and number (.*) and security number (.*) and expirationYear (.*)")]
		public void WhenISubscribeSuccessfullyWithFollowingCardTypeVisaAndNumberAndSecurityNumberAndExpirationMonthAndExpirationYear(string type, string number, string security, string year)
		{
			ConfirmationPage confirmationPage = new PaymentPage()
				.PaySuccesfully(type, number, security, year);
		}
	}
}
