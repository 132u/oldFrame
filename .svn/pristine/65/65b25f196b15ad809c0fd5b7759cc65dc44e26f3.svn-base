using System;
using NUnit.Framework;
using PageObjects.PageObjects;
using TechTalk.SpecFlow;

namespace Spec.Subscription
{
	[Binding]
	public class ValidationSteps
	{
		public SubscribeStepTwoPage War = new SubscribeStepTwoPage();
		public SubscribeStepThreePage Step3 = new SubscribeStepThreePage();
		[Given(@"I fill ""(.*)"" in email field, press Next button")]
		public void GivenIFillInEmailFieldPressNextButton(string p0)
		{
			new HomePage()
						.Header
						.NavigateToInvestHedgeSubscribePage()
						.NavigateToTheSubscribeStepTwoPage()
						.TypeInvalidEmail(p0);
		}

		[Then(@"warnings appears")]
		public void ThenAppears()
		{
			 Assert.IsTrue(this.War.WarningMessage1IsDisplayedCorrectly(), "Warnming for first email is not displayed");
			 Assert.IsTrue(this.War.WarningMessage2IsDisplayedCorrectly(), "Warnming for second email is not displayed");
		}

		[Given(@"I don't type value in email field, press Next button")]
		public void GivenIDonTTypeValueInEmailFieldPressNextButton()
		{
			new HomePage()
						.Header
						.NavigateToInvestHedgeSubscribePage()
						.NavigateToTheSubscribeStepTwoPage()
						.TypeInvalidEmail(string.Empty);
		}

		[Then(@"warning message that email and compare email are empty appears")]
		public void ThenWarningMessageThatEmailAndCompareEmailAreEmptyAppears()
		{
			Assert.IsTrue(this.War.WarningMessageEmptyEmailIsDisplayedCorrectly(), "Warnming for 1st email is not displayed");
			Assert.IsTrue(this.War.WarningMessageEmptyCompareEmailIsDisplayedCorrectly(), "Warnming for second email is not displayed");
		}

		[When(@"I fill ""(.*)"" in ""(.*)"", press Next button")]
		public void WhenIFillInPressNextButton(string p0, string p1)
		{
			this.Step3.TypeVaueInField(p1, p0).PressNextButton();
		}

		[Then(@"Warning message for first name field appears")]
		public void ThenWarningMessageForFirstNameFieldAppears()
		{
			Assert.IsTrue(this.Step3.WarningMessageInvalidFirstNameIsDisplayedCorrectly(), "Warnming for First Name is not displayed");
		}

		[Then(@"Warning message for ""(.*)"" appears")]
		public void ThenWarningMessageForAppears(string p0)
		{
			switch (p0)
			{
				case "FirstName":
					Assert.IsTrue(this.Step3.WarningMessageInvalidFirstNameIsDisplayedCorrectly(), "warning message for " + p0 + " is not found");
					break;
				case "LastName":
					Assert.IsTrue(this.Step3.WarningMessageInvalidLastNameIsDisplayedCorrectly(), "warning message for " + p0 + " is not found");
					break;
				case "CompanyName":
					Assert.IsTrue(this.Step3.WarningMessageInvalidCompanyNameIsDisplayedCorrectly(), "warning message for " + p0 + " is not found");
					break;
			}
		}

		[When(@"I don't fill  in ""(.*)"", press Next button")]
		public void WhenIDonTFillInPressNextButton(string p0)
		{
			this.Step3.TypeVaueInField(string.Empty, p0).PressNextButton();
		}

		[Then(@"Warning message empty value for ""(.*)"" appears")]
		public void ThenWarningMessageEmptyValueForAppears(string p0)
		{
			switch (p0)
			{
				case "FirstName":
					Assert.IsTrue(this.Step3.WarningMessageEmptyFirstNameIsDisplayedCorrectly(), "warning message for " + p0 + " is not found");
					break;
				case "LastName":
					Assert.IsTrue(this.Step3.WarningMessagEmptyLastNameIsDisplayedCorrectly(), "warning message for " + p0 + " is not found");
					break;
				case "CompanyName":
					Assert.IsTrue(this.Step3.WarningMessageEmptyCompanyNameIsDisplayedCorrectly(), "warning message for " + p0 + " is not found");
					break;
				case "City":
					Assert.IsTrue(this.Step3.WarningMessageEmptyCityIsDisplayedCorrectly(), "warning message for " + p0 + " is not found");
					break;
				case "Zip":
					Assert.IsTrue(this.Step3.WarningMessageEmptyZipIsDisplayedCorrectly(), "warning message for " + p0 + " is not found");
					break;
			}
		}
	}
}
