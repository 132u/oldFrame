using System;
using Core;
using Core.Configuration;
using NUnit.Framework;
using PageObjects.PageObjects;
using TechTalk.SpecFlow;

namespace Spec.FreeTrial
{
	[Binding]
	public class FreeTrialSteps
	{
		[Given(@"I'm not logged in")]
		public void GivenIMNotLoggedIn()
		{
			Assert.IsFalse(new HeaderComponent().IsLoggedIn(), "User is logged in.");
		}

		[When(@"I enter Free Trial page by Header Component link")]
		public void WhenIEnterFreeTrialPageByHeaderComponentLink()
		{
			new HomePage().Header.NavigateToTheFreeTrial();
		}

		[Then(@"Free Trial First Step page should be displayed correctly")]
		public void ThenFreeTrialFirstStepPageShouldBeDisplayedCorrectly()
		{
			Assert.IsTrue(new FreeTrialStepOnePage().IsDisplayedCorrectly(), "Free Trial step one page is not displayed correctly.");
			Assert.AreEqual(ApplicationConfiguration.Url + ApplicationConfiguration.FreeTrialStepOneUrl, WebBrowser.GetUrlAddress, "Free Trial step one page url is not as expected.");
		}

		[When(@"I try to get to the step two of registration without entering any credentials")]
		public void WhenITryToGetToTheStepTwoOfRegistrationWithoutEnteringAnyCredentials()
		{
			new HomePage()
						.Header
						.NavigateToTheFreeTrial()
						.NavigateToTheFreeTrialStepTwoFailed(string.Empty, string.Empty);
		}

		[Then(@"there should be You must enter an e-mail address validation message displayed")]
		public void ThenThereShouldBeYouMustEnterAnE_MailAddressValidationMessageDisplayed()
		{
			Assert.IsTrue(new FreeTrialStepOnePage().IsEmailAddressValidationMessageDisplayed(), "Email address validation message not displayed.");
		}

		[Then(@"there should be You must confirm your e-mail address validation message displayed")]
		public void ThenThereShouldBeYouMustConfirmYourE_MailAddressValidationMessageDisplayed()
		{
			Assert.IsTrue(new FreeTrialStepOnePage().IsEmailAddressConfirmationValidationMessageDisplayed(), "Email address confirmation validation message not displayed.");
		}

		[When(@"I try to get to the step two of registration without entering Email confirmation address")]
		public void WhenITryToGetToTheStepTwoOfRegistrationWithoutEnteringEmailConfirmationAddress()
		{
			new HomePage()
						.Header
						.NavigateToTheFreeTrial()
						.NavigateToTheFreeTrialStepTwoFailed(ApplicationConfiguration.NotExistingUserName, string.Empty);
		}

		[When(@"I try to get to the step two of registration without entering Email address")]
		public void WhenITryToGetToTheStepTwoOfRegistrationWithoutEnteringEmailAddress()
		{
			new HomePage()
						.Header
						.NavigateToTheFreeTrial()
						.NavigateToTheFreeTrialStepTwoFailed(string.Empty, ApplicationConfiguration.NotExistingUserName);
		}

		[Then(@"there should be The email address must be the same validation message displayed")]
		public void ThenThereShouldBeTheEmailAddressMustBeTheSameValidationMessageDisplayed()
		{
			Assert.IsTrue(new FreeTrialStepOnePage().IsEmailAddressMustBeTheSameValidationMessageDisplayed(), "Email address must be the same validation message not displayed.");
		}

		[When(@"I try to get to the step two of registration with invalid email confirmation address")]
		public void WhenITryToGetToTheStepTwoOfRegistrationWithInvalidEmailConfirmationAddress()
		{
			new HomePage()
						.Header
						.NavigateToTheFreeTrial()
						.NavigateToTheFreeTrialStepTwoFailed(ApplicationConfiguration.NotExistingUserName, ApplicationConfiguration.IncorrectUserName);
		}

		[When(@"I try to get to the step two of registration with correct data")]
		public void WhenITryToGetToTheStepTwoOfRegistrationWithCorrectData()
		{
			new HomePage()
						.Header
						.NavigateToTheFreeTrial()
						.NavigateToTheFreeTrialStepTwoSuccessfully();
		}

		[Then(@"there should be The password you supplied was incorrect validation message displayed")]
		public void ThenThereShouldBeThePasswordYouSuppliedWasIncorrectValidationMessageDisplayed()
		{
			Assert.IsTrue(new FreeTrialEnterExistingUserPasswordPage().IsPasswordValidationMessageDisplayed(), "Password validation message is not displayed.");
		}

