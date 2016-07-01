// -----------------------------------------------------------------------
// <copyright file="Logger.cs" company="Euromoney">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Core.Logger
{
	using System;
	using System.Diagnostics;
	using System.Drawing.Imaging;
	using System.IO;
	using Core;
	using Core.Configuration;
	using OpenQA.Selenium;

	/// <summary>
	/// TODO: Update summary.
	/// </summary>
	public class Logger
	{
		/// <summary>
		/// Gets or sets log content.
		/// </summary>
		private static string LogContent
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets start time.
		/// </summary>
		private static DateTime StartTime
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets end time.
		/// </summary>
		private static DateTime EndTime
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets test name.
		/// </summary>
		private static string TestName
		{
			get;
			set;
		}

		/// <summary>
		/// Add info message.
		/// </summary>
		/// <param name="value">Message value.</param>
		public static void Info(string value)
		{
			value = "Info: " + value;
			AddLine(value);
		}

		/// <summary>
		/// Add warning message.
		/// </summary>
		/// <param name="value">Message value.</param>
		public static void Warning(string value)
		{
			value = "Warning: " + value;
			AddLine(value);
		}

		/// <summary>
		/// Add error message.
		/// </summary>
		/// <param name="value">Message value.</param>
		public static void Error(string value)
		{
			value = "Error: " + value;
			AddLine(value);
		}

		/// <summary>
		/// Creation if log header.
		/// </summary>
		public static void LogHeader()
		{
			DateTime currentTime = DateTime.Now;
			StartTime = currentTime;
			AddLine("Tests start. Time: " + currentTime.ToString());
		}

		/// <summary>
		/// Creation of log footer.
		/// </summary>
		public static void LogFooter()
		{
			DateTime currentTime = DateTime.Now;
			EndTime = currentTime;
			AddLine(string.Format("Tests end. Time: {0}. Time taken: {1}", currentTime.ToString(), EndTime - StartTime));
			SaveLog();
		}

		/// <summary>
		/// Creation of test header.
		/// </summary>
		/// <param name="testName">Test name.</param>
		public static void TestHeader(string testName)
		{
			TestName = testName;
			AddLine("TestName: " + TestName);
		}

		/// <summary>
		/// Creation of test footer.
		/// </summary>
		/// <param name="testResult">Test result.</param>
		public static void TestFooter(string testResult)
		{
			if (testResult == "Failed")
			{
				TakeScreenshot(TestName);
			}

			AddLine("Test result: " + testResult + Environment.NewLine);
		}

		/// <summary>
		/// Save log to file.
		/// </summary>
		public static void SaveLog()
		{
			StreamWriter sw = new StreamWriter(ApplicationConfiguration.LogFileName, true);
			sw.WriteLine(LogContent);
			sw.Close();
		}

		/// <summary>
		/// Take screenshot and save it to tests results folder.
		/// </summary>
		/// <param name="name">File name.</param>
		public static void TakeScreenshot(string name)
		{
			string path = Environment.CurrentDirectory + "\\" + ApplicationConfiguration.ScreenShotsFolder + "\\";
			string fileName = name + ".png";

			if (!Directory.Exists(path))
			{
				Logger.Info("Screenshot directory doesn't exist. Creating directory..");
				try
				{
					Directory.CreateDirectory(path);
					Logger.Info("Directory created: " + path);
				}
				catch (Exception ex)
				{
					Logger.Error("Error while creating screenshot directory. Error value: " + ex);
				}
			}

			try
			{
				Logger.Info("Creating screenshot: " + fileName);
				Screenshot screenshot = ((ITakesScreenshot)WebBrowser.Driver).GetScreenshot();
				screenshot.SaveAsFile(path + fileName, ImageFormat.Png);
				Logger.Info("Screenshot created");
			}
			catch (Exception ex)
			{
				Logger.Error("Error while creating screenshot. Error message: " + ex);
			}
		}

		/// <summary>
		/// Add line to log file and debug console.
		/// </summary>
		/// <param name="value">Message value.</param>
		private static void AddLine(string value)
		{
			LogContent += value + Environment.NewLine;
			Debug.WriteLine(value);
		}
	}
}
