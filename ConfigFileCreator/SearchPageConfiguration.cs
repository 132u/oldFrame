using Core;
using Core.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConfigFileCreator
{
	[TestClass]
	public class SearchPageConfiguration : TestBase
	{
		[TestMethod]
		public void EAP_AdvancedSearchPageRequiredElements()
		{
			WebBrowser.Open(ApplicationConfiguration.Url + ApplicationConfiguration.AdvancedSearchUrl);

			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "AdvancedSearchPageRequiredElements", WebBrowser.PageSource));
		}
	}
}
