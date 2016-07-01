using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects.PageObjects
{
	public partial class InterviewsPage : PageBase
	{
		public bool IsDisplayedCorrectly()
		{
			return this.Interviews.IsFound;
		}
	}
}
