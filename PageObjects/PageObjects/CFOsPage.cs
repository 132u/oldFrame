using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects.PageObjects
{
	public partial class CFOsPage : PageBase
	{
		public bool IsDisplayedCorrectly()
		{
			return this.CFOs.IsFound;
		}
	}
}
