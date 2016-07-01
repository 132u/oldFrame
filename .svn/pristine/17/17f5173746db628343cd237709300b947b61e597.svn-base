using Core;
using Core.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects.PageObjects;

namespace ConfigFileCreator
{
	[TestClass]
	public class SubscribeConfiguration : TestBase
	{
		[TestMethod]
		public void EAP_SubscribeNBOCheckoutStepOneRegistrationPanel()
		{
			WebBrowser.Open(ApplicationConfiguration.Url + ApplicationConfiguration.SubscribeStepOneUrl);

			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "SubscribeNBOCheckoutStepOneRegistrationPanel", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_SubscribeNBOCheckoutStepOneToolbar()
		{
			WebBrowser.Open(ApplicationConfiguration.Url + ApplicationConfiguration.SubscribeStepOneUrl);

			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "SubscribeNBOCheckoutStepOneToolbar", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_SubscribeNBOCheckoutStepOneFooterLinks()
		{
			WebBrowser.Open(ApplicationConfiguration.Url + ApplicationConfiguration.SubscribeStepOneUrl);

			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "SubscribeNBOCheckoutStepOneFooterLinks", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_SubscribeStepOneForm()
		{
			WebBrowser.Open(ApplicationConfiguration.Url);

			SubscribeStepOnePage stepOnePage = new HomePage()
			.Footer
			.NavigateToTheSubscribePage();

			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "SubscribeStepOneForm", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_SubscribeStepOneRegistrationPanel()
		{
			WebBrowser.Open(ApplicationConfiguration.Url);

			SubscribeStepOnePage stepOnePage = new HomePage()
			.Footer
			.NavigateToTheSubscribePage();

			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "SubscribeStepOneRegistrationPanel", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_SubscribeStepOneToolbar()
		{
			WebBrowser.Open(ApplicationConfiguration.Url);

			SubscribeStepOnePage stepOnePage = new HomePage()
			.Footer
			.NavigateToTheSubscribePage();

			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "SubscribeStepOneToolbar", WebBrowser.PageSource));
		}
	}
}
