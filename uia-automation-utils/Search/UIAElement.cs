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

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Automation;
using Interop.UIAutomationClient;

namespace UIA.Automation.Utils.Search
{
    /// <summary>
    /// Class to find desktop elements using Microsoft UIA framework
    /// </summary>
	public class UIAElement
	{
        private List<PropertyCondition> _propertyConditions = new List<PropertyCondition>();
        private TreeScope _treeScope = TreeScope.TreeScope_Subtree;
        private AutomationElement _parentElement;

        /// <summary>
        /// Private constructor to prevent instantiation
        /// </summary>
        private UIAElement()
        {
        }

        /// <summary>
        /// Gets the root element for the automation hiearchy
        /// </summary>
        public static AutomationElement Desktop => AutomationElement.RootElement;

        /// <summary>
        /// Gets the element currenly in focus at the mouse location
        /// </summary>
        public static AutomationElement FocusedElement => AutomationElement.FocusedElement;

        /// <summary>
        /// Gets the element located at the given x and y co-ordinate
        /// </summary>
        /// <param name="x">The physical X co-ordinate of the UI element in the desktop</param>
        /// <param name="y">The physical Y co-ordinate of the UI element in the desktop</param>
        /// <returns><see cref="AutomationElement"/> at the given x and y co-ordinate</returns>
        public static AutomationElement FromPoint(int x, int y) => AutomationElement.FromPoint(new Point(x, y));

        /// <summary>
        /// Gets the element search context
        /// </summary>
        public static UIAElement Search => new UIAElement();

        /// <summary>
        /// Gets the element referenced by the given window handle
        /// </summary>
        /// <param name="windowHandle">The handle of the UI element</param>
        /// <returns></returns>
        public static AutomationElement FromHandle(int windowHandle) => AutomationElement.FromHandle(new IntPtr(windowHandle));

        /// <summary>
        /// Add name property as a search condition
        /// </summary>
        /// <param name="name">The name of the UI element</param>
        /// <returns>The <see cref="Element"/> search context object</returns>
        public UIAElement WithName(string name)
        {
            AddPropertyCondition(AutomationElement.NameProperty, name);
            return this;
        }

        /// <summary>
        /// Add name property as a search condition
        /// </summary>
        /// <param name="id">The name of the UI element</param>
        /// <returns>The <see cref="Element"/> search context object</returns>
        public UIAElement WithAutomationId(string id)
        {
            AddPropertyCondition(AutomationElement.AutomationIdProperty, id);
            return this;
        }

        /// <summary>
        /// Add name property as a search condition
        /// </summary>
        /// <param name="className">The name of the UI element</param>
        /// <returns>The <see cref="Element"/> search context object</returns>
        public UIAElement WithClassName(string className)
        {
            AddPropertyCondition(AutomationElement.ClassNameProperty, className);
            return this;
        }

        /// <summary>
        /// Add name property as a search condition
        /// </summary>
        /// <param name="helpText">The name of the UI element</param>
        /// <returns>The <see cref="Element"/> search context object</returns>
        public UIAElement WithHelpText(string helpText)
        {
            AddPropertyCondition(AutomationElement.HelpTextProperty, helpText);
            return this;
        }

        /// <summary>
        /// Add name property as a search condition
        /// </summary>
        /// <param name="treeScope">The name of the UI element</param>
        /// <returns>The <see cref="Element"/> search context object</returns>
        public UIAElement WithTreeScope(TreeScope treeScope)
        {
            _treeScope = treeScope;
            return this;
        }

        /// <summary>
        /// Add name property as a search condition
        /// </summary>
        /// <param name="name">The name of the UI element</param>
        /// <returns>The <see cref="Element"/> search context object</returns>
        public UIAElement WithParent(AutomationElement parentElement)
        {
            _parentElement = parentElement;
            return this;
        }


        /// <summary>
        /// Find first element that satisfies the serach conditions
        /// </summary>
        /// <returns>Found <see cref="AutomationElement"/></returns>
        public AutomationElement FindFirst()
        {
            var searchConditions = GetSearchConditions();
            var parent = _parentElement ?? Desktop;
            return parent.FindFirst(_treeScope, searchConditions);
        }

        /// <summary>
        /// Find all elements that satisfy the search conditions
        /// </summary>
        /// <returns>All elements as <see cref="AutomationElement"/> objects</returns>
        public IEnumerable<AutomationElement> FindAll()
        {
            var searchConditions = GetSearchConditions();
            var parent = _parentElement ?? Desktop;
            var elements = parent.FindAll(_treeScope, searchConditions);

            foreach(AutomationElement element in elements)
            {
                yield return element;
            }
        }

        private void AddPropertyCondition(AutomationProperty automationProperty, object value)
        {
            RemoveSearchConditionIfExistsForProperty(automationProperty);
            _propertyConditions.Add(new PropertyCondition(automationProperty, value, PropertyConditionFlags.PropertyConditionFlags_IgnoreCase));
        }

        private void RemoveSearchConditionIfExistsForProperty(AutomationProperty automationProperty)
        {
            if(_propertyConditions.Any(searchCondition => searchCondition.Property.ProgrammaticName == automationProperty.ProgrammaticName))
            {
                _propertyConditions = _propertyConditions.Where(condition => condition.Property.ProgrammaticName != automationProperty.ProgrammaticName).ToList();
            }
        }

        private Condition GetSearchConditions()
        {
            return new AndCondition(_propertyConditions.ToArray());
        }
    }
}

