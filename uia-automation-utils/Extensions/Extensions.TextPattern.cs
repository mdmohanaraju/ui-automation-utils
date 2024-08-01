using System;
using System.Windows.Automation;

namespace UIA.Automation.Utils.Extensions
{
	/// <summary>
	/// Extensions for <see cref="AutomationElement"/> object
	/// </summary>
    public static partial class AutomationElementExtensions
    {
        /// <summary>
        /// Get Text pattern object
        /// </summary>
        /// <param name="element">Automation element</param>
        /// <returns>Text pattern object if supported else null</returns>
        public static TextPattern GetTextPattern(this AutomationElement element)
        {
            return element.GetPattern<TextPattern>(TextPattern.Pattern);
        }

        /// <summary>
        /// Returns a plain text
        /// </summary>
        /// <param name="element">Text element</param>
        /// <returns><The plain text of the text range, possibly truncated at the specified maxLength/returns>
        public static string GetText(this AutomationElement element)
        {
            return element.GetTextPattern().DocumentRange.GetText(-1);
        }

        /// <summary>
        /// Returns a plain text of the text range
        /// </summary>
        /// <param name="element">Text element</param>
        /// <param name="maxLength">The maximum length of th string to return. Use -1 if no limit is required</param>
        /// <returns><The plain text of the text range, possibly truncated at the specified maxLength/returns>
        public static string GetText(this AutomationElement element, int maxLength)
        {
            return element.GetTextPattern().DocumentRange.GetText(maxLength);
        }

        /// <summary>
        /// Gets whether the text element contains text
        /// </summary>
        /// <param name="element">Text element</param>
        /// <param name="text">The text string to search for</param>
        /// <param name="backward">true if the last occuring text range should be returned instead of the first; otherwise false</param>
        /// <param name="ignoreCase">true if case should be ignored; otherwise false</param>
        /// <returns>true if text is found; otherwise false</returns>
        public static bool HasText(this AutomationElement element, string text, bool backward, bool ignoreCase)
        {
            return element.GetTextPattern().DocumentRange.FindText(text, backward, ignoreCase) != null;
        }
    }
}

