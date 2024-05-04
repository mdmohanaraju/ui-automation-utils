using System;
using System.Windows.Automation;

namespace UIA.Automation.Utils.Extensions
{
    public static partial class AutomationElementExtensions
    {
        public static GridItemPattern GetGridItemPattern(this AutomationElement element)
        {
            return element.GetPattern<GridItemPattern>(GridItemPattern.Pattern);
        }

        public static int GetRow(this AutomationElement element)
        {
            return element.GetGridItemPattern().Current.Row;
        }

        public static int GetRowSpan(this AutomationElement element)
        {
            return element.GetGridItemPattern().Current.RowSpan;
        }

        public static int GetColumn(this AutomationElement element)
        {
            return element.GetGridItemPattern().Current.Column;
        }

        public static int GetColumnSpan(this AutomationElement element)
        {
            return element.GetGridItemPattern().Current.ColumnSpan;
        }

        public static AutomationElement GetContainingGrid(this AutomationElement element)
        {
            return element.GetGridItemPattern().Current.ContainingGrid;
        }
    }
}

