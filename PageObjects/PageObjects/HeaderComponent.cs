using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Core.Configuration;

namespace PageObjects.PageObjects
{
	public partial class HeaderComponent : PageBase
	{
		public override bool PageIsVisible(string parameter = default(string))
		{
			return (IsDisplayedLoggedIn() || IsDisplayedLoggedOut());
		}

		/// <summary>
		/// Check if footer component is displayed.
		/// </summary>
		/// <returns>Returns true if footer component is displayed.</returns>
		public bool IsDisplayedLoggedIn()
		{
			if (!MyAccountBox.Optional)
			{
				return (this.MyEMAccount.IsFound || this.MyAccountBox.PageIsVisible());
			}

			return (this.Logo.IsFound && this.Logout.IsFound && this.SearchButton.IsFound && this.SearchTextbox.IsFound);
		}

		/// <summary>
		/// Check if footer component is displayed.
		/// </summary>
		/// <returns>Returns true if footer component is displayed.</returns>
		public bool IsDisplayedLoggedOut()
		{
			return (this.Logo.IsFound && this.Login.IsFound && this.SearchButton.IsFound && this.SearchTextbox.IsFound);
		}

		/// <summary>
		/// Navigates to the Login page.
		/// </summary>
		/// <returns>Returns new instance of the LoginPage class.</returns>
		public LoginPage NavigateToTheLoginPage()
		{
			WebBrowser.Open(ApplicationConfiguration.Url + ApplicationConfiguration.LoginPageUrl);

			return new LoginPage();
		}

		/// <summary>
		/// Checks if logo is displayed on the page.
		/// </summary>
		/// <returns>Returns true if logo is displayed on the page.</returns>
		public bool LogoIsDisplayed()
		{
			return this.Logo.IsFound;
		}

		/// <summary>
		/// This method is used for search option. Search should be finished with success.
		/// </summary>
		/// <param name="searchPhrase">Search phrase.</param>
		/// <returns>Returns new instance of the SearchResultsPage class.</returns>
		public SearchResultsPage SearchSuccessfully(string searchPhrase)
		{
			this.SearchTextbox.Text = searchPhrase;
			this.SearchButton.Click();

			return new SearchResultsPage();
		}

		/// <summary>
		/// This method is used for search option. Search should be finished without success.
		/// </summary>
		/// <param name="searchPhrase">Search phrase.</param>
		/// <returns>Returns new instance of the HomePage class.</returns>
		public HomePage SearchFailed(string searchPhrase)
		{
			this.SearchTextbox.Text = searchPhrase;
			this.SearchButton.Click();

			return new HomePage();
		}

		/// <summary>
		/// This method is used for search option. Search should be finished with success.
		/// </summary>
		/// <param name="searchPhrase">Search phrase.</param>
		/// <returns>Returns new instance of the SearchResultsPage class.</returns>
		public SearchResultsPage SearchSuccessfullyByPressingEnterKey(string searchPhrase)
		{
			this.SearchTextbox.Text = searchPhrase;
			this.SearchTextbox.Enter();

			return new SearchResultsPage();
		}

		/// <summary>
		/// This method is used for Logout option.
		/// </summary>
		/// <returns>Returns new instance of the HomePage class.</returns>
		public HomePage LogoutFromTheUserAccount()
		{
			this.Logout.Click();

			return new HomePage();
		}

		/// <summary>
		/// Checks if user is logged in to his account.
		/// </summary>
		/// <returns>Returns true if user is logged in to his account.</returns>
		public bool IsLoggedIn()
		{
			if (MyAccountBox.Optional)
			{
				return this.Logout.IsFound;
			}
			else
			{
				return (this.MyEMAccount.IsFound || this.MyAccountBox.PageIsVisible());
			}
		}

		/// <summary>
		/// This method is used for Logout option.
		/// </summary>
		/// <returns>Returns new instance of the MyAccountPage class.</returns>
		public MyAccountPage NavigateToTheMyAccount()
		{
			if (MyAccountBox.Optional || !this.MyAccountBox.PageIsVisible())
			{
				if (ApplicationConfiguration.ZeroFreeTrialPage)
				{
					WebBrowser.Open(ApplicationConfiguration.Url + ApplicationConfiguration.MyAccountPageUrl);
					return new MyAccountPage();
				}

				this.MyEMAccount.Click();
				return new MyAccountPage();
			}

			return new MyAccountPage();
		}

