using System;
using NUnit.Framework;
using PageObjects.PageObjects;
using TechTalk.SpecFlow;

namespace Spec.Checkout
{
	[Binding]
	public class LoginRegisterSteps
	{
		[When(@"I try to register with invalid email (.*)")]
		public void WhenITryToRegisterWithInvalidEmail(string email)
		{
			LoginRegisterPage loginRegisterPage = new LoginRegisterPage()
			.FailToCreateAccount(email);
		}

		[Then(@"Validation message should be displayed")]
		public void ThenValidationMessageShouldBeDisplayed()
		{
			Assert.IsTrue(new LoginRegisterPage().InvalidEmailEnteredMessageIsDisplayed(), "Invalid email message should be displayed, but wasn't.");
		}
	}
}
