using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace PageObjects.PageObjects
{
	public partial class MyAccountBoxComponent : PageBase
	{
		public override bool PageIsVisible(string parameter = default(string))
		{
			return (
				this.LoginInfo.IsFound
				&& this.MyDetails.IsFound
				&& this.MyEvents.IsFound
				&& this.MyInterests.IsFound
				&& this.ChangePassword.IsFound
				&& this.Close.IsFound
				&& this.Logout.IsFound);
		}

		public ChangePasswordPage NavigateToTheChangePasswordPage()
		{
			this.ChangePassword.Click();

			return new ChangePasswordPage();
		}

		public RegistrationDetailsPage NavigateToDetailsPage()
		{
			this.MyDetails.Click();

			return new RegistrationDetailsPage();
		}
	}
}