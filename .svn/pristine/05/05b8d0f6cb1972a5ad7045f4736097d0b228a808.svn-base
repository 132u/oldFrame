// -----------------------------------------------------------------------
// <copyright file="Element.cs" company="Euromoney">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace ConfigManager
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Net;
	using System.Text;
	using System.Threading.Tasks;
	using System.Web;
	using Core.Helpers;

	/// <summary>
	/// Element class.
	/// </summary>
	public class Element
	{
		/// <summary>
		/// Initializes a new instance of the Element class.
		/// </summary>
		public Element()
		{
			this.Attributes = new Dictionary<string, string>();
		}

		/// <summary>
		/// Gets or sets html name of element.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets exact type of element.
		/// </summary>
		public string Type { get; set; }

		/// <summary>
		/// Gets or sets element attributes.
		/// </summary>
		public Dictionary<string, string> Attributes { get; set; }

		public CompareResults CompareAttributes(Dictionary<string, string> compareWith)
		{
			CompareResults result = new CompareResults();

			if (this.Attributes.Count != compareWith.Count)
			{
				result.Errors.Add("Number of attributes is different");
			}

			foreach (var attribute in this.Attributes)
			{
				if (!compareWith.Any(a => a.Key == attribute.Key))
				{
					result.Errors.Add(string.Format("Attribute not found. Key: {0}, value: {1}", attribute.Key, attribute.Value));
				}
				else if (!compareWith.Any(a => a.Key == attribute.Key && a.Value == attribute.Value))
				{
					result.Errors.Add(
						string.Format(
						"Attribute value has changed. Attribute: {0}, expected value: {1}, actual value: {2}",
							attribute.Key,
							attribute.Value,
							compareWith.First(a => a.Key == attribute.Key).Value));
				}
			}

			if (result.Errors.Count == 0)
			{
				result.OverallResult = true;
			}

			return result;
		}
	}
}