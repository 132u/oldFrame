using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Controls;

namespace PageObjects.PageObjects
{
	public partial class CheckoutSelectionPage : PageBase
	{
		public LoginRegisterPage SelectBasicSubscription()
		{
			this.Next.Click();
			return new LoginRegisterPage();
		}

		public LoginRegisterPage SelectBasicSubscription(int quantity)
		{
			this.QuantityOpener.Click();

			Link value = new Link("Quantity", string.Format("//a[contains(@href, 'QuantityControl') and text()='{0}']", quantity), 5, false);
			value.Click();
			this.Next.Click();

			return new LoginRegisterPage();
		}
	}
}
