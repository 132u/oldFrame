using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects.PageObjects
{
	public partial class NewsPage : PageBase
	{
		/// <summary>
		/// Check if current page is displayed.
		/// </summary>
		/// <returns>Returns true if current page is displayed.</returns>
		public bool IsDisplayedCorrectly()
		{
			return this.News.IsFound;
		}

		/// <summary>
		/// Navigates to the first article from the article list.
		/// </summary>
		/// <returns>Returns new instance of the ArticlePage class.</returns>
		public ArticlePage NavigateToTheFirstArticleFromTheList()
		{
			this.FirstArticleLink.Click();

			return new ArticlePage();
		}

		/// <summary>
		/// Get first article title.
		/// </summary>
		/// <returns>Returns first article title.</returns>
		public string GetFirstArticleTitle()
		{
			return this.FirstArticleLink.Text;
		}
	}
}
