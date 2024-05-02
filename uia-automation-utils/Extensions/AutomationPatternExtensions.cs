using System;
using System.Windows.Automation;

namespace UIA.Automation.Utils.Extensions
{
	public static class AutomationPatternExtensions
	{
		public static T GetPattern<T>(this AutomationElement element, AutomationPattern pattern)
		{
			var isSupportedPattern = element.TryGetCurrentPattern(pattern, out var patternObj);
			if (isSupportedPattern)
			{
				return (T)patternObj;
			}

#pragma warning disable CS8603 // Possible null reference return.
            return default;
#pragma warning restore CS8603 // Possible null reference return.
        }

        public static InvokePattern GetInvokePattern(this AutomationElement element)
        {
			return element.GetPattern<InvokePattern>(InvokePattern.Pattern);			
        }
    }
}

