using System;
using System.Windows.Automation;
using Interop.UIAutomationClient;

namespace UIA.Automation.Utils.Extensions
{
	/// <summary>
	/// Extensions for <see cref="AutomationElement"/> objec t
	/// </summary>
	public static partial class AutomationElementExtensions
	{        
        public static ExpandCollapsePattern GetExpandCollpasePattern(this AutomationElement element)
        {
            return element.GetPattern<ExpandCollapsePattern>(ExpandCollapsePattern.Pattern);
        }

        public static void Expand(this AutomationElement element)
        {
            element.GetExpandCollpasePattern().Expand();
        }

        public static void Collapse(this AutomationElement element)
        {
            element.GetExpandCollpasePattern().Collapse();
        }

        public static bool IsExpanded(this AutomationElement element)
        {
            return element.GetExpandCollpasePattern().Current.ExpandCollapseState == ExpandCollapseState.ExpandCollapseState_Expanded;
        }

        public static bool IsCollapsed(this AutomationElement element)
        {
            return element.GetExpandCollpasePattern().Current.ExpandCollapseState == ExpandCollapseState.ExpandCollapseState_Collapsed;
        }

        public static bool IsLeafNode(this AutomationElement element)
        {
            return element.GetExpandCollpasePattern().Current.ExpandCollapseState == ExpandCollapseState.ExpandCollapseState_LeafNode;
        }

        public static bool IsPartiallyExpanded(this AutomationElement element)
        {
            return element.GetExpandCollpasePattern().Current.ExpandCollapseState == ExpandCollapseState.ExpandCollapseState_PartiallyExpanded;
        }
    }
}

