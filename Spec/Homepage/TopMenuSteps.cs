using Core;
using Core.Configuration;
using NUnit.Framework;
using PageObjects.PageObjects;
using TechTalk.SpecFlow;

namespace Spec.Homepage
{
	[Binding]
	public class TopMenuSteps
	{
		[When(@"I enter News page by top menu link")]
		public void WhenIEnterNewsPageByTopMenuLink()
		{
			new TopMenuComponent().NavigateToTheNews();
		}

		[When(@"I enter EM View page by top menu link")]
		public void WhenIEnterEMViewPageByTopMenuLink()
		{
			new TopMenuComponent().NavigateToTheEMView();
		}

		[When(@"I enter Analysis page by top menu link")]
		public void WhenIEnterAnalysisPageByTopMenuLink()
		{
			new TopMenuComponent().NavigateToTheAnalysis();
		}

		[Then(@"Analysis page is displayed")]
		public void ThenAnalysisPageIsDisplayed()
		{
			var analysisPage = new AnalysisPage();

			Assert.IsTrue(analysisPage.IsDisplayedCorrectly(), "Analysis page is not displayed.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.AnalysisUrl), "Analysis page is not displayed.");
			Assert.IsTrue(analysisPage.SidePanel.PageIsDisplayed("Default"), "Side panel is not displayed.");
			Assert.IsTrue(analysisPage.Header.PageIsDisplayed(), "Header component is not displayed.");
			Assert.IsTrue(analysisPage.TopMenu.PageIsDisplayed("Default"), "Top Menu is not displayed.");
			Assert.IsTrue(analysisPage.Breadcrumb.PageIsDisplayed("Analysis"), "Breadcrump is not displayed.");
			Assert.IsTrue(analysisPage.Footer.PageIsDisplayed(), "Footer is not displayed.");
		}

		[When(@"I enter Regions page by top menu link")]
		public void WhenIEnterRegionsPageByTopMenuLink()
		{
			new TopMenuComponent().NavigateToTheRegions();
		}

		[Then(@"Regions page is displayed")]
		public void ThenRegionsPageIsDisplayed()
		{
			var regionsPage = new RegionsPage();

			Assert.IsTrue(regionsPage.IsDisplayedCorrectly(), "Regions page is not displayed.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.RegionsUrl), "Regions page is not displayed.");
			Assert.IsTrue(regionsPage.SidePanel.PageIsDisplayed("Default"), "Side panel is not displayed.");
			Assert.IsTrue(regionsPage.Header.PageIsDisplayed(), "Header component is not displayed.");
			Assert.IsTrue(regionsPage.TopMenu.PageIsDisplayed("Default"), "Top Menu is not displayed.");
			Assert.IsTrue(regionsPage.Breadcrumb.PageIsDisplayed("Regions"), "Breadcrump is not displayed.");
			Assert.IsTrue(regionsPage.Footer.PageIsDisplayed(), "Footer is not displayed.");
		}

		[When(@"I enter Economics and Policy page by top menu link")]
		public void WhenIEnterEconomicsAndPolicyPageByTopMenuLink()
		{
			new TopMenuComponent().NavigateToTheEconomicsAndPolicy();
		}

		[When(@"I enter Financial Markets page by top menu link")]
		public void WhenIEnterFinancialMarketsPageByTopMenuLink()
		{
			new TopMenuComponent().NavigateToTheFinancialMarkets();
		}

		[When(@"I enter Development page by top menu link")]
		public void WhenIEnterDevelopmentPageByTopMenuLink()
		{
			new TopMenuComponent().NavigateToTheDevelopment();
		}

		[When(@"I enter Polls and Awards page by top menu link")]
		public void WhenIEnterPollsAndAwardsPageByTopMenuLink()
		{
			new TopMenuComponent().NavigateToThePollsAndAwards();
		}

		[When(@"I enter Events page by top menu link")]
		public void WhenIEnterEventsPageByTopMenuLink()
		{
			new TopMenuComponent().NavigateToTheEvents();
		}

		[When(@"I enter Video page by top menu link")]
		public void WhenIEnterVideoPageByTopMenuLink()
		{
			new TopMenuComponent().NavigateToTheSectorsPage();
		}

		[Then(@"Video page is displayed")]
		public void ThenVideoPageIsDisplayed()
		{
			var videoPage = new VideoPage();

			Assert.IsTrue(videoPage.IsDisplayedCorrectly(), "Video page is not displayed correctly.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.VideoUrl), "Video page URL is different than exptected.");
			Assert.IsTrue(videoPage.Header.PageIsDisplayed(), "Header component is not displayed.");
			Assert.IsTrue(videoPage.TopMenu.PageIsDisplayed("Default"), "Top Menu is not displayed.");
			Assert.IsTrue(videoPage.Breadcrumb.PageIsDisplayed("Video"), "Breadcrump is not displayed.");
			Assert.IsTrue(videoPage.Footer.PageIsDisplayed(), "Footer is not displayed.");
		}

		[When(@"I enter Comment and Opinion page by top menu link")]
		public void WhenIEnterCommentAndOpinionPageByTopMenuLink()
		{
			new TopMenuComponent().NavigateToTheCommentAndOpinion();
		}

		[When(@"I enter Features page by top menu link")]
		public void WhenIEnterFeaturesPageByTopMenuLink()
		{
			new TopMenuComponent().NavigateToTheFeatures();
		}

		[When(@"I enter Americas page by top menu link")]
		public void WhenIEnterAmericasPageByTopMenuLink()
		{
			new TopMenuComponent().NavigateToTheAmericas();
		}

		[When(@"I enter Asia page by top menu link")]
		public void WhenIEnterAsiaPageByTopMenuLink()
		{
			new TopMenuComponent().NavigateToTheAsia();
		}

		[When(@"I enter Emerging Europe page by top menu link")]
		public void WhenIEnterEmergingEuropePageByTopMenuLink()
		{
			new TopMenuComponent().NavigateToTheEmergingEurope();
		}

		[When(@"I enter Global page by top menu link")]
		public void WhenIEnterGlobalPageByTopMenuLink()
		{
			new TopMenuComponent().NavigateToTheEmergingGlobal();
		}

		[Then(@"Global page is displayed")]
		public void ThenGlobalPageIsDisplayed()
		{
			var globalPage = new GlobalPage();

			Assert.IsTrue(globalPage.IsDisplayedCorrectly(), "Global page is not displayed.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.GlobalUrl), "Global page is not displayed.");
			Assert.IsTrue(globalPage.SidePanel.PageIsDisplayed("Default"), "Side panel is not displayed.");
			Assert.IsTrue(globalPage.Header.PageIsDisplayed(), "Header component is not displayed.");
			Assert.IsTrue(globalPage.TopMenu.PageIsDisplayed("Default"), "Top Menu is not displayed.");
			Assert.IsTrue(globalPage.Breadcrumb.PageIsDisplayed("Global"), "Breadcrump is not displayed.");
			Assert.IsTrue(globalPage.Footer.PageIsDisplayed(), "Footer is not displayed.");
		}

		[When(@"I enter Middle East & Africa page by top menu link")]
		public void WhenIEnterMiddleEastAfricaPageByTopMenuLink()
		{
			new TopMenuComponent().NavigateToTheEmergingMiddleEastAndAfrica();
		}

		[When(@"I enter Sectors page by top menu link")]
		public void WhenIEnterSectorsPageByTopMenuLink()
		{
			new TopMenuComponent().NavigateToTheSectorsPage();
		}

		[Then(@"Sectors page is displayed")]
		public void ThenSectorsPageIsDisplayed()
		{
			var sectorsPage = new SectorsPage();

			Assert.IsTrue(sectorsPage.IsDisplayedCorrectly(), "Sectors page is not displayed correctly.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.SectorsUrl), "Sectors page is not displayed.");
		}

		[When(@"I enter Interviews page by top menu link")]
		public void WhenIEnterInterviewsPageByTopMenuLink()
		{
			new TopMenuComponent().NavigateToTheInterviewsPage();
		}

		[Then(@"Interviews page is displayed")]
		public void ThenInterviewsPageIsDisplayed()
		{
			var interviewsPage = new InterviewsPage();

			Assert.IsTrue(interviewsPage.IsDisplayedCorrectly(), "Interviews page is not displayed correctly.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.InterviewsUrl), "Interviews page is not displayed.");
		}

		[When(@"I enter CFOs page by top menu link")]
		public void WhenIEnterCFOsPageByTopMenuLink()
		{
			new TopMenuComponent().NavigateToTheCFOsPage();
		}

		[Then(@"CFOs page is displayed")]
		public void ThenCFOsPageIsDisplayed()
		{
			var cFOsPage = new CFOsPage();

			Assert.IsTrue(cFOsPage.IsDisplayedCorrectly(), "CFOsPage page is not displayed correctly.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.CFOsUrl), "CFOsPage page is not displayed.");
		}

		[When(@"I enter CMOs page by top menu link")]
		public void WhenIEnterCMOsPageByTopMenuLink()
		{
			new TopMenuComponent().NavigateToTheCMOsPage();
		}

		[Then(@"CMOs page is displayed")]
		public void ThenCMOsPageIsDisplayed()
		{
			var сMOsPage = new CMOsPage();

			Assert.IsTrue(сMOsPage.IsDisplayedCorrectly(), "CMOs page is not displayed correctly.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.CMOsUrl), "CMOs page is not displayed.");
		}

		[When(@"I enter GTBTV page by top menu link")]
		public void WhenIEnterGTBTVPageByTopMenuLink()
		{
			new TopMenuComponent().NavigateToTheGTBTV();
		}

		[Then(@"GTBTV page is displayed")]
		public void ThenGTBTVPageIsDisplayed()
		{
			var gTBTVPage = new GTBTVPage();

			Assert.IsTrue(gTBTVPage.IsDisplayedCorrectly(), "GTBTV page is not displayed correctly.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.GTBTVUrl), "GTBTV page is not displayed.");
		}

		[When(@"I enter AboutUs page by top menu link")]
		public void WhenIEnterAboutUsPageByTopMenuLink()
		{
			new TopMenuComponent().NavigateToTheAboutUsPage();
		}

		[Then(@"AboutUs page is displayed")]
		public void ThenAboutUsPageIsDisplayed()
		{
			var aboutUsPage = new AboutUsPage();

			Assert.IsTrue(aboutUsPage.IsDisplayedCorrectly(), "AboutUsPage page is not displayed correctly.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.AboutUsUrl), "AboutUs page is not displayed.");
		}

		[When(@"I enter MyAccount page by top menu link")]
		public void WhenIEnterMyAccountPageByTopMenuLink()
		{
			new TopMenuComponent().NavigateToTheMyAccountPage();
		}

		[Then(@"MyAccount page is displayed")]
		public void ThenMyAccountPageIsDisplayed()
		{
			var myAccountPage = new MyAccountPage();

			Assert.IsTrue(myAccountPage.IsDisplayedCorrectly(), "MyAccountPage page is not displayed correctly.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.MyAccountPageUrl), "MyAccount page is not displayed.");
		}
	}
}
