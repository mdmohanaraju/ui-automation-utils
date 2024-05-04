using System;
using System.Windows.Automation;

namespace UIA.Automation.Utils.Extensions
{
    public static partial class AutomationElementExtensions
    {
        public static SelectionPattern GetSelectionPattern(this AutomationElement element)
        {
            return element.GetPattern<SelectionPattern>(SelectionPattern.Pattern);
        }

        public static bool CanSelectMultiple(this AutomationElement element)
        {
            return element.GetSelectionPattern().Current.CanSelectMultiple;
        }

        public static bool IsSelectionRequired(this AutomationElement element)
        {
            return element.GetSelectionPattern().Current.IsSelectionRequired;
        }

        public static AutomationElement[] GetSelection(this AutomationElement element)
        {
            return element.GetSelectionPattern().Current.GetSelection();
        }
    }
}

