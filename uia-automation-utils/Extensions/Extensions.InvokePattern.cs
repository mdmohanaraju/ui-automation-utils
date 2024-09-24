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

using System;
using System.Windows.Automation;

namespace UIA.Automation.Utils.Extensions
{
	/// <summary>
	/// Extensions for <see cref="AutomationElement"/> objec t
	/// </summary>
    public static partial class AutomationElementExtensions
    {
        /// <summary>
        /// Get Invoke pattern object
        /// </summary>
        /// <param name="element">Automation element</param>
        /// <returns>Invoke pattern object if supported else null</returns>
        public static InvokePattern GetInvokePattern(this AutomationElement element)
        {
            return element.GetPattern<InvokePattern>(InvokePattern.Pattern);
        }

        /// <summary>
        /// Sends a request to activate a control and initiate its single, unambiguous action.
        /// </summary>
        /// <param name="element">Button element</param>
        /// <throws><see cref="InvalidOperationException"/> if the control does not support the InvokePattern control pattern or is hidden or blocked.</throws>
        /// <throws><see cref="ElementNotEnabledException"/> The element is not enabled. Can be raised when a UI Automation provider has implemented its own handling of the IsEnabled property.</throws>
        public static void Click(this AutomationElement element)
        {
            element.GetInvokePattern().Invoke();
        }
    }
}