		public HomePage ShowMyAccountBox()
		{
			this.MyEMAccount.Click();

			return new HomePage();
		}

		/// <summary>
		/// Navigates to the Free Trial page.
		/// </summary>
		/// <returns>Returns new instance of the FreeTrialStepOnePage class.</returns>
		public FreeTrialStepOnePage NavigateToTheFreeTrial()
		{
			this.SignUpForFree.Click();
			return new FreeTrialStepOnePage();
		}

		public SignUpPage NavigateToSignUpPage()
		{
			this.SignUp.Click();
			return new SignUpPage();
		}

		public SubscribeStepOnePage NavigateToSubscribePage()
		{
			this.Subscribe.Click();
			if (ApplicationConfiguration.SubscribtionZeroPage)
			{
				SubscribtionZeroPage zeroPage = new SubscribtionZeroPage();
				zeroPage.NavigateToStepOne();
			}

			return new SubscribeStepOnePage();
		}

		public SubscribeStepOnePage NavigateToAsiaHedgeSubscribePage()
		{
			this.Subscribe.Click();
			if (ApplicationConfiguration.SubscribtionZeroPage)
			{
				SubscribtionZeroPage zeroPage = new SubscribtionZeroPage();
				zeroPage.NavigateToAsiaHedgeStepOne();
			}

			return new SubscribeStepOnePage();
		}

		public SubscribeStepOnePage NavigateToInvestHedgeSubscribePage()
		{
			this.Subscribe.Click();
			if (ApplicationConfiguration.SubscribtionZeroPage)
			{
				SubscribtionZeroPage zeroPage = new SubscribtionZeroPage();
				zeroPage.NavigateToInvestHedgeStepOne();
			}

			return new SubscribeStepOnePage();
		}


		public SubscribeStepOnePage NavigateToSubscribePage(string subName)
		{
			this.Subscribe.Click();
			switch (subName)
			{
 				case"AsiaHedge":
					this.NavigateToAsiaHedgePage();
					break;
				case "EuroHedge":
					this.NavigateToEuroHedgePage();
					break;
				case "InvestHedge":
					this.NavigateToInvestHedgePage();
					break;
				case "AU":
					this.NavigateToAUSubscribePage();
					break;
				case "AR":
					this.NavigateToARSubscribePage();
					break;
			}

			//this.Subscribe.Click();
			//if (ApplicationConfiguration.SubscribtionZeroPage)
			//{
			//	SubscribtionZeroPage zeroPage = new SubscribtionZeroPage();
			//	zeroPage.NavigateToInvestHedgeStepOne();
			//}

			return new SubscribeStepOnePage();
		}

		public SubscribeStepOnePage NavigateToAUSubscribePage()
		{
			this.Subscribe.Click();
			if (ApplicationConfiguration.SubscribtionZeroPage)
			{
				SubscribtionZeroPage zeroPage = new SubscribtionZeroPage();
				zeroPage.NavigateToAUStepOne();
			}

			return new SubscribeStepOnePage();
		}

		public SubscribeStepOnePage NavigateToARSubscribePage()
		{
			this.Subscribe.Click();
			if (ApplicationConfiguration.SubscribtionZeroPage)
			{
				SubscribtionZeroPage zeroPage = new SubscribtionZeroPage();
				zeroPage.NavigateToARStepOne();
			}

			return new SubscribeStepOnePage();
		}

		public EuroHedgePage NavigateToEuroHedgePage()
		{
			this.EuroHedge.Click();
			return new EuroHedgePage();
		}

		public AsiaHedgePage NavigateToAsiaHedgePage()
		{
			this.AsiaHedge.Click();
			return new AsiaHedgePage();
		}

		public AbsoluteUCITSPage NavigateToAbsoluteUCITSPage()
		{
			this.AbsoluteUcits.Click();
			return new AbsoluteUCITSPage();
		}

		public AbsoluteReturnPage NavigateToAbsoluteReturnPage()
		{
			this.AbsoluteReturn.Click();
			return new AbsoluteReturnPage();
		}

		public EuroHedgePage NavigateToInvestHedgePage()
		{
			this.InvestHedge.Click();
			return new EuroHedgePage();
		}

		public CheckoutSelectionPage NavigateToCheckoutSsubscriptionSelectionPage()
		{
			this.Subscribe.Click();
			return new CheckoutSelectionPage();
		}
	}
}
