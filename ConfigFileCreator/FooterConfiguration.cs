namespace ConfigFileCreator
{
	using Core;
	using Core.Configuration;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class FooterConfiguration : TestBase
	{
		[TestMethod]
		public void EAP_FooterComponentRequiredElements()
		{
			string homePageUrl = ApplicationConfiguration.Url;
			WebBrowser.Open(homePageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "FooterComponentRequiredElements", WebBrowser.PageSource));
		}
	}
}
