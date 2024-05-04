using System;
using System.Windows.Automation;

namespace UIA.Automation.Utils.Extensions
{
    public static partial class AutomationElementExtensions
    {
        public static SelectionItemPattern GetSelectionItemPattern(this AutomationElement element)
        {
            return element.GetPattern<SelectionItemPattern>(SelectionItemPattern.Pattern);
        }

        public static void Select(this AutomationElement element)
        {
            element.GetSelectionItemPattern().Select();
        }

        public static void AddToSelection(this AutomationElement element)
        {
            element.GetSelectionItemPattern().AddToSelection();
        }

        public static void RemoveFromSelection(this AutomationElement element)
        {
            element.GetSelectionItemPattern().RemoveFromSelection();
        }

        public static bool IsSelected(this AutomationElement element)
        {
            return element.GetSelectionItemPattern().Current.IsSelected;
        }

        public static AutomationElement SelectionContainer(this AutomationElement element)
        {
            return element.GetSelectionItemPattern().Current.SelectionContainer;
        }
    }
}