		[When(@"I try to get to the step two of registration by using existing user email address and invalid password")]
		public void WhenITryToGetToTheStepTwoOfRegistrationByUsingExistingUserEmailAddressAndInvalidPassword()
		{
			var freeTrialEnterExistingUserPasswordPage = new HomePage()
																	.Header
																	.NavigateToTheFreeTrial()
																	.NavigateToStepOneByUsingExistingCredentials(ApplicationConfiguration.ExistingExpiredUserName);

			freeTrialEnterExistingUserPasswordPage.NavigateToTheFreeTrialStepTwoFailed(ApplicationConfiguration.IncorrectUserPassword);
		}

		[Then(@"Existing user page should be displayed correctly")]
		public void ThenExistingUserPageShouldBeDisplayedCorrectly()
		{
			Assert.IsTrue(new FreeTrialEnterExistingUserPasswordPage().IsDisplayedCorrectly(), "Free Trial Enter existing password page is not displayed.");
		}

		[When(@"I try to get to the step two of registration by using existing user email address and valid password")]
		public void WhenITryToGetToTheStepTwoOfRegistrationByUsingExistingUserEmailAddressAndValidPassword()
		{
			var freeTrialEnterExistingUserPasswordPage = new HomePage()
																	.Header
																	.NavigateToTheFreeTrial()
																	.NavigateToStepOneByUsingExistingCredentials(ApplicationConfiguration.ExistingExpiredUserName);

			var freeTrialStepTwoRegistrationPage = freeTrialEnterExistingUserPasswordPage.NavigateToTheFreeTrialStepTwoSuccessfully(ApplicationConfiguration.ExistingExpiredUserPassword);
		}

		[Then(@"I should be redirected to the Free Trial Second Step page")]
		public void ThenIShouldBeRedirectedToTheFreeTrialSecondStepPage()
		{
			Assert.IsTrue(new FreeTrialStepTwoPage().IsDsiplayed(), "Free Trial Step Two registration page is not displayed.");
		}

		[Then(@"Free Trial second page should be displayed correctly")]
		public void ThenFreeTrialSecondPageShouldBeDisplayedCorrectly()
		{
			Assert.IsTrue(new FreeTrialStepTwoPage().IsDisplayedCorrectly(), "Free Trial Step Two registration page is not displayed correctly.");
		}

		[Given(@"I'm on the Free Trial Second Step page")]
		public void GivenIMOnTheFreeTrialSecondStepPage()
		{
			new HomePage()
						.Header
						.NavigateToTheFreeTrial()
						.NavigateToTheFreeTrialStepTwoSuccessfully();

			Assert.IsTrue(new FreeTrialStepTwoPage().IsDsiplayed(), "Free Trial Step Two registration page is not displayed.");
		}

		[When(@"I try to register as a new user with valid data provided")]
		public void WhenITryToRegisterAsANewUserWithValidDataProvided()
		{
			new FreeTrialStepTwoPage().RegisterForFreeTrialSuccessfuly(
																	"Mr",
																	"testFirstName",
																	"testLastName",
																	"testJobTitle",
																	"testCompanyName",
																	"12345678",
																	"testAddressName",
																	"testAddressName",
																	"testCityName",
																	"12345",
																	"United Kingdom",
																	"Minister",
																	"Other",
																	true,
																	true);
		}

		[Then(@"I should be registered as a new user")]
		public void ThenIShouldBeRegisteredAsANewUser()
		{
			Assert.IsTrue(new FreeTrialRegistrationSucceedPage().IsDisplayed(), "Free Trial Registration Succeed Page is not displayed correctly.");
		}

		[When(@"I try to register as a new user without providing first name")]
		public void WhenITryToRegisterAsANewUserWithoutProvidingFirstName()
		{
			new FreeTrialStepTwoPage().RegisterForFreeTrialFailed(
																	"Mr",
																	string.Empty,
																	"testLastName",
																	"testJobTitle",
																	"testCompanyName",
																	"12345678",
																	"testAddressName",
																	"testAddressName",
																	"testCityName",
																	"12345",
																	"United Kingdom",
																	"Minister",
																	"Other",
																	true,
																	true);
		}

		[Then(@"I should not be registered as a new user")]
		public void ThenIShouldNotBeRegisteredAsANewUser()
		{
			Assert.IsFalse(new FreeTrialRegistrationSucceedPage().IsDisplayed(), "Free Trial Registration Succeed Page is displayed correctly.");
		}

		[Then(@"First Name validator should be diplayed")]
		public void ThenFirstNameValidatorShouldBeDiplayed()
		{
			Assert.IsTrue(new FreeTrialStepTwoPage().IsFirstNameValidationMessageDisplayed(), "First Name validation message is not displayed.");
		}

		[When(@"I try to register as a new user without providing last name")]
		public void WhenITryToRegisterAsANewUserWithoutProvidingLastName()
		{
			new FreeTrialStepTwoPage().RegisterForFreeTrialFailed(
																	"Mr",
																	"testFirstName",
																	string.Empty,
																	"testJobTitle",
																	"testCompanyName",
																	"12345678",
																	"testAddressName",
																	"testAddressName",
																	"testCityName",
																	"12345",
																	"United Kingdom",
																	"Minister",
																	"Other",
																	true,
																	true);
		}

