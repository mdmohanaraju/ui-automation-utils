#region Copyright (c) 2024 Mohanraj Devadoss
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:

// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.

// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
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

