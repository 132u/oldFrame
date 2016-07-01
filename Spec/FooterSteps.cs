using Core;
using NUnit.Framework;
using PageObjects.PageObjects;
using TechTalk.SpecFlow;

namespace Spec
{
	[Binding]
	public class FooterSteps
	{
		private HomePage homePage;

		[Given(@"I'm on the Home page")]
		public void GivenIMOnTheHomePage()
		{
			this.homePage = new HomePage();

			Assert.IsTrue(this.homePage.IsDisplayed());
			ScenarioContext.Current.Add("page", this.homePage);
		}

		[Then(@"the footer should be displayed")]
		public void ThenTheFooterShouldBeDisplayed()
		{
			var page = ScenarioContext.Current.Get<HomePage>("page");
			// Assert.IsTrue(page.Footer.IsDisplayedTheSameAsBefore());
		}

		[Then(@"I should be able to see logo of the site")]
		public void ThenIShouldBeAbleToSeeLogoOfTheSite()
		{
			Assert.IsTrue(this.homePage.LogoIsDisplayed());
		}
	}
}
