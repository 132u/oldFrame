using System;
using Core;

namespace PageObjects.PageObjects
{
	public partial class NewsletterPreferencesPage : PageBase
	{
		public override bool PageIsVisible(string parameter = default(string))
		{
			this.NewsletterPreferences.DeselectNewsAlerts();
			return this.CompareLists(this.NewsletterPreferencesRequiredElements);
		}

		/// <summary>
		/// Sets the emerging markets newsletter checkbox as true.
		/// </summary>
		public NewsletterPreferencesPage SignUpForEmergingMarketsNewsAlerts()
		{
			this.NewsletterPreferences.SelectNewsAlerts();
			this.Submit.Click();

			return new NewsletterPreferencesPage();
		}

		/// <summary>
		/// Sets the emerging markets newsletter checkbox as false.
		/// </summary>
		public void SignOutFromEmergingMarketsNewsAlerts()
		{
			this.NewsletterPreferences.DeselectNewsAlerts();
			this.Submit.Click();
		}

		public void SignOutFromAllPENewsletters()
		{
			this.NewsletterPreferences.PEBlogEmail.SetValue(false);
			this.NewsletterPreferences.PEBreakingNews.SetValue(false);
			this.NewsletterPreferences.PEMonthlyMagazineUpdate.SetValue(false);
		}

		public void SingUpForPetroleumEconomistNewsletter(string name)
		{
			if (name == "MonthlyMagazineUpdate")
			{
				this.NewsletterPreferences.PEMonthlyMagazineUpdate.SetValue(true);
			}
			else if (name == "BreakingNews")
			{
				this.NewsletterPreferences.PEBreakingNews.SetValue(true);
			}
			else if (name == "BlogEmail")
			{
				this.NewsletterPreferences.PEBlogEmail.SetValue(true);
			}
			else
			{
				throw new ArgumentException("There is no newsletter like provided");
			}
		}

		public void SignOutFromPetroleumEconomistNewsletter(string name)
		{
			if (name == "MonthlyMagazineUpdate")
			{
				this.NewsletterPreferences.PEMonthlyMagazineUpdate.SetValue(false);
			}
			else if (name == "BreakingNews")
			{
				this.NewsletterPreferences.PEBreakingNews.SetValue(false);
			}
			else if (name == "BlogEmail")
			{
				this.NewsletterPreferences.PEBlogEmail.SetValue(false);
			}
			else
			{
				throw new ArgumentException("There is no newsletter like provided");
			}
		}

		public bool IsUpdateConfirmationMessageDisplayed()
		{
			return this.UpdatedSettingsConfirmation.IsFound;
		}

		public void SavePreferences()
		{
			this.Submit.Click();
		}
	}
}
