using Core;
using Core.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConfigFileCreator
{
	[TestClass]
	public class SitePagesConfiguration : TestBase
	{
		[TestMethod]
		public void EAP_AboutUsRequiredElementsList()
		{
			string aboutUsPageUrl = ApplicationConfiguration.Url + ApplicationConfiguration.AboutUsUrl;
			WebBrowser.Open(aboutUsPageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "AboutUsRequiredElementsList", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_ContactUsRequiredElementsList()
		{
			string contactUsPageUrl = ApplicationConfiguration.Url + ApplicationConfiguration.ContactUsUrl;
			WebBrowser.Open(contactUsPageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "ContactUsRequiredElementsList", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_FeedbackFormRequiredElements()
		{
			string feedbackPageUrl = ApplicationConfiguration.Url + ApplicationConfiguration.FeedbackUrl;
			WebBrowser.Open(feedbackPageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "FeedbackForm", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_VideoPageRequiredElementsRequiredElements()
		{
			string videoPageUrl = ApplicationConfiguration.Url + ApplicationConfiguration.VideoUrl;
			WebBrowser.Open(videoPageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "VideoPageRequiredElements", WebBrowser.PageSource));
		}
	}
}
