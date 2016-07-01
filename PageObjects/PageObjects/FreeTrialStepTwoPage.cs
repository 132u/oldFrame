using Core;
using Core.Configuration;

namespace PageObjects.PageObjects
{
	public partial class FreeTrialStepTwoPage : PageBase
	{
		public bool IsDsiplayed()
		{
			return this.FirstName.IsFound;
		}

		/// <summary>
		/// Check if current page is displayed.
		/// </summary>
		/// <returns>Returns true if current page is displayed.</returns>
		public bool IsDisplayedCorrectly()
		{
			var pageSource = WebBrowser.PageSource;

			bool signUpStatusCompareResult = this.CompareLists(this.FreeTrialStepTwoSignUpStatus);
			bool yourDetailsSectionCompareResult = this.CompareLists(this.FreeTrialStepTwoYourDetailsSection);
			bool deliveryAddressSectionCompareResult = this.CompareLists(this.FreeTrialStepTwoDeliveryAddressSection);
			bool emailPreferencesSectionCompareResult = this.CompareLists(this.FreeTrialStepTwoEmailPreferencesSection);
			bool dataProtectionSectionCompareResult = this.CompareLists(this.FreeTrialStepTwoDataProtectionSection);

			return (signUpStatusCompareResult && yourDetailsSectionCompareResult && deliveryAddressSectionCompareResult && emailPreferencesSectionCompareResult && dataProtectionSectionCompareResult);
		}

		public FreeTrialRegistrationSucceedPage RegisterForFreeTrialSuccessfuly(
															string title,
															string firstName,
															string lastName,
															string jobTitle,
															string companyName,
															string telephoneNumber,
															string addressFirstLine,
															string addressSecondLine,
															string city,
															string zip,
															string country,
															string companyPosition,
															string companyType,
															bool privacyPolicy,
															bool termsAndConditions)
		{
			PerformActionOnControl(this.Title, title);
			PerformActionOnControl(this.FirstName, firstName);
			PerformActionOnControl(this.LastName, lastName);
			PerformActionOnControl(this.JobTitle, jobTitle);
			PerformActionOnControl(this.CompanyName, companyName);
			PerformActionOnControl(this.Telephone, telephoneNumber);
			PerformActionOnControl(this.AddressFirstLine, addressFirstLine);
			PerformActionOnControl(this.AddressSecondLine, addressSecondLine);
			PerformActionOnControl(this.City, city);
			PerformActionOnControl(this.PostCode, zip);
			PerformActionOnControl(this.Country, country);
			PerformActionOnControl(this.CompanyPosition, companyPosition);
			PerformActionOnControl(this.CompanyType, companyType);

			if (!ApplicationConfiguration.ZeroFreeTrialPage)
			{
				this.PrivacyPolicy.Select();
			}

			this.TermsAndConditions.Select();
			this.Submit.Click();
			return new FreeTrialRegistrationSucceedPage();
		}

		public FreeTrialStepTwoPage RegisterForFreeTrialFailed(
															string title,
															string firstName,
															string lastName,
															string jobTitle,
															string companyName,
															string telephoneNumber,
															string addressFirstLine,
															string addressSecondLine,
															string city,
															string zip,
															string country,
															string companyPosition,
															string companyType,
															bool privacyPolicy,
															bool termsAndConditions)
		{
			PerformActionOnControl(this.Title, title);
			PerformActionOnControl(this.FirstName, firstName);
			PerformActionOnControl(this.LastName, lastName);
			PerformActionOnControl(this.JobTitle, jobTitle);
			PerformActionOnControl(this.CompanyName, companyName);
			PerformActionOnControl(this.Telephone, telephoneNumber);
			PerformActionOnControl(this.AddressFirstLine, addressFirstLine);
			PerformActionOnControl(this.AddressSecondLine, addressSecondLine);
			PerformActionOnControl(this.City, city);
			PerformActionOnControl(this.PostCode, zip);
			PerformActionOnControl(this.Country, country);
			PerformActionOnControl(this.CompanyPosition, companyPosition);
			PerformActionOnControl(this.CompanyType, companyType);

			if (ApplicationConfiguration.ZeroFreeTrialPage)
			{
				privacyPolicy = false;
			}

			if (privacyPolicy)
			{
				this.PrivacyPolicy.Select();
			}

			if (termsAndConditions)
			{
				this.TermsAndConditions.Select();
			}

			this.Submit.Click();

			return new FreeTrialStepTwoPage();
		}

