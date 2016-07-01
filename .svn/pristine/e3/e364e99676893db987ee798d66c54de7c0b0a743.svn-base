using Core;

namespace PageObjects.PageObjects
{
	public partial class NewsletterPreferencesComponent : PageBase
	{
		public void SelectNewsAlerts()
		{
			this.EMNewsAlerts.Select();
		}

		public void DeselectNewsAlerts()
		{
			if (!this.EMNewsAlerts.Optional)
			{
				this.EMNewsAlerts.Deselect();
			}
		}

		public bool IsEmergingMarketsNewsletterSubscribed()
		{
			return this.EMNewsAlerts.IsSelected;
		}

		public bool IsMonthlyMagazineUpdateSubscribed()
		{
			return this.PEMonthlyMagazineUpdate.IsSelected;
		}

		public bool IsBreakingNewsSubscribed()
		{
			return this.PEBreakingNews.IsSelected;
		}

		public bool IsBlogEmailSubscribed()
		{
			return this.PEBlogEmail.IsDisabled;
		}

		public bool IsEmailFormatHtml()
		{
			return this.Html.IsSelected;
		}

		/// <summary>
		/// Sets the emerging markets newsletter email format to html.
		/// </summary>
		public void SetEmailFormatToHtml()
		{
			this.Html.Select();
		}

		/// <summary>
		/// Sets the emerging markets newsletter email format to text.
		/// </summary>
		public void SetEmailFormatToText()
		{
			this.Text.Select();
		}
	}
}