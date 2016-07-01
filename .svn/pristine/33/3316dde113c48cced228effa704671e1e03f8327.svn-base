using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects.PageObjects
{
	public partial class FreeTrialZeroStep : PageBase
	{
		public bool IsDisplayedCorrectly()
		{
			return (this.RegisterHereForAFreeTrial.IsFound);
		}

		public FreeTrialStepOnePage NavigateToStepOne()
		{
			this.Next.Click();
			return new FreeTrialStepOnePage();
		}
	}
}
