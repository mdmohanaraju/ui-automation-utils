#region Copyright 2024 mdmohanaraju

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

