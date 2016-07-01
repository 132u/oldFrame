using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects.PageObjects
{
	public partial class SignUpSuccessfulPage : PageBase
	{
		public bool SignUpSuccessfulMessageIsDisplayed()
		{
			return this.SuccessfulMessage.IsFound;
		}
	}
}
