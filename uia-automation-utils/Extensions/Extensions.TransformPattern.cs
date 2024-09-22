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

namespace UIA.Automation.Utils.Extensions
{
    /// <summary>
    /// Extensions for <see cref="AutomationElement"/> objec t
    /// </summary>
    public static partial class AutomationElementExtensions
    {
        /// <summary>
        /// Get Transform pattern object
        /// </summary>
        /// <param name="element">Automation element</param>
        /// <returns>Window Transform object if supported else null</returns>
        public static TransformPattern GetTransformPattern(this AutomationElement element)
        {
            return element.GetPattern<TransformPattern>(TransformPattern.Pattern);
        }

        /// <summary>
        /// Move window
        /// </summary>
        /// <param name="element">Window element</param>
        /// <param name="x">The new X position</param>
        /// <param name="y">The new Y position</param>
        public static void MoveWindow(this AutomationElement element, double x, double y)
        {
            element.GetTransformPattern().Move(x, y);
        }

        /// <summary>
        /// Resize window
        /// </summary>
        /// <param name="element">Window element</param>
        /// <param name="width">Resize width</param>
        /// <param name="height">Resize height</param>
        public static void ResizeWindow(this AutomationElement element, double width, double height)
        {
            element.GetTransformPattern().Resize(width, height);
        }

        /// <summary>
        /// Roate window in closewise direction 
        /// </summary>
        /// <param name="element">Window element</param>
        /// <param name="degrees">Degress to rotate the element</param>
        public static void RotateClockWise(this AutomationElement element, double degrees)
        {
            element.GetTransformPattern().Rotate(degrees);
        }

        /// <summary>
        /// Rotate window in the anti clockwise direction
        /// </summary>
        /// <param name="element">Window element</param>
        /// <param name="degrees">Degress to rotate the element</param>
        public static void RotateAntiClockWise(this AutomationElement element, double degrees)
        {
            element.GetTransformPattern().Rotate(-degrees);
        }

        /// <summary>
        /// Gets whether the window can be repositioned
        /// </summary>
        /// <param name="element">Window element</param>
        /// <returns>true if can be moved else false</returns>
        public static bool CanMoveWindow(this AutomationElement element)
        {
            return element.GetTransformPattern().Current.CanMove;
        }

        /// <summary>
        /// Gets whether the window can resized
        /// </summary>
        /// <param name="element">Window element</param>
        /// <returns>true if can resize else false</returns>
        public static bool CanResizeWindow(this AutomationElement element)
        {
            return element.GetTransformPattern().Current.CanResize;
        }

        /// <summary>
        /// Gets whether the window can be rotated
        /// </summary>
        /// <param name="element">Window element</param>
        /// <returns>true if can rotate else false</returns>
        public static bool CanRotateWindow(this AutomationElement element)
        {
            return element.GetTransformPattern().Current.CanRotate;
        }

    }
}

