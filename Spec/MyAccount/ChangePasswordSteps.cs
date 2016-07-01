using System.Collections.Generic;
using Core;
using Core.Configuration;
using Core.Controls;
using Core.Helpers;
using Core.Users;
using NUnit.Framework;
using PageObjects.PageObjects;
using TechTalk.SpecFlow;

namespace Spec.MyAccount
{
	[Binding]
	public class ChangePasswordSteps
	{
		[Then(@"MyAccount Change Password page is displayed correctly")]
		public void ThenMyAccountChangePasswordPageIsDisplayedCorrectly()
		{
			var changePasswordPage = new ChangePasswordPage();

			Assert.IsTrue(changePasswordPage.IsDisplayedCorrectly(), "Change password page is not displayed corectly.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.MyAccountChangePasswordUrl), "Change Password page url is not as expected.");
			Assert.IsTrue(changePasswordPage.SidePanel.PageIsDisplayed("Default"), "Side panel is not displayed.");
			Assert.IsTrue(changePasswordPage.Header.PageIsDisplayed(), "Header component is not displayed corectly.");
			Assert.IsTrue(changePasswordPage.TopMenu.PageIsDisplayed("Default"), "Top Menu is not displayed corectly.");
			Assert.IsTrue(changePasswordPage.Breadcrumb.PageIsDisplayed("ChangePassword"), "Breadcrump is not displayed corectly.");
			Assert.IsTrue(changePasswordPage.Footer.PageIsDisplayed(), "Footer is not displayed corectly.");
		}

		[Given(@"I enter My Account Change Password page")]
		public void GivenIEnterMyAccountChangePasswordPage()
		{
			ChangePasswordPage changePasswordPage = new HomePage()
						.Header
						.NavigateToTheMyAccount()
						.NavigateToTheChangePasswordPage();
		}

		[When(@"I try to change password without entering any data to the textboxes")]
		public void WhenITryToChangePasswordWithoutEnteringAnyDataToTheTextboxes()
		{
			var changePasswordPage = new ChangePasswordPage()
				.ChangePasswordFailed(string.Empty, string.Empty, string.Empty);
		}

		[Then(@"there should be Please enter your old password validation messages displayed")]
		public void ThenThereShouldBePleaseEnterYourOldPasswordValidationMessagesDisplayed()
		{
			Assert.IsTrue(new ChangePasswordPage().IsOldPasswordValidationMessageDisplayed(), "Old password validation message is not displayed.");
		}

		[Then(@"there should be Please enter your new password  validation messages displayed")]
		public void ThenThereShouldBePleaseEnterYourNewPasswordValidationMessagesDisplayed()
		{
			Assert.IsTrue(new ChangePasswordPage().IsNewPasswordValidationMessageDisplayed(), "New password validation message is not displayed.");
		}

		[Then(@"there should be Please confirm your new password validation messages displayed")]
		public void ThenThereShouldBePleaseConfirmYourNewPasswordValidationMessagesDisplayed()
		{
			Assert.IsTrue(new ChangePasswordPage().IsConfirmNewPasswordValidationMessageDisplayed(), "Confirm password validation message is not displayed.");
		}

		[When(@"I try to change password by using incorrect old password")]
		public void WhenITryToChangePasswordByUsingIncorrectOldPassword()
		{
			var changePasswordPage = new ChangePasswordPage().ChangePasswordFailed(
																					"IncorrectOldPassword##$%#",
																					"skdf3333e#",
																					"skdf3333e#");
		}

		[Then(@"there should be The details you have provided are invalid\. Please re-enter and try again message displayed")]
		public void ThenThereShouldBeTheDetailsYouHaveProvidedAreInvalid_PleaseRe_EnterAndTryAgainMessageDisplayed()
		{
			Assert.IsTrue(new ChangePasswordPage().IsPasswordDoNotMatchValidationMessageDisplayed(), "Password do not match validation message is not displayed.");
		}

		[When(@"I try to change password by using incorrect confirmation password")]
		public void WhenITryToChangePasswordByUsingIncorrectConfirmationPassword()
		{
			Credentials credentials = FeatureContext.Current.Get<Credentials>("Credentials");

			var changePasswordPage = new ChangePasswordPage().ChangePasswordFailed(
																				credentials.Password,
																				"somePassword3433$#$%",
																				"differentPassword23223&^");
		}

		[Then(@"there should be Your new passwords do not match validation messages displayed")]
		public void ThenThereShouldBeYourNewPasswordsDoNotMatchValidationMessagesDisplayed()
		{
			Assert.IsTrue(new ChangePasswordPage().IsYourNewPasswordDoNotMatchValidationMessageDisplayed(), "Your new password do not match validation message is not displayed.");
		}

		[When(@"I change my password correctly")]
		public void WhenIChangeMyPasswordCorrectly()
		{
			Credentials credentials = ScenarioContext.Current.Get<Credentials>("Credentials");
			new ChangePasswordPage().ChangePasswordSuccessfullyPasswordUpdatedPageDisplayed(
																credentials.Password,
																ApplicationConfiguration.ChangePasswordTestDifferentUserPassword,
																ApplicationConfiguration.ChangePasswordTestDifferentUserPassword);
		}

		[Then(@"Password Updated page is displayed")]
		public void ThenPasswordUpdatedPageIsDisplayed()
		{
			PasswordUpdatedPage passwordUpdatedPage = new PasswordUpdatedPage();

			Assert.IsTrue(passwordUpdatedPage.IsDisplayed(), "Password updated page is not displayed correctly.");
		}

		[Then(@"Password Updated pageshould be displayed correctly")]
		public void ThenPasswordUpdatedPageshouldBeDisplayedCorrectly()
		{
			PasswordUpdatedPage passwordUpdatedPage = new PasswordUpdatedPage();

			Assert.IsTrue(passwordUpdatedPage.IsDisplayed(), "Password updated page is not displayed correctly.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.MyAccountPasswordUpdatedUrl), "Password updated url is not as expected.");
			Assert.IsTrue(passwordUpdatedPage.SidePanel.PageIsDisplayed("Default"), "Side panel is not displayed correctly.");
			Assert.IsTrue(passwordUpdatedPage.Header.PageIsDisplayed(), "Header component is not displayed correctly.");
			Assert.IsTrue(passwordUpdatedPage.TopMenu.PageIsDisplayed("Default"), "Top Menu is not displayed correctly.");
			Assert.IsTrue(passwordUpdatedPage.Breadcrumb.PageIsDisplayed("PasswordUpdated"), "Password updated breadcrump is not displayed correctly.");
			Assert.IsTrue(passwordUpdatedPage.Footer.PageIsDisplayed(), "Footer is not displayed correctly.");
		}

		[Then(@"I revert those password changes for further testing")]
		public void ThenIRevertThosePasswordChangesForFurtherTesting()
		{
			new PasswordUpdatedPage().NavigateToTheChangePassword().ChangePasswordSuccessfullyPasswordUpdatedPageDisplayed(
																								ApplicationConfiguration.ChangePasswordTestDifferentUserPassword,
																								ApplicationConfiguration.ChangePasswordTestExistingUserPassword,
																								ApplicationConfiguration.ChangePasswordTestExistingUserPassword);
		}

		[Given(@"I'm on the My Account Change Password page")]
		public void GivenIMOnTheMyAccountChangePasswordPage()
		{
			Credentials credentials = new Credentials();

			try
			{
				credentials = ScenarioContext.Current.Get<Credentials>("Credentials");
			}
			catch (KeyNotFoundException)
			{
				credentials = FeatureContext.Current.Get<Credentials>("Credentials");
			}

			var changePaswordPage = new HomePage()
							.Header
							.NavigateToTheLoginPage()
							.LoginToTheUserAccountSuccessfully(credentials.Email, credentials.Password, false)
							.Header
							.NavigateToTheMyAccount()
							.NavigateToTheChangePasswordPage();
		}

		[When(@"I try to change password without providing any data to the textboxes")]
		public void WhenITryToChangePasswordWithoutProvidingAnyDataToTheTextboxes()
		{
			var changePasswordPage = new ChangePasswordPage().ChangePasswordFailedPopupDisplayed(string.Empty, string.Empty, string.Empty);

			ScenarioContext.Current.Add("messageBoxTextValue", new MessageBox().Text);
			new MessageBox().Accept();
		}

		[Then(@"there should be ""(.*)"" validation message displayed")]
		public void ThenThereShouldBeValidationMessageDisplayed(string validationMessage)
		{
			Assert.IsTrue(new ChangePasswordPage().IsPasswordValidationPopupMessageDisplayed(validationMessage, ScenarioContext.Current.Get<string>("messageBoxTextValue")));
		}

		[Then(@"there should be The old password is not correct message displayed")]
		public void ThenThereShouldBeTheOldPasswordIsNotCorrectMessageDisplayed()
		{
			Assert.IsTrue(new ChangePasswordPage().IsPasswordDoNotMatchValidationMessageDisplayed(), "Password do not match validation message is not displayed.");
		}

		[When(@"I try to change password by providing incorrect confirmation password")]
		public void WhenITryToChangePasswordByProvidingIncorrectConfirmationPassword()
		{
			new ChangePasswordPage().ChangePasswordFailedPopupDisplayed(
																		ApplicationConfiguration.ChangePasswordTestExistingUserPassword,
																		ApplicationConfiguration.IncorrectUserPassword,
																		ApplicationConfiguration.ChangePasswordTestExistingUserPassword);

			ScenarioContext.Current.Add("messageBoxTextValue", new MessageBox().Text);
			new MessageBox().Accept();
		}

		[Then(@"Password Updated message is displayed")]
		public void ThenPasswordUpdatedMessageIsDisplayed()
		{
			Assert.IsTrue(new ChangePasswordPage().IsYourPasswordHasBeenUpdatedMessageDisplayed(), "Password has been updated validation message is not displayed.");
		}

		[Then(@"I revert password changes for further testing")]
		public void ThenIRevertPasswordChangesForFurtherTesting()
		{
			new ChangePasswordPage().ChangePasswordSuccessfully(
																ApplicationConfiguration.ChangePasswordTestDifferentUserPassword,
																ApplicationConfiguration.ChangePasswordTestExistingUserPassword,
																ApplicationConfiguration.ChangePasswordTestExistingUserPassword);
		}

		[Given(@"I've created a new account")]
		public void GivenIVeCreatedANewAccount()
		{
			Credentials credentials = new LoginPage().CreateFreeTrialAccount();
			ScenarioContext.Current.Add("Credentials", credentials);
		}
	}
}
