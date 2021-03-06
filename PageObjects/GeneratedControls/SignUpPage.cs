// -----------------------------------------------------------------------
// <copyright file="SignUpPage.cs" company="Euromoney">
// TODO: Update copyright text.
// </copyright>
// <auto-generated />
// -----------------------------------------------------------------------
namespace PageObjects.PageObjects
{
	using System.Collections.Generic;
	using System.Globalization;
	using Core;
	using Core.Controls;
	using Core.Configuration;
	using ConfigManager;

	/// <summary> 
	/// Initializes a new instance of the SignUpPage class
	/// </summary>
	public partial class SignUpPage 
	{	
		public SignUpPage(bool optional=false)
		{
			this.Optional = optional;
		}


		/// <summary>
		/// Gets Email Textbox
		/// </summary> 
		private Textbox Email
		{
			get { return new Textbox("Email", "//div[contains(@id, 'pnlDetails')]//input[@id=//label[contains(text(), 'Email:')]/@for]", 0, false); }
		}

		/// <summary>
		/// Gets Title Dropdown
		/// </summary> 
		private Dropdown Title
		{
			get { return new Dropdown("Title", "//div[contains(@id, 'pnlDetails')]//select[@id=//label[contains(text(), 'Title:')]/@for]", 0, false); }
		}

		/// <summary>
		/// Gets FirstName Textbox
		/// </summary> 
		private Textbox FirstName
		{
			get { return new Textbox("FirstName", "//div[contains(@id, 'pnlDetails')]//input[@id=//label[contains(text(), 'First Name:')]/@for]", 0, false); }
		}

		/// <summary>
		/// Gets LastName Textbox
		/// </summary> 
		private Textbox LastName
		{
			get { return new Textbox("LastName", "//div[contains(@id, 'pnlDetails')]//input[@id=//label[contains(text(), 'Last Name:')]/@for]", 0, false); }
		}

		/// <summary>
		/// Gets JobTitle Textbox
		/// </summary> 
		private Textbox JobTitle
		{
			get { return new Textbox("JobTitle", "//div[contains(@id, 'pnlDetails')]//input[@id=//label[contains(text(), 'Job Title:')]/@for]", 0, false); }
		}

		/// <summary>
		/// Gets Company Textbox
		/// </summary> 
		private Textbox Company
		{
			get { return new Textbox("Company", "//div[contains(@id, 'pnlDetails')]//input[@id=//label[contains(text(), 'Company:')]/@for]", 0, false); }
		}

		/// <summary>
		/// Gets Country Dropdown
		/// </summary> 
		private Dropdown Country
		{
			get { return new Dropdown("Country", "//div[contains(@id, 'pnlDetails')]//select[@id=//label[contains(text(), 'Country:')]/@for]", 0, false); }
		}

		/// <summary>
		/// Gets PrivacyPolicy Checkbox
		/// </summary> 
		private Checkbox PrivacyPolicy
		{
			get { return new Checkbox("PrivacyPolicy", "//input[contains(@id, 'privacypolicy') and @type='checkbox']", 0, false); }
		}

		/// <summary>
		/// Gets TermsAndConditions Checkbox
		/// </summary> 
		private Checkbox TermsAndConditions
		{
			get { return new Checkbox("TermsAndConditions", "//input[contains(@id, 'termsconditions') and @type='checkbox']", 0, false); }
		}

		/// <summary>
		/// Gets SignUp Button
		/// </summary> 
		private Button SignUp
		{
			get { return new Button("SignUp", "//input[contains(@value, 'Sign up')]", 0, false); }
		}

	}
}
	
