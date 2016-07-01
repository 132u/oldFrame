using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Helpers;
using NUnit.Framework;
using PageObjects.PageObjects;
using TechTalk.SpecFlow;

namespace Spec.Checkout
{
	[Binding]
	public class YourDetailsSteps
	{
		[When(@"I create a new account for US with any (.*) and (.*)")]
		public void WhenICreateANewAccountForUSWithAnyAnd(string state, string postCode)
		{
			ConfirmationPage confirmationPage = new YourDetailsPage()
				.EnterDetailsAndGoNext("Mr", "Bob", "Test: " + state, "Engineer", "Tester Corp.", "9876543", string.Empty, "United States", "Tester Road", string.Empty, string.Empty, "Tester City", string.Empty, state, string.Empty, postCode)
				.GoNext()
				.ProceedToPaymentPage()
				.PaySuccesfully("MasterCard", "5555555555554444", "111", "2020");
		}

		[When(@"I create a new account for Canada with any (.*) and (.*)")]
		public void WhenICreateANewAccountForCanadaWithAnyAnd(string province, string postCode)
		{
			ConfirmationPage confirmationPage = new YourDetailsPage()
				.EnterDetailsAndGoNext("Mr", "Bob", "Test: " + province, "Engineer", "Tester Corp.", "9876543", string.Empty, "Canada", "Tester Road", string.Empty, string.Empty, "Tester City", string.Empty, string.Empty, province, postCode)
				.GoNext()
				.ProceedToPaymentPage()
				.PaySuccesfully("MasterCard", "5555555555554444", "111", "2020");
		}

		[Given(@"Given I've selected basic subscription")]
		public void GivenGivenIVeSelectedBasicSubscription()
		{
			LoginRegisterPage checkoutSelectionPage = new HomePage()
			.Header
			.NavigateToCheckoutSsubscriptionSelectionPage()
			.SelectBasicSubscription();
		}

		[When(@"I register with new email")]
		public void WhenIRegisterWithNewEmail()
		{
			YourDetailsPage yourDetailsPage = new LoginRegisterPage()
				.CreateNewAccountSuccessfuly(BasicHelper.GetRandomEmail());
		}

		[When(@"I create a new account with any (.*)")]
		public void WhenICreateANewAccountWithAny(string country)
		{
			ConfirmationPage confirmationPage = new YourDetailsPage()
				.EnterDetailsAndGoNext("Mr", "Bob", "Test: " + country.Replace("(", string.Empty).Replace(")", string.Empty), "Engineer", "Tester Corp.", "9876543", string.Empty, country, "Tester Road", string.Empty, string.Empty, "Tester City", string.Empty, string.Empty, string.Empty, "34334")
				.GoNext()
				.ProceedToPaymentPage()
				.PaySuccesfully("MasterCard", "5555555555554444", "111", "2020");
		}

		[Then(@"I should subscribe successfully")]
		public void ThenIShouldSubscribeSuccessfully()
		{
			Assert.IsTrue(new ConfirmationPage().PaymentIsSuccessful(), "Payment failed");
		}

		[When(@"I create a new account with allowed name (.*) and (.*)")]
		public void WhenICreateANewAccountWithAllowedNameAnd(string firstName, string lastName)
		{
			ConfirmationPage confirmationPage = new YourDetailsPage()
				.EnterDetailsAndGoNext("Mr", firstName, lastName, "Engineer", "Tester Corp.", "9876543", string.Empty, "United Kingdom", "Tester Road", string.Empty, string.Empty, "Tester City", string.Empty, string.Empty, string.Empty, "12345")
				.GoNext()
				.ProceedToPaymentPage()
				.PaySuccesfully("MasterCard", "5555555555554444", "111", "2020");
		}

		[When(@"I create a new accout with allowed company name (.*)")]
		public void WhenICreateANewAccoutWithAllowedCompanyName(string companyName)
		{
			ConfirmationPage confirmationPage = new YourDetailsPage()
				.EnterDetailsAndGoNext("Mr", "Bob", "Tester", "Engineer", companyName, "9876543", string.Empty, "United Kingdom", "Tester Road", string.Empty, string.Empty, "Tester City", string.Empty, string.Empty, string.Empty, "12345")
				.GoNext()
				.ProceedToPaymentPage()
				.PaySuccesfully("MasterCard", "5555555555554444", "111", "2020");
		}

