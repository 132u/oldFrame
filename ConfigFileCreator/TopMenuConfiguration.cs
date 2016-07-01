namespace ConfigFileCreator
{
	using Core;
	using Core.Configuration;
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using PageObjects.PageObjects;

	[TestClass]
	public class TopMenuConfiguration : TestBase
	{
		[TestMethod]
		public void EAP_TopMenuDefaultComponentRequiredElements()
		{
			string homePageUrl = ApplicationConfiguration.Url;
			WebBrowser.Open(homePageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "TopMenuDefaultComponentRequiredElements", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_SignUpTopMenuComponentRequiredElements()
		{
			WebBrowser.Open(ApplicationConfiguration.Url + ApplicationConfiguration.FreeTrialStepOneUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "SignUpTopMenuComponentRequiredElements", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_TopMenuAboutUsComponentRequiredElements()
		{
			WebBrowser.Open(ApplicationConfiguration.Url);
			AboutUsPage aboutUsPage = new HomePage().Footer.NavigateToTheAboutUs();
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "TopMenuAboutUsComponentRequiredElements", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_TopMenuEventsComponentRequiredElements()
		{
			WebBrowser.Open(ApplicationConfiguration.Url);
			EventsPage eventsPage = new HomePage().TopMenu.NavigateToTheEvents();
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "TopMenuEventsComponentRequiredElements", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_TopMenuCookiesComponentRequiredElements()
		{
			WebBrowser.Open(ApplicationConfiguration.Url);
			CookiesPage cookiesPage = new HomePage().Footer.NavigateToTheCookies();
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "TopMenuCookiesComponentRequiredElements", WebBrowser.PageSource));
		}
	}
}
