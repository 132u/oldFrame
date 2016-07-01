using System;
using Core;
using Core.Configuration;
using Core.Helpers;
using Core.Logger;

namespace PageObjects.PageObjects
{
	public partial class SubscribeStepOnePage : PageBase
	{
		/// <summary>
		/// Check if current page is displayed.
		/// </summary>
		/// <returns>Returns true if current page is displayed.</returns>
		public bool IsDisplayedCorrectly()
		{
			return (this.CompareLists(this.SubscribeStepOneToolbar));
		}

		public SubscribeStepTwoPage NavigateToTheSubscribeStepTwoPage()
		{
			this.Next.Click();
			return new SubscribeStepTwoPage();
		}

		public SubscribeStepTwoPage NavigateToTheSubscribeStepTwoPageSecondPackage()
		{
			this.Next2.Click();
			return new SubscribeStepTwoPage();
		}
	}
}
