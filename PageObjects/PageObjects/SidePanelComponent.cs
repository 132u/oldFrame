using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace PageObjects.PageObjects
{
	public partial class SidePanelComponent : PageBase
	{
		public override bool PageIsVisible(string parameter = default(string))
		{
			if (parameter == "Default" || string.IsNullOrEmpty(parameter))
			{
				return this.CompareLists(this.SidePanelDefaultRequiredElements);
			}
			else if (parameter == "Article")
			{
				return this.CompareLists(this.SidePanelArticlesPageRequiredElements);
			}
			else
			{
				throw new ArgumentException("There is no side panel as provided in parameter");
			}
		}
	}
}
