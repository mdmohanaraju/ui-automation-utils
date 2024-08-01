using System.Windows.Automation;
using Interop.UIAutomationClient;

namespace UIA.Automation.Utils.Extensions
{
	/// <summary>
	/// Extensions for <see cref="AutomationElement"/> objec t
	/// </summary>
	public static partial class AutomationElementExtensions
	{
        public static WindowPattern GetWindowPattern(this AutomationElement element)
        {
            return element.GetPattern<WindowPattern>(WindowPattern.Pattern);
        }

        public static void MinimizeWindow(this AutomationElement element)
        {
            element.SetWindowVisualState(WindowVisualState.WindowVisualState_Minimized);
        }

        public static void MaximizeWindow(this AutomationElement element)
        {
            element.SetWindowVisualState(WindowVisualState.WindowVisualState_Maximized);
        }

        public static void RestoreWindow(this AutomationElement element)
        {
            element.SetWindowVisualState(WindowVisualState.WindowVisualState_Normal);
        }

        public static void CloseWindow(this AutomationElement element)
        {
            element.GetWindowPattern().Close();
        }

        public static bool IsWindowMinimized(this AutomationElement element)
        {
            return element.GetWindowVisualState() == WindowVisualState.WindowVisualState_Minimized;
        }

        public static bool IsWindowMaximized(this AutomationElement element)
        {
            return element.GetWindowVisualState() == WindowVisualState.WindowVisualState_Maximized;
        }

        public static bool IsWindowRestored(this AutomationElement element)
        {
            return element.GetWindowVisualState() == WindowVisualState.WindowVisualState_Normal;
        }

        public static bool CanMinimize(this AutomationElement element)
        {
            return element.GetWindowPattern().Current.CanMinimize;
        }

        public static bool CanMaximize(this AutomationElement element)
        {
            return element.GetWindowPattern().Current.CanMaximize;
        }

        public static bool IsModalWindow(this AutomationElement element)
        {
            return element.GetWindowPattern().Current.IsModal;
        }

        public static bool IsTopMostWindow(this AutomationElement element)
        {
            return element.GetWindowPattern().Current.IsTopmost;
        }

        private static void SetWindowVisualState(this AutomationElement element, WindowVisualState windowVisualState)
        {
            element.GetWindowPattern().SetWindowVisualState(windowVisualState);
        }

        private static WindowVisualState GetWindowVisualState(this AutomationElement element)
        {
            return element.GetWindowPattern().Current.WindowVisualState;
        }
    }
}