		[When(@"I create a new accout with allowed addresses (.*) and (.*) and (.*)")]
		public void WhenICreateANewAccoutWithAllowedAddressesTesterStreetAndSomeAlleyAndShadyPlace(string addressOne, string addressTwo, string addressThree)
		{
			ConfirmationPage confirmationPage = new YourDetailsPage()
				.EnterDetailsAndGoNext("Mr", "Bob", "Tester", "Engineer", "Tester Corp.", "9876543", string.Empty, "United Kingdom", addressOne, addressTwo, addressThree, "Tester City", string.Empty, string.Empty, string.Empty, "12345")
				.GoNext()
				.ProceedToPaymentPage()
				.PaySuccesfully("MasterCard", "5555555555554444", "111", "2020");
		}

		[When(@"I create a new accout with allowed city value (.*)")]
		public void WhenICreateANewAccoutWithAllowedCityValueWarsaw(string city)
		{
			ConfirmationPage confirmationPage = new YourDetailsPage()
				.EnterDetailsAndGoNext("Mr", "Bob", "Tester", "Engineer", "Tester Corp.", "9876543", string.Empty, "United Kingdom", "Tester street", string.Empty, string.Empty, city, string.Empty, string.Empty, string.Empty, "12345")
				.GoNext()
				.ProceedToPaymentPage()
				.PaySuccesfully("MasterCard", "5555555555554444", "111", "2020");
		}

		[When(@"I create a new accout with allowed fax value (.*)")]
		public void WhenICreateANewAccoutWithAllowedFaxValue(string fax)
		{
			ConfirmationPage confirmationPage = new YourDetailsPage()
				.EnterDetailsAndGoNext("Mr", "Bob", "Tester", "Engineer", "Tester Corp.", "9876543", fax, "United Kingdom", "Tester street", string.Empty, string.Empty, "Tester city", string.Empty, string.Empty, string.Empty, "12345")
				.GoNext()
				.ProceedToPaymentPage()
				.PaySuccesfully("MasterCard", "5555555555554444", "111", "2020");
		}

		[When(@"I create a new accout with allowed zip value (.*)")]
		public void WhenICreateANewAccoutWithAllowedZipValue(string zip)
		{
			ConfirmationPage confirmationPage = new YourDetailsPage()
				.EnterDetailsAndGoNext("Mr", "Bob", "Tester", "Engineer", "Tester Corp.", "9876543", string.Empty, "United Kingdom", "Tester street", string.Empty, string.Empty, "Tester city", string.Empty, string.Empty, string.Empty, zip)
				.GoNext()
				.ProceedToPaymentPage()
				.PaySuccesfully("MasterCard", "5555555555554444", "111", "2020");
		}

		[When(@"I create a new accout with allowed county value (.*)")]
		public void WhenICreateANewAccoutWithAllowedCountyValue(string county)
		{
			ConfirmationPage confirmationPage = new YourDetailsPage()
				.EnterDetailsAndGoNext("Mr", "Bob", "Tester", "Engineer", "Tester Corp.", "12345678", string.Empty, "United Kingdom", "Tester street", string.Empty, string.Empty, "Tester city", county, string.Empty, string.Empty, "12345")
				.GoNext()
				.ProceedToPaymentPage()
				.PaySuccesfully("MasterCard", "5555555555554444", "111", "2020");
		}

		[When(@"I create a new accout with allowed telephone number value (.*)")]
		public void WhenICreateANewAccoutWithAllowedTelephoneNumberValue(string telephone)
		{
			ConfirmationPage confirmationPage = new YourDetailsPage()
				.EnterDetailsAndGoNext("Mr", "Bob", "Tester", "Engineer", "Tester Corp.", telephone, string.Empty, "United Kingdom", "Tester street", string.Empty, string.Empty, "Tester city", string.Empty, string.Empty, string.Empty, "12345")
				.GoNext()
				.ProceedToPaymentPage()
				.PaySuccesfully("MasterCard", "5555555555554444", "111", "2020");
		}

		[Then(@"I should stay at your details page")]
		public void ThenIShouldStayAtYourDetailsPage()
		{
			Assert.IsTrue(new YourDetailsPage().PageIsDisplayed(), "It should be your details page. but it's not");
		}

