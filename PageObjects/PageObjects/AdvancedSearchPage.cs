using Core;

namespace PageObjects.PageObjects
{
	public partial class AdvancedSearchPage : PageBase
	{
		public bool IsDisplayedCorrectly()
		{
			return (this.CompareLists(this.AdvancedSearchPageRequiredElements));
		}
	}
}
