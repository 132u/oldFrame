// -----------------------------------------------------------------------
// <copyright file="Link.cs" company="Euromoney">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Core.Controls
{
	using Core.Logger;
	using OpenQA.Selenium.Interactions;

	/// <summary>
	/// Link class.
	/// </summary>
	public class Link : ControlBase
	{
		/// <summary>
		/// Initializes a new instance of the Link class.
		/// </summary>
		/// <param name="name">Control name.</param>
		/// <param name="xpath">Control xpath.</param>
		/// <param name="timeout">Control timeout.</param>
		/// <param name="optional">Is control optional.</param>
		public Link(string name, string xpath, int timeout, bool optional)
			: base(name, xpath, timeout, optional)
		{
		}

		/// <summary>
		/// Gets Url.
		/// </summary>
		public string Url
		{
			get
			{
				if (!this.IsFound)
				{
					this.ControlNotFound();
				}

				Logger.Info(string.Format("Link {0}, gets URL attribute.", this.XPath));
				return WebElement.GetAttribute("href");
			}
		}

		/// <summary>
		/// Gets a value that is text from textbox.
		/// </summary>
		public virtual string Text
		{
			get
			{
				if (!this.IsFound)
				{
					this.ControlNotFound();
				}

				Logger.Info(string.Format("Link {0},  gets Text attribute.", this.XPath));
				return WebElement.Text;
			}
		}

		/// <summary>
		/// Gets Target attribute value.
		/// </summary>
		public string Target
		{
			get
			{
				if (!this.IsFound)
				{
					this.ControlNotFound();
				}

				Logger.Info(string.Format("Link {0},  gets Target attribute.", this.XPath));
				return WebElement.GetAttribute("target");
			}
		}

		/// <summary>
		/// Gets a value indicating whether element is enabled.
		/// </summary>
		public bool Enabled
		{
			get
			{
				if (!this.IsFound)
				{
					this.ControlNotFound();
				}

				Logger.Info(string.Format("Link {0},  check if link is enabled.", this.XPath));
				return !WebElement.GetAttribute("class").Contains("disabled");
			}
		}

		/// <summary>
		/// Gets value attribute.
		/// </summary>
		public string Value
		{
			get
			{
				if (!this.IsFound)
				{
					this.ControlNotFound();
				}

				Logger.Info(string.Format("Link {0},  gets Value attribute.", this.XPath));
				return WebElement.GetAttribute("value");
			}
		}

		/// <summary>
		/// Gets class attribute.
		/// </summary>
		public string Style
		{
			get
			{
				if (!this.IsFound)
				{
					this.ControlNotFound();
				}

				Logger.Info(string.Format("Link {0},  gets Style attribue.", this.XPath));
				return WebElement.GetAttribute("class");
			}
		}

		/// <summary>
		/// Click on the WebElement.
		/// </summary>
		public void Click()
		{
			if (!this.IsFound)
			{
				this.ControlNotFound();
			}

			Logger.Info(string.Format("Link {0},  try to click.", this.XPath));
			WebElement.Click();
			Logger.Info(string.Format("Link {0} clicked.", this.XPath));
		}

		/// <summary>
		/// Hover over the WebElement.
		/// </summary>
		public void Hover()
		{
			if (!this.IsFound)
			{
				this.ControlNotFound();
			}

			Logger.Info(string.Format("Try to hover over link {0}.", this.XPath));
			Actions actionBuilder = new Actions(WebBrowser.Driver);
			actionBuilder.MoveToElement(WebElement).Build().Perform();
			Logger.Info(string.Format("Link {0} hovered.", this.XPath));
		}
	}
}