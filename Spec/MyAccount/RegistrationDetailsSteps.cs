using System;
using Core.Configuration;
using Core.Helpers;
using NUnit.Framework;
using PageObjects.PageObjects;
using TechTalk.SpecFlow;

namespace Spec.MyAccount
{
	[Binding]
	public class RegistrationDetailsSteps
	{
		[Given(@"I'm on Registration Details page")]
		public void GivenIMOnRegistrationDetailsPage()
		{
			RegistrationDetailsPage registrationDetailsPage = new HomePage()
			.Header
			.NavigateToTheLoginPage()
			.LoginToTheUserAccountSuccessfully(ApplicationConfiguration.ExistingUserName, ApplicationConfiguration.ExistingUserPassword, false)
			.Header
			.NavigateToTheMyAccount()
			.NavigateToDetailsPage();
		}

		[When(@"I change basic details and save")]
		public void WhenIChangeBasicDetailsAndSave()
		{
			RegistrationDetailsPage registrationDetailsPage = new RegistrationDetailsPage();
			ScenarioContext.Current.Add("title", registrationDetailsPage.GetDifferentTitleOption());
			ScenarioContext.Current.Add("firstName", BasicHelper.GenerateRandomString());
			ScenarioContext.Current.Add("lastName", BasicHelper.GenerateRandomString());
			ScenarioContext.Current.Add("company", BasicHelper.GenerateRandomString());
			ScenarioContext.Current.Add("telephone", BasicHelper.GenerateRandomNumberString(7));

			registrationDetailsPage.UpdateBasicDetails(
				ScenarioContext.Current.Get<string>("title"),
				ScenarioContext.Current.Get<string>("firstName"),
				ScenarioContext.Current.Get<string>("lastName"),
				ScenarioContext.Current.Get<string>("company"),
				ScenarioContext.Current.Get<string>("telephone"));
			Assert.IsTrue(registrationDetailsPage.UpdatedSuccessfullyInformationDisplayed(), "Update successfylly information is not displayed.");
		}

		[Then(@"basic details should be updated")]
		public void ThenBasicDetailsShouldBeUpdated()
		{
			// Change page and go back to make sure data is updated.
			RegistrationDetailsPage registrationDetailsPage = new RegistrationDetailsPage()
			.Header
			.NavigateToTheMyAccount()
			.NavigateToDetailsPage();

			Assert.IsTrue(
						registrationDetailsPage.CompareBasicDetails(
																	ScenarioContext.Current.Get<string>("title"),
																	ScenarioContext.Current.Get<string>("firstName"),
																	ScenarioContext.Current.Get<string>("lastName"),
																	ScenarioContext.Current.Get<string>("company"),
																	ScenarioContext.Current.Get<string>("telephone")),
																	"Customer basic details are not updated.");
		}

		[When(@"I change required address details and save")]
		public void WhenIChangeRequiredAddressDetailsAndSave()
		{
			RegistrationDetailsPage registrationDetailsPage = new RegistrationDetailsPage();
			ScenarioContext.Current.Add("addressLineOne", BasicHelper.GenerateRandomString());
			ScenarioContext.Current.Add("addressLineTwo", BasicHelper.GenerateRandomString());
			ScenarioContext.Current.Add("city", BasicHelper.GenerateRandomString());
			ScenarioContext.Current.Add("postCode", BasicHelper.GenerateRandomString());
			ScenarioContext.Current.Add("country", registrationDetailsPage.GetDifferentCountryOption());
			ScenarioContext.Current.Add("telephone", BasicHelper.GenerateRandomNumberString(8));

			registrationDetailsPage.UpdateRequiredAddressDetails(
				ScenarioContext.Current.Get<string>("addressLineOne"),
				ScenarioContext.Current.Get<string>("addressLineTwo"),
				ScenarioContext.Current.Get<string>("city"),
				ScenarioContext.Current.Get<string>("postCode"),
				ScenarioContext.Current.Get<string>("country"),
				ScenarioContext.Current.Get<string>("telephone"));
			Assert.IsTrue(registrationDetailsPage.UpdatedSuccessfullyInformationDisplayed(), "Update successfylly information is not displayed.");
		}

		[Then(@"required address details should be updated")]
		public void ThenAddressDetailsShouldBeUpdated()
		{
			RegistrationDetailsPage registrationDetailsPage = new RegistrationDetailsPage()
			.Header
			.NavigateToTheMyAccount()
			.NavigateToDetailsPage();

			Assert.IsTrue(
					registrationDetailsPage.CompareRequiredAddressDetails(
																		ScenarioContext.Current.Get<string>("addressLineOne"),
																		ScenarioContext.Current.Get<string>("addressLineTwo"),
																		ScenarioContext.Current.Get<string>("city"),
																		ScenarioContext.Current.Get<string>("postCode"),
																		ScenarioContext.Current.Get<string>("country"),
																		ScenarioContext.Current.Get<string>("telephone")),
																		"Required address details are not updated.");
		}

		[When(@"I select all marketing choices and save")]
		public void WhenISelectAllMarketingChoicesAndSave()
		{
			RegistrationDetailsPage registationDetailsPage = new RegistrationDetailsPage();
			ScenarioContext.Current.Add("telephoneChoice", !registationDetailsPage.TelephoneChoice.IsSelected);
			ScenarioContext.Current.Add("faxChoice", !registationDetailsPage.FaxChoice.IsSelected);
			ScenarioContext.Current.Add("emailChoice", !registationDetailsPage.EmailChoice.IsSelected);
			ScenarioContext.Current.Add("mailChoice", !registationDetailsPage.MailChoice.IsSelected);
			ScenarioContext.Current.Add("offersFromOther", !registationDetailsPage.OffersFromOtherCompaniesChoice.IsSelected);

			registationDetailsPage.UpdateMarketingChoices(
				ScenarioContext.Current.Get<bool>("telephoneChoice"),
				ScenarioContext.Current.Get<bool>("faxChoice"),
				ScenarioContext.Current.Get<bool>("emailChoice"),
				ScenarioContext.Current.Get<bool>("mailChoice"),
				ScenarioContext.Current.Get<bool>("offersFromOther"));

			Assert.IsTrue(registationDetailsPage.UpdatedSuccessfullyInformationDisplayed(), "Update successfylly information is not displayed.");
		}

		[Then(@"marketing choices selection should be updated")]
		public void ThenMarketingChoicesSelectionShouldBeUpdated()
		{
			RegistrationDetailsPage registrationDetailsPage = new RegistrationDetailsPage()
			.Header
			.NavigateToTheMyAccount()
			.NavigateToDetailsPage();

			Assert.IsTrue(
						registrationDetailsPage.CompareMarketingChoices(
																	ScenarioContext.Current.Get<bool>("telephoneChoice"),
																	ScenarioContext.Current.Get<bool>("faxChoice"),
																	ScenarioContext.Current.Get<bool>("emailChoice"),
																	ScenarioContext.Current.Get<bool>("mailChoice"),
																	ScenarioContext.Current.Get<bool>("offersFromOther")),
																	"Markieting choices are not updated");
		}
	}
}
