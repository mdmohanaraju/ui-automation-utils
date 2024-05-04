using System;
using System.Windows.Automation;

namespace UIA.Automation.Utils.Extensions
{
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
            return element.GetExpandCollpasePattern().Current.ExpandCollapseState == ExpandCollapseState.Expanded;
        }

        public static bool IsCollapsed(this AutomationElement element)
        {
            return element.GetExpandCollpasePattern().Current.ExpandCollapseState == ExpandCollapseState.Collapsed;
        }

        public static bool IsLeafNode(this AutomationElement element)
        {
            return element.GetExpandCollpasePattern().Current.ExpandCollapseState == ExpandCollapseState.LeafNode;
        }

        public static bool IsPartiallyExpanded(this AutomationElement element)
        {
            return element.GetExpandCollpasePattern().Current.ExpandCollapseState == ExpandCollapseState.PartiallyExpanded;
        }
    }
}