		[Then(@"Last Name validator should be diplayed")]
		public void ThenLastNameValidatorShouldBeDiplayed()
		{
			Assert.IsTrue(new FreeTrialStepTwoPage().IsLastNameValidationMessageDisplayed(), "Last Name validation message is not displayed.");
		}

		[When(@"I try to register as a new user without providing company name")]
		public void WhenITryToRegisterAsANewUserWithoutProvidingCompanyName()
		{
			new FreeTrialStepTwoPage().RegisterForFreeTrialFailed(
																	"Mr",
																	"testFirstName",
																	"testLastName",
																	"testJobTitle",
																	string.Empty,
																	"12345678",
																	"testAddressName",
																	"testAddressName",
																	"testCityName",
																	"12345",
																	"United Kingdom",
																	"Minister",
																	"Other",
																	true,
																	true);
		}

		[Then(@"Company Name validator should be diplayed")]
		public void ThenCompanyNameValidatorShouldBeDiplayed()
		{
			Assert.IsTrue(new FreeTrialStepTwoPage().IsCompanyNameValidationMessageDisplayed(), "Company Name validation message is not displayed.");
		}

		[When(@"I try to register as a new user without providing job title")]
		public void WhenITryToRegisterAsANewUserWithoutProvidingJobTitle()
		{
			new FreeTrialStepTwoPage().RegisterForFreeTrialFailed(
																	"Mr",
																	"testFirstName",
																	"testLastName",
																	string.Empty,
																	"testCompanyName",
																	"12345678",
																	"testAddressName",
																	"testAddressName",
																	"testCityName",
																	"12345",
																	"United Kingdom",
																	"Minister",
																	"Other",
																	true,
																	true);
		}

		[Then(@"Job Title validator should be diplayed")]
		public void ThenJobTitleValidatorShouldBeDiplayed()
		{
			Assert.IsTrue(new FreeTrialStepTwoPage().IsJobTitleValidationMessageDisplayed(), "Job Title validation message is not displayed.");
		}

		[When(@"I try to register as a new user without providing user title")]
		public void WhenITryToRegisterAsANewUserWithoutProvidingUserTitle()
		{
			new FreeTrialStepTwoPage().RegisterForFreeTrialFailed(
																string.Empty,
																"testFirstName",
																"testLastName",
																"testJobTitle",
																"testCompanyName",
																"12345678",
																"testAddressName",
																"testAddressName",
																"testCityName",
																"12345",
																"United Kingdom",
																"Minister",
																"Other",
																true,
																true);
		}

		[Then(@"User Title validator should be diplayed")]
		public void ThenUserTitleValidatorShouldBeDiplayed()
		{
			Assert.IsTrue(new FreeTrialStepTwoPage().IsUserTitleValidationMessageDisplayed(), "User Title validation message is not displayed.");
		}

		[When(@"I try to register as a new user without providing telephone number")]
		public void WhenITryToRegisterAsANewUserWithoutProvidingTelephoneNumber()
		{
			new FreeTrialStepTwoPage().RegisterForFreeTrialFailed(
																"Mr",
																"testFirstName",
																"testLastName",
																"testJobTitle",
																"testCompanyName",
																string.Empty,
																"testAddressName",
																"testAddressName",
																"testCityName",
																"12345",
																"United Kingdom",
																"Minister",
																"Other",
																true,
																true);
		}

		[Then(@"Telephone number validator should be diplayed")]
		public void ThenTelephoneNumberValidatorShouldBeDiplayed()
		{
			Assert.IsTrue(new FreeTrialStepTwoPage().IsTelephoneNumberValidationMessageDisplayed(), "Telephone number validation message is not displayed.");
		}

		[When(@"I try to register as a new user without providing address")]
		public void WhenITryToRegisterAsANewUserWithoutProvidingAddress()
		{
			new FreeTrialStepTwoPage().RegisterForFreeTrialFailed(
																"Mr",
																"testFirstName",
																"testLastName",
																"testJobTitle",
																"testCompanyName",
																"12345678",
																string.Empty,
																"testAddressName",
																"testCityName",
																"12345",
																"United Kingdom",
																"Minister",
																"Other",
																true,
																true);
		}

		[Then(@"Address validator should be diplayed")]
		public void ThenAddressValidatorShouldBeDiplayed()
		{
			Assert.IsTrue(new FreeTrialStepTwoPage().IsAddressValidationMessageDisplayed(), "Address validation message is not displayed.");
		}

