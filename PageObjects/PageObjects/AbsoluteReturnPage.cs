using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects.PageObjects
{
	public partial class AbsoluteReturnPage : PageBase
	{
		public SubscribeStepOnePage NavigateToStepOne()
		{
			this.Subscribe.Click();
			return new SubscribeStepOnePage();
		}
	}
}
