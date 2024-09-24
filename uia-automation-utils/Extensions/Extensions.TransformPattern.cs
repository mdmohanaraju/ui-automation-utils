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

