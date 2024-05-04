using System;
using System.Windows.Automation;

namespace UIA.Automation.Utils.Extensions
{
    public static partial class AutomationElementExtensions
    {
        public static ScrollPattern GetScrollPattern(this AutomationElement element)
        {
            return element.GetPattern<ScrollPattern>(ScrollPattern.Pattern);
        }

        public static void Scroll(this AutomationElement element, ScrollAmount horizontalAmount, ScrollAmount verticalAmount)
        {
            element.GetScrollPattern().Scroll(horizontalAmount, verticalAmount);
        }

        public static void ScrollHorizontal(this AutomationElement element, ScrollAmount horizontalAmount)
        {
            element.GetScrollPattern().ScrollHorizontal(horizontalAmount);
        }

        public static void ScrollVertical(this AutomationElement element, ScrollAmount verticalAmount)
        {
            element.GetScrollPattern().ScrollVertical(verticalAmount);
        }

        public static void SetScrollPercent(this AutomationElement element, double horizontalPercent, double verticalPercent)
        {
            element.GetScrollPattern().SetScrollPercent(horizontalPercent, verticalPercent);
        }

        public static bool IsHorizontallyScrollable(this AutomationElement element)
        {
            return element.GetScrollPattern().Current.HorizontallyScrollable;
        }

        public static double GetHorizontalScrollPercent(this AutomationElement element)
        {
            return element.GetScrollPattern().Current.HorizontalScrollPercent;
        }

        public static double GetHorizontalViewSize(this AutomationElement element)
        {
            return element.GetScrollPattern().Current.HorizontalViewSize;
        }

        public static bool IsVerticallyScrollable(this AutomationElement element)
        {
            return element.GetScrollPattern().Current.VerticallyScrollable;
        }

        public static double GetVerticalScrollPercent(this AutomationElement element)
        {
            return element.GetScrollPattern().Current.VerticalScrollPercent;
        }

        public static double GetVerticalViewSize(this AutomationElement element)
        {
            return element.GetScrollPattern().Current.VerticalViewSize;
        }
    }
}

