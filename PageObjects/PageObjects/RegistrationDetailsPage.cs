using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Core.Helpers;

namespace PageObjects.PageObjects
{
	public partial class RegistrationDetailsPage : PageBase
	{
		/// <summary>
		/// Check if current page is displayed.
		/// </summary>
		/// <returns>Returns true if current page is displayed.</returns>
		public bool IsDisplayedCorrectly()
		{
			return this.CompareLists(this.RegistrationDetailsPageRequiredElements);
		}

		public RegistrationDetailsPage UpdateBasicDetails(string title, string firstName, string lastName, string companyName, string telephone)
		{
			this.Title.SelectItemByText(title);
			this.FirstName.Text = firstName;
			this.LastName.Text = lastName;
			this.CompanyName.Text = companyName;
			this.SelectPrivacyPolicyAndTermsAndConditionsIfRequired();
			this.Telephone.Text = telephone;

			this.Update.Click();

			return new RegistrationDetailsPage();
		}

		public RegistrationDetailsPage UpdateRequiredAddressDetails(string addressLineOne, string addressLineTwo, string city, string postCode, string country, string telephone)
		{
			this.AddressLineOne.Text = addressLineOne;
			this.AddressLineTwo.Text = addressLineTwo;
			this.City.Text = city;
			this.PostCode.Text = postCode;
			this.Country.SelectItemByText(country);
			this.Telephone.Text = telephone;
			this.SelectPrivacyPolicyAndTermsAndConditionsIfRequired();
			this.Update.Click();

			return new RegistrationDetailsPage();
		}

		public bool UpdatedSuccessfullyInformationDisplayed()
		{
			return this.AccountUpdatedSuccessfully.IsFound;
		}

		public bool CompareBasicDetails(string title, string firstName, string lastName, string companyName, string telephone)
		{
			return this.Title.GetSelectedOptionText() == title && this.FirstName.Text == firstName && this.LastName.Text == lastName && this.CompanyName.Text == companyName && this.Telephone.Text == telephone;
		}

		public bool CompareRequiredAddressDetails(string addressLineOne, string addressLineTwo, string city, string postCode, string country, string telephone)
		{
			return this.AddressLineOne.Text == addressLineOne
				&& this.AddressLineTwo.Text == addressLineTwo
				&& this.City.Text == city
				&& this.PostCode.Text == postCode
				&& this.Country.GetSelectedOptionText() == country
				&& this.Telephone.Text == telephone;
		}

		public bool CompareMarketingChoices(bool telephoneSelcted, bool faxSelected, bool emailSelected, bool mailSelected, bool offersFromOtherSelected)
		{
			return this.TelephoneChoice.IsSelected == telephoneSelcted
			&& this.FaxChoice.IsSelected == faxSelected
			&& this.EmailChoice.IsSelected == emailSelected
			&& this.MailChoice.IsSelected == mailSelected
			&& this.OffersFromOtherCompaniesChoice.IsSelected == offersFromOtherSelected;
		}

		public RegistrationDetailsPage UpdateMarketingChoices(bool telephoneChoice, bool faxChoices, bool emailChoice, bool mailChoice, bool offersFromOtherSelected)
		{
			this.TelephoneChoice.SetValue(telephoneChoice);
			this.FaxChoice.SetValue(faxChoices);
			this.EmailChoice.SetValue(emailChoice);
			this.MailChoice.SetValue(mailChoice);
			this.OffersFromOtherCompaniesChoice.SetValue(offersFromOtherSelected);
			this.SelectPrivacyPolicyAndTermsAndConditionsIfRequired();
			this.Update.Click();

			return new RegistrationDetailsPage();
		}

		public string GetDifferentTitleOption()
		{
			return BasicHelper.GetDropdownElementExcept(this.Title, this.Title.GetSelectedOptionText());
		}

		public string GetDifferentCountryOption()
		{
			return BasicHelper.GetDropdownElementExcept(this.Country, this.Country.GetSelectedOptionText());
		}

		private void SelectPrivacyPolicyAndTermsAndConditionsIfRequired()
		{
			if (!this.PrivacyPolicy.Optional)
			{
				this.PrivacyPolicy.Select();
			}

			if (!this.TermsAndConditions.Optional)
			{
				this.TermsAndConditions.Select();
			}
		}
	}
}