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
    /// Extensions for <see cref="AutomationElement"/> objec t
    /// </summary>
    public static partial class AutomationElementExtensions
	{
        /// <summary>
        /// Get RangeValue pattern object
        /// </summary>
        /// <param name="element">Automation element</param>
        /// <returns>RangeValue pattern object if supported else null</returns>
        public static RangeValuePattern GetRangeValuePattern(this AutomationElement element)
        {
            return element.GetPattern<RangeValuePattern>(RangeValuePattern.Pattern);
        }

        public static void SetRange(this AutomationElement element, double value)
        {
            var rangeValuePattern = element.GetPattern<RangeValuePattern>(RangeValuePattern.Pattern);
            rangeValuePattern?.SetValue(value);
        }

        /// <summary>
        /// Gets a value that specifies whether the value of a UI Automation element is read-only.
        /// </summary>
        /// <param name="element">Represents a control that can be set to a value within a range.</param>
        /// <returns>true if the value is read-only; false if it can be modified. The default is true.</returns>
        public static bool IsReadOnly(this AutomationElement element)
        {
            var rangeValuePattern = element.GetPattern<RangeValuePattern>(RangeValuePattern.Pattern);
            return rangeValuePattern.Current.IsReadOnly;
        }

        /// <summary>
        /// Gets the current value of the UI Automation element.
        /// </summary>
        /// <param name="element">Represents a control that can be set to a value within a range.</param>
        /// <returns>The current value of the UI Automation element or null if the element does not support Value. The default value is 0.0.</returns>
        public static double GetRange(this AutomationElement element)
        {
            var rangeValuePattern = element.GetPattern<RangeValuePattern>(RangeValuePattern.Pattern);
            return rangeValuePattern.Current.Value;
        }

        /// <summary>
        /// Gets the maximum range value supported by the UI Automation element.
        /// </summary>
        /// <param name="element">Represents a control that can be set to a value within a range.</param>
        /// <returns>The maximum value supported by the UI Automation element or null if the element does not support Maximum. The default value is 0.0.</returns>
        public static double GetMaximumRange(this AutomationElement element)
        {
            var rangeValuePattern = element.GetPattern<RangeValuePattern>(RangeValuePattern.Pattern);
            return rangeValuePattern.Current.Maximum;
        }

        /// <summary>
        /// Gets the minimum range value supported by the UI Automation element.
        /// </summary>
        /// <param name="element">Represents a control that can be set to a value within a range.</param>
        /// <returns>he minimum value supported by the UI Automation element or null if the element does not support Minimum. The default value is 0.0.</returns>
        public static double GetMinimumRange(this AutomationElement element)
        {
            var rangeValuePattern = element.GetPattern<RangeValuePattern>(RangeValuePattern.Pattern);
            return rangeValuePattern.Current.Minimum;
        }

        /// <summary>
        /// Gets the control-specific large-change value which is added to or subtracted from the Value property.
        /// </summary>
        /// <param name="element">Represents a control that can be set to a value within a range.</param>
        /// <returns>The large-change value or null if the element does not support LargeChange. The default value is 0.0.</returns>
        public static double GetLargeChange(this AutomationElement element)
        {
            var rangeValuePattern = element.GetPattern<RangeValuePattern>(RangeValuePattern.Pattern);
            return rangeValuePattern.Current.LargeChange;
        }

        /// <summary>
        /// Gets the control-specific small-change value which is added to or subtracted from the Value property.
        /// </summary>
        /// <param name="element">Represents a control that can be set to a value within a range.</param>
        /// <returns>The small-change value unique to the UI Automation element or null if the element does not support SmallChange. The default value is 0.0.</returns>
        public static double GetSmallChange(this AutomationElement element)
        {
            var rangeValuePattern = element.GetPattern<RangeValuePattern>(RangeValuePattern.Pattern);
            return rangeValuePattern.Current.SmallChange;
        }
    }
}

