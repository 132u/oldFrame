using Core;
using Core.Configuration;
using Core.Helpers;
using NUnit.Framework;
using PageObjects.PageObjects;
using TechTalk.SpecFlow;

namespace Spec.MyAccount
{
	[Binding]
	public class MyAccountSteps
	{
		[Given(@"I'm logged in")]
		public void GivenIMLoggedIn()
		{
			var homePage = new HomePage()
									.Header
									.NavigateToTheLoginPage()
									.LoginToTheUserAccountSuccessfully(ApplicationConfiguration.ExistingUserName, ApplicationConfiguration.ExistingUserPassword, false);

			Assert.IsTrue(new HeaderComponent().IsLoggedIn(), "User is not logged in.");
		}

		[When(@"I enter MyAccount page")]
		public void WhenIEnterMyAccountPage()
		{
			new HomePage().Header.NavigateToTheMyAccount();
		}

		[Given(@"I enter Change Password page")]
		public void GivenIEnterChangePasswordPage()
		{
			new MyAccountPage().NavigateToTheChangePasswordPage();
		}

		[Then(@"MyAccount page is displayed correctly")]
		public void ThenMyAccountPageIsDisplayedCorrectly()
		{
			var myAccountPage = new MyAccountPage();

			Assert.IsTrue(myAccountPage.IsDisplayedCorrectly(), "My Account page is not displayed correctly.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.MyAccountPageUrl), "My Account page URL is not as expected.");
			Assert.IsTrue(myAccountPage.SidePanel.PageIsDisplayed("Default"), "Side panel is not displayed.");
			Assert.IsTrue(myAccountPage.Header.PageIsDisplayed(), "Header component is not displayed.");
			Assert.IsTrue(myAccountPage.TopMenu.PageIsDisplayed("Default"), "Top Menu is not displayed.");
			Assert.IsTrue(myAccountPage.Breadcrumb.PageIsDisplayed("MyAccount"), "Breadcrump is not displayed.");
			Assert.IsTrue(myAccountPage.Footer.PageIsDisplayed(), "Footer is not displayed.");
		}

		[Given(@"I enter Newsletter Preferences page")]
		public void GivenIEnterNewsletterPreferencesPage()
		{
			new MyAccountPage().NavigateToTheEmailPreferences();
		}

		[Then(@"My Account Newsletter Preferences page is displayed correctly")]
		public void ThenMyAccountNewsletterPreferencesPageIsDisplayedCorrectly()
		{
			var newsletterPreferencesPage = new NewsletterPreferencesPage();

			Assert.IsTrue(newsletterPreferencesPage.PageIsDisplayed(), "Newsletter preferences page is not displayed correctly.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.NewsletterPreferencesUrl), "Newsletter preferences url is not as expected.");
			Assert.IsTrue(newsletterPreferencesPage.SidePanel.PageIsDisplayed("Default"), "Side panel is not displayed correctly.");
			Assert.IsTrue(newsletterPreferencesPage.Header.PageIsDisplayed(), "Header component is not displayed correctly.");
			Assert.IsTrue(newsletterPreferencesPage.TopMenu.PageIsDisplayed("Default"), "Top Menu is not displayed correctly.");
			Assert.IsTrue(BasicHelper.WaitForSuccess(() => newsletterPreferencesPage.Breadcrumb.PageIsDisplayed("NewsletterPreferences")), "Breadcrump is not displayed correctly.");
			Assert.IsTrue(newsletterPreferencesPage.Footer.PageIsDisplayed(), "Footer is not displayed correctly.");
		}

		[Given(@"I enter My Clippings page")]
		public void GivenIEnterMyClippingsPage()
		{
			new MyAccountPage().NavigateToTheMyClippings();
		}

		[Then(@"My Account My Clippings page is displayed correctly")]
		public void ThenMyAccountMyClippingsPageIsDisplayedCorrectly()
		{
			var myClippingsPage = new MyClippingsPage();

			Assert.IsTrue(myClippingsPage.IsDisplayedCorrectly(), "My Clippings preferences page is not displayed correctly.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.MyClippingsUrl), "My Clippings page URL is different than expected.");
			Assert.IsTrue(myClippingsPage.SidePanel.PageIsDisplayed("Default"), "Side panel is not displayed correctly.");
			Assert.IsTrue(myClippingsPage.Header.PageIsDisplayed(), "Header component is not displayed correctly.");
			Assert.IsTrue(myClippingsPage.TopMenu.PageIsDisplayed("Default"), "Top Menu is not displayed correctly.");
			Assert.IsTrue(myClippingsPage.Breadcrumb.PageIsDisplayed("MyClippings"), "Breadcrump is not displayed correctly.");
			Assert.IsTrue(myClippingsPage.Footer.PageIsDisplayed(), "Footer is not displayed correctly.");
		}

		[Given(@"I'm on the MyAccount page")]
		public void GivenIMOnTheMyAccountPage()
		{
			MyAccountPage myAccountPage = new HomePage()
						.Header
						.NavigateToTheLoginPage()
						.LoginToTheUserAccountSuccessfully(ApplicationConfiguration.ExistingUserName, ApplicationConfiguration.ExistingUserPassword, false)
						.Header
						.NavigateToTheMyAccount();

			Assert.IsTrue(myAccountPage.IsDisplayedCorrectly(), "My Account page is not displayed.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.MyAccountPageUrl), "My Account page is not displayed.");
		}

		[When(@"I enter details page")]
		public void WhenIEnterDetailsPage()
		{
			new HomePage()
						.Header
						.NavigateToTheLoginPage()
						.LoginToTheUserAccountSuccessfully(ApplicationConfiguration.ExistingUserName, ApplicationConfiguration.ExistingUserPassword, false)
						.Header
						.NavigateToTheMyAccount()
						.NavigateToDetailsPage();
		}

		[Then(@"Registration details page is displayed correctly")]
		public void ThenRegistrationDetailsPageIsDisplayedCorrectly()
		{
			Assert.IsTrue(new RegistrationDetailsPage().IsDisplayedCorrectly(), "Registration details page is not displayed.");
		}

		[Given(@"I enter Manage Your Addresses page")]
		public void GivenIEnterManageYourAddressesPage()
		{
			new MyAccountPage().NavigateToTheManageYourAddresses();
		}

		[Then(@"My Account Manage Your Addresses page is displayed correctly")]
		public void ThenMyAccountManageYourAddressesPageIsDisplayedCorrectly()
		{
			Assert.IsTrue(new ManageYourAddressesPage().IsDisplayedCorrectly(), "Manage your addresses page is not displayed.");
		}

		[Given(@"I enter View your previous purchases page")]
		public void GivenIEnterViewYourPreviousPurchasesPage()
		{
			new MyAccountPage().NavigateToTheViewYourPreviousPurchases();
		}

		[Then(@"My Account View your previous purchases page is displayed correctly")]
		public void ThenMyAccountViewYourPreviousPurchasesPageIsDisplayedCorrectly()
		{
			Assert.IsTrue(new ViewYourPreviousPurchasesPage().IsDisplayedCorrectly(), "View your previous purchases page is not displayed.");
		}

		[Given(@"I enter View your previous subscriptions page")]
		public void GivenIEnterViewYourPreviousSubscriptionsPage()
		{
			new MyAccountPage().NavigateToTheViewYourSubscriptions();
		}

		[Then(@"My Account View your previous subscriptions page is displayed correctly")]
		public void ThenMyAccountViewYourPreviousSubscriptionsPageIsDisplayedCorrectly()
		{
			Assert.IsTrue(new ViewYourSubscriptionsPage().IsDisplayedCorrectly(), "View your previous subscriptions page is not displayed.");
		}

		[When(@"I click MyAccount button")]
		public void WhenIClickMyAccountButton()
		{
			new HomePage().Header.ShowMyAccountBox();
		}

		[Then(@"MyAccount box is displayed")]
		public void ThenMyAccountBoxIsDisplayed()
		{
			Assert.IsTrue(new HomePage().Header.MyAccountBox.PageIsDisplayed());
		}

		[When(@"I enter Change Password page from My Account box link")]
		public void WhenIEnterChangePasswordPageFromMyAccountBoxLink()
		{
			new MyAccountBoxComponent().NavigateToTheChangePasswordPage();
		}

		[When(@"I enter registration details page from My Account box link")]
		public void WhenIEnterRegistrationDetailsPageFromMyAccountBoxLink()
		{
			new MyAccountBoxComponent().NavigateToDetailsPage();
		}
	}
}