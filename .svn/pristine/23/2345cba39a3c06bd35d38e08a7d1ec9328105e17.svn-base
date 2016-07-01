using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Helpers;
using NUnit.Framework;
using PageObjects.PageObjects;
using TechTalk.SpecFlow;

namespace Spec.Registration
{
	[Binding]
	public class SignUpSteps
	{
		[Given(@"I'm on sign up page")]
		public void GivenIMOnSignUpPage()
		{
			new HomePage().Header.NavigateToSignUpPage();
		}

		[When(@"I submit registration form")]
		public void WhenISubmitRegistrationForm()
		{
			string email = BasicHelper.GetRandomEmail();
			string title = "Mr";
			string firstName = "Bob";
			string lastName = "Tester";
			string jobTitle = "Engineer";
			string company = "Tester Corp.";
			string country = "United Kingdom";

			new SignUpPage().SignUpSuccesfuly(email, title, firstName, lastName, jobTitle, company, country);
		}

		[Then(@"I should be registered")]
		public void ThenIShouldBeRegistered()
		{
			SignUpSuccessfulPage signUpSuccessfulyPage = new SignUpSuccessfulPage();
			Assert.IsTrue(signUpSuccessfulyPage.SignUpSuccessfulMessageIsDisplayed(), "Sign up succesfuly message is not displayed.");
		}
	}
}