		[When(@"I create a new accout with invalid first name (.*)")]
		public void WhenICreateANewAccoutWithInvalidFirstName(string invalidFirstName)
		{
			YourDetailsPage yourDetailsPage = new YourDetailsPage()
				.EnterDetailsAndGoNext("Mr", invalidFirstName, "Tester", "Engineer", "Tester Corp.", "456789", string.Empty, "United Kingdom", "Tester street", string.Empty, string.Empty, "Tester city", string.Empty, string.Empty, string.Empty, "12345");
		}

		[Then(@"First name is invalid validation message should be displayed.")]
		public void ThenFirstNameIsInvalidValidationMessageShouldBeDisplayed()
		{
			Assert.IsTrue(new YourDetailsPage().FirstNameValidationIsDisplayed(), "First name validation is not displayed.");
		}

		[When(@"I create a new accout with invalid surname (.*)")]
		public void WhenICreateANewAccoutWithInvalidSurnameShouldFail(string invalidSurname)
		{
			YourDetailsPage yourDetailsPage = new YourDetailsPage()
				.EnterDetailsAndGoNext("Mr", "Bob", invalidSurname, "Engineer", "Tester Corp.", "456789", string.Empty, "United Kingdom", "Tester street", string.Empty, string.Empty, "Tester city", string.Empty, string.Empty, string.Empty, "12345");
		}

		[Then(@"Surname is invalid validation message should be displayed.")]
		public void ThenSurnameIsInvalidValidationMessageShouldBeDisplayed()
		{
			Assert.IsTrue(new YourDetailsPage().SurnameValidationIsDisplayed(), "Surname validation is not displayed.");
		}

		[When(@"I create a new accout with invalid company name (.*)")]
		public void WhenICreateANewAccoutWithInvalidCompanyName(string invalidCompanyName)
		{
			YourDetailsPage yourDetailsPage = new YourDetailsPage()
				.EnterDetailsAndGoNext("Mr", "Bob", "Tester", "Engineer", invalidCompanyName, "456789", string.Empty, "United Kingdom", "Tester street", string.Empty, string.Empty, "Tester city", string.Empty, string.Empty, string.Empty, "12345");
		}

		[Then(@"Company name is invalid validation message should be displayed.")]
		public void ThenCompanyNameIsInvalidValidationMessageShouldBeDisplayed()
		{
			Assert.IsTrue(new YourDetailsPage().CompanyNameValidationIsDisplayed(), "Company name validation is not displayed.");
		}

		[When(@"I create a new accout with invalid address one (.*)")]
		public void WhenICreateANewAccoutWithInvalidAddressOne(string invalidAddressOne)
		{
			YourDetailsPage yourDetailsPage = new YourDetailsPage()
				.EnterDetailsAndGoNext("Mr", "Bob", "Tester", "Engineer", "QA Corp.", "456789", string.Empty, "United Kingdom", invalidAddressOne, string.Empty, string.Empty, "Tester city", string.Empty, string.Empty, string.Empty, "12345");
		}

		[Then(@"Address one is invalid validation message should be displayed.")]
		public void ThenAddressOneIsInvalidValidationMessageShouldBeDisplayed()
		{
			Assert.IsTrue(new YourDetailsPage().AddressOneValidationIsDisplayed(), "Address one validation is not displayed.");
		}

		[When(@"I create a new accout with invalid  address two (.*)")]
		public void WhenICreateANewAccoutWithInvalidAddressTwo(string invalidAddressTwo)
		{
			YourDetailsPage yourDetailsPage = new YourDetailsPage()
				.EnterDetailsAndGoNext("Mr", "Bob", "Tester", "Engineer", "QA Corp.", "456789", string.Empty, "United Kingdom", "Tester street 1", invalidAddressTwo, string.Empty, "Tester city", string.Empty, string.Empty, string.Empty, "12345");
		}

		[Then(@"Address two is invalid validation message should be displayed.")]
		public void ThenAddressTwoIsInvalidValidationMessageShouldBeDisplayed()
		{
			Assert.IsTrue(new YourDetailsPage().AddressTwoValidationIsDisplayed(), "Address two validation is not displayed.");
		}

		[When(@"I create a new accout with invalid address three (.*)")]
		public void WhenICreateANewAccoutWithInvalidAddressThree(string invalidAddressThree)
		{
			YourDetailsPage yourDetailsPage = new YourDetailsPage()
				.EnterDetailsAndGoNext("Mr", "Bob", "Tester", "Engineer", "QA Corp.", "456789", string.Empty, "United Kingdom", "Tester street 1", "Some more address info", invalidAddressThree, "Tester city", string.Empty, string.Empty, string.Empty, "12345");
		}

