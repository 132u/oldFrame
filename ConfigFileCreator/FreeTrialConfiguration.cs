using Core;
using Core.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects.PageObjects;

namespace ConfigFileCreator
{
	[TestClass]
	public class FreeTrialConfiguration : TestBase
	{
		[TestMethod]
		public void EAP_FreeTrialStepOneSignUpStatus()
		{
			WebBrowser.Open(ApplicationConfiguration.Url + ApplicationConfiguration.FreeTrialStepOneUrl);

			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "FreeTrialStepOneSignUpStatus", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_FreeTrialStepOneRegistrationPanel()
		{
			WebBrowser.Open(ApplicationConfiguration.Url + ApplicationConfiguration.FreeTrialStepOneUrl);

			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "FreeTrialStepOneRegistrationPanel", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_FreeTrialEnterExistingUserPasswordSignUpStatus()
		{
			WebBrowser.Open(ApplicationConfiguration.Url);
			new HomePage().Header.NavigateToTheFreeTrial().NavigateToStepOneByUsingExistingCredentials(ApplicationConfiguration.ExistingExpiredUserName);

			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "FreeTrialEnterExistingUserPasswordSignUpStatus", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_FreeTrialStepTwoSignUpStatus()
		{
			WebBrowser.Open(ApplicationConfiguration.Url);
			new HomePage().Header.NavigateToTheFreeTrial().NavigateToTheFreeTrialStepTwoSuccessfully();

			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "FreeTrialStepTwoSignUpStatus", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_FreeTrialStepTwoYourDetailsSection()
		{
			WebBrowser.Open(ApplicationConfiguration.Url);
			new HomePage().Header.NavigateToTheFreeTrial().NavigateToTheFreeTrialStepTwoSuccessfully();

			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "FreeTrialStepTwoYourDetailsSection", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_FreeTrialStepTwoDeliveryAddressSection()
		{
			WebBrowser.Open(ApplicationConfiguration.Url);
			new HomePage().Header.NavigateToTheFreeTrial().NavigateToTheFreeTrialStepTwoSuccessfully();

			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "FreeTrialStepTwoDeliveryAddressSection", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_FreeTrialStepTwoEmailPreferencesSection()
		{
			WebBrowser.Open(ApplicationConfiguration.Url);
			new HomePage().Header.NavigateToTheFreeTrial().NavigateToTheFreeTrialStepTwoSuccessfully();

			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "FreeTrialStepTwoEmailPreferencesSection", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_FreeTrialStepTwoDataProtectionSection()
		{
			WebBrowser.Open(ApplicationConfiguration.Url);
			new HomePage().Header.NavigateToTheFreeTrial().NavigateToTheFreeTrialStepTwoSuccessfully();

			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "FreeTrialStepTwoDataProtectionSection", WebBrowser.PageSource));
		}
	}
}
