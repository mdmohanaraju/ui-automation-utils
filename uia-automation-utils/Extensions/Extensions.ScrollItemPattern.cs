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
        /// Get ScrollItem pattern object
        /// </summary>
        /// <param name="element">Automation element</param>
        /// <returns>ScrollItem pattern object if supported else null</returns>
        public static ScrollItemPattern GetScrollItemPattern(this AutomationElement element)
        {
            return element.GetPattern<ScrollItemPattern>(ScrollItemPattern.Pattern);
        }

        /// <summary>
        /// Scrolls the content area of a container object in order to display the AutomationElement within the visible region (viewport) of the container.
        /// </summary>
        /// <param name="element">Scrollable element</param>
        public static void ScrollIntoView(this AutomationElement element)
        {
            element.GetScrollItemPattern().ScrollIntoView();
        }
    }
}

