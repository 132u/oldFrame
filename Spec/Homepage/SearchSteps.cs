using Core;
using Core.Configuration;
using NUnit.Framework;
using PageObjects.PageObjects;
using TechTalk.SpecFlow;

namespace Spec.Homepage
{
	[Binding]
	public class SearchSteps
	{
		[When(@"I perform search with an empty phrase")]
		public void WhenIPerformSearchWithAnEmptyPhrase()
		{
			new HomePage().Header.SearchFailed(string.Empty);
		}

		[When(@"I perform search with white spaces")]
		public void WhenIPerformSearchWithWhiteSpaces()
		{
			new HomePage().Header.SearchFailed("   ");
		}

		[Then(@"Search process shouldn't start")]
		public void ThenSearchProcessShouldnTStart()
		{
			Assert.IsTrue(new HomePage().IsDisplayed(), "Home page is not displayed.");
			Assert.AreEqual(ApplicationConfiguration.Url, WebBrowser.GetUrlAddress, "Home page is not displayed.");
			Assert.IsFalse(new SearchResultsPage().IsDisplayed(), "Search results page is displayed.");
		}

		[When(@"I perform search with ""(.*)"" phrase")]
		public void WhenIPerformSearchWithPhrase(string searchPhrase)
		{
			new HomePage().Header.SearchSuccessfully(searchPhrase);
		}

		[Then(@"Search results page should be displayed")]
		public void ThenSearchResultsPageShouldBeDisplayed()
		{
			var searchResultsPage = new SearchResultsPage();

			Assert.IsTrue(searchResultsPage.IsDisplayed(), "Search results page is not displayed.");
		}

		[Then(@"Search results page should be displayed correctly")]
		public void ThenSearchResultsPageShouldBeDisplayedCorrectly()
		{
			var searchResultsPage = new SearchResultsPage();

			Assert.IsTrue(searchResultsPage.IsDisplayed(), "Search results page is not displayed.");
			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.SearchResultsPageUrl), "Search results page is not displayed.");
			Assert.IsTrue(searchResultsPage.SidePanel.PageIsDisplayed("Default"), "Side panel is not displayed.");
			Assert.IsTrue(searchResultsPage.Header.PageIsDisplayed(), "Header component is not displayed.");
			Assert.IsTrue(searchResultsPage.TopMenu.PageIsDisplayed("Default"), "Top Menu is not displayed.");
			Assert.IsTrue(searchResultsPage.Footer.PageIsDisplayed(), "Footer is not displayed.");
		}

		[When(@"I perform search with ""(.*)"" phrase and I press enter key")]
		public void WhenIPerformSearchWithPhraseAndIPressEnterKey(string searchPhrase)
		{
			new HomePage().Header.SearchSuccessfullyByPressingEnterKey(searchPhrase);
		}

		[When(@"I perform search with string with special characters")]
		public void WhenIPerformSearchWithStringWithSpecialCharacters()
		{
			new HomePage().Header.SearchFailed(" {      [              (              ~             !              @            #             $              %            ^             &             *             `               |                    :               ”              ;               ’               <             >             ?              ,               .               /              *             -        +             )              ]              }");
		}

		[When(@"I perform search with SQL injection")]
		public void WhenIPerformSearchWithSQLInjection()
		{
			new HomePage().Header.SearchFailed("Select * from randomTable");
		}

		[Then(@"Advanced Search Page should be displayed")]
		public void ThenAdvancedSearchPageShouldBeDisplayed()
		{
			var advancedSearchPage = new AdvancedSearchPage();

			Assert.IsTrue(WebBrowser.GetUrlAddress.Contains(ApplicationConfiguration.AdvancedSearchUrl), "Advanced Search Page is not displayed.");
		}

		[Then(@"Advanced search page should be displayed correctly")]
		public void ThenAdvancedSearchPageShouldBeDisplayedCorrectly()
		{
			var advancedSearchPage = new AdvancedSearchPage();

			Assert.IsTrue(advancedSearchPage.Header.PageIsDisplayed(), "Header component is not displayed.");
			Assert.IsTrue(advancedSearchPage.TopMenu.PageIsDisplayed("Default"), "Top Menu is not displayed.");
			Assert.IsTrue(advancedSearchPage.Footer.PageIsDisplayed(), "Footer is not displayed.");
			Assert.IsTrue(advancedSearchPage.PageIsDisplayed(), "Advanced Search Page is not displayed correctly");
		}
	}
}
