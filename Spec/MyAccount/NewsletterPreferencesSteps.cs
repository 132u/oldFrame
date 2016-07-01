using Core;
using Core.Configuration;
using NUnit.Framework;
using PageObjects.PageObjects;
using TechTalk.SpecFlow;

namespace Spec
{
	[Binding]
	public class NewsletterPreferencesSteps
	{
		[Given(@"I'm on the Newsletter Preferences page")]
		public void GivenIMOnTheNewsletterPreferencesPage()
		{
			var homePage = new HeaderComponent()
					.NavigateToTheLoginPage()
					.LoginToTheUserAccountSuccessfully(ApplicationConfiguration.ExistingUserName, ApplicationConfiguration.ExistingUserPassword, false)
					.Header
					.NavigateToTheMyAccount()
					.NavigateToTheEmailPreferences();
		}

		[Then(@"Update successful message should be displayed")]
		public void ThenUpdateSuccessfulMessageShouldBeDisplayed()
		{
			Assert.IsTrue(new NewsletterPreferencesPage().IsUpdateConfirmationMessageDisplayed(), "Settings updated message is not displayed.");
		}

		[When(@"I go back to newsletter preferences")]
		public void WhenIGoBackToNewsletterPreferences()
		{
			new NewsletterPreferencesPage()
				.Header
				.NavigateToTheMyAccount()
				.NavigateToTheEmailPreferences();
		}

		[When(@"I sign up for News Alerts Newsletter")]
		public void WhenISignUpForNewsAlertsNewsletter()
		{
			new NewsletterPreferencesPage()
				.SignUpForEmergingMarketsNewsAlerts();
		}

		[Then(@"Newsletter sign up is saved")]
		public void ThenNewsletterSignUpIsSaved()
		{
			Assert.IsTrue(new NewsletterPreferencesPage().NewsletterPreferences.IsEmergingMarketsNewsletterSubscribed(), "Emerging markets news alerts is not subscribed.");
		}

		[When(@"I sign out from News Alerts Newsletter")]
		public void WhenISignOutFromNewsAlertsNewsletter()
		{
			new NewsletterPreferencesPage().SignOutFromEmergingMarketsNewsAlerts();
		}

		[Then(@"Newsletter sign out is saved")]
		public void ThenNewsletterSignOutIsSaved()
		{
			Assert.IsFalse(new NewsletterPreferencesPage().NewsletterPreferences.IsEmergingMarketsNewsletterSubscribed(), "Emerging markets news alerts is not subscribed.");
			Assert.IsTrue(new NewsletterPreferencesPage().IsUpdateConfirmationMessageDisplayed(), "Settings updated message is not displayed.");
		}

		[When(@"I choose Html version of email format and save")]
		public void WhenIChooseHtmlVersionOfEmailFormatAndSave()
		{
			NewsletterPreferencesPage newsletterPreferencesPage = new NewsletterPreferencesPage();
			newsletterPreferencesPage.NewsletterPreferences.SetEmailFormatToHtml();
			newsletterPreferencesPage.SavePreferences();
		}

