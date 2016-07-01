using Core;
using Core.Controls;

namespace PageObjects.PageObjects
{
	public partial class ChangePasswordPage : PageBase
	{
		/// <summary>
		/// Check if current page is displayed.
		/// </summary>
		/// <returns>Returns true if current page is displayed.</returns>
		public bool IsDisplayedCorrectly()
		{
			return this.CompareLists(this.ChangePasswordPageRequiredElements);
		}

		/// <summary>
		/// Changes the user password. Process should succeed.
		/// </summary>
		/// <param name="oldPassword">Old password.</param>
		/// <param name="newPassword">New password.</param>
		/// <param name="newPasswordConfirmation">Password confirmation.</param>
		/// <returns>Returns new instance of the PasswordUpdatedPage class.</returns>
		public PasswordUpdatedPage ChangePasswordSuccessfullyPasswordUpdatedPageDisplayed(string oldPassword, string newPassword, string newPasswordConfirmation)
		{
			this.OldPassword.Text = oldPassword;
			this.NewPassword.Text = newPassword;
			this.ConfirmNewPassword.Text = newPasswordConfirmation;

			this.Submit.Click();

			return new PasswordUpdatedPage();
		}

		/// <summary>
		/// Changes the user password. Process should succeed.
		/// </summary>
		/// <param name="oldPassword">Old password.</param>
		/// <param name="newPassword">New password.</param>
		/// <param name="newPasswordConfirmation">Password confirmation.</param>
		/// <returns>Returns new instance of the ChangePasswordPage class.</returns>
		public ChangePasswordPage ChangePasswordSuccessfully(string oldPassword, string newPassword, string newPasswordConfirmation)
		{
			this.OldPassword.Text = oldPassword;
			this.NewPassword.Text = newPassword;
			this.ConfirmNewPassword.Text = newPasswordConfirmation;

			this.Submit.Click();

			return new ChangePasswordPage();
		}

		/// <summary>
		/// Changes the user password. Process shouldn't succeed.
		/// </summary>
		/// <param name="oldPassword">Old password.</param>
		/// <param name="newPassword">New password.</param>
		/// <param name="newPasswordConfirmation">Password confirmation.</param>
		/// <returns>Returns new instance of the ChangePasswordPage class.</returns>
		public ChangePasswordPage ChangePasswordFailed(string oldPassword, string newPassword, string newPasswordConfirmation)
		{
			this.OldPassword.Text = oldPassword;
			this.NewPassword.Text = newPassword;
			this.ConfirmNewPassword.Text = newPasswordConfirmation;

			this.Submit.Click();

			return new ChangePasswordPage();
		}

		/// <summary>
		/// Changes the user password. Process shouldn't succeed.
		/// </summary>
		/// <param name="oldPassword">Old password.</param>
		/// <param name="newPassword">New password.</param>
		/// <param name="newPasswordConfirmation">Password confirmation.</param>
		/// <returns>Returns new instance of the MessageBox class.</returns>
		public MessageBox ChangePasswordFailedPopupDisplayed(string oldPassword, string newPassword, string newPasswordConfirmation)
		{
			this.OldPassword.Text = oldPassword;
			this.NewPassword.Text = newPassword;
			this.ConfirmNewPassword.Text = newPasswordConfirmation;

			this.Submit.Click();

			return new MessageBox();
		}

		/// <summary>
		/// Checks if old password textbox validation message is displayed correct.
		/// </summary>
		/// <returns>Returns true if old password textbox validation message is displayed correct.</returns>
		public bool IsOldPasswordValidationMessageDisplayed()
		{
			return this.MissingNewPasswordValidationMessage.IsFound;
		}

		/// <summary>
		/// Checks if new password textbox validation message is displayed correct.
		/// </summary>
		/// <returns>Returns true if new password textbox validation message is displayed correct.</returns>
		public bool IsNewPasswordValidationMessageDisplayed()
		{
			return this.MissingOldPasswordValidationMessage.IsFound;
		}

		/// <summary>
		/// Checks if confirm new password validation message is displayed correct.
		/// </summary>
		/// <returns>Returns true if confirm new password validation message is displayed correct.</returns>
		public bool IsConfirmNewPasswordValidationMessageDisplayed()
		{
			return this.MissingConfirmNewPasswordValidationMessage.IsFound;
		}

		/// <summary>
		/// Checks if password do not match validation message is displayed correct.
		/// </summary>
		/// <returns>Returns true if password do not match validation message is displayed correct.</returns>
		public bool IsPasswordDoNotMatchValidationMessageDisplayed()
		{
			return this.PasswordDoNotMatchValidationMessage.IsFound;
		}

		/// <summary>
		/// Checks if your new password do not match validation message is displayed correct. 
		/// </summary>
		/// <returns>Returns true if your new password do not match validation message is displayed correct.</returns>
		public bool IsYourNewPasswordDoNotMatchValidationMessageDisplayed()
		{
			return this.YourNewPasswordDoNotMatchValidationMessage.IsFound;
		}

		/// <summary>
		/// Checks if your password validation message is displayed correctly. 
		/// </summary>
		/// <param name="validationMessage">Validation message.</param>
		/// <param name="messageBoxTextValue">Text value of messageBox window.</param>
		/// <returns>Returns true if requested password validation message is displayed correctly.</returns>
		public bool IsPasswordValidationPopupMessageDisplayed(string validationMessage, string messageBoxTextValue)
		{
			return messageBoxTextValue.Contains(validationMessage);
		}

		/// <summary>
		/// Checks if your password validation message is displayed correctly. 
		/// </summary>
		/// <returns>Returns true if requested password has been updated message is displayed correctly.</returns>
		public bool IsYourPasswordHasBeenUpdatedMessageDisplayed()
		{
			return this.YourPasswordHasBeenUpdated.IsFound;
		}
	}
}
