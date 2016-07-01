using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects.PageObjects
{
	public partial class SubscribtionZeroPage : PageBase
	{
		public SubscribeStepOnePage NavigateToStepOne()
		{
			this.EuroHedge.Click();
			return new SubscribeStepOnePage();
		}

		public SubscribeStepOnePage NavigateToAsiaHedgeStepOne()
		{
			this.AsiaHedge.Click();
			return new SubscribeStepOnePage();
		}

		public SubscribeStepOnePage NavigateToInvestHedgeStepOne()
		{
			this.InvestHedge.Click();
			return new SubscribeStepOnePage();
		}

		public SubscribeStepOnePage NavigateToAUStepOne()
		{
			this.AU.Click();
			return new SubscribeStepOnePage();
		}

		public SubscribeStepOnePage NavigateToARStepOne()
		{
			this.AR.Click();
			return new SubscribeStepOnePage();
		}
	}
}
