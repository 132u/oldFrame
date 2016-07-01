// -----------------------------------------------------------------------
// <copyright file="Label.cs" company="Euromoney">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Core.Controls
{
	using Core.Logger;

	/// <summary>
	/// Label class.
	/// </summary>
	public class Label : ControlBase
	{
		/// <summary>
		/// Initializes a new instance of the Label class.
		/// </summary>
		/// <param name="name">Control name.</param>
		/// <param name="xpath">Control xpath.</param>
		/// <param name="timeout">Control timeout.</param>
		/// <param name="optional">Is control optional.</param>
		public Label(string name, string xpath, int timeout, bool optional)
			: base(name, xpath, timeout, optional)
		{
		}

		public string Text
		{
			get
			{
				if (!this.IsFound)
				{
					this.ControlNotFound();
				}

				Logger.Info(string.Format("Label {0}, gets Text value.", this.XPath));
				return this.WebElement.Text;
			}
		}
	}
}