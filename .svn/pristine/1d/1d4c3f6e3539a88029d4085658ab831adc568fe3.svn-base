using Core;
using Core.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects.PageObjects;

namespace ConfigFileCreator
{
	[TestClass]
	public class SidePanelConfiguration : TestBase
	{
		[TestMethod]
		public void EAP_SidePanelDefaultRequiredElements()
		{
			WebBrowser.Open(ApplicationConfiguration.Url);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "SidePanelDefaultRequiredElements", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_SidePanelArticlesPageRequiredElements()
		{
			WebBrowser.Open(ApplicationConfiguration.Url);
			new HomePage()
				.Header
				.NavigateToTheLoginPage()
				.LoginToTheUserAccountSuccessfully(ApplicationConfiguration.ExistingUserName, ApplicationConfiguration.ExistingUserPassword, true)
				.TopMenu
				.NavigateToTheNews()
				.NavigateToTheFirstArticleFromTheList();

			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "SidePanelArticlesPageRequiredElements", WebBrowser.PageSource));
		}
	}
}
