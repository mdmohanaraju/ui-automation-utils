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
        /// Get GridPattern pattern object
        /// </summary>
        /// <param name="element">Automation element</param>
        /// <returns>GridPattern pattern object if supported else null</returns>
        public static GridPattern GetGridPattern(this AutomationElement element)
        {
            return element.GetPattern<GridPattern>(GridPattern.Pattern);
        }

        /// <summary>
        /// Retrieves an AutomationElement that represents the specified cell.
        /// </summary>
        /// <param name="element">Grid element</param>
        /// <param name="row">The ordinal number of the row of interest.</param>
        /// <param name="column">he ordinal number of the column of interest./param>
        /// <returns>An <see cref="AutomationElement"/> that represents the retrieved cell.</returns>
        public static AutomationElement GetCell(this AutomationElement element, int row, int column)
        {
            return element.GetGridPattern().GetItem(row, column);
        }

        /// <summary>
        /// Gets the total number of rows in a grid.
        /// </summary>
        /// <param name="element">Grid element</param>
        /// <returns>The total number of rows in a grid.</returns>
        public static int GetRowCount(this AutomationElement element)
        {
            return element.GetGridPattern().Current.RowCount;
        }

        /// <summary>
        /// Gets the total number of columns in a grid.
        /// </summary>
        /// <param name="element">Grid element</param>
        /// <returns>The total number of columns in a grid.</returns>
        public static int GetColumnCount(this AutomationElement element)
        {
            return element.GetGridPattern().Current.ColumnCount;
        }
    }
}

