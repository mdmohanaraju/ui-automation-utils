#region Copyright (c) 2024 Mohanraj Devadoss
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:

// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.

// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
#endregion

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

