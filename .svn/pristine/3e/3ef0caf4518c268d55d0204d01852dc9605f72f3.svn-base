using Core;
using Core.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects.PageObjects;

namespace ConfigFileCreator
{
	[TestClass]
	public class RegistrationDetailsConfiguration : TestBase
	{
		[TestMethod]
		public void EAP_RegistrationDetailsRequiredElements()
		{
			WebBrowser.Open(ApplicationConfiguration.Url + ApplicationConfiguration.LoginPageUrl);
			RegistrationDetailsPage registrationDetailsPage = new LoginPage()
				.LoginToTheUserAccountSuccessfully(ApplicationConfiguration.ExistingUserName, ApplicationConfiguration.ExistingUserPassword, false)
				.Header
				.NavigateToTheMyAccount()
				.NavigateToDetailsPage();

			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "RegistrationDetailsPageRequiredElements", WebBrowser.PageSource));
		}
	}
}
