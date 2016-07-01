using Core.Controls;

namespace PageObjects.PageObjects
{
	public partial class MyClippingsPage : PageBase
	{
		/// <summary>
		/// Check if current page is displayed.
		/// </summary>
		/// <returns>Returns true if current page is displayed.</returns>
		public bool IsDisplayedCorrectly()
		{
			return this.MyClippingsHeader.IsFound;
		}

		/// <summary>
		/// Check if requested article is present on the list.
		/// </summary>
		/// <param name="articleTitle">Article title.</param>
		/// <returns>Returns true if requested article is present on the list.</returns>
		public bool ArticleIsOnTheList(string articleTitle)
		{
			Link requestedArticleTitle = new Link("requestedArticle", this.FindArticleByParam.XPath.Replace("@param", articleTitle), 0, false);

			return requestedArticleTitle.IsFound;
		}

		/// <summary>
		/// Gets title of the first article on the list.
		/// </summary>
		/// <returns>Returns string with first article title.</returns>
		public string GetFirstArticleTitle()
		{
			return this.FirstArticleLink.Text;
		}

		/// <summary>
		/// Removes requested article from my clipping list.
		/// </summary>
		/// <param name="articleTitle">Article title.</param>
		public void RemoveArticle(string articleTitle)
		{
			Button delete = new Button("DeleteByParam", this.DeleteByParam.XPath.Replace("@param", articleTitle), 0, false);
			delete.Click();
		}

		/// <summary>
		/// Navigates to the first article on the my clippings list.
		/// </summary>
		/// <returns>Returns new instance of the ArticlePage class.</returns>
		public ArticlePage NavigateToTheFirstArticleOnTheMyClippingsList()
		{
			this.FirstArticleLink.Click();

			return new ArticlePage();
		}
	}
}
