using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace PageObjects.PageObjects
{
	public partial class HomePage : PageBase
	{
		public bool IsDisplayed()
		{
			return this.HomePageUniqueElement.IsFound;
		}

		/// <summary>
		/// Check if current page is displayed.
		/// </summary>
		/// <returns>Returns true if current page is displayed.</returns>
		public bool IsDisplayedCorrectly()
		{
			return this.HomePageUniqueElement.IsFound;
		}
	}
}
