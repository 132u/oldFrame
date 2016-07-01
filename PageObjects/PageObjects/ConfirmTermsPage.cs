using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects.PageObjects
{
	public partial class ConfirmTermsPage : PageBase
	{
		/// <summary>
		/// Check if current page is displayed.
		/// </summary>
		/// <returns>Returns true if current page is displayed.</returns>
		public bool IsDisplayedCorrectly()
		{
			return this.PrivacyPolicy.IsFound && this.TermsAndConditions.IsFound;
		}

		/// <summary>
		/// Accepts mandatory contracts on Confirm Terms page.
		/// </summary>
		/// <returns>Returns new instance of the LoginPage class.</returns>
		public LoginPage AcceptMandatoryContracts()
		{
			this.PrivacyPolicy.Select();
			this.TermsAndConditions.Select();
			this.Continue.Click();

			return new LoginPage();
		}
	}
}
