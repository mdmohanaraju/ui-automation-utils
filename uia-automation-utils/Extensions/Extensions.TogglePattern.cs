#region Copyright 2024 MohanrajDevadoss

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
    /// Extensions for <see cref="AutomationElement"/> object
    /// </summary>
    public static partial class AutomationElementExtensions
    {
        /// <summary>
        /// Get Toggle pattern object
        /// </summary>
        /// <param name="element">Automation element</param>
        /// <returns>Toggle pattern object if supported else null</returns>
        public static TogglePattern GetTogglePattern(this AutomationElement element)
        {
            return element.GetPattern<TogglePattern>(TogglePattern.Pattern);
        }

        /// <summary>
        /// Check checkbox/toggle button
        /// </summary>
        /// <param name="element">CheckBox/toggle button</param>
        public static void Check(this AutomationElement element)
        {
            if(element.IsUnchecked())
            {
                element.Toggle();
            }
        }

        /// <summary>
        /// Uncheck checkbox/toggle button
        /// </summary>
        /// <param name="element">CheckBox/toggle button</param>
        public static void Uncheck(this AutomationElement element)
        {
            if (element.IsChecked())
            {
                element.Toggle();
            }
        }

        /// <summary>
        /// Gets whether the element is checked
        /// </summary>
        /// <param name="element">CheckBox or toggle button</param>
        /// <returns>true if checked else false</returns>
        public static bool IsChecked(this AutomationElement element)
        {
            return element.IsToggleStateMatch(ToggleState.ToggleState_On);
        }

        /// <summary>
        /// Gets whether the element is unchecked
        /// </summary>
        /// <param name="element">CheckBox or toggle button</param>
        /// <returns>true if unchecked else false</returns>
        public static bool IsUnchecked(this AutomationElement element)
        {
            return element.IsToggleStateMatch(ToggleState.ToggleState_Off);
        }

        /// <summary>
        /// Gets whether the element is in intermediate state
        /// </summary>
        /// <param name="element">CheckBox or toggle button</param>
        /// <returns>true if in intermediate state else false</returns>
        public static bool IsIndeterminate(this AutomationElement element)
        {
            return element.IsToggleStateMatch(ToggleState.ToggleState_Indeterminate);
        }

        private static void Toggle(this AutomationElement element)
        {
            element.GetTogglePattern().Toggle();
        }

        private static bool IsToggleStateMatch(this AutomationElement element, ToggleState toggleState)
        {
            return element.GetTogglePattern().Current.ToggleState == toggleState;
        }
    }
}

