// -----------------------------------------------------------------------
// <copyright file="RequiredElements.cs" company="Euromoney">
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
	/// Required elements list.
	/// </summary>
	public class RequiredElements
	{
		/// <summary>
		/// Gets or sets list name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets xpath representation of area of elements search.
		/// </summary>
		public string Xpath { get; set; }

		/// <summary>
		/// Gets or sets list of elements to search.
		/// </summary>
		public string Filter { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether information list is optional.
		/// </summary>
		public bool Optional { get; set; }

		/// <summary>
		/// Gets or sets list of elements.
		/// </summary>
		public List<Element> List { get; set; }
	}
}