using System;
using System.Windows.Automation;

namespace UIA.Automation.Utils.Extensions
{
	/// <summary>
	/// Extensions for <see cref="AutomationElement"/> object
	/// </summary>
    public static partial class AutomationElementExtensions
    {
        public static TextPattern GetTextPattern(this AutomationElement element)
        {
            return element.GetPattern<TextPattern>(TextPattern.Pattern);
        }

        public static string GetText(this AutomationElement element)
        {
            return element.GetTextPattern().DocumentRange.GetText(-1);
        }

        public static string GetText(this AutomationElement element, int maxLength)
        {
            return element.GetTextPattern().DocumentRange.GetText(maxLength);
        }

        public static bool HasText(this AutomationElement element, string text, bool backward, bool ignoreCase)
        {
            return element.GetTextPattern().DocumentRange.FindText(text, backward, ignoreCase) != null;
        }
    }
}

