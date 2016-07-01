using System.Collections.Generic;
using Core;
using Core.Configuration;
using Core.Logger;
using Core.Users;
using NUnit.Framework;
using PageObjects.PageObjects;
using TechTalk.SpecFlow;

namespace Spec
{
	[Binding]
	public static class TestBase
	{
		[BeforeFeature("Articles")]
		[BeforeFeature("ChangePassword")]
		[BeforeFeature("MyClippings")]
		public static void BeforeFeature()
		{
			Credentials credentials = new LoginPage().CreateFreeTrialAccount();
			FeatureContext.Current.Add("Credentials", credentials);
			Logger.Info("Before scenario end.");
		}

		/// <summary>
		/// This flag is used for After Scenario execution. It should be executed when flag is set as true.
		/// </summary>
		private static bool runAfterScenario = false;

		/// <summary>
		/// This method is being run before every test scenario.
		/// </summary>
		[BeforeScenario]
		public static void BeforeScenario()
		{
			if (CanTestRun())
			{
				Logger.Info(string.Format("Opening {0} url address for scenario: {1}. Running with category: {2}", ApplicationConfiguration.Url, ScenarioContext.Current.ScenarioInfo.Title, ApplicationConfiguration.TestDataKey));
				WebBrowser.Open(ApplicationConfiguration.Url);

				runAfterScenario = true;
			}
			else
			{
				MarkTestAsNotRun();
			}
		}

		/// <summary>
		/// This method is being run after every test scenario.
		/// </summary>
		[AfterScenario]
		public static void AfterScenario()
		{
			if (runAfterScenario)
			{
				if (ScenarioContext.Current.TestError != null)
				{
					Logger.TakeScreenshot(ScenarioContext.Current.ScenarioInfo.Title);
				}

				WebBrowser.Close();
				WebBrowser.DriverRunning = false;
			}
		}

		[AfterTestRun]
		public static void AfterTests()
		{
			Logger.SaveLog();
			WebBrowser.Close();
		}

		/// <summary>
		/// Checks if current test should be run for current site.
		/// </summary>
		/// <returns>Returns true if current test should be run for current site.</returns>
		private static bool CanTestRun()
		{
			var categories = new List<string>();
			categories.AddRange(ScenarioContext.Current.ScenarioInfo.Tags);
			categories.AddRange(FeatureContext.Current.FeatureInfo.Tags);

			return categories.Contains(ApplicationConfiguration.TestDataKey);
		}

		/// <summary>
		/// Marks the test as Not Run.
		/// </summary>
		private static void MarkTestAsNotRun()
		{
			Assert.Inconclusive(string.Format("SKIPPED: there is no '@{0}' tag.", ApplicationConfiguration.TestDataKey));
		}

		/// <summary>
		/// Marks the test as Ignored.
		/// </summary>
		private static void MarkTestAsIgnored()
		{
			Assert.Ignore(string.Format("IGNORED."));
		}
	}
}
