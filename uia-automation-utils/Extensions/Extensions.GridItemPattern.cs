using System.Windows.Automation;

namespace UIA.Automation.Utils.Extensions
{
    /// <summary>
    /// Extensions for <see cref="AutomationElement"/> objec t
    /// </summary>
    public static partial class AutomationElementExtensions
    {
        /// <summary>
        /// Get GridItem pattern object
        /// </summary>
        /// <param name="element">Automation element</param>
        /// <returns>GridItem pattern object if supported else null</returns>
        public static GridItemPattern GetGridItemPattern(this AutomationElement element)
        {
            return element.GetPattern<GridItemPattern>(GridItemPattern.Pattern);
        }

        /// <summary>
        /// Gets the ordinal number of the row that contains the cell or item
        /// </summary>
        /// <param name="element">Grid Cell or item element</param>
        /// <returns>Ordinal number of the row that contains the cell or item</returns>
        public static int GetRow(this AutomationElement element)
        {
            return element.GetGridItemPattern().Current.Row;
        }

        /// <summary>
        /// Gets the number of rows spanned by a cell or item.
        /// </summary>
        /// <param name="element">Grid cell or item element</param>
        /// <returns>A zero-based ordinal number that identifies the row containing the table cell or item. The default value is 0.</returns>
        public static int GetRowSpan(this AutomationElement element)
        {
            return element.GetGridItemPattern().Current.RowSpan;
        }

        /// <summary>
        /// ets the ordinal number of the column that contains the cell or item.
        /// </summary>
        /// <param name="element"></param>
        /// <returns>A zero-based ordinal number that identifies the column containing the cell or item. The default value is 0.</returns>
        public static int GetColumn(this AutomationElement element)
        {
            return element.GetGridItemPattern().Current.Column;
        }

        /// <summary>
        /// Gets the number of columns spanned by a cell or item.
        /// </summary>
        /// <param name="element">Grid cell or item element</param>
        /// <returns>The number of columns spanned. The default value is 1.</returns>
        public static int GetColumnSpan(this AutomationElement element)
        {
            return element.GetGridItemPattern().Current.ColumnSpan;
        }

        /// <summary>
        /// Gets a UI Automation element that supports GridPattern and represents the container of the cell or item.
        /// </summary>
        /// <param name="element">Cell or Item element</param>
        /// <returns>A UI Automation element that supports the GridPattern and represents the table cell or item container. The default is a null reference</returns>
        public static AutomationElement GetContainingGrid(this AutomationElement element)
        {
            return element.GetGridItemPattern().Current.ContainingGrid;
        }
    }
}

