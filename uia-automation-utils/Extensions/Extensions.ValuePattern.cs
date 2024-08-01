using System;
using System.Windows.Automation;

namespace UIA.Automation.Utils.Extensions
{
	/// <summary>
	/// Extensions for <see cref="AutomationElement"/> objec t
	/// </summary>
	public static partial class AutomationElementExtensions
    {
        public static ValuePattern GetValuePattern(this AutomationElement element)
        {
            return element.GetPattern<ValuePattern>(ValuePattern.Pattern);
        }

        public static void EnterText(this AutomationElement element, string value)
        {
            element.GetValuePattern().SetValue(value);
        }

        public static string GetValue(this AutomationElement element)
        {
            return element.GetValuePattern().Current.Value;
        }
    }
}

