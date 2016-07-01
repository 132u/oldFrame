using Core;
using Core.Configuration;
using NUnit.Framework;
using PageObjects.PageObjects;
using TechTalk.SpecFlow;

namespace Spec.Homepage
{
	[Binding]
	public class FooterSteps
	{
		[Given(@"I'm on the Homepage")]
		public void GivenIMOnTheHomepage()
		{
			var homePage = new HomePage();

			Assert.IsTrue(homePage.IsDisplayed(), "Home page is not displayed.");
			Assert.AreEqual(ApplicationConfiguration.Url, WebBrowser.GetUrlAddress, "Home page URL is not as expected.");
		}

		[Then(@"the footer should be displayed")]
		public void ThenTheFooterShouldBeDisplayed()
		{
			Assert.IsTrue(new FooterComponent().PageIsDisplayed(), "Footer is not displayed correctly.");
		}

		[Then(@"The Copyright should be displayed under the footer")]
		public void ThenTheCopyrightShouldBeDisplayedUnderTheFooter()
		{
			Assert.IsTrue(new FooterComponent().CopyrightIsDisplayed(), "Copyright is not displayed correctly.");
		}

		[Then(@"I should be able to see logo of the site")]
		public void ThenIShouldBeAbleToSeeLogoOfTheSite()
		{
			Assert.IsTrue(new HeaderComponent().LogoIsDisplayed(), "Logo is not displayed.");
		}

		[When(@"I enter About Us page by footer link")]
		public void WhenIEnterAboutUsPageByFooterLink()
		{
			new FooterComponent().NavigateToTheAboutUs();
		}