		[Then(@"Address three is invalid validation message should be displayed.")]
		public void ThenAddressThreeIsInvalidValidationMessageShouldBeDisplayed()
		{
			Assert.IsTrue(new YourDetailsPage().AddressThreeValidationIsDisplayed(), "Address three validation is not displayed.");
		}

		[When(@"I create a new accout with invalid city (.*)")]
		public void WhenICreateANewAccoutWithInvalidCity(string invalidCity)
		{
			YourDetailsPage yourDetailsPage = new YourDetailsPage()
				.EnterDetailsAndGoNext("Mr", "Bob", "Tester", "Engineer", "QA Corp.", "456789", string.Empty, "United Kingdom", "Tester street 1", string.Empty, string.Empty, invalidCity, string.Empty, string.Empty, string.Empty, "12345");
		}

		[Then(@"City is invalid validation message should be displayed.")]
		public void ThenCityIsInvalidValidationMessageShouldBeDisplayed()
		{
			Assert.IsTrue(new YourDetailsPage().CityValidationIsDisplayed(), "City validation is not displayed.");
		}

		[When(@"I create a new accout with invalid county (.*)")]
		public void WhenICreateANewAccoutWithInvalidCounty(string invalidCounty)
		{
			YourDetailsPage yourDetailsPage = new YourDetailsPage()
				.EnterDetailsAndGoNext("Mr", "Bob", "Tester", "Engineer", "QA Corp.", "456789", string.Empty, "United Kingdom", "Tester street 1", string.Empty, string.Empty, "City", invalidCounty, string.Empty, string.Empty, "12345");
		}

		[Then(@"County is invalid validation message should be displayed.")]
		public void ThenCountyIsInvalidValidationMessageShouldBeDisplayed()
		{
			Assert.IsTrue(new YourDetailsPage().CountyValidationIsDisplayed(), "County validation is not displayed.");
		}

		[When(@"I create a new accout with invalid fax (.*)")]
		public void WhenICreateANewAccoutWithInvalidFax(string invalidFax)
		{
			YourDetailsPage yourDetailsPage = new YourDetailsPage()
				.EnterDetailsAndGoNext("Mr", "Bob", "Tester", "Engineer", "QA Corp.", string.Empty, invalidFax, "United Kingdom", "Tester street 1", string.Empty, string.Empty, "City", string.Empty, string.Empty, string.Empty, "12345");
		}

		[Then(@"Fax is invalid validation message should be displayed.")]
		public void ThenFaxIsInvalidValidationMessageShouldBeDisplayed()
		{
			Assert.IsTrue(new YourDetailsPage().FaxValidationIsDisplayed(), "Fax validation is not displayed.");
		}

		[When(@"I create a new accout with invalid zip (.*)")]
		public void WhenICreateANewAccoutWithInvalidZip(string invalidZip)
		{
			YourDetailsPage yourDetailsPage = new YourDetailsPage()
				.EnterDetailsAndGoNext("Mr", "Bob", "Tester", "Engineer", "QA Corp.", "456789", string.Empty, "United Kingdom", "Tester street 1", string.Empty, string.Empty, "City", string.Empty, string.Empty, string.Empty, invalidZip);
		}

		[Then(@"Zip is invalid validation message should be displayed.")]
		public void ThenZipIsInvalidValidationMessageShouldBeDisplayed()
		{
			Assert.IsTrue(new YourDetailsPage().ZipValidationIsDisplayed(), "Zip validation is not displayed.");
		}

		[When(@"I create a new accout with invalid telephone (.*)")]
		public void WhenICreateANewAccoutWithInvalidTelephone(string invalidTelephone)
		{
			YourDetailsPage yourDetailsPage = new YourDetailsPage()
				.EnterDetailsAndGoNext("Mr", "Bob", "Tester", "Engineer", "QA Corp.", invalidTelephone, string.Empty, "United Kingdom", "Tester street 1", string.Empty, string.Empty, "City", string.Empty, string.Empty, string.Empty, "12345");
		}

		[Then(@"Telephone is invalid validation message should be displayed.")]
		public void ThenTelephoneIsInvalidValidationMessageShouldBeDisplayed()
		{
			Assert.IsTrue(new YourDetailsPage().TelephoneValidationIsDisplayed(), "Telephone validation is not displayed.");
		}
	}
}
