// -----------------------------------------------------------------------
// <copyright file="SectorsPage.cs" company="Euromoney">
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
	/// Initializes a new instance of the SectorsPage class
	/// </summary>
	public partial class SectorsPage 
	{	
		public SectorsPage(bool optional=false)
		{
			this.Optional = optional;
		}


		/// <summary>
		/// Gets Sectors Label
		/// </summary> 
		private Label Sectors
		{
			get { return new Label("Sectors", "//h2//a[contains(text(), 'Management issues')]", 0, false); }
		}

	}
}
	
