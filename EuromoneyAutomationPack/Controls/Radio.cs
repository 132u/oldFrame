// -----------------------------------------------------------------------
// <copyright file="Radio.cs" company="Euromoney">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Core.Controls
{
	using Core.Logger;

	/// <summary>
	/// Radio class.
	/// </summary>
	public class Radio : ControlBase
	{
		/// <summary>
		/// Initializes a new instance of the Radio class.
		/// </summary>
		/// <param name="name">Control name.</param>
		/// <param name="xpath">Control xpath.</param>
		/// <param name="timeout">Control timeout.</param>
		/// <param name="optional">Is control optional.</param>
		public Radio(string name, string xpath, int timeout, bool optional)
			: base(name, xpath, timeout, optional)
		{
		}

		/// <summary>
		/// Gets a value indicating whether radio button is selected.
		/// </summary>
		public bool IsSelected
		{
			get
			{
				if (!this.IsFound)
				{
					this.ControlNotFound();
				}

				Logger.Info(string.Format("Radio {0} initialized.", this.XPath));
				return WebElement.Selected;
			}
		}

		/// <summary>
		/// Select radio button.
		/// </summary>
		public void Select()
		{
			if (!this.IsFound)
			{
				this.ControlNotFound();
			}

			Logger.Info(string.Format("Radio {0}, try to select element.", this.XPath));
			if (!this.WebElement.Selected)
			{
				this.WebElement.Click();
				Logger.Info(string.Format("Radio {0} selected.", this.XPath));
			}
			else
			{
				Logger.Warning(string.Format("Radio {0} have already been selected.", this.XPath));
			}
		}
	}
}