using System;
using System.Windows.Automation;

namespace UIA.Automation.Utils.Extensions
{
	/// <summary>
	/// Extensions for <see cref="AutomationElement"/> objec t
	/// </summary>
	public static partial class AutomationElementExtensions
	{
        public static RangeValuePattern GetRangeValuePattern(this AutomationElement element)
        {
            return element.GetPattern<RangeValuePattern>(RangeValuePattern.Pattern);
        }

        public static void SetRange(this AutomationElement element, double value)
		{
            var rangeValuePattern = element.GetPattern<RangeValuePattern>(RangeValuePattern.Pattern);
            rangeValuePattern?.SetValue(value);
        }

        public static bool IsReadOnly(this AutomationElement element)
        {
            var rangeValuePattern = element.GetPattern<RangeValuePattern>(RangeValuePattern.Pattern);
            return rangeValuePattern.Current.IsReadOnly;
        }

        public static double GetRange(this AutomationElement element)
        {
            var rangeValuePattern = element.GetPattern<RangeValuePattern>(RangeValuePattern.Pattern);
            return rangeValuePattern.Current.Value;
        }

        public static double GetMaximumRange(this AutomationElement element)
        {
            var rangeValuePattern = element.GetPattern<RangeValuePattern>(RangeValuePattern.Pattern);
            return rangeValuePattern.Current.Maximum;
        }

        public static double GetMinimumRange(this AutomationElement element)
        {
            var rangeValuePattern = element.GetPattern<RangeValuePattern>(RangeValuePattern.Pattern);
            return rangeValuePattern.Current.Minimum;
        }
    }
}