		[Then(@"About Us page is displayed")]
		public void ThenAboutUsPageIsDisplayed()
		{
			var aboutUsPage = new AboutUsPage();

			Assert.IsTrue(aboutUsPage.IsDisplayedCorrectly(), "About us page is not displayed correctly.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.AboutUsUrl), "About us page URL is not as expected.");
			Assert.IsTrue(aboutUsPage.SidePanel.PageIsDisplayed("Default"), "Side panel is not displayed correctly.");
			Assert.IsTrue(aboutUsPage.Header.PageIsDisplayed(), "Header component is not displayed correctly.");
			Assert.IsTrue(aboutUsPage.TopMenu.PageIsDisplayed("AboutUs"), "Top Menu is not displayed correctly.");
			Assert.IsTrue(aboutUsPage.Breadcrumb.PageIsDisplayed("AboutUs"), "Breadcrump is not displayed correctly.");
			Assert.IsTrue(aboutUsPage.Footer.PageIsDisplayed(), "Footer is not displayed correctly.");
		}

		[When(@"I enter Contact Us page by footer link")]
		public void WhenIEnterContactUsPageByFooterLink()
		{
			new FooterComponent().NavigateToTheContactUs();
		}

		[Then(@"Contact Us page is displayed")]
		public void ThenContactUsPageIsDisplayed()
		{
			var contactUsPage = new ContactUsPage();

			Assert.IsTrue(contactUsPage.IsDisplayedCorrectly(), "Contact us page is not displayed correctly.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.ContactUsUrl), "Contact us page URL is not as expected.");
			Assert.IsTrue(contactUsPage.SidePanel.PageIsDisplayed("Default"), "Side panel is not displayed correctly.");
			Assert.IsTrue(contactUsPage.Header.PageIsDisplayed(), "Header component is not displayed correctly.");
			Assert.IsTrue(contactUsPage.TopMenu.PageIsDisplayed("Default"), "Top Menu is not displayed correctly.");
			Assert.IsTrue(contactUsPage.Breadcrumb.PageIsDisplayed("ContactUs"), "Breadcrump is not displayed correctly.");
			Assert.IsTrue(contactUsPage.Footer.PageIsDisplayed(), "Footer is not displayed correctly.");
		}

		[When(@"I enter Sign-up page by footer link")]
		public void WhenIEnterSign_UpPageByFooterLink()
		{
			new FooterComponent().NavigateToTheSignUp();
		}

		[Then(@"Sign-up page is displayed")]
		public void ThenSign_UpPageIsDisplayed()
		{
			var freeTrialStepOnePage = new FreeTrialStepOnePage();

			Assert.IsTrue(freeTrialStepOnePage.IsDisplayedCorrectly(), "Free Trial Step One page is not displayed correctly.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.FreeTrialStepOneUrl), "Free Trial Step One page URL is not as expected.");
			Assert.IsTrue(freeTrialStepOnePage.Header.LogoIsDisplayed(), "Header component is not displayed correctly.");
			Assert.IsTrue(freeTrialStepOnePage.TopMenu.PageIsDisplayed("SignUp"), "Top Menu is not displayed correctly.");
		}

		[When(@"I enter Feedback page by footer link")]
		public void WhenIEnterFeedbackPageByFooterLink()
		{
			new FooterComponent().NavigateToTheFeedback();
		}

		[Then(@"Feedback page is displayed")]
		public void ThenFeedbackPageIsDisplayed()
		{
			var feedbackPage = new FeedbackPage();

			Assert.IsTrue(feedbackPage.IsDisplayedCorrectly(), "Feedback page is not displayed.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.FeedbackUrl), "Feedback page URL is not as expected.");
			Assert.IsTrue(feedbackPage.SidePanel.PageIsDisplayed("Default"), "Side panel is not displayed.");
			Assert.IsTrue(feedbackPage.Header.PageIsDisplayed(), "Header component is not displayed.");
			Assert.IsTrue(feedbackPage.TopMenu.PageIsDisplayed("Default"), "Top Menu is not displayed.");
			Assert.IsTrue(feedbackPage.Breadcrumb.PageIsDisplayed("Feedback"), "Breadcrump is not displayed.");
			Assert.IsTrue(feedbackPage.Footer.PageIsDisplayed(), "Footer is not displayed.");
		}

		[When(@"I enter Terms and Conditions page by footer link")]
		public void WhenIEnterTermsAndConditionsPageByFooterLink()
		{
			new FooterComponent().NavigateToTheTermsAndConditions();
		}

		[Then(@"Terms and Conditions page is displayed")]
		public void ThenTermsAndConditionsPageIsDisplayed()
		{
			var termsAndConditionsPage = new TermsAndConditionsPage();

			if (!termsAndConditionsPage.IsDisplayed())
			{
				WebBrowser.SwitchToPopup();
			}

			Assert.IsTrue(termsAndConditionsPage.IsDisplayed(), "Terms and Conditions header title is not found.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.TermsAndConditionsUrl), "Terms and Conditions URL is not as expected.");
			Assert.IsTrue(termsAndConditionsPage.SidePanel.PageIsDisplayed("Default"), "Side panel is not displayed.");
			Assert.IsTrue(termsAndConditionsPage.Header.PageIsDisplayed(), "Header component is not displayed.");
			Assert.IsTrue(termsAndConditionsPage.TopMenu.PageIsDisplayed("Default"), "Top Menu is not displayed.");
			Assert.IsTrue(termsAndConditionsPage.Breadcrumb.PageIsDisplayed("Terms"), "Breadcrump is not displayed.");
			Assert.IsTrue(termsAndConditionsPage.Footer.PageIsDisplayed(), "Footer is not displayed.");
		}

		[When(@"I enter Privacy Policy page by footer link")]
		public void WhenIEnterPrivacyPolicyPageByFooterLink()
		{
			new FooterComponent().NavigateToThePrivacyPolicy();
		}

		[Then(@"Privacy Policy page is displayed")]
		public void ThenPrivacyPolicyPageIsDisplayed()
		{
			var privacyPolicyPage = new PrivacyPolicyPage();

			if (!privacyPolicyPage.IsDisplayed())
			{
				WebBrowser.SwitchToPopup();
			}

			Assert.IsTrue(privacyPolicyPage.IsDisplayed(), "Privacy Policy header title is not displayed.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.PrivacyPolicyUrl), "Privacy Policy page URL is not as expected.");
			Assert.IsTrue(privacyPolicyPage.SidePanel.PageIsDisplayed("Default"), "Side panel is not displayed.");
			Assert.IsTrue(privacyPolicyPage.Header.PageIsDisplayed(), "Header component is not displayed.");
			Assert.IsTrue(privacyPolicyPage.TopMenu.PageIsDisplayed("Default"), "Top Menu is not displayed.");
			Assert.IsTrue(privacyPolicyPage.Breadcrumb.PageIsDisplayed("Privacy"), "Breadcrump is not displayed.");
			Assert.IsTrue(privacyPolicyPage.Footer.PageIsDisplayed(), "Footer is not displayed.");
		}

		[When(@"I enter FAQs page by footer link")]
		public void WhenIEnterFAQsPageByFooterLink()
		{
			new FooterComponent().NavigateToTheFAQ();
		}

		[Then(@"FAQs page is displayed")]
		public void ThenFAQsPageIsDisplayed()
		{
			var faqPage = new FaqPage();

			Assert.IsTrue(faqPage.IsDisplayedCorrectly(), "FAQ page title is not displayed.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.FAQUrl), "FAQ page URL is not as expected.");
			Assert.IsTrue(faqPage.SidePanel.PageIsDisplayed("Default"), "Side panel is not displayed.");
			Assert.IsTrue(faqPage.Header.PageIsDisplayed(), "Header component is not displayed.");
			Assert.IsTrue(faqPage.TopMenu.PageIsDisplayed(ApplicationConfiguration.FaqTopMenuComponent), "Top Menu is not displayed.");
			Assert.IsTrue(faqPage.Breadcrumb.PageIsDisplayed("FAQ"), "Breadcrump is not displayed.");
			Assert.IsTrue(faqPage.Footer.PageIsDisplayed(), "Footer is not displayed correctly.");
		}

		[When(@"I enter Cookies page by footer link")]
		public void WhenIEnterCookiesPageByFooterLink()
		{
			new FooterComponent().NavigateToTheCookies();
		}

		[Then(@"Cookies page is displayed")]
		public void ThenCookiesPageIsDisplayed()
		{
			var cookiesPage = new CookiesPage();

			Assert.IsTrue(cookiesPage.IsDisplayedCorrectly(), "Cookies page is not displayed correctly.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.CookiesUrl), "Cookies page URL is not as expected.");
			Assert.IsTrue(cookiesPage.SidePanel.PageIsDisplayed("Default"), "Side panel is not displayed correctly.");
			Assert.IsTrue(cookiesPage.Header.PageIsDisplayed(), "Header component is not displayed correctly.");
			Assert.IsTrue(cookiesPage.TopMenu.PageIsDisplayed(ApplicationConfiguration.CookiesTopMenuComponent), "Top Menu is not displayed correctly.");
			Assert.IsTrue(cookiesPage.Breadcrumb.PageIsDisplayed("Cookies"), "Breadcrump is not displayed correctly.");
			Assert.IsTrue(cookiesPage.Footer.PageIsDisplayed(), "Footer is not displayed correctly.");
		}

		[When(@"I enter Newspaper Archive page by footer link")]
		public void WhenIEnterNewspaperArchivePageByFooterLink()
		{
			new FooterComponent().NavigateToTheNewspaperArchive();
		}

		[Then(@"Newspaper Archive page is displayed")]
		public void ThenNewspaperArchivePageIsDisplayed()
		{
			var newspaperArchive = new NewspaperArchivePage();

			Assert.IsTrue(newspaperArchive.IsDisplayedCorrectly(), "Newspaper Archive page is not displayed.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.NewspaperArchiveUrl), "Newspaper Archive page URL is not as expected.");
			Assert.IsTrue(newspaperArchive.SidePanel.PageIsDisplayed("Default"), "Side panel is not displayed.");
			Assert.IsTrue(newspaperArchive.Header.PageIsDisplayed(), "Header component is not displayed.");
			Assert.IsTrue(newspaperArchive.TopMenu.PageIsDisplayed("Default"), "Top Menu is not displayed.");
			Assert.IsTrue(newspaperArchive.Breadcrumb.PageIsDisplayed("NewspaperArchive"), "Breadcrump is not displayed.");
			Assert.IsTrue(newspaperArchive.Footer.PageIsDisplayed(), "Footer is not displayed.");
		}

		[When(@"I enter Sponsored Reports page by footer link")]
		public void WhenIEnterSponsoredReportsPageByFooterLink()
		{
			new FooterComponent().NavigateToTheSponsoredReports();
		}

		[Then(@"Sponsored Reports page is displayed")]
		public void ThenSponsoredReportsPageIsDisplayed()
		{
			var sponsoredReportsPage = new SponsoredReportsPage();

			Assert.IsTrue(sponsoredReportsPage.IsDisplayedCorrectly(), "Sponsored Reports page is not displayed.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.SponsoredReportsUrl), "Sponsored Reports page URL is not as expected.");
			Assert.IsTrue(sponsoredReportsPage.SidePanel.PageIsDisplayed("Default"), "Side panel is not displayed.");
			Assert.IsTrue(sponsoredReportsPage.Header.PageIsDisplayed(), "Header component is not displayed.");
			Assert.IsTrue(sponsoredReportsPage.TopMenu.PageIsDisplayed("Default"), "Top Menu is not displayed.");
			Assert.IsTrue(sponsoredReportsPage.Breadcrumb.PageIsDisplayed("SponsoredReports"), "Breadcrump is not displayed.");
			Assert.IsTrue(sponsoredReportsPage.Footer.PageIsDisplayed(), "Footer is not displayed.");
		}

		[When(@"I enter Economics and Policy page by footer link")]
		public void WhenIEnterEconomicsAndPolicyPageByFooterLink()
		{
			new FooterComponent().NavigateToTheEconomicsAndPolicy();
		}

		[Then(@"Economics and Policy page is displayed")]
		public void ThenEconomicsAndPolicyPageIsDisplayed()
		{
			var economicsAndPolicyPage = new EconomicsAndPolicyPage();

			Assert.IsTrue(economicsAndPolicyPage.IsDisplayedCorrectly(), "Economics and policy page is not displayed.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.EconomicsAndPolicyUrl), "Economics and policy page URL is not as expected.");
			Assert.IsTrue(economicsAndPolicyPage.SidePanel.PageIsDisplayed("Default"), "Side panel is not displayed.");
			Assert.IsTrue(economicsAndPolicyPage.Header.PageIsDisplayed(), "Header component is not displayed.");
			Assert.IsTrue(economicsAndPolicyPage.TopMenu.PageIsDisplayed("Default"), "Top Menu is not displayed.");
			Assert.IsTrue(economicsAndPolicyPage.Breadcrumb.PageIsDisplayed("EconomicsAndPolicy"), "Breadcrump is not displayed.");
			Assert.IsTrue(economicsAndPolicyPage.Footer.PageIsDisplayed(), "Footer is not displayed.");
		}

		[When(@"I enter Financial Markets page by footer link")]
		public void WhenIEnterFinancialMarketsPageByFooterLink()
		{
			new FooterComponent().NavigateToTheFinancialMarkets();
		}

		[Then(@"Financial Markets page is displayed")]
		public void ThenFinancialMarketsPageIsDisplayed()
		{
			var financialMarketsPage = new FinancialMarketsPage();

			Assert.IsTrue(financialMarketsPage.IsDisplayedCorrectly(), "Financial markets page is not displayed.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.FinancialMarketsUrl), "Financial markets page URL is not as expected.");
			Assert.IsTrue(financialMarketsPage.SidePanel.PageIsDisplayed("Default"), "Side panel is not displayed.");
			Assert.IsTrue(financialMarketsPage.Header.PageIsDisplayed(), "Header component is not displayed.");
			Assert.IsTrue(financialMarketsPage.TopMenu.PageIsDisplayed("Default"), "Top Menu is not displayed.");
			Assert.IsTrue(financialMarketsPage.Breadcrumb.PageIsDisplayed("FinancialMarkets"), "Breadcrump is not displayed.");
			Assert.IsTrue(financialMarketsPage.Footer.PageIsDisplayed(), "Footer is not displayed.");
		}

		[When(@"I enter Development page by footer link")]
		public void WhenIEnterDevelopmentPageByFooterLink()
		{
			new FooterComponent().NavigateToTheDevelopment();
		}

		[Then(@"Development page is displayed")]
		public void ThenDevelopmentPageIsDisplayed()
		{
			var developmentPage = new DevelopmentPage();

			Assert.IsTrue(developmentPage.IsDisplayedCorrectly(), "Development page is not displayed.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.DevelopmentUrl), "Development page URL is not as expected.");
			Assert.IsTrue(developmentPage.SidePanel.PageIsDisplayed("Default"), "Side panel is not displayed.");
			Assert.IsTrue(developmentPage.Header.PageIsDisplayed(), "Header component is not displayed.");
			Assert.IsTrue(developmentPage.TopMenu.PageIsDisplayed("Default"), "Top Menu is not displayed.");
			Assert.IsTrue(developmentPage.Breadcrumb.PageIsDisplayed("Development"), "Breadcrump is not displayed.");
			Assert.IsTrue(developmentPage.Footer.PageIsDisplayed(), "Footer is not displayed.");
		}

		[When(@"I enter Middle East & Africa page by footer link")]
		public void WhenIEnterMiddleEastAfricaPageByFooterLink()
		{
			new FooterComponent().NavigateToTheMiddleEastAndAfrica();
		}

		[Then(@"Middle East & Africa page is displayed")]
		public void ThenMiddleEastAfricaPageIsDisplayed()
		{
			var middleEastAndAfricaPage = new MiddleEastAndAfricaPage();

			Assert.IsTrue(middleEastAndAfricaPage.IsDisplayedCorrectly(), "Middle East & Africa page is not displayed.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.MiddleEastAndAfricaUrl), "Middle East & Africa page URL is not as expected.");
			Assert.IsTrue(middleEastAndAfricaPage.SidePanel.PageIsDisplayed("Article"), "Side panel is not displayed.");
			Assert.IsTrue(middleEastAndAfricaPage.Header.PageIsDisplayed(), "Header component is not displayed.");
			Assert.IsTrue(middleEastAndAfricaPage.TopMenu.PageIsDisplayed("Default"), "Top Menu is not displayed.");
			Assert.IsTrue(middleEastAndAfricaPage.Breadcrumb.PageIsDisplayed("MiddleEastAndAfrica"), "Breadcrump is not displayed.");
			Assert.IsTrue(middleEastAndAfricaPage.Footer.PageIsDisplayed(), "Footer is not displayed.");
		}

		[When(@"I enter Americas page by footer link")]
		public void WhenIEnterAmericasPageByFooterLink()
		{
			new FooterComponent().NavigateToTheAmericas();
		}

		[Then(@"Americas page is displayed")]
		public void ThenAmericasPageIsDisplayed()
		{
			var americasPage = new AmericasPage();

			Assert.IsTrue(americasPage.IsDisplayedCorrectly(), "Americas page is not displayed correctly.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.AmericasUrl), "Americas page URL is not as expected.");
			Assert.IsTrue(americasPage.SidePanel.PageIsDisplayed("Default"), "Side panel is not displayed.");
			Assert.IsTrue(americasPage.Header.PageIsDisplayed(), "Header component is not displayed correctly.");
			Assert.IsTrue(americasPage.TopMenu.PageIsDisplayed("Default"), "Top Menu is not displayed correctly.");
			Assert.IsTrue(americasPage.Breadcrumb.PageIsDisplayed("Americas"), "Breadcrump is not displayed correctly.");
			Assert.IsTrue(americasPage.Footer.PageIsDisplayed(), "Footer is not displayed correctly.");
		}

		[When(@"I enter Asia page by footer link")]
		public void WhenIEnterAsiaPageByFooterLink()
		{
			new FooterComponent().NavigateToTheAsia();
		}

		[Then(@"Asia page is displayed")]
		public void ThenAsiaPageIsDisplayed()
		{
			var asiaPage = new AsiaPage();

			Assert.IsTrue(asiaPage.IsDisplayedCorrectly(), "Asia page is not displayed.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.AsiaUrl), "Asia page URL is not as expected.");
			Assert.IsTrue(asiaPage.SidePanel.PageIsDisplayed("Default"), "Side panel is not displayed.");
			Assert.IsTrue(asiaPage.Header.PageIsDisplayed(), "Header component is not displayed.");
			Assert.IsTrue(asiaPage.TopMenu.PageIsDisplayed("Default"), "Top Menu is not displayed.");
			Assert.IsTrue(asiaPage.Breadcrumb.PageIsDisplayed("Asia"), "Breadcrump is not displayed.");
			Assert.IsTrue(asiaPage.Footer.PageIsDisplayed(), "Footer is not displayed.");
		}

		[When(@"I enter Europe page by footer link")]
		public void WhenIEnterEuropePageByFooterLink()
		{
			new FooterComponent().NavigateToTheEurope();
		}

		[Then(@"Europe page is displayed")]
		public void ThenEuropePageIsDisplayed()
		{
			var europePage = new EuropePage();

			Assert.IsTrue(europePage.IsDisplayedCorrectly(), "Europe page is not displayed.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.EuropeUrl), "Europe page URL is not as expected.");
			Assert.IsTrue(europePage.SidePanel.PageIsDisplayed("Default"), "Side panel is not displayed.");
			Assert.IsTrue(europePage.Header.PageIsDisplayed(), "Header component is not displayed.");
			Assert.IsTrue(europePage.TopMenu.PageIsDisplayed("Default"), "Top Menu is not displayed.");
			Assert.IsTrue(europePage.Breadcrumb.PageIsDisplayed("EmergingEurope"), "Breadcrump is not displayed.");
			Assert.IsTrue(europePage.Footer.PageIsDisplayed(), "Footer is not displayed.");
		}

		[When(@"I enter Polls And Awards page by footer link")]
		public void WhenIEnterPollsAndAwardsPageByFooterLink()
		{
			new FooterComponent().NavigateToThePollsAndAwards();
		}

		[Then(@"Polls And Awards page is displayed")]
		public void ThenPollsAndAwardsPageIsDisplayed()
		{
			var pollsAndAwardsPage = new PollsAndAwardsPage();

			Assert.IsTrue(pollsAndAwardsPage.IsDisplayedCorrectly(), "Polls And Awards page is not displayed.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.PollsAndAwardsUrl), "Polls And Awards page URL is not as expected.");
			Assert.IsTrue(pollsAndAwardsPage.SidePanel.PageIsDisplayed("Default"), "Side panel is not displayed.");
			Assert.IsTrue(pollsAndAwardsPage.Header.PageIsDisplayed(), "Header component is not displayed.");
			Assert.IsTrue(pollsAndAwardsPage.TopMenu.PageIsDisplayed("Default"), "Top Menu is not displayed.");
			Assert.IsTrue(pollsAndAwardsPage.Breadcrumb.PageIsDisplayed("PollsAndAwards"), "Breadcrump is not displayed.");
			Assert.IsTrue(pollsAndAwardsPage.Footer.PageIsDisplayed(), "Footer is not displayed.");
		}

		[When(@"I enter Events page by footer link")]
		public void WhenIEnterEventsPageByFooterLink()
		{
			new FooterComponent().NavigateToTheEvents();
		}

		[Then(@"Events page is displayed")]
		public void ThenEventsPageIsDisplayed()
		{
			var eventsPage = new EventsPage();

			Assert.IsTrue(eventsPage.IsDisplayedCorrectly(), "Events page is not displayed.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.EventsUrl), "Events page URL is not as expected.");
			Assert.IsTrue(eventsPage.SidePanel.PageIsDisplayed("Default"), "Side panel is not displayed.");
			Assert.IsTrue(eventsPage.Header.PageIsDisplayed(), "Header component is not displayed.");
			Assert.IsTrue(eventsPage.TopMenu.PageIsDisplayed("Events"), "Top Menu is not displayed.");
			Assert.IsTrue(eventsPage.Breadcrumb.PageIsDisplayed("Events"), "Breadcrump is not displayed.");
			Assert.IsTrue(eventsPage.Footer.PageIsDisplayed(), "Footer is not displayed.");
		}

		[When(@"I enter Comment And Opinion page by footer link")]
		public void WhenIEnterCommentAndOpinionPageByFooterLink()
		{
			new FooterComponent().NavigateToTheCommentAndOpinion();
		}

		[Then(@"Comment And Opinion page is displayed")]
		public void ThenCommentAndOpinionPageIsDisplayed()
		{
			var commentAndOpinionPage = new CommentAndOpinionPage();

			Assert.IsTrue(commentAndOpinionPage.IsDisplayedCorrectly(), "Comment And Opinion page is not displayed.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.CommentAndOpinionUrl), "Comment And Opinion page URL is not as expected.");
			Assert.IsTrue(commentAndOpinionPage.SidePanel.PageIsDisplayed("Default"), "Side panel is not displayed.");
			Assert.IsTrue(commentAndOpinionPage.Header.PageIsDisplayed(), "Header component is not displayed.");
			Assert.IsTrue(commentAndOpinionPage.TopMenu.PageIsDisplayed("Default"), "Top Menu is not displayed.");
			Assert.IsTrue(commentAndOpinionPage.Breadcrumb.PageIsDisplayed("CommentAndOpinion"), "Breadcrump is not displayed.");
			Assert.IsTrue(commentAndOpinionPage.Footer.PageIsDisplayed(), "Footer is not displayed.");
		}

		[When(@"I enter Features page by footer link")]
		public void WhenIEnterFeaturesPageByFooterLink()
		{
			new FooterComponent().NavigateToTheFeatures();
		}

		[Then(@"Features page is displayed")]
		public void ThenFeaturesPageIsDisplayed()
		{
			var featuresPage = new FeaturesPage();

			Assert.IsTrue(featuresPage.IsDisplayedCorrectly(), "Features page is not displayed.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.FeaturesUrl), "Features page URL is not as expected.");
			Assert.IsTrue(featuresPage.SidePanel.PageIsDisplayed("Default"), "Side panel is not displayed.");
			Assert.IsTrue(featuresPage.Header.PageIsDisplayed(), "Header component is not displayed.");
			Assert.IsTrue(featuresPage.TopMenu.PageIsDisplayed("Default"), "Top Menu is not displayed.");
			Assert.IsTrue(featuresPage.Breadcrumb.PageIsDisplayed("Features"), "Breadcrump is not displayed.");
			Assert.IsTrue(featuresPage.Footer.PageIsDisplayed(), "Footer is not displayed.");
		}

		[When(@"I enter News page by footer link")]
		public void WhenIEnterNewsPageByFooterLink()
		{
			new FooterComponent().NavigateToTheNews();
		}

		[Then(@"News page is displayed")]
		public void ThenNewsPageIsDisplayed()
		{
			var newsPage = new NewsPage();

			Assert.IsTrue(newsPage.IsDisplayedCorrectly(), "News page is not displayed.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.NewsUrl), "News page URL is not as expected.");
			Assert.IsTrue(newsPage.SidePanel.PageIsDisplayed("Default"), "Side panel is not displayed.");
			Assert.IsTrue(newsPage.Header.PageIsDisplayed(), "Header component is not displayed.");
			Assert.IsTrue(newsPage.TopMenu.PageIsDisplayed("Default"), "Top Menu is not displayed.");
			Assert.IsTrue(newsPage.Breadcrumb.PageIsDisplayed("News"), "Breadcrump is not displayed.");
			Assert.IsTrue(newsPage.Footer.PageIsDisplayed(), "Footer is not displayed.");
		}

		[When(@"I enter Research page by footer link")]
		public void WhenIEnterResearchPageByFooterLink()
		{
			new FooterComponent().NavigateToTheResearch();
		}

		[Then(@"Research page is displayed")]
		public void ThenResearchPageIsDisplayed()
		{
			var researchPage = new ResearchPage();

			Assert.IsTrue(researchPage.IsDisplayedCorrectly(), "Research page is not displayed.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.ResearchUrl), "Research page URL is not as expected.");
			Assert.IsTrue(researchPage.SidePanel.PageIsDisplayed("Default"), "Side panel is not displayed.");
			Assert.IsTrue(researchPage.Header.PageIsDisplayed(), "Header component is not displayed.");
			Assert.IsTrue(researchPage.TopMenu.PageIsDisplayed("Default"), "Top Menu is not displayed.");
			Assert.IsTrue(researchPage.Breadcrumb.PageIsDisplayed("Research"), "Breadcrump is not displayed.");
			Assert.IsTrue(researchPage.Footer.PageIsDisplayed(), "Footer is not displayed.");
		}

		[When(@"I enter EM View page by footer link")]
		public void WhenIEnterEMViewPageByFooterLink()
		{
			new FooterComponent().NavigateToTheEMView();
		}

		[Then(@"EM View page is displayed")]
		public void ThenEMViewPageIsDisplayed()
		{
			var emViewPage = new EMViewPage();

			Assert.IsTrue(emViewPage.IsDisplayedCorrectly(), "EM View page is not displayed.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.EMViewUrl), "EM View page URL is not as expected.");
			Assert.IsTrue(emViewPage.SidePanel.PageIsDisplayed("Default"), "Side panel is not displayed.");
			Assert.IsTrue(emViewPage.Header.PageIsDisplayed(), "Header component is not displayed.");
			Assert.IsTrue(emViewPage.TopMenu.PageIsDisplayed("Default"), "Top Menu is not displayed.");
			Assert.IsTrue(emViewPage.Breadcrumb.PageIsDisplayed("EMView"), "Breadcrump is not displayed.");
			Assert.IsTrue(emViewPage.Footer.PageIsDisplayed(), "Footer is not displayed.");
		}

		[When(@"I enter RSS page by footer link")]
		public void WhenIEnterRSSPageByFooterLink()
		{
			new FooterComponent().NavigateToTheRSS();
		}

		[Then(@"RSS page is displayed")]
		public void ThenRSSPageIsDisplayed()
		{
			var rssPage = new RSSPage();

			Assert.IsTrue(rssPage.IsDisplayed(), "RSS page is not displayed correctly.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.RSSUrl), "RSS page URL is not as expected.");
			Assert.IsTrue(rssPage.SidePanel.PageIsDisplayed("Default"), "Side panel is not displayed corectly.");
			Assert.IsTrue(rssPage.Header.PageIsDisplayed(), "Header component is not displayed corectly.");
			Assert.IsTrue(rssPage.TopMenu.PageIsDisplayed("Default"), "Top Menu is not displayed corectly.");
			Assert.IsTrue(rssPage.Breadcrumb.PageIsDisplayed("RSSFeeds"), "Breadcrump is not displayed corectly.");
			Assert.IsTrue(rssPage.Footer.PageIsDisplayed(), "Footer is not displayed corectly.");
		}

		[When(@"I enter Subscribe page by footer link")]
		public void WhenIEnterSubscribePageByFooterLink()
		{
			new FooterComponent().NavigateToTheSubscribePage();
		}

		[Then(@"Subscribe page is displayed")]
		public void ThenSubscribePageIsDisplayed()
		{
			var subscribeStepOnePage = new SubscribeStepOnePage();

			Assert.IsTrue(subscribeStepOnePage.IsDisplayedCorrectly(), "Subscribe step one page is not displayed.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.SubscribeStepOneUrl), "Subscribe Step One page URL is not as expected.");
		}

		[Then(@"NBO Subscribe page is displayed")]
		public void ThenNBOSubscribePageIsDisplayed()
		{
			var subscribeNBOCheckoutStepOnePage = new SubscribeNBOCheckoutStepOnePage();

			Assert.IsTrue(subscribeNBOCheckoutStepOnePage.IsDisplayedCorrectly(), "Subscribe step one page is not displayed.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.SubscribeStepOneUrl), "Subscribe Step One page URL is not as expected.");
		}
	}
}