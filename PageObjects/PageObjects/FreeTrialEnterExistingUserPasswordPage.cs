using Core;

namespace PageObjects.PageObjects
{
	public partial class FreeTrialEnterExistingUserPasswordPage : PageBase
	{
		public bool IsDisplayed()
		{
			return this.PasswordTextbox.IsFound;
		}

		/// <summary>
		/// Check if current page is displayed.
		/// </summary>
		/// <returns>Returns true if current page is displayed.</returns>
		public bool IsDisplayedCorrectly()
		{
			return (this.CompareLists(this.FreeTrialEnterExistingUserPasswordSignUpStatus) && this.NextButton.IsFound && this.PasswordTextbox.IsFound);
		}

		/// <summary>
		/// Checks if password validation message is displayed correct. 
		/// </summary>
		/// <returns>Returns true if validation message is displayed correct. </returns>
		public bool IsPasswordValidationMessageDisplayed()
		{
			return this.PasswordValidationMessage.IsFound;
		}

		/// <summary>
		/// Navigates to the Free Trial Step Two page. Process shouldn't succeed.
		/// </summary>
		/// <param name="wrongUserPassword">User password.</param>
		/// <returns>Returns new instance of the FreeTrialEnterExistingUserPasswordPage class.</returns>
		public FreeTrialEnterExistingUserPasswordPage NavigateToTheFreeTrialStepTwoFailed(string wrongUserPassword)
		{
			this.PasswordTextbox.Text = wrongUserPassword;
			this.NextButton.Click();

			return new FreeTrialEnterExistingUserPasswordPage();
		}

		/// <summary>
		/// Navigates to the Free Trial Step Two page. Process should succeed.
		/// </summary>
		/// <param name="existingUserPassword">User password.</param>
		/// <returns>Returns new instance of the FreeTrialStepTwoPage class.</returns>
		public FreeTrialStepTwoPage NavigateToTheFreeTrialStepTwoSuccessfully(string existingUserPassword)
		{
			this.PasswordTextbox.Text = existingUserPassword;
			this.NextButton.Click();

			return new FreeTrialStepTwoPage();
		}
	}
}
