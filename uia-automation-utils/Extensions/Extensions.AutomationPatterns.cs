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

