// -----------------------------------------------------------------------
// <copyright file="Textbox.cs" company="Euromoney">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Core.Controls
{
	using Core.Logger;
	using OpenQA.Selenium;

	/// <summary>
	/// Textbox class.
	/// </summary>
	public class Textbox : ControlBase
	{
		/// <summary>
		/// Text box value.
		/// </summary>
		private const string TextAttributeName = "value";

		/// <summary>
		/// Initializes a new instance of the Textbox class.
		/// </summary>
		/// <param name="name">Control name.</param>
		/// <param name="xpath">Control xpath.</param>
		/// <param name="timeout">Control timeout.</param>
		/// <param name="optional">Is control optional.</param>
		public Textbox(string name, string xpath, int timeout, bool optional)
			: base(name, xpath, timeout, optional)
		{
		}

		/// <summary>
		/// Gets or sets a value that is text from textbox.
		/// </summary>
		public virtual string Text
		{
			get
			{
				if (!this.IsFound)
				{
					this.ControlNotFound();
				}

				Logger.Info(string.Format("TextBox {0}, gets Text value.", this.XPath));
				return WebElement.GetAttribute(TextAttributeName);
			}

			set
			{
				if (!this.IsFound)
				{
					this.ControlNotFound();
				}

				Logger.Info(string.Format("TextBox {0}, set Text value.", this.XPath));
				WebElement.Clear();
				WebElement.Click();
				WebElement.SendKeys(value);
				Logger.Info(string.Format("TextBox {0}, Text value set.", this.XPath));
			}
		}

		/// <summary>
		/// Click on the WebElement.
		/// </summary>
		public void Clear()
		{
			if (!this.IsFound)
			{
				this.ControlNotFound();
			}

			Logger.Info(string.Format("Clear TextBox {0}.", this.XPath));
			WebElement.Click();
			WebElement.Clear();
			Logger.Info(string.Format("extBox {0} cleared.", this.XPath));
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

			Logger.Info(string.Format("Try to click TextBox {0}.", this.XPath));
			WebElement.Click();
			Logger.Info(string.Format("TextBox {0}, clicked.", this.XPath));
		}

		/// <summary>
		/// Press enter.
		/// </summary>
		public void Enter()
		{
			if (!this.IsFound)
			{
				this.ControlNotFound();
			}

			Logger.Info(string.Format("TextBox {0}, send Enter key.", this.XPath));
			WebElement.SendKeys(Keys.Enter);
			Logger.Info(string.Format("TextBox {0}, Enter key sent.", this.XPath));
		}
	}
}