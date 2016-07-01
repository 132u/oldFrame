// -----------------------------------------------------------------------
// <copyright file="ConfigManager.cs" company="Euromoney">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace ConfigManager
{
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;
	using System.Text;
	using System.Web;
	using System.Xml;
	using Core.Configuration;
	using Core.Helpers;
	using Core.Logger;
	using HtmlAgilityPack;

	/// <summary>
	/// Class to operate on configuration files.
	/// </summary>
	public class ConfigManager
	{
		/// <summary>
		/// Creates a list of elements.
		/// </summary>
		/// <param name="name">Name of elements list.</param>
		/// <param name="pageSource">Web page source code.</param>
		/// <param name="xpath">Xpath to page area.</param>
		/// <param name="filter">Only these controls will be selected.</param>
		/// <returns>List of elements found.</returns>
		public static List<Element> CreateListOfElementsFromXPath(string name, string pageSource, string xpath, string filter)
		{
			HtmlDocument doc = new HtmlDocument();
			doc.LoadHtml(pageSource);
			HtmlNodeCollection allElementsFound = null;

			if (!xpath.EndsWith(ApplicationConfiguration.GetAllElementsSuffix))
			{
				xpath += ApplicationConfiguration.GetAllElementsSuffix;
			}

			allElementsFound = doc.DocumentNode.SelectNodes(xpath);

			string[] elementsToInclude = filter.Split('|');
			List<HtmlNode> filteredNodes = new List<HtmlNode>();

			if (allElementsFound == null)
			{
				string errorMessage = string.Format("No elements found. Probably xpath is not correct. Required elements name {0}, xpath: {1}", name, xpath);
				Logger.Error(errorMessage);
				throw new NoElementsToCompareException(errorMessage);
			}

			foreach (HtmlNode node in allElementsFound)
			{
				if (elementsToInclude.Contains(node.Name))
				{
					filteredNodes.Add(node);
				}
			}

			List<Element> controlsFounded = new List<Element>();
			foreach (HtmlNode node in filteredNodes)
			{
				Element control = new Element();
				control.Name = node.Name;

				switch (node.Name)
				{
					case "a":
						control.Type = "Link";
						if (node.Attributes.Any(a => a.Name == "href"))
						{
							control.Attributes.Add("href", node.Attributes.First(a => a.Name == "href").Value);
						}
						else
						{
							control.Attributes.Add("href", string.Empty);
						}

						break;
					case "img":
						control.Type = "Image";
						control.Attributes.Add("src", node.Attributes.First(a => a.Name == "src").Value);

						if (node.Attributes.Any(a => a.Name == "alt"))
						{
							control.Attributes.Add("alt", node.Attributes.First(a => a.Name == "alt").Value);
						}

						break;
					case "input":
						string type = node.Attributes.First(t => t.Name == "type").Value.ToLower();

						if (type == "text" || type == "password")
						{
							control.Type = "TextBox";
						}
						else if (type == "checkbox")
						{
							control.Type = "Checkbox";
							if (node.Attributes.Any(a => a.Name == "checked"))
							{
								control.Attributes.Add("checked", node.Attributes.First(a => a.Name == "checked").Value);
							}
						}
						else if (type == "radio")
						{
							control.Type = "radio";

							if (node.Attributes.Any(a => a.Name == "checked"))
							{
								control.Attributes.Add("checked", node.Attributes.First(a => a.Name == "checked").Value);
							}
						}
						else if (type == "submit" || type == "button")
						{
							control.Type = "Button";
						}
						else if (type == "hidden")
						{
							continue;
						}
						else
						{
							control.Type = string.Empty;
						}

						break;
					default:
						control.Type = node.Name;
						break;
				}

				if (node.Attributes.Any(a => a.Name == "value"))
				{
					control.Attributes.Add("value", node.Attributes.First(a => a.Name == "value").Value);
				}

				if (node.Attributes.Any(a => a.Name == "id"))
				{
					control.Attributes.Add("id", node.Attributes.First(a => a.Name == "id").Value);
				}

				if (!string.IsNullOrEmpty(node.InnerText))
				{
					control.Attributes.Add("innerText", CleanString(node.InnerText));
				}

				controlsFounded.Add(control);
			}

			return controlsFounded;
		}

		/// <summary>
		/// Creates a list of elements.
		/// </summary>
		/// <param name="name">Name of elements list.</param>
		/// <param name="pageSource">Web page source code.</param>
		/// <param name="xpath">Xpath to page area.</param>
		/// <param name="filter">Only these controls will be selected.</param>
		/// <returns>List of elements found in string form.</returns>
		public static string CreateListOfElements(string name, string pageSource, string xpath, string filter)
		{
			List<Element> controlsFound = CreateListOfElementsFromXPath(name, pageSource, xpath, filter);

			StringBuilder result = new StringBuilder();

			result.Append(string.Format("<RequiredElements name=\"{0}\" xpath=\"{1}\" filter=\"{2}\">\r\n", name, xpath, filter));
			foreach (Element c in controlsFound)
			{
				result.Append(string.Format("\t<Element name=\"{0}\"  type=\"{1}\">\r\n", c.Name, c.Type));

				foreach (var attribute in c.Attributes)
				{
					result.Append(string.Format("\t\t<Attribute name=\"{0}\"  value=\"{1}\"/>\r\n", attribute.Key, HtmlHelper.MyHtmlEncode(attribute.Value)));
				}

				result.Append("\t</Element>\r\n");
			}

			result.Append(string.Format("</RequiredElements>", Environment.NewLine));

			return result.ToString();
		}

		/// <summary>
		/// Creates a list of elements and return xml node.
		/// </summary>
		/// <param name="name">Name of elements list.</param>
		/// <param name="pageSource">Web page source code.</param>
		/// <param name="xpath">Xpath to page area.</param>
		/// <param name="filter">Only these controls will be selected.</param>
		/// <returns>List of elements found in string form.</returns>
		public static XmlNode CreateListOfElementsToXml(string name, string pageSource, string xpath, string filter)
		{
			List<Element> controlsFound = CreateListOfElementsFromXPath(name, pageSource, xpath, filter);

			XmlDocument doc = new XmlDocument();
			XmlElement root = doc.CreateElement("RequiredElements");
			root.SetAttribute("name", name);
			root.SetAttribute("xpath", xpath);
			root.SetAttribute("filter", filter);

			foreach (Element element in controlsFound)
			{
				XmlElement xmlElement = doc.CreateElement("Element");
				xmlElement.SetAttribute("name", element.Name);
				xmlElement.SetAttribute("type", element.Type);

				foreach (var attribute in element.Attributes)
				{
					XmlElement childElement = doc.CreateElement("Attribute");
					childElement.SetAttribute("name", attribute.Key);
					childElement.SetAttribute("value", attribute.Value);
					xmlElement.AppendChild(childElement);
				}

				root.AppendChild(xmlElement);
			}

			doc.AppendChild(root);
			return doc.SelectSingleNode("//RequiredElements");
		}

		public static CompareResults CompareLists(RequiredElements expected, string pageSource)
		{
			if (expected.Optional)
			{
				Logger.Info("Required list check omitted because list is set as optional in configuration file.");
				return new CompareResults { OverallResult = true };
			}

			// Create found list.
			RequiredElements found = new RequiredElements();
			found.Name = expected.Name;
			found.Xpath = expected.Xpath;
			found.Filter = expected.Filter;
			found.List = CreateListOfElementsFromXPath(found.Name, pageSource, found.Xpath, found.Filter);

			CompareResults results = new CompareResults();
			results.OverallResult = true;
			List<Element> expectedElementsNotFound = WhichElementAreNotOnTheList(found.List, expected.List);
			List<Element> unexpectedElementsFound = WhichElementAreNotOnTheList(expected.List, found.List);

			if (expectedElementsNotFound.Count > 0 || unexpectedElementsFound.Count > 0)
			{
				results.OverallResult = false;
			}

			foreach (Element e in expectedElementsNotFound)
			{
				StringBuilder attributesErrors = new StringBuilder();
				foreach (var atribue in e.Attributes.ToList())
				{
					attributesErrors.Append(string.Format("key: {0} value: {1}, ", atribue.Key, atribue.Value));
				}

				results.Errors.Add(string.Format("Expected element not found. Name: {0}, type:{1}, attributes: {2}", e.Name, e.Type, attributesErrors.ToString()));
			}

			foreach (Element e in unexpectedElementsFound)
			{
				StringBuilder attributesErrors = new StringBuilder();
				foreach (var atribue in e.Attributes.ToList())
				{
					attributesErrors.Append(string.Format("key: {0} value: {1}, ", atribue.Key, atribue.Value));
				}

				results.Errors.Add(string.Format("Unexpected element found. Name: {0}, type:{1}, attributes: {2}", e.Name, e.Type, attributesErrors.ToString()));
			}

			if (results.Errors.Count > 0)
			{
				Logger.Info(string.Format("Comparison result: fail. Requied element: {0}, xpath: {1}", expected.Name, expected.Xpath));
				foreach (string message in results.Errors)
				{
					Logger.Info(message);
				}
			}
			else
			{
				Logger.Info(string.Format("Comparison result: success. Requied element: {0}, xpath: {1}", expected.Name, expected.Xpath));
			}

			return results;
		}

		/// <summary>
		/// Fills up selected required elements node.
		/// </summary>
		/// <param name="filePath">Config file to update path.</param>
		/// <param name="requiredElementsName">Name of node to fill.</param>
		/// <param name="pageSource">Web page source.</param>
		/// <returns>True if filling up is successful, false if not.</returns>
		public static bool FillUpRequiredElements(string filePath, string requiredElementsName, string pageSource)
		{
			try
			{
				StreamReader reader = new StreamReader(filePath);
				XmlDocument configFile = new XmlDocument();
				configFile.LoadXml(reader.ReadToEnd());
				reader.Close();
				RequiredElements requiredElementsNode = LoadRequiredElementsProperties(configFile, requiredElementsName);

				XmlNode child = CreateListOfElementsToXml(requiredElementsNode.Name, pageSource, requiredElementsNode.Xpath, requiredElementsNode.Filter);
				bool elementsAdded = AddFoundElementsToNode(configFile, child, requiredElementsNode.Name, ApplicationConfiguration.TestsConfigFilePath);

				if (!elementsAdded)
				{
					return false;
				}

				return true;
			}
			catch (FileNotFoundException)
			{
				Logger.Info("File " + filePath + " was not found");
				return false;
			}
			catch (Exception e)
			{
				Logger.Info("Exception thrown: " + e.Message);
				return false;
			}
		}

		/// <summary>
		/// Load required elements object from configuration file.
		/// </summary>
		/// <param name="doc">Config file content.</param>
		/// <param name="name">Name of required elements node to read.</param>
		/// <returns>Required Elements object.</returns>
		private static RequiredElements LoadRequiredElementsProperties(XmlDocument doc, string name)
		{
			XmlNode node = doc.SelectSingleNode(string.Format("//RequiredElements[@name='{0}']", name));
			RequiredElements requiredElementsProperties = new RequiredElements
			{
				Name = name,
				Xpath = node.Attributes["xpath"].Value,
				Filter = node.Attributes["filter"].Value
			};

			return requiredElementsProperties;
		}

		/// <summary>
		/// Add found elements to node and save file.
		/// </summary>
		/// <param name="doc">Config file content.</param>
		/// <param name="nodeWithElements">XMl node with required elements to add.</param>
		/// <param name="name">Required elements node name.</param>
		/// <param name="filePath">Configuration file path.</param>
		private static bool AddFoundElementsToNode(XmlDocument doc, XmlNode nodeWithElements, string name, string filePath)
		{
			try
			{
				XmlNode importNode = doc.ImportNode(nodeWithElements, true);
				XmlNodeList nodes = importNode.ChildNodes;

				if (nodes.Count == 0)
				{
					return false;
				}

				XmlNode requiredElementsNode = doc.SelectSingleNode(string.Format("//RequiredElements[@name='{0}']", name));

				while (requiredElementsNode.ChildNodes.Count > 0)
				{
					requiredElementsNode.RemoveChild(requiredElementsNode.ChildNodes[0]);
				}

				foreach (XmlNode node in nodes)
				{
					doc.SelectSingleNode(string.Format("//RequiredElements[@name='{0}']", name)).AppendChild(node.Clone());
				}

				doc.Save(filePath);
				return true;
			}
			catch (Exception ex)
			{
				Logger.Error("Exception occured durign adding required elements to file. Value: " + ex.Message);
				return false;
			}
		}

		/// <summary>
		/// Cleans string from new line char and trim spaces.
		/// </summary>
		/// <param name="input">Input string.</param>
		/// <returns>Cleaned up string.</returns>
		private static string CleanString(string input)
		{
			return input.Replace(System.Environment.NewLine, string.Empty).Trim();
		}

		/// <summary>
		/// Check which elements are not on the list.
		/// </summary>
		/// <param name="expected">Base list.</param>
		/// <param name="found">List to compare with.</param>
		/// <returns>List of elements that are not found.</returns>
		private static List<Element> WhichElementAreNotOnTheList(List<Element> expected, List<Element> found)
		{
			List<Element> results = new List<Element>();

			foreach (Element foundElement in found)
			{
				bool isOnTheList = false;
				foreach (Element expectedElement in expected)
				{
					if (foundElement.Name == expectedElement.Name &&
						foundElement.Type == expectedElement.Type &&
						foundElement.CompareAttributes(expectedElement.Attributes).OverallResult == true)
					{
						isOnTheList = true;
						break;
					}
				}

				if (!isOnTheList)
				{
					results.Add(foundElement);
				}
			}

			return results;
		}

		/// <summary>
		/// Find out how many elements like provided are on the list.
		/// </summary>
		/// <param name="elementToCheck">Element to check.</param>
		/// <param name="list">List go through.</param>
		/// <returns>Number of elements.</returns>
		private static int HowManyElementsLikeThisOnList(Element elementToCheck, List<Element> list)
		{
			int numberOfElements = 0;

			foreach (Element listElement in list)
			{
				if (elementToCheck.Name == listElement.Name &&
					elementToCheck.Type == listElement.Type &&
					elementToCheck.CompareAttributes(listElement.Attributes).OverallResult == true)
				{
					numberOfElements++;
				}
			}

			return numberOfElements;
		}
	}
}