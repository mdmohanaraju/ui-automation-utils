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
    /// Extensions for <see cref="AutomationElement"/> objec t
    /// </summary>
    public static partial class AutomationElementExtensions
	{
		/// <summary>
		/// Get the <see cref="AutomationPattern"/> object for the <see cref="AutomationElement"/>
		/// </summary>
		/// <typeparam name="T">Type of the automation pattern object</typeparam>
		/// <param name="element">The elmeent for which the automation pattern is looked into</param>
		/// <param name="pattern">The Automation pattern for which object is to be created</param>
		/// <returns>The <see cref="AutomationPattern"/> object if valid else null</returns>
		public static T GetPattern<T>(this AutomationElement element, AutomationPattern pattern)
		{
			var isSupportedPattern = element.TryGetCurrentPattern(pattern, out var patternObj);
			if (isSupportedPattern)
			{
				return (T)patternObj;
			}

            return default(T);
        }        
    }
}

