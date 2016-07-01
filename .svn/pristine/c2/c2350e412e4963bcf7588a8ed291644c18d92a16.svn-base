// -----------------------------------------------------------------------
// <copyright file="Image.cs" company="Euromoney">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Core.Controls
{
	using Core.Logger;

	/// <summary>
	/// Image class.
	/// </summary>
	public class Image : ControlBase
	{
		/// <summary>
		/// Initializes a new instance of the Image class.
		/// </summary>
		/// <param name="name">Control name.</param>
		/// <param name="xpath">Control xpath.</param>
		/// <param name="timeout">Control timeout.</param>
		/// <param name="optional">Is control optional.</param>
		public Image(string name, string xpath, int timeout, bool optional)
			: base(name, xpath, timeout, optional)
		{
		}

		/// <summary>
		/// Gets the Url.
		/// </summary>
		public string Url
		{
			get
			{
				if (!this.IsFound)
				{
					this.ControlNotFound();
				}

				Logger.Info(string.Format("Image {0}, gets Url attribute.", this.XPath));
				return WebElement.GetAttribute("href");
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

				Logger.Info(string.Format("Image {0}, gets Target attribute.", this.XPath));
				return WebElement.GetAttribute("target");
			}
		}

		/// <summary>
		/// Gets SRC attribute value.
		/// </summary>
		public string Src
		{
			get
			{
				if (!this.IsFound)
				{
					this.ControlNotFound();
				}

				Logger.Info(string.Format("Image {0}, gets SRC attribute.", this.XPath));
				return WebElement.GetAttribute("src");
			}
		}

		/// <summary>
		/// Gets alt attribute value.
		/// </summary>
		public string Alt
		{
			get
			{
				if (!this.IsFound)
				{
					this.ControlNotFound();
				}

				Logger.Info(string.Format("Image {0}, gets Alt attribute.", this.XPath));
				return WebElement.GetAttribute("alt");
			}
		}

		/// <summary>
		/// Gets alt attribute value.
		/// </summary>
		public int Width
		{
			get
			{
				if (!this.IsFound)
				{
					this.ControlNotFound();
				}

				Logger.Info(string.Format("Image {0}, gets Width attribute.", this.XPath));
				return WebElement.Size.Width;
			}
		}

		/// <summary>
		/// Gets alt attribute value.
		/// </summary>
		public int Height
		{
			get
			{
				if (!this.IsFound)
				{
					this.ControlNotFound();
				}

				Logger.Info(string.Format("Image {0}, gets Height attribute.", this.XPath));
				return WebElement.Size.Height;
			}
		}
	}
}