using Core;

namespace PageObjects.PageObjects
{
	public partial class FooterComponent : PageBase
	{
		public override bool PageIsVisible(string parameter = default(string))
		{
			return this.CompareLists(this.FooterComponentRequiredElements);
		}

		/// <summary>
		/// Check if copyright component is displayed.
		/// </summary>
		/// <returns>Returns true if copyright component is displayed.</returns>
		public bool CopyrightIsDisplayed()
		{
			return this.Copyright.IsFound;
		}

		/// <summary>
		/// Navigates to the About Us page.
		/// </summary>
		/// <returns>Returns new instance of the AboutUsPage class.</returns>
		public AboutUsPage NavigateToTheAboutUs()
		{
			this.AboutUs.Click();

			return new AboutUsPage();
		}

		/// <summary>
		/// Navigates to the Contact us page.
		/// </summary>
		/// <returns>Returns new instance of the ContactUsPage class.</returns>
		public ContactUsPage NavigateToTheContactUs()
		{
			this.ContactUs.Click();

			return new ContactUsPage();
		}

		/// <summary>
		/// Navigates to the Sign Up page.
		/// </summary>
		/// <returns>Returns new instance of the FreeTrialStepOnePage class.</returns>
		public FreeTrialStepOnePage NavigateToTheSignUp()
		{
			this.SignUp.Click();

			return new FreeTrialStepOnePage();
		}

		/// <summary>
		/// Navigates to the Subscribe page.
		/// </summary>
		/// <returns>Returns new instance of the SubscribeStepOnePage class.</returns>
		public SubscribeStepOnePage NavigateToTheSubscribePage()
		{
			this.Subscribe.Click();

			return new SubscribeStepOnePage();
		}

		/// <summary>
		/// Navigates to the Subscribe page.
		/// </summary>
		/// <returns>Returns new instance of the SubscribeNBOCheckoutStepOnePage class.</returns>
		public SubscribeNBOCheckoutStepOnePage NavigateToTheNBOSubscribePage()
		{
			this.Subscribe.Click();

			return new SubscribeNBOCheckoutStepOnePage();
		}

		/// <summary>
		/// Navigates to the Feedback page.
		/// </summary>
		/// <returns>Returns new instance of the FeedbackPage class.</returns>
		public FeedbackPage NavigateToTheFeedback()
		{
			this.Feedback.Click();

			return new FeedbackPage();
		}

		/// <summary>
		/// Navigates to the Terms And Conditions page.
		/// </summary>
		/// <returns>Returns new instance of the TermsAndConditionsPage class.</returns>
		public TermsAndConditionsPage NavigateToTheTermsAndConditions()
		{
			this.TermsAndConditions.Click();

			return new TermsAndConditionsPage();
		}

		/// <summary>
		/// Navigates to the Privacy Policy page.
		/// </summary>
		/// <returns>Returns new instance of the PrivacyPolicyPage class.</returns>
		public PrivacyPolicyPage NavigateToThePrivacyPolicy()
		{
			this.PrivacyPolicy.Click();

			return new PrivacyPolicyPage();
		}

		/// <summary>
		/// Navigates to the FAQ page.
		/// </summary>
		/// <returns>Returns new instance of the FAQPage class.</returns>
		public FaqPage NavigateToTheFAQ()
		{
			this.FAQ.Click();

			return new FaqPage();
		}

		/// <summary>
		/// Navigates to the Cookies page.
		/// </summary>
		/// <returns>Returns new instance of the CookiesPage class.</returns>
		public CookiesPage NavigateToTheCookies()
		{
			this.Cookies.Click();

			return new CookiesPage();
		}

		/// <summary>
		/// Navigates to the Newspaper Archive page.
		/// </summary>
		/// <returns>Returns new instance of the NewspaperArchivePage class.</returns>
		public NewspaperArchivePage NavigateToTheNewspaperArchive()
		{
			this.NewspaperArchive.Click();

			return new NewspaperArchivePage();
		}

		/// <summary>
		/// Navigates to the Sponsored Reports page.
		/// </summary>
		/// <returns>Returns new instance of the SponsoredReportsPage class.</returns>
		public SponsoredReportsPage NavigateToTheSponsoredReports()
		{
			this.SponsoredReports.Click();

			return new SponsoredReportsPage();
		}

