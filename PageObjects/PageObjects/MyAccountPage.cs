using Core;

namespace PageObjects.PageObjects
{
	public partial class MyAccountPage : PageBase
	{
		/// <summary>
		/// Check if current page is displayed.
		/// </summary>
		/// <returns>Returns true if current page is displayed.</returns>
		public bool IsDisplayedCorrectly()
		{
			return this.CompareLists(this.MyAccountPageRequiredElements);
		}

		/// <summary>
		/// Navigates to the Change Password page.
		/// </summary>
		/// <returns>Returns new instance of the ChangePasswordPage class.</returns>
		public ChangePasswordPage NavigateToTheChangePasswordPage()
		{
			this.ChangePassword.Click();

			return new ChangePasswordPage();
		}

		/// <summary>
		/// Navigates to the Newsletter Preferences page.
		/// </summary>
		/// <returns>Returns new instance of the NewsletterPreferencesPage class.</returns>
		public NewsletterPreferencesPage NavigateToTheEmailPreferences()
		{
			this.NewsletterPreferences.Click();

			return new NewsletterPreferencesPage();
		}

		/// <summary>
		/// Navigates to the My Clippings page.
		/// </summary>
		/// <returns>Returns new instance of the MyClippingsPage class.</returns>
		public MyClippingsPage NavigateToTheMyClippings()
		{
			this.MyClippings.Click();

			return new MyClippingsPage();
		}

		/// <summary>
		/// Navigate to registration details page.
		/// </summary>
		/// <returns>Registration details page.</returns>
		public RegistrationDetailsPage NavigateToDetailsPage()
		{
			this.UpdateDetails.Click();

			return new RegistrationDetailsPage();
		}

		/// <summary>
		/// Navigates to the Manage Your Addresses page.
		/// </summary>
		/// <returns>Returns new instance of the ManageYourAddressesPage class.</returns>
		public ManageYourAddressesPage NavigateToTheManageYourAddresses()
		{
			this.ManageYourAddresses.Click();

			return new ManageYourAddressesPage();
		}

		/// <summary>
		/// Navigates to the View Your Previous Purchases page.
		/// </summary>
		/// <returns>Returns new instance of the ViewYourPreviousPurchases class.</returns>
		public ViewYourPreviousPurchasesPage NavigateToTheViewYourPreviousPurchases()
		{
			this.ViewYourPreviousPurchases.Click();

			return new ViewYourPreviousPurchasesPage();
		}

		/// <summary>
		/// Navigates to the View Your Previous Subscriptions page.
		/// </summary>
		/// <returns>Returns new instance of the ViewYourSubscriptionsPage class.</returns>
		public ViewYourSubscriptionsPage NavigateToTheViewYourSubscriptions()
		{
			this.ViewYourSubscriptions.Click();

			return new ViewYourSubscriptionsPage();
		}
	}
}
