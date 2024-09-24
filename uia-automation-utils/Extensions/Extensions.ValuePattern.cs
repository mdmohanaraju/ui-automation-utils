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

