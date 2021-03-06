// -----------------------------------------------------------------------
// <copyright file="LoginRegisterPage.cs" company="Euromoney">
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
	/// Initializes a new instance of the LoginRegisterPage class
	/// </summary>
	public partial class LoginRegisterPage 
	{	
		public LoginRegisterPage(bool optional=false)
		{
			this.Optional = optional;
		}


		/// <summary>
		/// Gets NewEmail Textbox
		/// </summary> 
		private Textbox NewEmail
		{
			get { return new Textbox("NewEmail", "//input[contains(@name, 'txtNewEmail')]", 0, false); }
		}

		/// <summary>
		/// Gets Register Button
		/// </summary> 
		private Button Register
		{
			get { return new Button("Register", "//input[contains(@name,'btnRegister')]", 0, false); }
		}

		/// <summary>
		/// Gets InvalidEmailMessage Label
		/// </summary> 
		private Label InvalidEmailMessage
		{
			get { return new Label("InvalidEmailMessage", "//span[contains(@id, 'rfvNewEmail') and contains(@style, 'visible')]", 0, false); }
		}

	}
}
	
