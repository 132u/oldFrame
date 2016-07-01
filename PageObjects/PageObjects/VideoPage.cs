using Core;

namespace PageObjects.PageObjects
{
	public partial class VideoPage : PageBase
	{
		/// <summary>
		/// Check if current page is displayed.
		/// </summary>
		/// <returns>Returns true if current page is displayed.</returns>
		public bool IsDisplayedCorrectly()
		{
			return this.CompareLists(this.VideoPageRequiredElements);
		}
	}
}
