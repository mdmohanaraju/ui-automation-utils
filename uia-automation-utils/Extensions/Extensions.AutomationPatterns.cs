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

#pragma warning disable CS8603 // Possible null reference return.
            return default;
#pragma warning restore CS8603 // Possible null reference return.
        }        
    }
}

