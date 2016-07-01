using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Core.Configuration;

namespace PageObjects.PageObjects
{
	public partial class PasswordUpdatedPage : PageBase
	{
		/// <summary>
		/// Check if current page is displayed.
		/// </summary>
		/// <returns>Returns true if current page is displayed.</returns>
		public bool IsDisplayed()
		{
			return this.PasswordUpdatedHeader.IsFound;
		}

		/// <summary>
		/// Navigates to the Change Password page.
		/// </summary>
		/// <returns>Returns new instance of the ChangePasswordPage class.</returns>
		public ChangePasswordPage NavigateToTheChangePassword()
		{
			WebBrowser.Open(ApplicationConfiguration.Url + ApplicationConfiguration.MyAccountChangePasswordUrl);

			return new ChangePasswordPage();
		}
	}
}
