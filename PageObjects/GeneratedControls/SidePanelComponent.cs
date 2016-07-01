// -----------------------------------------------------------------------
// <copyright file="SidePanelComponent.cs" company="Euromoney">
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
	/// Initializes a new instance of the SidePanelComponent class
	/// </summary>
	public partial class SidePanelComponent 
	{	
		public SidePanelComponent(bool optional=false)
		{
			this.Optional = optional;
		}


		/// <summary>
		/// Gets SidePanelDefaultRequiredElements list
		/// </summary>
		public RequiredElements SidePanelDefaultRequiredElements
		{
			get
			{
				return new RequiredElements
				{
					Name = "SidePanelDefaultRequiredElements",
					Xpath = "//ul[@class='tabs']",
					Filter = "a",
					Optional = false,
					List = new List<Element>
					{
						new Element
						{
							Name = "a",
							Type = "Link",
							Attributes = new Dictionary<string, string>
							{
								{"href","javascript:void(0);"},
								{"id","ctl00_RightZone_ctl04_hlMostRead"},
								{"innerText","Most read"}
							}
						}, new Element
						{
							Name = "a",
							Type = "Link",
							Attributes = new Dictionary<string, string>
							{
								{"href","javascript:void(0);"},
								{"id","ctl00_RightZone_ctl04_hlMostEmailed"},
								{"innerText","Most emailed"}
							}
						}
					}
				};
			}
		}

		/// <summary>
		/// Gets SidePanelArticlesPageRequiredElements list
		/// </summary>
		public RequiredElements SidePanelArticlesPageRequiredElements
		{
			get
			{
				return new RequiredElements
				{
					Name = "SidePanelArticlesPageRequiredElements",
					Xpath = "//div[@class='secondary_content']",
					Filter = "h2",
					Optional = true,
					List = new List<Element>
					{
						
					}
				};
			}
		}

	}
}
	
