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

namespace UIA.Automation.Utils.Extensions
{
    /// <summary>
    /// Extensions for <see cref="AutomationElement"/> object
    /// </summary>
    public static partial class AutomationElementExtensions
    {
        /// <summary>
        /// Get Value pattern object
        /// </summary>
        /// <param name="element">Automation element</param>
        /// <returns>Value pattern object if supported else null</returns>
        public static ValuePattern GetValuePattern(this AutomationElement element)
        {
            return element.GetPattern<ValuePattern>(ValuePattern.Pattern);
        }

        /// <summary>
        /// Enter text
        /// </summary>
        /// <param name="element">TextBox element</param>
        /// <param name="value">Value to enter in the textbox</param>
        public static void EnterText(this AutomationElement element, string value)
        {
            element.GetValuePattern().SetValue(value);
        }

        /// <summary>
        /// Gets the value in the textbox element
        /// </summary>
        /// <param name="element">TextBox element</param>
        /// <returns>Text in the textbox</returns>
        public static string GetValue(this AutomationElement element)
        {
            return element.GetValuePattern().Current.Value;
        }
    }
}

