using System;
using Core;
using Core.Configuration;
using Core.Helpers;
using Core.Logger;

namespace PageObjects.PageObjects
{
	public partial class SubscribeStepTwoPage : PageBase
	{
		public string RememberEmail;
		public bool IsDisplayedCorrectly()
		{
			return (this.CompareLists(this.SubscribeStepTwoToolbar));
		}

		public SubscribeStepThreePage NavigateToTheSubscribeStepThreePage()
		{
			string email = BasicHelper.GetRandomEmail();
			return this.NavigateToTheFreeTrialStepTwoSuccessfully(email);
		}

		public SubscribeStepTwoPage TypeInvalidEmail(string email)
		{
			try
			{
				this.EmailAddress.Text = email;
				this.EmailCompare.Text = email;
			}
			catch
			{
				this.EmailAddress.Text = email;
				this.EmailCompare.Text = email;
			}

			this.Next.Click();
			return new SubscribeStepTwoPage();
		}

		public bool WarningMessage1IsDisplayedCorrectly()
		{
			return this.WarningMessage1.IsFound;
		}

		public bool WarningMessage2IsDisplayedCorrectly()
		{
			return this.WarningMessage2.IsFound;
		}

		public bool WarningMessageEmptyEmailIsDisplayedCorrectly()
		{
			return this.WarningMessageEmptyEmail.IsFound;
		}

		public bool WarningMessageEmptyCompareEmailIsDisplayedCorrectly()
		{
			return this.WarningMessageEmptyCompareEmail.IsFound;
		}

		private SubscribeStepThreePage NavigateToTheFreeTrialStepTwoSuccessfully(string email)
		{
			try
			{
				this.EmailAddress.Text = email;
				this.EmailCompare.Text = email;
			}
			catch
			{
				this.EmailAddress.Text = email;
				this.EmailCompare.Text = email;
			}

			this.Next.Click();
			this.RememberEmail = email;
			return new SubscribeStepThreePage();
		}
	}
}
