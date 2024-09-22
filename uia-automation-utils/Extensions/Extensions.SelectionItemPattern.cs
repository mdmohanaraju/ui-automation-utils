#region Copyright 2024 MohanrajDevadoss

//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at

//        http://www.apache.org/licenses/LICENSE-2.0

//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

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

