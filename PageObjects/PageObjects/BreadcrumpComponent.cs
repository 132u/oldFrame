using System;
using Core;

namespace PageObjects.PageObjects
{
	public partial class BreadcrumbComponent : PageBase
	{
		public override bool PageIsVisible(string parameter = default(string))
		{
			if (parameter == "AboutUs")
			{
				return this.CompareLists(this.AboutUsBreadcrumb);
			}
			else if (parameter == "ContactUs")
			{
				return this.CompareLists(this.ContactUsBreadcrumb);
			}
			else if (parameter == "Feedback")
			{
				return this.CompareLists(this.FeedbackBreadcrumb);
			}
			else if (parameter == "Terms")
			{
				return this.CompareLists(this.TermsBreadcrumb);
			}
			else if (parameter == "Privacy")
			{
				return this.CompareLists(this.PrivacyBreadcrumb);
			}
			else if (parameter == "FAQ")
			{
				return this.CompareLists(this.FAQBreadcrumb);
			}
			else if (parameter == "Cookies")
			{
				return this.CompareLists(this.CookiesBreadcrumb);
			}
			else if (parameter == "NewspaperArchive")
			{
				return this.CompareLists(this.NewspaperArchiveBreadcrumb);
			}
			else if (parameter == "SponsoredReports")
			{
				return this.CompareLists(this.SponsoredReportsBreadcrumb);
			}
			else if (parameter == "EconomicsAndPolicy")
			{
				return this.CompareLists(this.EconomicsAndPolicyBreadcrumb);
			}
			else if (parameter == "FinancialMarkets")
			{
				return this.CompareLists(this.FinancialMarketsBreadcrumb);
			}
			else if (parameter == "Development")
			{
				return this.CompareLists(this.DevelopmentBreadcrumb);
			}
			else if (parameter == "MiddleEastAndAfrica")
			{
				return this.CompareLists(this.MiddleEastAndAfricaBreadcrumb);
			}
			else if (parameter == "Americas")
			{
				return this.CompareLists(this.AmericasBreadcrumb);
			}
			else if (parameter == "Asia")
			{
				return this.CompareLists(this.AsiaBreadcrumb);
			}
			else if (parameter == "EmergingEurope")
			{
				return this.CompareLists(this.EmergingEuropeBreadcrumb);
			}
			else if (parameter == "PollsAndAwards")
			{
				return this.CompareLists(this.PollsAndAwardsBreadcrumb);
			}
			else if (parameter == "Events")
			{
				return this.CompareLists(this.EventsBreadcrumb);
			}
			else if (parameter == "CommentAndOpinion")
			{
				return this.CompareLists(this.CommentAndOpinionBreadcrumb);
			}
			else if (parameter == "Features")
			{
				return this.CompareLists(this.FeaturesBreadcrumb);
			}
			else if (parameter == "News")
			{
				return this.CompareLists(this.NewsBreadcrumb);
			}
			else if (parameter == "Research")
			{
				return this.CompareLists(this.ResearchBreadcrumb);
			}
			else if (parameter == "EMView")
			{
				return this.CompareLists(this.EMViewBreadcrumb);
			}
			else if (parameter == "RSSFeeds")
			{
				return this.CompareLists(this.RSSFeedsBreadcrumb);
			}
			else if (parameter == "Login")
			{
				return this.CompareLists(this.LoginBreadcrumb);
			}
			else if (parameter == "Analysis")
			{
				return this.CompareLists(this.AnalysisBreadcrumb);
			}
			else if (parameter == "Regions")
			{
				return this.CompareLists(this.RegionsBreadcrumb);
			}
			else if (parameter == "Video")
			{
				return this.CompareLists(this.VideoBreadcrumb);
			}
			else if (parameter == "Global")
			{
				return this.CompareLists(this.GlobalBreadcrumb);
			}
			else if (parameter == "MyAccount")
			{
				return this.CompareLists(this.MyAccountBreadcrumb);
			}
			else if (parameter == "ChangePassword")
			{
				return this.CompareLists(this.MyAccountChangePasswordBreadcrumb);
			}
			else if (parameter == "PasswordUpdated")
			{
				return this.CompareLists(this.MyAccountPasswordUpdatedBreadcrumb);
			}
			else if (parameter == "NewsletterPreferences")
			{
				return this.CompareLists(this.MyAccountNewsletterPreferencesBreadcrumb);
			}
			else if (parameter == "MyClippings")
			{
				return this.CompareLists(this.MyAccountMyClippingsBreadcrumb);
			}
			else
			{
				throw new ArgumentException("There is no breadcrumb as provided in parameter");
			}
		}
	}
}
