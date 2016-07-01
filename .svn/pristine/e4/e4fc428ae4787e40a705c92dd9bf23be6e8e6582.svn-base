using System;
using Core;
using Core.Controls;

namespace PageObjects.PageObjects
{
	public partial class TopMenuComponent : PageBase
	{
		public override bool PageIsVisible(string parameter = default(string))
		{
			if (parameter == "Default" || string.IsNullOrEmpty(parameter))
			{
				return this.CompareLists(this.TopMenuDefaultComponentRequiredElements);
			}
			else if (parameter == "AboutUs")
			{
				return this.CompareLists(this.TopMenuAboutUsComponentRequiredElements);
			}
			else if (parameter == "Events")
			{
				return this.CompareLists(this.TopMenuEventsComponentRequiredElements);
			}
			else if (parameter == "SignUp")
			{
				return this.CompareLists(this.SignUpTopMenuComponentRequiredElements);
			}
			else if (parameter == "Cookies")
			{
				return this.CompareLists(this.TopMenuCookiesComponentRequiredElements);
			}
			else
			{
				throw new ArgumentException("There is no top menu as provided in parameter");
			}
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
		/// Navigates to the EM View page.
		/// </summary>
		/// <returns>Returns new instance of the EMViewPage class.</returns>
		public EMViewPage NavigateToTheEMView()
		{
			this.EMView.Click();

			return new EMViewPage();
		}

		/// <summary>
		/// Navigates to the Analysis page.
		/// </summary>
		/// <returns>Returns new instance of the AnalysisPage class.</returns>
		public AnalysisPage NavigateToTheAnalysis()
		{
			this.Analysis.Click();

			return new AnalysisPage();
		}

		/// <summary>
		/// Navigates to the Comment and Opinion page.
		/// </summary>
		/// <returns>Returns new instance of the CommentAndOpinionPage class.</returns>
		public CommentAndOpinionPage NavigateToTheCommentAndOpinion()
		{
			this.Analysis.Hover();
			this.CommentsAndOpinions.Click();

			return new CommentAndOpinionPage();
		}

		/// <summary>
		/// Navigates to the Features page.
		/// </summary>
		/// <returns>Returns new instance of the FeaturesPage class.</returns>
		public FeaturesPage NavigateToTheFeatures()
		{
			this.Analysis.Hover();
			this.Features.Click();

			return new FeaturesPage();
		}

		/// <summary>
		/// Navigates to the Regions page.
		/// </summary>
		/// <returns>Returns new instance of the RegionsPage class.</returns>
		public RegionsPage NavigateToTheRegions()
		{
			this.Regions.Click();

			return new RegionsPage();
		}

		/// <summary>
		/// Navigates to the Americas page.
		/// </summary>
		/// <returns>Returns new instance of the AmericasPage class.</returns>
		public AmericasPage NavigateToTheAmericas()
		{
			this.Regions.Hover();
			this.Americas.Click();

			return new AmericasPage();
		}

		/// <summary>
		/// Navigates to the Asia page.
		/// </summary>
		/// <returns>Returns new instance of the AsiaPage class.</returns>
		public AsiaPage NavigateToTheAsia()
		{
			this.Regions.Hover();
			this.Asia.Click();

			return new AsiaPage();
		}

		/// <summary>
		/// Navigates to the Emerging Europe page.
		/// </summary>
		/// <returns>Returns new instance of the EuropePage class.</returns>
		public EuropePage NavigateToTheEmergingEurope()
		{
			this.Regions.Hover();
			this.EmergingEurope.Click();

			return new EuropePage();
		}

		/// <summary>
		/// Navigates to the Global page.
		/// </summary>
		/// <returns>Returns new instance of the GlobalPage class.</returns>
		public GlobalPage NavigateToTheEmergingGlobal()
		{
			this.Regions.Hover();
			this.Global.Click();

			return new GlobalPage();
		}

		/// <summary>
		/// Navigates to the Middle East and Africa page.
		/// </summary>
		/// <returns>Returns new instance of the MiddleEastAndAfricaPage class.</returns>
		public MiddleEastAndAfricaPage NavigateToTheEmergingMiddleEastAndAfrica()
		{
			this.Regions.Hover();
			this.MiddleEastAndAfrica.Click();

			return new MiddleEastAndAfricaPage();
		}

		/// <summary>
		/// Navigates to the Economics and Policy page.
		/// </summary>
		/// <returns>Returns new instance of the EconomicsAndPolicyPage class.</returns>
		public EconomicsAndPolicyPage NavigateToTheEconomicsAndPolicy()
		{
			this.EconomicsAndPolicy.Click();

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
		/// Navigates to the Polls and Awards page.
		/// </summary>
		/// <returns>Returns new instance of the PollsAndAwardsPage class.</returns>
		public PollsAndAwardsPage NavigateToThePollsAndAwards()
		{
			this.PollsAndAwards.Click();

			return new PollsAndAwardsPage();
		}

		/// <summary>
		/// Navigates to the Events page.
		/// </summary>
		/// <returns>Returns new instance of the EventsPage class.</returns>
		public EventsPage NavigateToTheEvents()
		{
			this.Events.Click();

			return new EventsPage();
		}

		/// <summary>
		/// Navigates to the Video page.
		/// </summary>
		/// <returns>Returns new instance of the VideoPage class.</returns>
		public VideoPage NavigateToTheVideo()
		{
			this.Video.Click();

			return new VideoPage();
		}

		public SectorsPage NavigateToTheSectorsPage()
		{
			this.Sectors.Click();

			return new SectorsPage();
		}

		public InterviewsPage NavigateToTheInterviewsPage()
		{
			this.Interviews.Click();

			return new InterviewsPage();
		}

		public CFOsPage NavigateToTheCFOsPage()
		{
			this.CFOs.Click();

			return new CFOsPage();
		}

		public CMOsPage NavigateToTheCMOsPage()
		{
			this.CMOs.Click();

			return new CMOsPage();
		}

		public GTBTVPage NavigateToTheGTBTV()
		{
			this.GTBTV.Click();

			return new GTBTVPage();
		}

		public AboutUsPage NavigateToTheAboutUsPage()
		{
			this.AboutUs.Click();

			return new AboutUsPage();
		}

		public MyAccountPage NavigateToTheMyAccountPage()
		{
			this.MyAccount.Click();

			return new MyAccountPage();
		}
	}
}
