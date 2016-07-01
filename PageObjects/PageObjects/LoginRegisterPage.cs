using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Helpers;

namespace PageObjects.PageObjects
{
	public partial class LoginRegisterPage : PageBase
	{
		public YourDetailsPage CreateNewAccountSuccessfuly(string email)
		{
			this.NewEmail.Text = email;
			this.Register.Click();

			return new YourDetailsPage();
		}

		public LoginRegisterPage FailToCreateAccount(string email)
		{
			this.NewEmail.Text = email;
			this.Register.Click();

			return new LoginRegisterPage();
		}

		public bool InvalidEmailEnteredMessageIsDisplayed()
		{
			return this.InvalidEmailMessage.IsFound;
		}
	}
}