		[Then(@"Html version of email format is saved")]
		public void ThenHtmlVersionOfEmailFormatIsSaved()
		{
			Assert.IsTrue(new NewsletterPreferencesPage().IsUpdateConfirmationMessageDisplayed(), "Settings updated message is not displayed.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.NewsletterPreferencesUrl), "Newsletter preferences url is different than expected.");
			Assert.IsTrue(new NewsletterPreferencesPage().NewsletterPreferences.IsEmailFormatHtml(), "Html format is not saved");
		}

		[When(@"I choose Text version of email format and save")]
		public void WhenIChooseTextVersionOfEmailFormat()
		{
			NewsletterPreferencesPage newsletterPreferencesPage = new NewsletterPreferencesPage();
			newsletterPreferencesPage.NewsletterPreferences.SetEmailFormatToText();
			newsletterPreferencesPage.SavePreferences();
		}

		[Then(@"Text version of email format is saved")]
		public void ThenTextVersionOfEmailFormatIsSaved()
		{
			Assert.IsTrue(new NewsletterPreferencesPage().IsUpdateConfirmationMessageDisplayed(), "Settings updated message is not displayed.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.NewsletterPreferencesUrl), "Newsletter preferences url is different than expected.");
			Assert.IsFalse(new NewsletterPreferencesPage().NewsletterPreferences.IsEmailFormatHtml(), "Text format is not saved.");
		}

		[When(@"I sign up for Petroleum Economist Monthly Magazine Update Newsletter")]
		public void WhenISignUpForPetroleumEconomistMonthlyMagazineUpdateNewsletter()
		{
			// TODO: when bug which moves to previous page is fixed sigh out from all pe newsletters should move to another page manually to ensure that customer is really signed out.
			new NewsletterPreferencesPage().SignOutFromAllPENewsletters();
			new NewsletterPreferencesPage().SingUpForPetroleumEconomistNewsletter("MonthlyMagazineUpdate");
		}

		[Then(@"Monthly Magazine Update Newsletter sign up is saved")]
		public void ThenMonthlyMagazineUpdateNewsletterSignUpIsSaved()
		{
			Assert.IsTrue(new NewsletterPreferencesPage().NewsletterPreferences.PEMonthlyMagazineUpdate.IsSelected, "Monthly Magazine Update Newsletter is not subscribed.");
			Assert.IsTrue(new NewsletterPreferencesPage().IsUpdateConfirmationMessageDisplayed(), "Settings updated message is not displayed.");
		}

		[When(@"I sign up for Petroleum Economist Breaking News Newsletter")]
		public void WhenISignUpForPetroleumEconomistBreakingNewsNewsletter()
		{
			new NewsletterPreferencesPage().SignOutFromAllPENewsletters();
			new NewsletterPreferencesPage().SingUpForPetroleumEconomistNewsletter("BreakingNews");
		}

		[Then(@"Breaking News Newsletter sign up is saved")]
		public void ThenBreakingNewsNewsletterSignUpIsSaved()
		{
			Assert.IsTrue(new NewsletterPreferencesPage().NewsletterPreferences.PEBreakingNews.IsSelected, "Breaking News Newsletter is not subscribed.");
			Assert.IsTrue(new NewsletterPreferencesPage().IsUpdateConfirmationMessageDisplayed(), "Settings updated message is not displayed.");
		}

		[When(@"I sign up for Petroleum Economist Blog Email")]
		public void WhenISignUpForPetroleumEconomistBlogEmail()
		{
			new NewsletterPreferencesPage().SignOutFromAllPENewsletters();
			new NewsletterPreferencesPage().SingUpForPetroleumEconomistNewsletter("BlogEmail");
		}

		[Then(@"Blog Email sign up is saved")]
		public void ThenBlogEmailSignUpIsSaved()
		{
			Assert.IsTrue(new NewsletterPreferencesPage().NewsletterPreferences.PEBlogEmail.IsSelected, "Blog Email Newsletter is not subscribed.");
			Assert.IsTrue(new NewsletterPreferencesPage().IsUpdateConfirmationMessageDisplayed(), "Settings updated message is not displayed.");
		}

		[When(@"I sign out from Petroleum Economist Monthly Magazine Update Newsletter")]
		public void WhenISignOutFromPetroleumEconomistMonthlyMagazineUpdateNewsletter()
		{
			new NewsletterPreferencesPage().SignOutFromPetroleumEconomistNewsletter("MonthlyMagazineUpdate");
		}

		[Then(@"Monthly Magazine Update Newsletter sign out is saved")]
		public void ThenMonthlyMagazineUpdateNewsletterSignOutIsSaved()
		{
			Assert.IsFalse(new NewsletterPreferencesPage().NewsletterPreferences.PEBreakingNews.IsSelected, "Monthly Magazine Update Newsletter is still subscribed.");
			Assert.IsTrue(new NewsletterPreferencesPage().IsUpdateConfirmationMessageDisplayed(), "Settings updated message is not displayed.");
		}

		[When(@"I sign out from Petroleum Economist Breaking News Newsletter")]
		public void WhenISignOutFromPetroleumEconomistBreakingNewsNewsletter()
		{
			new NewsletterPreferencesPage().SignOutFromPetroleumEconomistNewsletter("BreakingNews");
		}

		[Then(@"Breaking News Newsletter sign out is saved")]
		public void ThenBreakingNewsNewsletterSignOutIsSaved()
		{
			Assert.IsFalse(new NewsletterPreferencesPage().NewsletterPreferences.PEBreakingNews.IsSelected, "Monthly Magazine Update Newsletter is still subscribed.");
			Assert.IsTrue(new NewsletterPreferencesPage().IsUpdateConfirmationMessageDisplayed(), "Settings updated message is not displayed.");
		}

		[When(@"I sign out from Petroleum Economist Blog Email")]
		public void WhenISignOutFromPetroleumEconomistBlogEmail()
		{
			new NewsletterPreferencesPage().SignOutFromPetroleumEconomistNewsletter("BlogEmail");
		}

		[Then(@"Blog Email sign out is saved")]
		public void ThenBlogEmailSignOutIsSaved()
		{
			Assert.IsFalse(new NewsletterPreferencesPage().NewsletterPreferences.PEBreakingNews.IsSelected, "Blog Email Newsletter is still subscribed.");
			Assert.IsTrue(new NewsletterPreferencesPage().IsUpdateConfirmationMessageDisplayed(), "Settings updated message is not displayed.");
		}
	}
}
