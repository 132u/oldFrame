using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Core.Configuration;
using Core.Controls;
using Core.Logger;

namespace Core.Helpers
{
	public static class BasicHelper
	{
		public static string GenerateRandomString()
		{
			return Guid.NewGuid().ToString().Replace("-", string.Empty);
		}

		public static string GenerateRandomNumberString(int numberOfDigits)
		{
			return Regex.Replace(GenerateRandomString(), "[A-Za-z ]", string.Empty).Substring(0, numberOfDigits);
		}

		public static string GetDropdownElementExcept(Dropdown dropdown, string exceptThis)
		{
			List<string> valuesWithoutUnwanted = new List<string>();

			foreach (Option option in dropdown.Options)
			{
				if (option.Text != exceptThis)
				{
					valuesWithoutUnwanted.Add(option.Text);
				}
			}

			Random random = new Random(DateTime.Now.Millisecond);

			return valuesWithoutUnwanted[random.Next(0, valuesWithoutUnwanted.Count - 1)];
		}

		/// <summary>
		/// Waits specific time for returning by action 'True'. 
		/// </summary>
		/// <param name="action">Method that indicates that condition is meet.</param>
		/// <param name="millsecond">Time to wait for meet the condition.</param>
		/// <returns>Result of comparison. True if action return True in specified time.</returns>
		public static bool WaitForSuccess(Func<bool> action, int millsecond = 5000)
		{
			Logger.Logger.Info(string.Format("Waiting for action: {0}, timeout: {1}", action, millsecond));
			var start = DateTime.Now;
			double timeRun;

			do
			{
				Thread.Sleep(500);
				timeRun = (DateTime.Now - start).TotalMilliseconds;

				if (action())
				{
					Logger.Logger.Info(string.Format("Action executed successfuly.", action, millsecond));
					return true;
				}
			}
			while (timeRun <= millsecond);

			Logger.Logger.Error(string.Format("Failed to execute action.", action, millsecond));
			return false;
		}

		public static string GetPasswordFromMailtrapByEmail(string email)
		{
			string url = string.Format("https://mailtrap.io/api/v1/inboxes/{0}/messages?search={1}&api_token={2}", ApplicationConfiguration.MailtrapMailboxNumber, email, ApplicationConfiguration.MailtrapToken);
			Logger.Logger.Info("Url send to Mailtrap: " + url);

			StringBuilder responseFromMailtrap = new StringBuilder();

			for (int i = 0; i < 4; i++)
			{
				System.Threading.Thread.Sleep(ApplicationConfiguration.ShortTimeout);

				WebRequest request = WebRequest.Create(@url);
				request.Method = "GET";
				HttpWebResponse response = (HttpWebResponse)request.GetResponse();

				byte[] buf = new byte[8192];
				Stream resStream = response.GetResponseStream();
				int count = 0;

				do
				{
					count = resStream.Read(buf, 0, buf.Length);
					if (count != 0)
					{
						responseFromMailtrap.Append(Encoding.UTF8.GetString(buf, 0, count));
					}
				}
				while (count > 0);

				if (responseFromMailtrap.ToString().ToLower().Contains("password"))
				{
					break;
				}
			}

			Regex regex = new Regex(ApplicationConfiguration.PasswordRetrieveRegex);
			var results = regex.Match(responseFromMailtrap.ToString());
			string password = results.Groups[0].Value.Replace(ApplicationConfiguration.PasswordRetrieveFromEmailPrefix, string.Empty);
			int whenSufixStarts = password.IndexOf(ApplicationConfiguration.PasswordRetrieveFromEmailSufix[0]);
			if (whenSufixStarts != -1)
			{
				password = password.Remove(whenSufixStarts);
			}

			if (string.IsNullOrWhiteSpace(password))
			{
				string message = "Password not found in email. Probably regex match is not configured.";
				Logger.Logger.Error(message);
				throw new ArgumentException(message);
			}

			Logger.Logger.Info("Password retrieved: " + password);

			return password;
		}

		public static string GetRandomEmail()
		{
			string randomEmail = Guid.NewGuid() + "@euromoney.test";
			Logger.Logger.Info("Random email address generated: " + randomEmail);
			return randomEmail;
		}
	}
}
