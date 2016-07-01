using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects.PageObjects
{
	public partial class SignUpPage : PageBase
	{
		public SignUpSuccessfulPage SignUpSuccesfuly(string email, string title, string firstName, string lastName, string jobTitle, string company, string country)
		{
			this.Email.Text = email;
			this.Title.SelectItemByText(title);
			this.FirstName.Text = firstName;
			this.LastName.Text = lastName;
			this.JobTitle.Text = jobTitle;
			this.Company.Text = company;
			this.Country.SelectItemByText(country);
			this.PrivacyPolicy.Select();
			this.TermsAndConditions.Select();
			this.SignUp.Click();

			return new SignUpSuccessfulPage();
		}
	}
}
