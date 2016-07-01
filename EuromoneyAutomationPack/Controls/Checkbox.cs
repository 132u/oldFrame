// -----------------------------------------------------------------------
// <copyright file="Checkbox.cs" company="Euromoney">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Core.Controls
{
	using Core.Logger;

	/// <summary>
	/// Checkbox class.
	/// </summary>
	public class Checkbox : ControlBase
	{
		/// <summary>
		/// Initializes a new instance of the Checkbox class.
		/// </summary>
		/// <param name="name">Control name.</param>
		/// <param name="xpath">Control xpath.</param>
		/// <param name="timeout">Control timeout.</param>
		/// <param name="optional">Is control optional.</param>
		public Checkbox(string name, string xpath, int timeout, bool optional)
			: base(name, xpath, timeout, optional)
		{
		}

		/// <summary>
		/// Gets a value indicating whether checkbox is selected.
		/// </summary>
		public bool IsSelected
		{
			get
			{
				if (!this.IsFound)
				{
					this.ControlNotFound();
				}

				Logger.Info(string.Format("Checkbox {0} initialized.", this.XPath));
				return WebElement.Selected;
			}
		}

		/// <summary>
		/// Select checkbox.
		/// </summary>
		public void Select()
		{
			if (!this.IsFound)
			{
				this.ControlNotFound();
			}

			Logger.Info(string.Format("Checkbox {0}, try to select element.", this.XPath));
			if (!this.WebElement.Selected)
			{
				this.WebElement.Click();
				Logger.Info(string.Format("Checkbox {0} selected.", this.XPath));
			}
			else
			{
				Logger.Warning(string.Format("Checkbox {0} have already been selected.", this.XPath));
			}
		}

		/// <summary>
		/// Deselect checkbox button.
		/// </summary>
		public void Deselect()
		{
			if (!this.IsFound)
			{
				this.ControlNotFound();
			}

			Logger.Info(string.Format("Checkbox {0}, try to deselect element.", this.XPath));
			if (this.WebElement.Selected)
			{
				this.WebElement.Click();
				Logger.Info(string.Format("Checkbox {0} deselected.", this.XPath));
			}
			else
			{
				Logger.Warning(string.Format("Checkbox {0} have already been deselected.", this.XPath));
			}
		}

		/// <summary>
		/// Set checkbox value.
		/// </summary>
		/// <param name="value">Value to be set.</param>
		public void SetValue(bool value)
		{
			if (!this.IsFound)
			{
				this.ControlNotFound();
			}

			Logger.Info(string.Format("Checkbox {0}, try to set value of element.", this.XPath));
			if ((value == true && this.IsSelected) || (value == false && !this.IsSelected))
			{
				Logger.Info(string.Format("Checkbox {0} expected value already set.", this.XPath));
			}
			else if (value == true)
			{
				this.Select();
			}
			else
			{
				this.Deselect();
			}
		}
	}
}