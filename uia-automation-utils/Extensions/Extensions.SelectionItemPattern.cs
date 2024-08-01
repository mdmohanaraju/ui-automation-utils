using System.Windows.Automation;

namespace UIA.Automation.Utils.Extensions
{
    /// <summary>
    /// Extensions for <see cref="AutomationElement"/> objec t
    /// </summary>
    public static partial class AutomationElementExtensions
    {
        /// <summary>
        /// Get SelectionItem pattern object
        /// </summary>
        /// <param name="element">Automation element</param>
        /// <returns>SelectionItem pattern object if supported else null</returns>
        public static SelectionItemPattern GetSelectionItemPattern(this AutomationElement element)
        {
            return element.GetPattern<SelectionItemPattern>(SelectionItemPattern.Pattern);
        }

        /// <summary>
        /// Deselects any selected items and then selects the current element.
        /// </summary>
        /// <param name="element">ListItem element</param>
        public static void Select(this AutomationElement element)
        {
            element.GetSelectionItemPattern().Select();
        }

        /// <summary>
        /// Adds the current element to the collection of selected items.
        /// </summary>
        /// <param name="element">ListItem element</param>
        public static void AddToSelection(this AutomationElement element)
        {
            element.GetSelectionItemPattern().AddToSelection();
        }

        /// <summary>
        /// Removes the current element from the collection of selected items.
        /// </summary>
        /// <param name="element">ListItem element</param>
        public static void RemoveFromSelection(this AutomationElement element)
        {
            element.GetSelectionItemPattern().RemoveFromSelection();
        }

        /// <summary>
        /// Gets a value that indicates whether an item is selected.
        /// </summary>
        /// <param name="element">ListItem element</param>
        /// <returns>true if the item is selected; otherwise false.</returns>
        public static bool IsSelected(this AutomationElement element)
        {
            return element.GetSelectionItemPattern().Current.IsSelected;
        }

        /// <summary>
        /// Gets the AutomationElement that supports the SelectionPattern control pattern and acts as the container for the calling object.
        /// </summary>
        /// <param name="element">ListItem element</param>
        /// <returns>The container object. The default is a null reference</returns>
        public static AutomationElement SelectionContainer(this AutomationElement element)
        {
            return element.GetSelectionItemPattern().Current.SelectionContainer;
        }
    }
}

