using System.Windows.Automation;

namespace UIA.Automation.Utils.Extensions
{
    /// <summary>
    /// Extensions for <see cref="AutomationElement"/> objec t
    /// </summary>
    public static partial class AutomationElementExtensions
    {
        /// <summary>
        /// Get Selection pattern object
        /// </summary>
        /// <param name="element">Automation element</param>
        /// <returns>Selection pattern object if supported else null</returns>
        public static SelectionPattern GetSelectionPattern(this AutomationElement element)
        {
            return element.GetPattern<SelectionPattern>(SelectionPattern.Pattern);
        }

        /// <summary>
        /// Gets a value that specifies whether the container allows more than one child element to be selected concurrently.
        /// </summary>
        /// <param name="element">List element</param>
        /// <returns>true if the control supports multiple selection; otherwise false.</returns>
        public static bool CanSelectMultiple(this AutomationElement element)
        {
            return element.GetSelectionPattern().Current.CanSelectMultiple;
        }

        /// <summary>
        /// Gets a value that specifies whether the container requires at least one child element to be selected.
        /// </summary>
        /// <param name="element">List element</param>
        /// <returns>true if the control requires at least one item to be selected; otherwise false.</returns>
        public static bool IsSelectionRequired(this AutomationElement element)
        {
            return element.GetSelectionPattern().Current.IsSelectionRequired;
        }

        /// <summary>
        /// Retrieves all items in the selection container that are selected.
        /// </summary>
        /// <param name="element">List element</param>
        /// <returns>he collection of selected items. The default is an empty array.</returns>
        public static AutomationElement[] GetSelection(this AutomationElement element)
        {
            return element.GetSelectionPattern().Current.GetSelection();
        }
    }
}

