using Core;
using Core.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects.PageObjects;

namespace ConfigFileCreator
{
	[TestClass]
	public class MyAccountPageConfiguration : TestBase
	{
		[TestMethod]
		public void EAP_MyAccountPageRequiredElements()
		{
			WebBrowser.Open(ApplicationConfiguration.Url + ApplicationConfiguration.LoginPageUrl);
			new LoginPage().LoginToTheUserAccountSuccessfully(ApplicationConfiguration.ExistingUserName, ApplicationConfiguration.ExistingUserPassword, false);
			WebBrowser.Open(ApplicationConfiguration.Url + ApplicationConfiguration.MyAccountPageUrl);

			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "MyAccountPageRequiredElements", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_ChangePasswordPageRequiredElements()
		{
			WebBrowser.Open(ApplicationConfiguration.Url + ApplicationConfiguration.LoginPageUrl);
			new LoginPage().LoginToTheUserAccountSuccessfully(ApplicationConfiguration.ExistingUserName, ApplicationConfiguration.ExistingUserPassword, false);
			new HomePage().Header.NavigateToTheMyAccount().NavigateToTheChangePasswordPage();

			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "ChangePasswordPageRequiredElements", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_NewsletterPreferencesRequiredElements()
		{
			WebBrowser.Open(ApplicationConfiguration.Url + ApplicationConfiguration.LoginPageUrl);
			new LoginPage().LoginToTheUserAccountSuccessfully(ApplicationConfiguration.ExistingUserName, ApplicationConfiguration.ExistingUserPassword, false);
			NewsletterPreferencesPage newsletterPreferencesPage = new HomePage().Header.NavigateToTheMyAccount().NavigateToTheEmailPreferences();
			newsletterPreferencesPage.NewsletterPreferences.DeselectNewsAlerts();

			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "NewsletterPreferencesRequiredElements", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_ViewYourPreviousPurchasesRequiredElements()
		{
			WebBrowser.Open(ApplicationConfiguration.Url + ApplicationConfiguration.LoginPageUrl);
			new LoginPage().LoginToTheUserAccountSuccessfully(ApplicationConfiguration.ExistingUserName, ApplicationConfiguration.ExistingUserPassword, false);
			new HomePage().Header.NavigateToTheMyAccount().NavigateToTheViewYourPreviousPurchases();

			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "ViewYourPreviousPurchasesRequiredElements", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_ViewYourSubscriptionsRequiredElements()
		{
			WebBrowser.Open(ApplicationConfiguration.Url + ApplicationConfiguration.LoginPageUrl);
			new LoginPage().LoginToTheUserAccountSuccessfully(ApplicationConfiguration.ExistingUserName, ApplicationConfiguration.ExistingUserPassword, false);
			new HomePage().Header.NavigateToTheMyAccount().NavigateToTheViewYourSubscriptions();

			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "ViewYourSubscriptionsRequiredElements", WebBrowser.PageSource));
		}
	}
}
