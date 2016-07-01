using Core;
using Core.Configuration;
using Core.Users;
using NUnit.Framework;
using PageObjects.PageObjects;
using TechTalk.SpecFlow;

namespace Spec.MyAccount
{
	[Binding]
	public class MyClippingsSteps
	{
		[When(@"I enter My Clippings page")]
		public void WhenIEnterMyClippingsPage()
		{
			Credentials credentials = FeatureContext.Current.Get<Credentials>("Credentials");

			var myClippingsPage = new HomePage()
			.Header
			.NavigateToTheLoginPage()
			.LoginToTheUserAccountSuccessfully(credentials.Email, credentials.Password, false)
			.Header
			.NavigateToTheMyAccount()
			.NavigateToTheMyClippings();
		}

		[When(@"I delete first article from the my clippings list")]
		public void WhenIDeleteFirstArticleFromTheMyClippingsList()
		{
			var myClippingsPage = new MyClippingsPage();

			ScenarioContext.Current.Add("deletedArticleTitle", myClippingsPage.GetFirstArticleTitle());
			myClippingsPage.RemoveArticle(myClippingsPage.GetFirstArticleTitle());
		}

		[Then(@"first article should be removed")]
		public void ThenFirstArticleShouldBeRemoved()
		{
			var myClippingsPage = new MyClippingsPage();

			Assert.IsFalse(myClippingsPage.ArticleIsOnTheList(ScenarioContext.Current.Get<string>("deletedArticleTitle")));
		}

		[Then(@"I should be able to add article to my clippings")]
		public void ThenIShouldBeAbleToAddArticleToMyClippings()
		{
			Assert.IsTrue(new ArticlePage().IsAddToMyClippingsButtonDisplayed(), "Add to my clippings button is not displayed.");
		}

		[Then(@"I shouldn't be able to add article to my clippings")]
		public void ThenIShouldnTBeAbleToAddArticleToMyClippings()
		{
			Assert.IsFalse(new ArticlePage().IsAddToMyClippingsButtonDisplayed(), "Add to my clippings button is displayed.");
		}

		[When(@"I add article to my clippings list")]
		public void WhenIAddArticleToMyClippingsList()
		{
			var articlePage = new ArticlePage().AddArticleToTheMyClippingsListSuccessfully();

			ScenarioContext.Current.Add("articleTitle", articlePage.GetArticleTitle());
		}

		[Then(@"Article should be added to my clippings list")]
		public void ThenArticleShouldBeAddedToMyClippingsList()
		{
			Credentials credentials = FeatureContext.Current.Get<Credentials>("Credentials");

			var myClippingsPage = new HeaderComponent()
						.NavigateToTheLoginPage()
						.LoginToTheUserAccountSuccessfully(credentials.Email, credentials.Password, false)
						.Header
						.NavigateToTheMyAccount()
						.NavigateToTheMyClippings();

			Assert.IsTrue(myClippingsPage.ArticleIsOnTheList(ScenarioContext.Current.Get<string>("articleTitle")), "Article was not added to the my clippings list.");
		}

		[Given(@"I have added article to the my clippings list")]
		public void GivenIHaveAddedArticleToTheMyClippingsList()
		{
			Credentials credentials = FeatureContext.Current.Get<Credentials>("Credentials");

			new HomePage()
					.Header
					.NavigateToTheLoginPage()
					.LoginToTheUserAccountSuccessfully(credentials.Email, credentials.Password, false);

			new HomePage()
					.TopMenu.NavigateToTheNews()
					.NavigateToTheFirstArticleFromTheList()
					.AddArticleToTheMyClippingsListSuccessfully();
		}

		[When(@"I click on an article from list")]
		public void WhenIClickOnAnArticleFromList()
		{
			var myClippingsPage = new MyClippingsPage();

			ScenarioContext.Current.Add("myClippingsArticleTitle", myClippingsPage.GetFirstArticleTitle());

			myClippingsPage.NavigateToTheFirstArticleOnTheMyClippingsList();
		}

		[Then(@"the article should be displayed")]
		public void ThenTheArticleShouldBeDisplayed()
		{
			Assert.AreEqual(ScenarioContext.Current.Get<string>("myClippingsArticleTitle").ToLower(), new ArticlePage().GetArticleTitle().ToLower(), "Article title is different than expected.");
		}
	}
}
