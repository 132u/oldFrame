using Core;
using Core.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConfigFileCreator
{
	[TestClass]
	public class LoginPageConfiguration : TestBase
	{
		[TestMethod]
		public void EAP_LoginPageRequiredElements()
		{
			WebBrowser.Open(ApplicationConfiguration.Url + ApplicationConfiguration.LoginPageUrl);

			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "LoginPageRequiredElements", WebBrowser.PageSource));
		}
	}
}