		/// <summary>
		/// Checks if first name validation message is displayed.
		/// </summary>
		/// <returns>Returns true if first name validation message is displayed.</returns>
		public bool IsFirstNameValidationMessageDisplayed()
		{
			return this.FirstNameValidationMessage.IsFound;
		}

		/// <summary>
		/// Checks if last name validation message is displayed.
		/// </summary>
		/// <returns>Returns true if last name validation message is displayed.</returns>
		public bool IsLastNameValidationMessageDisplayed()
		{
			return this.LastNameValidationMessage.IsFound;
		}

		/// <summary>
		/// Checks if job title validation message is displayed.
		/// </summary>
		/// <returns>Returns true if job title validation message is displayed.</returns>
		public bool IsJobTitleValidationMessageDisplayed()
		{
			return this.JobTitleValidationMessage.IsFound;
		}

		/// <summary>
		/// Checks if company name validation message is displayed.
		/// </summary>
		/// <returns>Returns true if company name validation message is displayed.</returns>
		public bool IsCompanyNameValidationMessageDisplayed()
		{
			return this.CompanyNameValidationMessage.IsFound;
		}

		/// <summary>
		/// Checks if user title validation message is displayed.
		/// </summary>
		/// <returns>Returns true if user title validation message is displayed.</returns>
		public bool IsUserTitleValidationMessageDisplayed()
		{
			return this.TitleValidationMessage.IsFound;
		}

		/// <summary>
		/// Checks if telephone number message is displayed.
		/// </summary>
		/// <returns>Returns true if telephone number validation message is displayed.</returns>
		public bool IsTelephoneNumberValidationMessageDisplayed()
		{
			return this.TelephoneNumberValidationMessage.IsFound;
		}

		/// <summary>
		/// Checks if address message is displayed.
		/// </summary>
		/// <returns>Returns true if address validation message is displayed.</returns>
		public bool IsAddressValidationMessageDisplayed()
		{
			return this.AddressValidationMessage.IsFound;
		}

		/// <summary>
		/// Checks if city message is displayed.
		/// </summary>
		/// <returns>Returns true if city validation message is displayed.</returns>
		public bool IsCityValidationMessageDisplayed()
		{
			return this.CityValidationMessage.IsFound;
		}

		/// <summary>
		/// Checks if zip message is displayed.
		/// </summary>
		/// <returns>Returns true if zip validation message is displayed.</returns>
		public bool IsZipValidationMessageDisplayed()
		{
			return this.ZipValidationMessage.IsFound;
		}

		/// <summary>
		/// Checks if country message is displayed.
		/// </summary>
		/// <returns>Returns true if country validation message is displayed.</returns>
		public bool IsCountryValidationMessageDisplayed()
		{
			return this.CountryValidationMessage.IsFound;
		}

		/// <summary>
		/// Checks if position type message is displayed.
		/// </summary>
		/// <returns>Returns true if position type validation message is displayed.</returns>
		public bool IsPositionTypeValidationMessageDisplayed()
		{
			return this.CompanyPositionValidationMessage.IsFound;
		}

		/// <summary>
		/// Checks if company type message is displayed.
		/// </summary>
		/// <returns>Returns true if company type validation message is displayed.</returns>
		public bool IsCompanyTypeValidationMessageDisplayed()
		{
			return this.CompanyTypeValidationMessage.IsFound;
		}

		/// <summary>
		/// Checks if address line two message is displayed.
		/// </summary>
		/// <returns>Returns true if address line two validation message is displayed.</returns>
		public bool IsAddressLineTwoValidationMessageDisplayed()
		{
			return this.AddressSecondLineValidationMessage.IsFound;
		}
	}
}
