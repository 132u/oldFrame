// -----------------------------------------------------------------------
// <copyright file="Dropdown.cs" company="Euromoney">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Core.Controls
{
	using System.Collections.Generic;
	using System.Linq;
	using Core.Configuration;
	using Core.Helpers;
	using Core.Logger;
	using OpenQA.Selenium;

	/// <summary>
	/// Dropdown class.
	/// </summary>
	public class Dropdown : ControlBase
	{
		/// <summary>
		/// Initializes a new instance of the Dropdown class.
		/// </summary>
		/// <param name="name">Control name.</param>
		/// <param name="xpath">Control xpath.</param>
		/// <param name="timeout">Control timeout.</param>
		/// <param name="optional">Is control optional.</param>
		public Dropdown(string name, string xpath, int timeout, bool optional)
			: base(name, xpath, timeout, optional)
		{
		}

		/// <summary>
		/// Gets dropdown options.
		/// </summary>
		public IList<Option> Options
		{
			get
			{
				List<Option> options = new List<Option>();
				IList<IWebElement> listOfOptions = WebBrowser.Driver.FindElements(By.XPath(this.XPath + "/option"));

				foreach (IWebElement element in listOfOptions)
				{
					Logger.Info(string.Format("Dropdown {0}: {1} options found.", this.XPath, element.Text));
					options.Add(new Option(element.Text, element.GetAttribute("value"), element.Selected));
				}

				return options;
			}
		}

		/// <summary>
		/// Get selected item text.
		/// </summary>
		/// <returns>Item text.</returns>
		public string GetSelectedOptionText()
		{
			Logger.Info(string.Format("Dropdown {0} getting selected option.", this.XPath));
			return WebBrowser.Driver.FindElement(By.XPath(this.XPath + "/option[@selected='selected']")).Text;
		}

		/// <summary>
		/// Select item by text.
		/// </summary>
		/// <param name="text">Option text.</param>
		public void SelectItemByText(string text)
		{
			Logger.Info(string.Format("Dropdown {0} selecting item by text: {1}.", this.XPath, text));
			WebBrowser.Driver.FindElement(By.XPath(string.Format("{0}/option[text()='{1}']", this.XPath, text))).Click();
		}

		public void SelectItemByTextNormalizeSpaces(string text)
		{
			Logger.Info(string.Format("Dropdown {0} selecting item by text: {1}.", this.XPath, text));
			WebBrowser.Driver.FindElement(By.XPath(string.Format("{0}/option[normalize-space(text())='{1}']", this.XPath, text))).Click();
		}

		/// <summary>
		/// Select item by value.
		/// </summary>
		/// <param name="value">Value to search for.</param>
		public void SelectItemByValue(string value)
		{
			Logger.Info(string.Format("Dropdown {0} selecting item by value: {1}.", this.XPath, value));
			WebBrowser.Driver.FindElement(By.XPath(string.Format("{0}/option[@value='{1}']", this.XPath, value))).Click();
		}

		/// <summary>
		/// Option exist.
		/// </summary>
		/// <param name="text">Option's text.</param>
		/// <returns>True if option exist, false if not.</returns>
		public bool FindIfOptionExistByText(string text)
		{
			Logger.Info(string.Format("Dropdown {0} check if option: {1} exist.", this.XPath, text));

			if (this.Options.Any(o => o.Text == text))
			{
				Logger.Info(string.Format("Option: {0} exist.", text));
				return true;
			}
			else
			{
				Logger.Info(string.Format("Option: {0} doesn't exist.", text));
				return false;
			}
		}
	}
}