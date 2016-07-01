using System;
using Core;
using Core.Configuration;
using Core.Helpers;
using Core.Logger;

namespace PageObjects.PageObjects
{
	public partial class FreeTrialStepOnePage : PageBase
	{
		/// <summary>
		/// Check if current page is displayed.
		/// </summary>
		/// <returns>Returns true if current page is displayed.</returns>
		public bool IsDisplayedCorrectly()
		{
			return (this.CompareLists(this.FreeTrialStepOneSignUpStatus) && this.CompareLists(this.FreeTrialStepOneRegistrationPanel));
		}

		/// <summary>
		/// Navigates to the Free Trial Step Two page. Process should succeed.
		/// </summary>
		/// <returns>Returns new instance of the FreeTrialStepTwoPage class.</returns>
		public FreeTrialStepTwoPage NavigateToTheFreeTrialStepTwoSuccessfully()
		{
			string email = BasicHelper.GetRandomEmail();

			return this.NavigateToTheFreeTrialStepTwoSuccessfully(email);
		}

		public FreeTrialStepTwoPage NavigateToTheFreeTrialStepTwoSuccessfully(string email)
		{
			// Selenium not always see these two textboxes. I have no other idea how to fix this.
			try
			{
				this.EmailAddressTextbox.Text = email;
				this.ConfirmEmailAddressTextbox.Text = email;
			}
			catch
			{
				this.EmailAddressTextbox.Text = email;
				this.ConfirmEmailAddressTextbox.Text = email;
			}

			this.SubmitButton.Click();

			return new FreeTrialStepTwoPage();
		}

		/// <summary>
		/// Navigates to the Free Trial Step Two page. Process shouldn't succeed.
		/// </summary>
		/// <param name="emailAddress">Email address.</param>
		/// <param name="emailConfirmationAddress">Email confirmation address.</param>
		/// <returns>Returns new instance of the FreeTrialStepOnePage class.</returns>
		public FreeTrialStepOnePage NavigateToTheFreeTrialStepTwoFailed(string emailAddress, string emailConfirmationAddress)
		{
			this.EmailAddressTextbox.Text = emailAddress;
			this.ConfirmEmailAddressTextbox.Text = emailConfirmationAddress;
			this.SubmitButton.Click();

			return new FreeTrialStepOnePage();
		}

		/// <summary>
		/// Navigates to the Free Trial Step One page. Process should succeed.
		/// </summary>
		/// <param name="existingUserEmailAddress">Email address.</param>
		/// <returns>Returns new instance of the FreeTrialEnterExistingUserPasswordPage class.</returns>
		public FreeTrialEnterExistingUserPasswordPage NavigateToStepOneByUsingExistingCredentials(string existingUserEmailAddress)
		{
			this.EmailAddressTextbox.Text = existingUserEmailAddress;
			this.ConfirmEmailAddressTextbox.Text = existingUserEmailAddress;
			this.SubmitButton.Click();

			return new FreeTrialEnterExistingUserPasswordPage();
		}

		/// <summary>
		/// Checks if email address validation message is displayed.
		/// </summary>
		/// <returns>Returns true if email address validation message is displayed.</returns>
		public bool IsEmailAddressValidationMessageDisplayed()
		{
			return this.MissingEmailAddressValidationMessage.IsFound;
		}

		/// <summary>
		/// Checks if email address confirmation validation message is displayed.
		/// </summary>
		/// <returns>Returns true if email address confirmation validation message is displayed.</returns>
		public bool IsEmailAddressConfirmationValidationMessageDisplayed()
		{
			return this.MissingEmailAddressConfirmationValidationMessage.IsFound;
		}

		/// <summary>
		/// Checks if email address must ne the same validation message is displayed.
		/// </summary>
		/// <returns>Returns true if email address must ne the same validation message is displayed.</returns>
		public bool IsEmailAddressMustBeTheSameValidationMessageDisplayed()
		{
			return this.EmailAddressMustBeTheSameValidationMessage.IsFound;
		}
	}
}
