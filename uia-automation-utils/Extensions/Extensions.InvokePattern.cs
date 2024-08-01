using System;
using System.Windows.Automation;

namespace UIA.Automation.Utils.Extensions
{
	/// <summary>
	/// Extensions for <see cref="AutomationElement"/> objec t
	/// </summary>
    public static partial class AutomationElementExtensions
    {
        public static InvokePattern GetInvokePattern(this AutomationElement element)
        {
            return element.GetPattern<InvokePattern>(InvokePattern.Pattern);
        }

        public static void Click(this AutomationElement element)
        {
            element.GetInvokePattern().Invoke();
        }
    }
}

