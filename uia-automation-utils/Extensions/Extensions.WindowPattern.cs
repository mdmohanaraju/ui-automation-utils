#region Copyright 2024 mdmohanaraju

//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at

//        http://www.apache.org/licenses/LICENSE-2.0

//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

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

