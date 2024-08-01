using System;
using System.Windows.Automation;

namespace UIA.Automation.Utils.Extensions
{
	/// <summary>
	/// Extensions for <see cref="AutomationElement"/> objec t
	/// </summary>
    public static partial class AutomationElementExtensions
    {
        /// <summary>
        /// Get ScrollItem pattern object
        /// </summary>
        /// <param name="element">Automation element</param>
        /// <returns>ScrollItem pattern object if supported else null</returns>
        public static ScrollItemPattern GetScrollItemPattern(this AutomationElement element)
        {
            return element.GetPattern<ScrollItemPattern>(ScrollItemPattern.Pattern);
        }

        /// <summary>
        /// Scrolls the content area of a container object in order to display the AutomationElement within the visible region (viewport) of the container.
        /// </summary>
        /// <param name="element">Scrollable element</param>
        public static void ScrollIntoView(this AutomationElement element)
        {
            element.GetScrollItemPattern().ScrollIntoView();
        }
    }
}

