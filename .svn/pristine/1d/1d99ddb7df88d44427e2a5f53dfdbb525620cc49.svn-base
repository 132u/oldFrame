using Core;

namespace PageObjects.PageObjects
{
	public partial class SubscribeNBOCheckoutStepOnePage : PageBase
	{
		/// <summary>
		/// Check if current page is displayed.
		/// </summary>
		/// <returns>Returns true if current page is displayed.</returns>
		public bool IsDisplayedCorrectly()
		{
			return (this.CompareLists(this.SubscribeNBOCheckoutStepOneRegistrationPanel)
				&& this.CompareLists(this.SubscribeNBOCheckoutStepOneToolbar))
				&& this.CompareLists(this.SubscribeNBOCheckoutStepOneFooterLinks);
		}
	}
}
