using System;
using System.Windows.Automation;

namespace UIA.Automation.Utils.Extensions
{
    public static partial class AutomationElementExtensions
    {
        public static TransformPattern GetTransformPattern(this AutomationElement element)
        {
            return element.GetPattern<TransformPattern>(TransformPattern.Pattern);
        }

        public static void MoveWindow(this AutomationElement element, double x, double y)
        {
            element.GetTransformPattern().Move(x, y);
        }

        public static void ResizeWindow(this AutomationElement element, double width, double height)
        {
            element.GetTransformPattern().Resize(width, height);
        }

        public static void RotateClockWise(this AutomationElement element, double degrees)
        {
            element.GetTransformPattern().Rotate(degrees);
        }

        public static void RotateAntiClockWise(this AutomationElement element, double degrees)
        {
            element.GetTransformPattern().Rotate(-degrees);
        }

        public static bool CanMoveWindow(this AutomationElement element)
        {
            return element.GetTransformPattern().Current.CanMove;
        }

        public static bool CanResizeWindow(this AutomationElement element)
        {
            return element.GetTransformPattern().Current.CanResize;
        }

        public static bool CanRotateWindow(this AutomationElement element)
        {
            return element.GetTransformPattern().Current.CanRotate;
        }

    }
}

