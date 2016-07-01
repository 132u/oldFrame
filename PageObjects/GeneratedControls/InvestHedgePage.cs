// -----------------------------------------------------------------------
// <copyright file="InvestHedgePage.cs" company="Euromoney">
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
	/// Initializes a new instance of the InvestHedgePage class
	/// </summary>
	public partial class InvestHedgePage 
	{	
		public InvestHedgePage(bool optional=false)
		{
			this.Optional = optional;
		}


		/// <summary>
		/// Gets Subscribe Link
		/// </summary> 
		private Link Subscribe
		{
			get { return new Link("Subscribe", "//a[text()='Subscribe Now']", 0, false); }
		}

	}
}
	
