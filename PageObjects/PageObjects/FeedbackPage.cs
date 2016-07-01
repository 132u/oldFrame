using Core;

namespace PageObjects.PageObjects
{
	public partial class FeedbackPage : PageBase
	{
		/// <summary>
		/// Check if current page is displayed.
		/// </summary>
		/// <returns>Returns true if current page is displayed.</returns>
		public bool IsDisplayedCorrectly()
		{
			return (this.Email.IsFound && this.FullName.IsFound && this.Send.IsFound);
		}
	}
}