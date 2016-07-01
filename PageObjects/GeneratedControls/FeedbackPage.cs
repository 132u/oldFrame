// -----------------------------------------------------------------------
// <copyright file="FeedbackPage.cs" company="Euromoney">
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
	/// Initializes a new instance of the FeedbackPage class
	/// </summary>
	public partial class FeedbackPage 
	{	
		public FeedbackPage(bool optional=false)
		{
			this.Optional = optional;
		}


		/// <summary>
		/// Gets Header HeaderComponent
		/// </summary> 
		public HeaderComponent Header
		{
			get { return new HeaderComponent(); }
		}

		/// <summary>
		/// Gets Footer FooterComponent
		/// </summary> 
		public FooterComponent Footer
		{
			get { return new FooterComponent(); }
		}

		/// <summary>
		/// Gets SidePanel SidePanelComponent
		/// </summary> 
		public SidePanelComponent SidePanel
		{
			get { return new SidePanelComponent(); }
		}

		/// <summary>
		/// Gets TopMenu TopMenuComponent
		/// </summary> 
		public TopMenuComponent TopMenu
		{
			get { return new TopMenuComponent(); }
		}

		/// <summary>
		/// Gets Breadcrumb BreadcrumbComponent
		/// </summary> 
		public BreadcrumbComponent Breadcrumb
		{
			get { return new BreadcrumbComponent(); }
		}

		/// <summary>
		/// Gets FullName Label
		/// </summary> 
		private Label FullName
		{
			get { return new Label("FullName", "//label[text()='Full Name']", 0, false); }
		}

		/// <summary>
		/// Gets Email Label
		/// </summary> 
		private Label Email
		{
			get { return new Label("Email", "//label[text()='Email']", 0, false); }
		}

		/// <summary>
		/// Gets Send Button
		/// </summary> 
		private Button Send
		{
			get { return new Button("Send", "//input[contains(@id, 'Send')]", 0, false); }
		}

		/// <summary>
		/// Gets FeedbackForm list
		/// </summary>
		public RequiredElements FeedbackForm
		{
			get
			{
				return new RequiredElements
				{
					Name = "FeedbackForm",
					Xpath = "//fieldset",
					Filter = "legend",
					Optional = false,
					List = new List<Element>
					{
						new Element
						{
							Name = "legend",
							Type = "legend",
							Attributes = new Dictionary<string, string>
							{
								{"innerText","Search"}
							}
						}, new Element
						{
							Name = "legend",
							Type = "legend",
							Attributes = new Dictionary<string, string>
							{
								{"innerText","Contact us"}
							}
						}
					}
				};
			}
		}

	}
}
	
