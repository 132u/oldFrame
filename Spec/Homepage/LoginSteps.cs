using System;
using Core;
using Core.Configuration;
using NUnit.Framework;
using PageObjects.PageObjects;
using TechTalk.SpecFlow;

namespace Spec.Homepage
{
	[Binding]
	public class LoginSteps
	{
		[Given(@"I'm on the Login Page")]
		public void GivenIMOnTheLoginPage()
		{
			LoginPage loginPage = new HomePage()
				.Header
				.NavigateToTheLoginPage();

			Assert.IsTrue(loginPage.IsDisplayed(), "Login page is not displayed.");
		}

		[Then(@"Login page should be displayed correctly")]
		public void ThenLoginPageShouldBeDisplayedCorrectly()
		{
			Assert.IsTrue(new LoginPage().IsDisplayedCorrectly(), "Login page is not displayed.");
			Assert.AreEqual(ApplicationConfiguration.Url + ApplicationConfiguration.LoginPageUrl, WebBrowser.GetUrlAddress, "Login page is not displayed.");
		}

		[When(@"I login successfully")]
		public void WhenILoginSuccessfully()
		{
			HomePage homePage = new LoginPage()
				.LoginToTheUserAccountSuccessfully(ApplicationConfiguration.ExistingUserName, ApplicationConfiguration.ExistingUserPassword, false);

			Assert.IsTrue(homePage.IsDisplayed(), "Home page is not displayed.");

			homePage.Header.NavigateToTheMyAccount();
			Assert.IsTrue(homePage.Header.IsLoggedIn(), "User is not logged in.");
		}

		[Then(@"I should be logged in to user account")]
		public void ThenIShouldBeLoggedInToUserAccount()
		{
			Assert.IsTrue(new LoginPage().Header.IsLoggedIn(), "User is not logged in.");
		}

		[Then(@"I shouldn't be logged in to user account")]
		public void ThenIShouldnTBeLoggedInToUserAccount()
		{
			Assert.IsFalse(new LoginPage().Header.IsLoggedIn(), "User is logged in.");
		}

		[When(@"I try to login with incorrect username")]
		public void WhenITryToLoginWithIncorrectUsername()
		{
			new LoginPage().LoginToTheUserAccountFailed(ApplicationConfiguration.IncorrectUserName, ApplicationConfiguration.ExistingUserPassword);
		}

		[When(@"I try to login with incorrect password")]
		public void WhenITryToLoginWithIncorrectPassword()
		{
			new LoginPage().LoginToTheUserAccountFailed(ApplicationConfiguration.ExistingUserName, ApplicationConfiguration.IncorrectUserPassword);
		}

		[When(@"I try to login with incorrect username and password")]
		public void WhenITryToLoginWithIncorrectUsernameAndPassword()
		{
			new LoginPage().LoginToTheUserAccountFailed(ApplicationConfiguration.IncorrectUserPassword, ApplicationConfiguration.IncorrectUserPassword);
		}

		[When(@"I logout correct")]
		public void WhenILogoutCorrect()
		{
			var homePage  = new HomePage()
				.Header
				.NavigateToTheMyAccount()
				.Header
				.LogoutFromTheUserAccount();

			Assert.IsTrue(homePage.IsDisplayed(), "Home page is not displayed.");
			Assert.IsFalse(new LoginPage().Header.IsLoggedIn(), "User is logged in.");
		}

		[Then(@"I should be logged out from the user account")]
		public void ThenIShouldBeLoggedOutFromTheUserAccount()
		{
			Assert.IsFalse(new LoginPage().Header.IsLoggedIn(), "User is logged in.");
		}
	}
}