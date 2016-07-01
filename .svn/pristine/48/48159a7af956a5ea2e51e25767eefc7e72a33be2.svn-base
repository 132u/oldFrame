using Core.Configuration;
using Core.Logger;
using Core.Users;
using NUnit.Framework;
using PageObjects.PageObjects;
using TechTalk.SpecFlow;

namespace Spec.Articles
{
	[Binding]
	public class ArticlesSteps
	{
		[Then(@"Article page should be displayed correctly")]
		public void ThenArticlePageShouldBeDisplayedCorrectly()
		{
			ArticlePage articlePage = new ArticlePage();
			string articleTitleFromNewsList = ScenarioContext.Current.Get<string>("ArticleTitle");
			string currentTitle = articlePage.GetArticleTitle();

			Assert.AreEqual(articleTitleFromNewsList.ToLower(), currentTitle.ToLower(), "Article titles are not equal.");
			Assert.IsTrue(articlePage.SidePanel.PageIsDisplayed("Article"), "Side panel is not displayed correctly.");
			Assert.IsTrue(articlePage.Header.PageIsDisplayed(), "Header component is not displayed correctly.");
			Assert.IsTrue(articlePage.TopMenu.PageIsDisplayed("Default"), "Top Menu is not displayed correctly.");
			Assert.IsTrue(articlePage.Footer.PageIsDisplayed(), "Footer is not displayed correctly.");
		}

		[When(@"I have entered article in the News section")]
		public void WhenIHaveEnteredArticleInTheNewsSection()
		{
			var newsPage = new TopMenuComponent().NavigateToTheNews();
			string firstArticleTitle = newsPage.GetFirstArticleTitle();

			ArticlePage articlePage = newsPage.NavigateToTheFirstArticleFromTheList();
		}

		[Then(@"I should be able to add comment to the article")]
		public void ThenIShouldBeAbleToAddCommentToTheArticle()
		{
			Credentials credentials = FeatureContext.Current.Get<Credentials>("Credentials");

			ArticlePage articlePage = new ArticlePage();
			articlePage.MoveToCommentBox();
			Assert.IsTrue(articlePage.IsAddCommentButtonDisplayed(), "Add comment option is not available.");
			Assert.IsTrue(articlePage.AddCommentBoxIsDisplayedCorrect(credentials.Email), "Add comment box is not displayed correctly.");
		}

		[Then(@"I shouldn't be able to add comment to the article")]
		public void ThenIShouldnTBeAbleToAddCommentToTheArticle()
		{
			ArticlePage articlePage = new ArticlePage();
			Assert.IsFalse(articlePage.IsAddCommentButtonDisplayed(), "Add comment option is available.");
		}

		[Given(@"I'm on the first article page in the News section")]
		public void GivenIMOnTheFirstArticlePageInTheNewsSection()
		{
			Credentials credentails = FeatureContext.Current.Get<Credentials>("Credentials");

			var homePage = new HomePage()
									.Header
									.NavigateToTheLoginPage()
									.LoginToTheUserAccountSuccessfully(
																	credentails.Email,
																	credentails.Password,
																	false);

			NewsPage newsPage = new TopMenuComponent().NavigateToTheNews();
			ScenarioContext.Current.Add("ArticleTitle", newsPage.GetFirstArticleTitle());
			var articlePage = newsPage.NavigateToTheFirstArticleFromTheList();
		}

		[When(@"All required fields on the add comment section are filled")]
		public void WhenAllRequiredFieldsOnTheAddCommentSectionAreFilled()
		{
			new ArticlePage().AddCommentToTheArticleSuccessfully();
		}

		[Then(@"Comment should be added correctly")]
		public void ThenCommentShouldBeAddedCorrectly()
		{
			Assert.IsTrue(new ArticlePage().IsAddCommentConfirmationMessageDisplayed(), "Comment added confirmation message is not displayed.");
		}

		[When(@"Your name/commenter name is empty")]
		public void WhenYourNameCommenterNameIsEmpty()
		{
			Credentials credentails = FeatureContext.Current.Get<Credentials>("Credentials");
			ArticlePage articlePage = new ArticlePage();
			articlePage.AddCommentToTheArticleFailed(string.Empty, credentails.Email, ApplicationConfiguration.CommentTestText);
		}

		[Then(@"Comment shouldn't be added")]
		public void ThenCommentShouldnTBeAdded()
		{
			Assert.IsFalse(new ArticlePage().IsAddCommentConfirmationMessageDisplayed(), "Comment added confirmation message is displayed.");
		}

		[When(@"Your email address is empty")]
		public void WhenYourEmailAddressIsEmpty()
		{
			Credentials credentails = FeatureContext.Current.Get<Credentials>("Credentials");
			new ArticlePage().AddCommentToTheArticleFailed(credentails.Email, string.Empty, ApplicationConfiguration.CommentTestText);
		}

		[When(@"Your comments is empty")]
		public void WhenYourCommentsIsEmpty()
		{
			Credentials credentails = FeatureContext.Current.Get<Credentials>("Credentials");
			new ArticlePage().AddCommentToTheArticleFailed(credentails.Email, credentails.Email, string.Empty);
		}

		[When(@"Captcha field is empty")]
		public void WhenCaptchaFieldIsEmpty()
		{
			new ArticlePage().ClearCaptcha();
		}
	}
}