		[When(@"I try to register as a new user without providing address line two")]
		public void WhenITryToRegisterAsANewUserWithoutProvidingAddressLineTwo()
		{
			new FreeTrialStepTwoPage().RegisterForFreeTrialFailed(
													"Mr",
													"testFirstName",
													"testLastName",
													"testJobTitle",
													"testCompanyName",
													"12345678",
													"testAddressName",
													string.Empty,
													"testCityName",
													"12345",
													"United Kingdom",
													"Minister",
													"Other",
													true,
													true);
		}

		[Then(@"Address line two validator should be diplayed")]
		public void ThenAddressLineTwoValidatorShouldBeDiplayed()
		{
			Assert.IsTrue(new FreeTrialStepTwoPage().IsAddressLineTwoValidationMessageDisplayed(), "Address line two validation message is not displayed.");
		}

		[When(@"I try to register as a new user without providing city")]
		public void WhenITryToRegisterAsANewUserWithoutProvidingCity()
		{
			new FreeTrialStepTwoPage().RegisterForFreeTrialFailed(
																"Mr",
																"testFirstName",
																"testLastName",
																"testJobTitle",
																"testCompanyName",
																"12345678",
																"testAddressName",
																"testAddressName",
																string.Empty,
																"12345",
																"United Kingdom",
																"Minister",
																"Other",
																true,
																true);
		}

		[Then(@"City validator should be diplayed")]
		public void ThenCityValidatorShouldBeDiplayed()
		{
			Assert.IsTrue(new FreeTrialStepTwoPage().IsCityValidationMessageDisplayed(), "City validation message is not displayed.");
		}

		[When(@"I try to register as a new user without providing zip")]
		public void WhenITryToRegisterAsANewUserWithoutProvidingZip()
		{
			new FreeTrialStepTwoPage().RegisterForFreeTrialFailed(
																"Mr",
																"testFirstName",
																"testLastName",
																"testJobTitle",
																"testCompanyName",
																"12345678",
																"testAddressName",
																"testAddressName",
																"testCityName",
																string.Empty,
																"United Kingdom",
																"Minister",
																"Other",
																true,
																true);
		}

		[Then(@"Zip validator should be diplayed")]
		public void ThenZipValidatorShouldBeDiplayed()
		{
			Assert.IsTrue(new FreeTrialStepTwoPage().IsZipValidationMessageDisplayed(), "Zip validation message is not displayed.");
		}

		[When(@"I try to register as a new user without providing country")]
		public void WhenITryToRegisterAsANewUserWithoutProvidingCountry()
		{
			new FreeTrialStepTwoPage().RegisterForFreeTrialFailed(
																"Mr",
																"testFirstName",
																"testLastName",
																"testJobTitle",
																"testCompanyName",
																"12345678",
																"testAddressName",
																"testAddressName",
																"testCityName",
																"12345",
																string.Empty,
																"Minister",
																"Other",
																true,
																true);
		}

		[Then(@"Country validator should be diplayed")]
		public void ThenCountryValidatorShouldBeDiplayed()
		{
			Assert.IsTrue(new FreeTrialStepTwoPage().IsCountryValidationMessageDisplayed(), "Country validation message is not displayed.");
		}

		[When(@"I try to register as a new user without providing position type from the list")]
		public void WhenITryToRegisterAsANewUserWithoutProvidingPositionTypeFromTheList()
		{
			new FreeTrialStepTwoPage().RegisterForFreeTrialFailed(
													"Mr",
													"testFirstName",
													"testLastName",
													"testJobTitle",
													"testCompanyName",
													"12345678",
													"testAddressName",
													"testAddressName",
													"testCityName",
													"12345",
													"United Kingdom",
													string.Empty,
													"Other",
													true,
													true);
		}

		[Then(@"Position type validator should be diplayed")]
		public void ThenPositionTypeValidatorShouldBeDiplayed()
		{
			Assert.IsTrue(new FreeTrialStepTwoPage().IsPositionTypeValidationMessageDisplayed(), "Position type validation message is not displayed.");
		}

		[When(@"I try to register as a new user without providing company type from the list")]
		public void WhenITryToRegisterAsANewUserWithoutProvidingCompanyTypeFromTheList()
		{
			new FreeTrialStepTwoPage().RegisterForFreeTrialFailed(
										"Mr",
										"testFirstName",
										"testLastName",
										"testJobTitle",
										"testCompanyName",
										"12345678",
										"testAddressName",
										"testAddressName",
										"testCityName",
										"12345",
										"United Kingdom",
										"Minister",
										string.Empty,
										true,
										true);
		}

		[Then(@"Company type validator should be diplayed")]
		public void ThenCompanyTypeValidatorShouldBeDiplayed()
		{
			Assert.IsTrue(new FreeTrialStepTwoPage().IsCompanyTypeValidationMessageDisplayed(), "Company type validation message is not displayed.");
		}
	}
}