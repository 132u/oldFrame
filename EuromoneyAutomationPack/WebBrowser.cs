// -----------------------------------------------------------------------
// <copyright file="WebBrowser.cs" company="Euromoney">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Core
{
	using System;
	using System.Collections.ObjectModel;
	using System.Text;
	using System.Web;
	using Core.Configuration;
	using Core.Helpers;
	using OpenQA.Selenium;
	using OpenQA.Selenium.Firefox;
	using OpenQA.Selenium.PhantomJS;

	/// <summary>
	/// Web Browser class.
	/// </summary>
	public static class WebBrowser
	{
		/// <summary>
		/// Gets or sets web driver.
		/// </summary>
		public static IWebDriver Driver { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether web driver is running.
		/// </summary>
		public static bool DriverRunning { get; set; }

		/// <summary>
		/// Gets page source.
		/// </summary>
		public static string PageSource
		{
			get
			{
				return HttpUtility.HtmlDecode(Driver.PageSource);
			}
		}

		/// <summary>
		/// Gets url address value from the browser.
		/// </summary>
		public static string GetUrlAddress
		{
			get { return Driver.Url; }
		}

		/// <summary>
		/// Open a browser and navigate to url.
		/// </summary>
		/// <param name="url">Navigate to site.</param>
		public static void Open(string url)
		{
			if (!DriverRunning)
			{
				switch (ApplicationConfiguration.Browser)
				{
					case "FireFox":
					case "Firefox":
						Logger.Logger.Info("Open Firefox browser");
						Driver = new FirefoxDriver();
						Driver.Manage().Window.Maximize();
						Driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 0, ApplicationConfiguration.ImplicitlyWait));
						break;
					case "PhantomJS":
						Logger.Logger.Info("Open PhantomJS browser");
						Driver = new PhantomJSDriver();
						Driver.Manage().Window.Maximize();
						Driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 0, ApplicationConfiguration.ImplicitlyWait));
						break;
					default:
						Driver = null;
						Logger.Logger.Error("WebDriver have not been initialized.");
						throw new ArgumentOutOfRangeException("Browser: " + ApplicationConfiguration.Browser + " is not available");
				}

				DriverRunning = true;
			}

			Logger.Logger.Info("Navigate to url: " + url);
			Driver.Navigate().GoToUrl(url);
		}

		/// <summary>
		/// This method executes java script that will hide required element on the site.
		/// </summary>
		/// <param name="selector">Describes element which will be hidden.</param>
		public static void HideElement(string selector)
		{
			IJavaScriptExecutor driverForJS = Driver as IJavaScriptExecutor;
			driverForJS.ExecuteScript(string.Format("$('{0}'.hide()", selector));

			Logger.Logger.Info(string.Format("Element described by selector as \"{0}\" was hidden."));
		}

		/// <summary>
		/// This method executes java script that will show required element on the site.
		/// </summary>
		/// <param name="selector">Describes element which will be shown.</param>
		public static void ShowElement(string selector)
		{
			IJavaScriptExecutor driverForJS = Driver as IJavaScriptExecutor;
			driverForJS.ExecuteScript(string.Format("$('{0}'.show()", selector));

			Logger.Logger.Info(string.Format("Element described by selector as \"{0}\" was shown."));
		}

		public static void CleanCache()
		{
			Driver.Manage().Cookies.DeleteAllCookies();
		}

		/// <summary>
		/// Close browser.
		/// </summary>
		public static void Close()
		{
			Logger.Logger.Info("Close browser");
			WebBrowser.Driver.Quit();
			DriverRunning = false;
		}

		public static void SwitchToPopup()
		{
			string currentHandle = Driver.CurrentWindowHandle;
			string popupHandle = string.Empty;
			ReadOnlyCollection<string> windowHandles = Driver.WindowHandles;

			foreach (string handle in windowHandles)
			{
				if (handle != currentHandle)
				{
					popupHandle = handle;
					break;
				}
			}

			Driver.SwitchTo().Window(popupHandle);
		}

		public static void SwitchToFrame(string xpath)
		{
			Logger.Logger.Info("Switch to frame: " + xpath);
			if (!string.IsNullOrEmpty(xpath))
			{
				IWebElement frame = Driver.FindElement(By.XPath(xpath));
				Driver.SwitchTo().Frame(frame);
			}
		}

		public static void SwitchToDefaultFrame()
		{
			Logger.Logger.Info("Switch to default frame");
			Driver.SwitchTo().DefaultContent();
		}

		public static void ReturnBack()
		{
			Driver.Navigate().Back();
		}
	}
}