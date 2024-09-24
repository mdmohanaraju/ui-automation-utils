#region Copyright (c) 2024 Mohanraj Devadoss
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:

// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.

// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
#endregion

using System.Windows.Automation;
using Interop.UIAutomationClient;

namespace UIA.Automation.Utils.Extensions
{
	/// <summary>
	/// Extensions for <see cref="AutomationElement"/> objec t
	/// </summary>
	public static partial class AutomationElementExtensions
	{
        /// <summary>
        /// Get window pattern object
        /// </summary>
        /// <param name="element">Automation element</param>
        /// <returns>Window pattern object if supported else null</returns>
        public static WindowPattern GetWindowPattern(this AutomationElement element)
        {
            return element.GetPattern<WindowPattern>(WindowPattern.Pattern);
        }

        /// <summary>
        /// Minimize window
        /// </summary>
        /// <param name="element">Automation element</param>
        public static void MinimizeWindow(this AutomationElement element)
        {
            element.SetWindowVisualState(WindowVisualState.WindowVisualState_Minimized);
        }

        /// <summary>
        /// Maximize window
        /// </summary>
        /// <param name="element">Automation element</param>
        public static void MaximizeWindow(this AutomationElement element)
        {
            element.SetWindowVisualState(WindowVisualState.WindowVisualState_Maximized);
        }

        /// <summary>
        /// Restore window
        /// </summary>
        /// <param name="element">Automation element</param>
        public static void RestoreWindow(this AutomationElement element)
        {
            element.SetWindowVisualState(WindowVisualState.WindowVisualState_Normal);
        }

        /// <summary>
        /// Close window
        /// </summary>
        /// <param name="element">Automation element</param>
        public static void CloseWindow(this AutomationElement element)
        {
            element.GetWindowPattern().Close();
        }

        /// <summary>
        /// Gets whether the window is minmized
        /// </summary>
        /// <param name="element">Automation element</param>
        public static bool IsWindowMinimized(this AutomationElement element)
        {
            return element.GetWindowVisualState() == WindowVisualState.WindowVisualState_Minimized;
        }

        /// <summary>
        /// Gets whether the window is maxmized
        /// </summary>
        /// <param name="element">Automation element</param>
        public static bool IsWindowMaximized(this AutomationElement element)
        {
            return element.GetWindowVisualState() == WindowVisualState.WindowVisualState_Maximized;
        }

        /// <summary>
        /// Gets whether the window is displayed in restored state
        /// </summary>
        /// <param name="element">Automation element</param>
        public static bool IsWindowRestored(this AutomationElement element)
        {
            return element.GetWindowVisualState() == WindowVisualState.WindowVisualState_Normal;
        }

        /// <summary>
        /// Get window pattern object
        /// </summary>
        /// <param name="element">Automation element</param>
        public static bool CanMinimize(this AutomationElement element)
        {
            return element.GetWindowPattern().Current.CanMinimize;
        }

        /// <summary>
        /// Get window pattern object
        /// </summary>
        /// <param name="element">Automation element</param>
        public static bool CanMaximize(this AutomationElement element)
        {
            return element.GetWindowPattern().Current.CanMaximize;
        }

        /// <summary>
        /// Gets whether the element is a modal window
        /// </summary>
        /// <param name="element">Automation element</param>
        public static bool IsModalWindow(this AutomationElement element)
        {
            return element.GetWindowPattern().Current.IsModal;
        }

        /// <summary>
        /// Gets whether the element is the top most window
        /// </summary>
        /// <param name="element">Automation element</param>
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

