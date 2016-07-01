﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects.PageObjects
{
	public partial class EconomicsAndPolicyPage : PageBase
	{
		/// <summary>
		/// Check if current page is displayed.
		/// </summary>
		/// <returns>Returns true if current page is displayed.</returns>
		public bool IsDisplayedCorrectly()
		{
			return this.EconomicsAndPolicy.IsFound;
		}
	}
}
