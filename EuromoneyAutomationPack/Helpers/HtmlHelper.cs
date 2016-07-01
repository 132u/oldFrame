using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Core.Helpers
{
	public static class HtmlHelper
	{
		public static string MyHtmlEncode(string value)
		{
			// call the normal HtmlEncode first
			char[] chars = HttpUtility.HtmlEncode(value).ToCharArray();
			StringBuilder encodedValue = new StringBuilder();
			foreach (char c in chars)
			{
				// above normal ASCII
				if ((int)c > 127)
				{
					encodedValue.Append("&#" + (int)c + ";");
				}
				else
				{
					encodedValue.Append(c);
				}
			}

			return encodedValue.ToString();
		}
	}
}