		/// <summary>
		/// Navigates to the Economics And Policy page.
		/// </summary>
		/// <returns>Returns new instance of the EconomicsAndPolicyPage class.</returns>
		public EconomicsAndPolicyPage NavigateToTheEconomicsAndPolicy()
		{
			this.EconomicsPolicy.Click();

			return new EconomicsAndPolicyPage();
		}

		/// <summary>
		/// Navigates to the Financial Markets page.
		/// </summary>
		/// <returns>Returns new instance of the FinancialMarketsPage class.</returns>
		public FinancialMarketsPage NavigateToTheFinancialMarkets()
		{
			this.FinancialMarkets.Click();

			return new FinancialMarketsPage();
		}

		/// <summary>
		/// Navigates to the Development page.
		/// </summary>
		/// <returns>Returns new instance of the DevelopmentPage class.</returns>
		public DevelopmentPage NavigateToTheDevelopment()
		{
			this.Development.Click();

			return new DevelopmentPage();
		}

		/// <summary>
		/// Navigates to the Middle East And Africa page.
		/// </summary>
		/// <returns>Returns new instance of the MiddleEastAndAfricaPage class.</returns>
		public MiddleEastAndAfricaPage NavigateToTheMiddleEastAndAfrica()
		{
			this.MiddleEastAfrica.Click();

			return new MiddleEastAndAfricaPage();
		}

		/// <summary>
		/// Navigates to the Americas page.
		/// </summary>
		/// <returns>Returns new instance of the Americas class.</returns>
		public AmericasPage NavigateToTheAmericas()
		{
			this.Americas.Click();

			return new AmericasPage();
		}

		/// <summary>
		/// Navigates to the Asia page.
		/// </summary>
		/// <returns>Returns new instance of the Asia class.</returns>
		public AsiaPage NavigateToTheAsia()
		{
			this.Asia.Click();

			return new AsiaPage();
		}

		/// <summary>
		/// Navigates to the Europe page.
		/// </summary>
		/// <returns>Returns new instance of the Europe class.</returns>
		public EuropePage NavigateToTheEurope()
		{
			this.Europe.Click();

			return new EuropePage();
		}

		/// <summary>
		/// Navigates to the Polls And Awards page.
		/// </summary>
		/// <returns>Returns new instance of the PollsAndAwards class.</returns>
		public PollsAndAwardsPage NavigateToThePollsAndAwards()
		{
			this.PollsAndAwards.Click();

			return new PollsAndAwardsPage();
		}

		/// <summary>
		/// Navigates to the Events page.
		/// </summary>
		/// <returns>Returns new instance of the Events class.</returns>
		public EventsPage NavigateToTheEvents()
		{
			this.Events.Click();

			return new EventsPage();
		}

		/// <summary>
		/// Navigates to the Comment And Opinion page.
		/// </summary>
		/// <returns>Returns new instance of the CommentAndOpinion class.</returns>
		public CommentAndOpinionPage NavigateToTheCommentAndOpinion()
		{
			this.CommentAndOpinion.Click();

			return new CommentAndOpinionPage();
		}

		/// <summary>
		/// Navigates to the Features page.
		/// </summary>
		/// <returns>Returns new instance of the FeaturesPage class.</returns>
		public FeaturesPage NavigateToTheFeatures()
		{
			this.Features.Click();

			return new FeaturesPage();
		}

		/// <summary>
		/// Navigates to the News page.
		/// </summary>
		/// <returns>Returns new instance of the NewsPage class.</returns>
		public NewsPage NavigateToTheNews()
		{
			this.News.Click();

			return new NewsPage();
		}

		/// <summary>
		/// Navigates to the Research page.
		/// </summary>
		/// <returns>Returns new instance of the ResearchPage class.</returns>
		public ResearchPage NavigateToTheResearch()
		{
			this.Research.Click();

			return new ResearchPage();
		}

		/// <summary>
		/// Navigates to the EM View page.
		/// </summary>
		/// <returns>Returns new instance of the EMViewPage class.</returns>
		public EMViewPage NavigateToTheEMView()
		{
			this.EMView.Click();

			return new EMViewPage();
		}

		/// <summary>
		/// Navigates to the RSS Page page.
		/// </summary>
		/// <returns>Returns new instance of the RSSPage class.</returns>
		public RSSPage NavigateToTheRSS()
		{
			this.RSS.Click();

			return new RSSPage();
		}
	}
}
