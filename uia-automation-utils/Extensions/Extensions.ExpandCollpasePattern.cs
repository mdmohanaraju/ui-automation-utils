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
using Interop.UIAutomationClient;

namespace UIA.Automation.Utils.Extensions
{
    /// <summary>
    /// Extensions for <see cref="AutomationElement"/> objec t
    /// </summary>
    public static partial class AutomationElementExtensions
	{
        /// <summary>
        /// Get expand collapse pattern object
        /// </summary>
        /// <param name="element">Automation element</param>
        /// <returns>ExpandCollapse pattern object if supported else null</returns>    
        public static ExpandCollapsePattern GetExpandCollpasePattern(this AutomationElement element)
        {
            return element.GetPattern<ExpandCollapsePattern>(ExpandCollapsePattern.Pattern);
        }

        /// <summary>
        /// Displays all child nodes, controls, or content of the AutomationElement.
        /// </summary>
        /// <param name="element">Tree node, combo box or any expandable control</param>
        public static void Expand(this AutomationElement element)
        {
            element.GetExpandCollpasePattern().Expand();
        }

        /// <summary>
        /// Hides all descendant nodes, controls, or content of the AutomationElement.
        /// </summary>
        /// <param name="element">Tree node, combo box or any expandable control</param>
        public static void Collapse(this AutomationElement element)
        {
            element.GetExpandCollpasePattern().Collapse();
        }

        /// <summary>
        /// Gets whether the element is expanded
        /// </summary>
        /// <param name="element">Tree node, combo box or any expandable control</param>
        /// <returns>true if expanded; else false</returns>
        public static bool IsExpanded(this AutomationElement element)
        {
            return element.GetExpandCollpasePattern().Current.ExpandCollapseState == ExpandCollapseState.ExpandCollapseState_Expanded;
        }

        /// <summary>
        /// Gets whether the element is collapsed
        /// </summary>
        /// <param name="element">Tree node, combo box or any expandable control</param>
        /// <returns>true if collapsed; else false</returns>
        public static bool IsCollapsed(this AutomationElement element)
        {
            return element.GetExpandCollpasePattern().Current.ExpandCollapseState == ExpandCollapseState.ExpandCollapseState_Collapsed;
        }

        /// <summary>
        /// Gets whether the element is a leaf node
        /// </summary>
        /// <param name="element">Tree node</param>
        /// <returns>true if leaf node; else false</returns>
        public static bool IsLeafNode(this AutomationElement element)
        {
            return element.GetExpandCollpasePattern().Current.ExpandCollapseState == ExpandCollapseState.ExpandCollapseState_LeafNode;
        }

        /// <summary>
        /// Gets whether the element is partially expanded
        /// </summary>
        /// <param name="element">Tree node, combo box or any expandable control</param>
        /// <returns>true if partially expanded; else false</returns>
        public static bool IsPartiallyExpanded(this AutomationElement element)
        {
            return element.GetExpandCollpasePattern().Current.ExpandCollapseState == ExpandCollapseState.ExpandCollapseState_PartiallyExpanded;
        }
    }
}

