using System;
using System.Windows.Automation;

namespace UIA.Automation.Utils.Extensions
{
	/// <summary>
	/// Extensions for <see cref="AutomationElement"/> objec t
	/// </summary>
    public static partial class AutomationElementExtensions
    {
        public static GridPattern GetGridPattern(this AutomationElement element)
        {
            return element.GetPattern<GridPattern>(GridPattern.Pattern);
        }

        public static AutomationElement GetCell(this AutomationElement element, int row, int column)
        {
            return element.GetGridPattern().GetItem(row, column);
        }

        public static int GetRowCount(this AutomationElement element)
        {
            return element.GetGridPattern().Current.RowCount;
        }

        public static int GetColumnCount(this AutomationElement element)
        {
            return element.GetGridPattern().Current.ColumnCount;
        }
    }
}

