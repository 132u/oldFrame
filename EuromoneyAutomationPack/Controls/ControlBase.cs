// -----------------------------------------------------------------------
// <copyright file="ControlBase.cs" company="Euromoney">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Core.Controls
{
	using System;
	using System.Threading;
	using Core.Configuration;
	using Core.Logger;
	using OpenQA.Selenium;
	using OpenQA.Selenium.Support.UI;

	/// <summary>
	/// Control base class.
	/// </summary>
	public class ControlBase
	{
		/// <summary>
		/// Initializes a new instance of the ControlBase class.
		/// </summary>
		/// <param name="name">Control name.</param>
		/// <param name="xpath">Control xpath.</param>
		/// <param name="timeout">Control timeout.</param>
		/// <param name="optional">Is control optional.</param>
		public ControlBase(string name, string xpath, int timeout, bool optional)
		{
			this.Name = name;
			this.XPath = xpath;
			this.Timeout = timeout;
			this.Optional = optional;

			try
			{
				WebDriverWait wait = new WebDriverWait(WebBrowser.Driver, TimeSpan.FromSeconds(this.Timeout));
				this.WebElement = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(this.XPath)));
			}
			catch (WebDriverTimeoutException)
			{
				Logger.Info(string.Format("Control: {0} WebDriverTimeoutException thrown.", this.Name));
				this.WebElement = null;
			}
			catch (NoSuchElementException)
			{
				Logger.Info(string.Format("Control: {0} NoSuchElementException thrown.", this.Name));
				this.WebElement = null;
			}
			catch (StaleElementReferenceException)
			{
				Logger.Warning(string.Format("Control: {0} StaleElementReferenceException thrown.", this.Name));
				Thread.Sleep(ApplicationConfiguration.StaleExceptionTiemout);
				this.WebElement = WebBrowser.Driver.FindElement(By.XPath(this.XPath));
			}
		}

		/// <summary>
		/// Gets name.
		/// </summary>
		public string Name { get; private set; }

		/// <summary>
		/// Gets XPath value.
		/// </summary>
		public string XPath { get; private set; }

		/// <summary>
		/// Gets WebElement.
		/// </summary>
		public IWebElement WebElement { get; private set; }

		/// <summary>
		/// Gets timeout.
		/// </summary>
		public int Timeout { get; private set; }

		/// <summary>
		/// Gets a value indicating whether optional parameter is true or false.
		/// </summary>
		public bool Optional { get; private set; }

		/// <summary>
		/// Gets a value indicating whether control exist on page or not.
		/// </summary>
		public bool IsFound
		{
			get
			{
				if (this.Optional)
				{
					Logger.Info("Control finding omitted because control is set as optional in configuration file.");
					return true;
				}

				Logger.Info(string.Format("Check if control name: {0}, xpath: {1} is found.", this.Name, this.XPath));
				return this.WebElement != null;
			}
		}

		public bool IsNotFound
		{
			get
			{
				if (this.WebElement == null)
				{
					Logger.Info(string.Format("Control name:{0}, xpath: {1} was not found.", this.Name, this.XPath));
					return true;
				}
				else
				{
					Logger.Info(string.Format("Control name:{0}, xpath: {1} was found.", this.Name, this.XPath));
					return false;
				}
			}
		}

		/// <summary>
		/// Act when control is not found.
		/// </summary>
		protected void ControlNotFound()
		{
			string message = string.Format("{0} {1} have not been found, thus action cannot be performed.", this.GetType().ToString(), this.XPath);
			Logger.Error(message);
			throw new NoSuchElementException(message);
		}

		/// <summary>
		/// Gets a value indicating whether it is disabled or not.
		/// </summary>
		public bool IsDisabled
		{
			get
			{
				if (this.WebElement.Enabled)
				{
					Logger.Info(string.Format("Control {0} is enabled.", this.XPath));
					return false;
				}
				else
				{
					Logger.Info(string.Format("Control {0} is disabled.", this.XPath));
					return true;
				}
			}
		}
	}
}
