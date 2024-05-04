using System;
using System.Windows.Automation;

namespace UIA.Automation.Utils.Extensions
{
    public static partial class AutomationElementExtensions
    {
        public static TogglePattern GetTogglePattern(this AutomationElement element)
        {
            return element.GetPattern<TogglePattern>(TogglePattern.Pattern);
        }

        public static void Check(this AutomationElement element)
        {
            if(element.IsUnchecked())
            {
                element.GetTogglePattern().Toggle();
            }
        }

        public static void Uncheck(this AutomationElement element)
        {
            if (element.IsChecked())
            {
                element.GetTogglePattern().Toggle();
            }
        }

        public static bool IsChecked(this AutomationElement element)
        {
            return element.IsToggleStateMatch(ToggleState.On);
        }

        public static bool IsUnchecked(this AutomationElement element)
        {
            return element.IsToggleStateMatch(ToggleState.Off);
        }

        public static bool IsIndeterminate(this AutomationElement element)
        {
            return element.IsToggleStateMatch(ToggleState.Indeterminate);
        }

        private static bool IsToggleStateMatch(this AutomationElement element, ToggleState toggleState)
        {
            return element.GetTogglePattern().Current.ToggleState == toggleState;
        }
    }
}

