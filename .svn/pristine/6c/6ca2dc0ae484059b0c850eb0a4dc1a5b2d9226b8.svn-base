using Core;
using Core.Configuration;
using Core.Logger;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConfigFileCreator
{
	public class TestBase
	{
		/// <summary>
		/// Test context.
		/// </summary>
		private TestContext testContext;

		/// <summary>
		/// Gets or sets test Context.
		/// </summary>
		public TestContext TestContext
		{
			get { return this.testContext; }
			set { this.testContext = value; }
		}

		/// <summary>
		/// Assembly initialize.
		/// </summary>
		/// <param name="context">TestContext object.</param>
		[AssemblyInitialize]
		public static void AssemblyInit(TestContext context)
		{
			Logger.LogHeader();
			WebBrowser.Open(ApplicationConfiguration.Url);
		}

		/// <summary>
		/// Cleans up after assembly has ended.
		/// </summary>
		[AssemblyCleanup]
		public static void AssemblyClean()
		{
			Logger.LogFooter();
			WebBrowser.Close();
		}

		/// <summary>
		/// Initializes the tests. It is choosing the base url from the config file.
		/// </summary>
		[TestInitialize]
		public void TestInitialize()
		{
			Logger.TestHeader(TestContext.TestName);
		}

		/// <summary>
		/// Test cleanup.
		/// </summary>
		[TestCleanup]
		public void TestCleanup()
		{
			Logger.TestFooter(TestContext.CurrentTestOutcome.ToString());
			WebBrowser.Close();
		}
	}
}
