using Core.Configuration;

namespace PageObjects.PageObjects
{
	public partial class ArticlePage : PageBase
	{
		/// <summary>
		/// Check if it's possible to add comment to the article.
		/// </summary>
		/// <returns>Returns true if it's possible to add comment to the article.</returns>
		public bool IsAddCommentButtonDisplayed()
		{
			return this.AddComment.IsFound;
		}

		/// <summary>
		/// Check if it's possible to add article to my clippings.
		/// </summary>
		/// <returns>Returns true if it's possible to add article to my clippings.</returns>
		public bool IsAddToMyClippingsButtonDisplayed()
		{
			return this.AddToMyClippings.IsFound;
		}

		/// <summary>
		/// Check if add comment confirmation message is displayed.
		/// </summary>
		/// <returns>Returns true if add comment confirmation message is displayed.</returns>
		public bool IsAddCommentConfirmationMessageDisplayed()
		{
			return this.AddCommentConfirmationMessage.IsFound;
		}

		/// <summary>
		/// Adds comment to the article. Process should finish with success.
		/// </summary>
		/// <returns>Returns new instance of ArticlePage class.</returns>
		public ArticlePage AddCommentToTheArticleSuccessfully()
		{
			this.AddComment.Click();
			this.YourName.Text = ApplicationConfiguration.ExistingUserName;

			if (!this.YourEmail.IsDisabled)
			{
				this.YourEmail.Text = ApplicationConfiguration.ExistingUserName;
			}

			this.YourComments.Text = ApplicationConfiguration.CommentTestText;

			this.Submit.Click();

			return new ArticlePage();
		}

		/// <summary>
		/// Adds comment to the article. Process shouldn't finish with success.
		/// </summary>
		/// <param name="username">User name.</param>
		/// <param name="emailAddress">Email address.</param>
		/// <param name="comment">Comment.</param>
		/// <returns>Returns new instance of the ArticlePage class.</returns>
		public ArticlePage AddCommentToTheArticleFailed(string username, string emailAddress, string comment)
		{
			this.AddComment.Click();
			this.YourName.Text = username;

			if (!this.YourEmail.IsDisabled)
			{
				this.YourEmail.Text = emailAddress;
			}

			this.YourComments.Text = comment;

			this.Submit.Click();

			return new ArticlePage();
		}

		/// <summary>
		/// Gets the article title.
		/// </summary>
		/// <returns>Returns article title.</returns>
		public string GetArticleTitle()
		{
			return this.ArticleTitle.Text;
		}

		/// <summary>
		/// Adds article to the my clippings list. Process should finish with success.
		/// </summary>
		/// <returns>Returns new instance of ArticlePage class.</returns>
		public ArticlePage AddArticleToTheMyClippingsListSuccessfully()
		{
			this.AddToMyClippings.Click();

			return new ArticlePage();
		}

		/// <summary>
		/// Checks if Add comment box is displayed correctly.
		/// </summary>
		/// <param name="email">Email address.</param>
		/// <returns>Returns true if Add comment box is displayed correctly.</returns>
		public bool AddCommentBoxIsDisplayedCorrect(string email)
		{
			if (this.YourEmail.IsDisabled && (this.YourEmail.Text != email))
			{
				return false;
			}

			return true;
		}

		public void MoveToCommentBox()
		{
			this.AddComment.Click();
		}

		public void ClearCaptcha()
		{
			if (this.Captcha.IsNotFound)
			{
				this.AddComment.Click();
			}

			this.Captcha.Text = string.Empty;
		}
	}
}