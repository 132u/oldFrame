using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using ConfigManager;

namespace PageElementsCheck
{
	public partial class PageElementsCheck : Form
	{
		public PageElementsCheck()
		{
			InitializeComponent();
		}

		private void BtnSearch_Click(object sender, EventArgs e)
		{
			this.webBrowser.Navigate(this.txtAddress.Text);
		}

		private void BtnRun_Click(object sender, EventArgs e)
		{
			string output = string.Empty;

			try
			{
				string pageSource = HttpUtility.HtmlDecode(this.webBrowser.DocumentText);
				output = ConfigManager.ConfigManager.CreateListOfElements("Test", pageSource, this.txtSearchXPath.Text, this.txtFilter.Text);
				this.txtConfigOutput.Text = output;

				XmlDocument doc = new XmlDocument();
				doc.LoadXml(output);
				int numberOfElmentsFound = doc.SelectNodes("//Element").Count;
				this.lblGeneratedConfig.Text += ", elements found: " + numberOfElmentsFound.ToString();
			}
			catch (XPathException)
			{
				MessageBox.Show("Wrong xpath");
			}
			catch (NullReferenceException)
			{
				this.txtConfigOutput.Text = "No results";
			}
		}
	}
}
