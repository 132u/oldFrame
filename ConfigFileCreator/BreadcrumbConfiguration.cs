using Core;
using Core.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjects.PageObjects;

namespace ConfigFileCreator
{
	[TestClass]
	public class BreadcrumbConfiguration : TestBase
	{
		[TestMethod]
		public void EAP_AboutUsBreadcrumbRequiredElements()
		{
			string aboutUsPageUrl = ApplicationConfiguration.Url + ApplicationConfiguration.AboutUsUrl;
			WebBrowser.Open(aboutUsPageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "AboutUsBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_ContactUsBreadcrumbRequiredElements()
		{
			string contactUsPageUrl = ApplicationConfiguration.Url + ApplicationConfiguration.ContactUsUrl;
			WebBrowser.Open(contactUsPageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "ContactUsBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_FeedbackBreadcrumbRequiredElements()
		{
			string feedbackPageUrl = ApplicationConfiguration.Url + ApplicationConfiguration.FeedbackUrl;
			WebBrowser.Open(feedbackPageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "FeedbackBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_TermsBreadcrumbRequiredElements()
		{
			string termsPageUrl = ApplicationConfiguration.Url + ApplicationConfiguration.TermsAndConditionsUrl;
			WebBrowser.Open(termsPageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "TermsBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_PrivacyBreadcrumbRequiredElements()
		{
			string privacyPageUrl = ApplicationConfiguration.Url + ApplicationConfiguration.PrivacyPolicyUrl;
			WebBrowser.Open(privacyPageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "PrivacyBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_FAQBreadcrumbRequiredElements()
		{
			string faqPageUrl = ApplicationConfiguration.Url + ApplicationConfiguration.FAQUrl;
			WebBrowser.Open(faqPageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "FAQBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_CookiesBreadcrumbRequiredElements()
		{
			string cookiesPageUrl = ApplicationConfiguration.Url + ApplicationConfiguration.CookiesUrl;
			WebBrowser.Open(cookiesPageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "CookiesBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_NewspaperArchiveBreadcrumbRequiredElements()
		{
			string newspaperArchivePageUrl = ApplicationConfiguration.Url + ApplicationConfiguration.NewspaperArchiveUrl;
			WebBrowser.Open(newspaperArchivePageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "NewspaperArchiveBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_SponsoredReportsBreadcrumbRequiredElements()
		{
			string sponsoredReportsPageUrl = ApplicationConfiguration.Url + ApplicationConfiguration.SponsoredReportsUrl;
			WebBrowser.Open(sponsoredReportsPageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "SponsoredReportsBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_EconomicsAndPolicyBreadcrumbRequiredElements()
		{
			string economicsAndPolicyPageUrl = ApplicationConfiguration.Url + ApplicationConfiguration.EconomicsAndPolicyUrl;
			WebBrowser.Open(economicsAndPolicyPageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "EconomicsAndPolicyBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_FinancialMarketsBreadcrumbRequiredElements()
		{
			string financialMarketsPageUrl = ApplicationConfiguration.Url + ApplicationConfiguration.FinancialMarketsUrl;
			WebBrowser.Open(financialMarketsPageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "FinancialMarketsBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_DevelopmentBreadcrumbRequiredElements()
		{
			string developmentPageUrl = ApplicationConfiguration.Url + ApplicationConfiguration.DevelopmentUrl;
			WebBrowser.Open(developmentPageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "DevelopmentBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_MiddleEastAndAfricaBreadcrumbRequiredElements()
		{
			string middleEastAndAfricaPageUrl = ApplicationConfiguration.Url + ApplicationConfiguration.MiddleEastAndAfricaUrl;
			WebBrowser.Open(middleEastAndAfricaPageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "MiddleEastAndAfricaBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_AmericasBreadcrumbRequiredElements()
		{
			string americasPageUrl = ApplicationConfiguration.Url + ApplicationConfiguration.AmericasUrl;
			WebBrowser.Open(americasPageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "AmericasBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_AsiaBreadcrumbRequiredElements()
		{
			string asiaPageUrl = ApplicationConfiguration.Url + ApplicationConfiguration.AsiaUrl;
			WebBrowser.Open(asiaPageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "AsiaBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_EmergingEuropeBreadcrumbRequiredElements()
		{
			string emergingEuropePageUrl = ApplicationConfiguration.Url + ApplicationConfiguration.EuropeUrl;
			WebBrowser.Open(emergingEuropePageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "EmergingEuropeBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_PollsAndAwardsBreadcrumbRequiredElements()
		{
			string pollsAndAwardsPageUrl = ApplicationConfiguration.Url + ApplicationConfiguration.PollsAndAwardsUrl;
			WebBrowser.Open(pollsAndAwardsPageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "PollsAndAwardsBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_EventsBreadcrumbRequiredElements()
		{
			string eventsPageUrl = ApplicationConfiguration.Url + ApplicationConfiguration.EventsUrl;
			WebBrowser.Open(eventsPageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "EventsBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_CommentAndOpinionBreadcrumbRequiredElements()
		{
			string commentAndOpinionPageUrl = ApplicationConfiguration.Url + ApplicationConfiguration.CommentAndOpinionUrl;
			WebBrowser.Open(commentAndOpinionPageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "CommentAndOpinionBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_FeaturesBreadcrumbRequiredElements()
		{
			string featuresPageUrl = ApplicationConfiguration.Url + ApplicationConfiguration.FeaturesUrl;
			WebBrowser.Open(featuresPageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "FeaturesBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_NewsBreadcrumbRequiredElements()
		{
			string newsPageUrl = ApplicationConfiguration.Url + ApplicationConfiguration.NewsUrl;
			WebBrowser.Open(newsPageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "NewsBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_ResearchBreadcrumbRequiredElements()
		{
			string researchPageUrl = ApplicationConfiguration.Url + ApplicationConfiguration.ResearchUrl;
			WebBrowser.Open(researchPageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "ResearchBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_EMViewBreadcrumbRequiredElements()
		{
			string emViewPageUrl = ApplicationConfiguration.Url + ApplicationConfiguration.EMViewUrl;
			WebBrowser.Open(emViewPageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "EMViewBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_RSSFeedsBreadcrumbRequiredElements()
		{
			string rssFeedsPageUrl = ApplicationConfiguration.Url + ApplicationConfiguration.RSSUrl;
			WebBrowser.Open(rssFeedsPageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "RSSFeedsBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_LoginBreadcrumbRequiredElements()
		{
			string loginPageUrl = ApplicationConfiguration.Url + ApplicationConfiguration.LoginPageUrl;
			WebBrowser.Open(loginPageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "LoginBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_AnalysisBreadcrumbRequiredElements()
		{
			string analysisPageUrl = ApplicationConfiguration.Url + ApplicationConfiguration.AnalysisUrl;
			WebBrowser.Open(analysisPageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "AnalysisBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_RegionsBreadcrumbRequiredElements()
		{
			string regionsPageUrl = ApplicationConfiguration.Url + ApplicationConfiguration.RegionsUrl;
			WebBrowser.Open(regionsPageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "RegionsBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_VideoBreadcrumbRequiredElements()
		{
			string videoPageUrl = ApplicationConfiguration.Url + ApplicationConfiguration.VideoUrl;
			WebBrowser.Open(videoPageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "VideoBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_GlobalBreadcrumbRequiredElements()
		{
			string globalPageUrl = ApplicationConfiguration.Url + ApplicationConfiguration.GlobalUrl;
			WebBrowser.Open(globalPageUrl);
			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "GlobalBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_MyAccountBreadcrumbRequiredElements()
		{
			WebBrowser.Open(ApplicationConfiguration.Url + ApplicationConfiguration.LoginPageUrl);
			new LoginPage().LoginToTheUserAccountSuccessfully(ApplicationConfiguration.ExistingUserName, ApplicationConfiguration.ExistingUserPassword, false);
			WebBrowser.Open(ApplicationConfiguration.Url + ApplicationConfiguration.MyAccountPageUrl);

			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "MyAccountBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_MyAccountChangePasswordBreadcrumbRequiredElements()
		{
			WebBrowser.Open(ApplicationConfiguration.Url + ApplicationConfiguration.LoginPageUrl);
			new LoginPage().LoginToTheUserAccountSuccessfully(ApplicationConfiguration.ExistingUserName, ApplicationConfiguration.ExistingUserPassword, false);
			WebBrowser.Open(ApplicationConfiguration.Url + ApplicationConfiguration.MyAccountChangePasswordUrl);

			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "MyAccountChangePasswordBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_MyAccountPasswordUpdatedBreadcrumbRequiredElements()
		{
			WebBrowser.Open(ApplicationConfiguration.Url + ApplicationConfiguration.LoginPageUrl);
			new LoginPage().LoginToTheUserAccountSuccessfully(ApplicationConfiguration.ExistingUserName, ApplicationConfiguration.ExistingUserPassword, false);
			WebBrowser.Open(ApplicationConfiguration.Url + ApplicationConfiguration.MyAccountPasswordUpdatedUrl);

			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "MyAccountPasswordUpdatedBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_MyAccountNewsletterPreferencesBreadcrumbRequiredElements()
		{
			WebBrowser.Open(ApplicationConfiguration.Url + ApplicationConfiguration.LoginPageUrl);
			new LoginPage().LoginToTheUserAccountSuccessfully(ApplicationConfiguration.ExistingUserName, ApplicationConfiguration.ExistingUserPassword, false);
			WebBrowser.Open(ApplicationConfiguration.Url + ApplicationConfiguration.NewsletterPreferencesUrl);

			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "MyAccountNewsletterPreferencesBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_MyAccountMyClippingsBreadcrumbRequiredElements()
		{
			WebBrowser.Open(ApplicationConfiguration.Url + ApplicationConfiguration.LoginPageUrl);
			new LoginPage().LoginToTheUserAccountSuccessfully(ApplicationConfiguration.ExistingUserName, ApplicationConfiguration.ExistingUserPassword, false);
			WebBrowser.Open(ApplicationConfiguration.Url + ApplicationConfiguration.MyClippingsUrl);

			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "MyAccountMyClippingsBreadcrumb", WebBrowser.PageSource));
		}

		[TestMethod]
		public void EAP_SearchResultsBreadcrumbRequiredElements()
		{
			WebBrowser.Open(ApplicationConfiguration.Url + ApplicationConfiguration.SearchResultsPageUrl);

			Assert.IsTrue(ConfigManager.ConfigManager.FillUpRequiredElements(ApplicationConfiguration.TestsConfigFilePath, "SearchResultsBreadcrumb", WebBrowser.PageSource));
		}
	}
}
