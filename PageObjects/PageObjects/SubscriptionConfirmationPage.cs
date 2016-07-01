using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects.PageObjects
{
	public partial class SubscriptionConfirmationPage : PageBase
	{
		public bool IsDisplayed()
		{
			return (this.SelctedStep.IsFound);
		}
	}
}
