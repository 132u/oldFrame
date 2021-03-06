// -----------------------------------------------------------------------
// <copyright file="ManageYourAddressesPage.cs" company="Euromoney">
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
	/// Initializes a new instance of the ManageYourAddressesPage class
	/// </summary>
	public partial class ManageYourAddressesPage 
	{	
		public ManageYourAddressesPage(bool optional=false)
		{
			this.Optional = optional;
		}


		/// <summary>
		/// Gets AddNewAddress Label
		/// </summary> 
		private Label AddNewAddress
		{
			get { return new Label("AddNewAddress", "//notSet", 0, false); }
		}

	}
}
	
