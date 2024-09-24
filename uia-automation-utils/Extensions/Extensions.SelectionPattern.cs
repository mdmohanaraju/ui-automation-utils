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

