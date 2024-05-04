using System;
using System.Windows.Automation;

namespace UIA.Automation.Utils.Extensions
{
    public static partial class AutomationElementExtensions
    {
        public static ScrollItemPattern GetScrollItemPattern(this AutomationElement element)
        {
            return element.GetPattern<ScrollItemPattern>(ScrollItemPattern.Pattern);
        }

        public static void ScrollIntoView(this AutomationElement element)
        {
            element.GetScrollItemPattern().ScrollIntoView();
        }
    }
}

