// -----------------------------------------------------------------------
// <copyright file="ElementsHelper.cs" company="Euromoney">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Core.Helpers
{
	using OpenQA.Selenium;

	/// <summary>
	/// Elements helper class.
	/// </summary>
	public static class ElementsHelper
	{
		/// <summary>
		/// Count elements by XPath.
		/// </summary>
		/// <param name="xpath">XPath to search.</param>
		/// <returns>Number of element found.</returns>
		public static int CountElements(string xpath)
		{
			Logger.Logger.Info(string.Format("Counting elements of the following xpath: {0}", xpath));
			int count = WebBrowser.Driver.FindElements(By.XPath(xpath)).Count;
			Logger.Logger.Info(count + " elements found");
			return count;
		}
	}
}
