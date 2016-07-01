using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Core.Configuration;
using Core.Helpers;
using Core.Logger;
using Core.Users;
using UserHelper;

namespace PageObjects.PageObjects
{
	public partial class LoginPage : PageBase
	{
		public bool IsDisplayed()
		{
			return this.Login.IsFound;
		}

		/// <summary>
		/// Check if current page is displayed.
		/// </summary>
		/// <returns>Returns true if current page is displayed.</returns>
		public bool IsDisplayedCorrectly()
		{
			return this.CompareLists(this.LoginPageRequiredElements);
		}

		/// <summary>
		/// This method is used for login to the user account successfully.
		/// </summary>
		/// <param name="username">User name.</param>
		/// <param name="password">Password.</param>
		/// <param name="rememberMe">Remember me flag parameter.</param>
		/// <returns>Returns new instance of the HomePage class.</returns>
		public HomePage LoginToTheUserAccountSuccessfully(string username, string password, bool rememberMe)
		{
			Logger.Info(string.Format("Login page. Email: {0}, password {1}", username, password));
			this.Username.Text = username;
			this.Password.Text = password;
			this.SetRememberMeOption(rememberMe);
			Logger.Info("Click login");
			this.Login.Click();

			var confirmTermsPage = new ConfirmTermsPage();

			if (confirmTermsPage.IsDisplayedCorrectly())
			{
				Logger.Info("Confirm T&C and PP page displayed");
				confirmTermsPage.AcceptMandatoryContracts();
			}

			Logger.Info("Should navigate to home page.");
			return new HomePage();
		}

		/// <summary>
		/// This method is used for login to the user account with invalid credentials.
		/// </summary>
		/// <param name="username">User name.</param>
		/// <param name="password">Password.</param>
		/// <returns>Returns new instance of the LoginPage class.</returns>
		public LoginPage LoginToTheUserAccountFailed(string username, string password)
		{
			this.Username.Text = username;
			this.Password.Text = password;
			this.Login.Click();

			return new LoginPage();
		}

		public Credentials CreateFreeTrialAccount()
		{
			string failedAccountCrationMessage = "Account creation unsuccessful";
			string email = BasicHelper.GetRandomEmail();

			WebBrowser.Open(ApplicationConfiguration.Url);

			if (ApplicationConfiguration.RegistrationType == "FreeTrial")
			{
				FreeTrialRegistrationSucceedPage registrationSuccessPage = new HomePage()
				.Header
				.NavigateToTheFreeTrial()
				.NavigateToTheFreeTrialStepTwoSuccessfully(email)
				.RegisterForFreeTrialSuccessfuly("Mr", "Bob", "Tester", "Geologist", "Test Company", "567342456", "Testers Road 3", "Address line 2", "Testershire", "456321", "United Kingdom", "Geologist", "Other", true, true);

				if (!registrationSuccessPage.IsDisplayed())
				{
					throw new Exception(failedAccountCrationMessage);
				}
			}
			else if (ApplicationConfiguration.RegistrationType == "SinglePage")
			{
				SignUpSuccessfulPage signupSuccessfulPage = new HomePage()
				.Header
				.NavigateToSignUpPage()
				.SignUpSuccesfuly(email, "Mr", "Bob", "Tester", "Engineer", "Testers Corp.", "United Kingdom");

				if (!signupSuccessfulPage.SignUpSuccessfulMessageIsDisplayed())
				{
					throw new Exception(failedAccountCrationMessage);
				}

				signupSuccessfulPage
					.Header
					.NavigateToTheMyAccount()
					.Header
					.LogoutFromTheUserAccount();
			}
			else if (ApplicationConfiguration.RegistrationType == "API")
			{
				var user = new UserManager();
				email = user.CreateUser().EmailAddress;
				user.SendPassword(email);
			}
			else
			{
				throw new NotSupportedException("Registration type " + ApplicationConfiguration.RegistrationType + " is not supported ATM.");
			}

			string password = BasicHelper.GetPasswordFromMailtrapByEmail(email);

			WebBrowser.Open(ApplicationConfiguration.Url);

			Logger.Info(string.Format("About to return credentials after successful retrieval. Login: {0}, password: {1} ", email, password));
			return new Credentials { Email = email, Password = password };
		}

		/// <summary>
		/// Sets the state of Remember me checkbox.
		/// </summary>
		/// <param name="rememberMe">Remember me checkbox parameter.</param>
		private void SetRememberMeOption(bool rememberMe)
		{
			if (rememberMe)
			{
				this.RememberMe.Select();
			}
			else
			{
				this.RememberMe.Deselect();
			}
		}
	}
}
