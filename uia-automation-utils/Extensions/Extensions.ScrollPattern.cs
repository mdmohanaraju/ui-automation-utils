using System;
using System.Windows.Automation;
using Interop.UIAutomationClient;

namespace UIA.Automation.Utils.Extensions
{
	/// <summary>
	/// Extensions for <see cref="AutomationElement"/> objec t
	/// </summary>
    public static partial class AutomationElementExtensions
    {
        /// <summary>
        /// Get Scroll pattern object
        /// </summary>
        /// <param name="element">Automation element</param>
        /// <returns>Scroll pattern object if supported else null</returns>
        public static ScrollPattern GetScrollPattern(this AutomationElement element)
        {
            return element.GetPattern<ScrollPattern>(ScrollPattern.Pattern);
        }

        /// <summary>
        /// Scrolls the visible region of the content area horizontally and vertically.
        /// </summary>
        /// <param name="element">Scrollable element</param>
        /// <param name="horizontalAmount">The horizontal increment specific to the control. NoScroll should be passed in if the control cannot be scrolled in this direction.</param>
        /// <param name="verticalAmount">The vertical increment specific to the control. NoScroll should be passed in if the control cannot be scrolled in this direction.</param>
        public static void Scroll(this AutomationElement element, ScrollAmount horizontalAmount, ScrollAmount verticalAmount)
        {
            element.GetScrollPattern().Scroll(horizontalAmount, verticalAmount);
        }

        /// <summary>
        /// Sets the horizontal and/or vertical scroll position as a percentage of the total content area within the AutomationElement.
        /// </summary>
        /// <param name="element">Scrollable element</param>
        /// <param name="horizontalPercent">The percentage of the total horizontal content area. NoScroll should be passed in if the control cannot be scrolled in this direction.</param>
        /// <param name="verticalPercent">The percentage of the total vertical content area. NoScroll should be passed in if the control cannot be scrolled in this direction.</param>
        public static void SetScrollPercent(this AutomationElement element, double horizontalPercent, double verticalPercent)
        {
            element.GetScrollPattern().SetScrollPercent(horizontalPercent, verticalPercent);
        }

        /// <summary>
        /// Scrolls the currently visible region of the content area, horizontally, the specified ScrollAmount.
        /// </summary>
        /// <param name="element">Scrollable element</param>
        /// <param name="horizontalAmount">The horizontal ScrollAmount increment specific to the control.</param>
        public static void ScrollHorizontal(this AutomationElement element, ScrollAmount horizontalAmount)
        {
            element.GetScrollPattern().ScrollHorizontal(horizontalAmount);
        }

        /// <summary>
        /// Scrolls the currently visible region of the content area, vertically, the specified ScrollAmount.
        /// </summary>
        /// <param name="element">Scrollable element</param>
        /// <param name="verticalAmount">The vertical ScrollAmount increment specific to the control.</param>
        public static void ScrollVertical(this AutomationElement element, ScrollAmount verticalAmount)
        {
            element.GetScrollPattern().ScrollVertical(verticalAmount);
        }

        /// <summary>
        /// Gets a value that indicates whether the UI Automation element can scroll horizontally.
        /// </summary>
        /// <param name="element">Scrollable element</param>
        /// <returns>true if the UI Automation element can scroll horizontally; otherwise false. The default value is false.</returns>
        public static bool IsHorizontallyScrollable(this AutomationElement element)
        {
            return element.GetScrollPattern().Current.HorizontallyScrollable;
        }

        /// <summary>
        /// Gets the current horizontal scroll position.
        /// </summary>
        /// <param name="element">Scrollable element</param>
        /// <returns>The horizontal scroll position as a percentage of the total content area within the UI Automation element. The default value is 0.0.</returns>
        public static double GetHorizontalScrollPercent(this AutomationElement element)
        {
            return element.GetScrollPattern().Current.HorizontalScrollPercent;
        }

        /// <summary>
        /// Gets the current horizontal view size.
        /// </summary>
        /// <param name="element">Scrollable element</param>
        /// <returns>The horizontal size of the viewable region as a percentage of the total content area within the UI Automation element. The default value is 100.0.</returns>
        public static double GetHorizontalViewSize(this AutomationElement element)
        {
            return element.GetScrollPattern().Current.HorizontalViewSize;
        }

        /// <summary>
        /// Retrieves a value that indicates whether the UI Automation element can scroll vertically.
        /// </summary>
        /// <param name="element"></param>
        /// <returns>true if the UI Automation element can scroll vertically; otherwise false. The default value is false.</returns>
        public static bool IsVerticallyScrollable(this AutomationElement element)
        {
            return element.GetScrollPattern().Current.VerticallyScrollable;
        }

        /// <summary>
        /// Gets the current vertical scroll position.
        /// </summary>
        /// <param name="element">Scrollable element</param>
        /// <returns>The vertical scroll position as a percentage of the total content area within the UI Automation element. The default value is 0.0.</returns>
        public static double GetVerticalScrollPercent(this AutomationElement element)
        {
            return element.GetScrollPattern().Current.VerticalScrollPercent;
        }

        /// <summary>
        /// Gets the current vertical view size.
        /// </summary>
        /// <param name="element">Scrollable element</param>
        /// <returns>he vertical size of the viewable region as a percentage of the total content area within the UI Automation element. The default value is 100.0.</returns>
        public static double GetVerticalViewSize(this AutomationElement element)
        {
            return element.GetScrollPattern().Current.VerticalViewSize;
        }
    }
}

