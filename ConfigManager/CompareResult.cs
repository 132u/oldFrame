// -----------------------------------------------------------------------
// <copyright file="CompareResults.cs" company="Euromoney">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace ConfigManager
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	/// <summary>
	/// Present elements list comparison results.
	/// </summary>
	public class CompareResults
	{
		/// <summary>
		/// Gets or sets a value indicating whether.
		/// </summary>
		public bool OverallResult { get; set; }

		/// <summary>
		/// Gets or sets errors list.
		/// </summary>
		public List<string> Errors { get; set; }

		/// <summary>
		/// Initializes a new instance of the CompareResults class.
		/// </summary>
		public CompareResults()
		{
			this.Errors = new List<string>();
		}

		public string GetAllErrors()
		{
			if (this.Errors.Count > 0)
			{
				StringBuilder errors = new StringBuilder();

				foreach (string error in this.Errors)
				{
					errors.Append(error);
					errors.Append(Environment.NewLine);
				}

				return errors.ToString();
			}
			else
			{
				return string.Empty;
			}
		}
	}
}
