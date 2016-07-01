// -----------------------------------------------------------------------
// <copyright file="MessageBox.cs" company="Euromoney">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Core.Controls
{
	using Core.Logger;
	using OpenQA.Selenium;

	/// <summary>
	/// MessageBox class.
	/// </summary>
	public class MessageBox
	{
		/// <summary>
		/// MessageBox object.
		/// </summary>
		private IAlert alert;

		/// <summary>
		/// Initializes a new instance of the MessageBox class.
		/// </summary>
		public MessageBox()
		{
			Logger.Info("Try to initialize Message box.");
			this.alert = WebBrowser.Driver.SwitchTo().Alert();
			Logger.Info("Message box initialized.");
		}

		/// <summary>
		/// Gets alert text.
		/// </summary>
		public string Text
		{
			get
			{
				Logger.Info("Message box, gets Text attribute.");
				return this.alert.Text;
			}
		}

		/// <summary>
		/// Gets value attribute.
		/// </summary>
		public string Value
		{
			get
			{
				Logger.Info("Message box, gets Value attribute.");
				return this.alert.Text;
			}
		}

		/// <summary>
		/// Accept messageBox.
		/// </summary>
		public void Accept()
		{
			Logger.Info("Try to accept message box.");
			this.alert.Accept();
			Logger.Info("Message box accepted.");
		}
	}
}