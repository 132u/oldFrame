// -----------------------------------------------------------------------
// <copyright file="Button.cs" company="Euromoney">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Core.Controls
{
	using Core.Logger;

	/// <summary>
	/// Button class.
	/// </summary>
	public class Button : ControlBase
	{
		/// <summary>
		/// Initializes a new instance of the Button class.
		/// </summary>
		/// <param name="name">Control name.</param>
		/// <param name="xpath">Control xpath.</param>
		/// <param name="timeout">Control timeout.</param>
		/// <param name="optional">Is control optional.</param>
		public Button(string name, string xpath, int timeout, bool optional)
			: base(name, xpath, timeout, optional)
		{
		}

		/// <summary>
		/// Click action.
		/// </summary>
		public void Click()
		{
			Logger.Info(string.Format("Try to click button {0}.", this.XPath));

			if (!this.IsFound)
			{
				this.ControlNotFound();
			}

			WebElement.Click();
			Logger.Info(string.Format("Button {0} clicked.", this.XPath));
		}
	}
}