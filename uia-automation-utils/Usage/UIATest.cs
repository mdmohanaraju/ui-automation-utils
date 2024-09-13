using UIA.Automation.Utils.Search;

namespace UIA.Automation.Utils.Usage
{
    /// <summary>
    /// Test class for UIAElement
    /// </summary>
    public class UIATest
    {
        /// <summary>
        /// Method to demonstrate how to use find first
        /// </summary>
        public void FindFirst()
        {
            UIAElement.Search.WithName("Calculator").WithAutomationId("CalculatorResults").FindFirst();
        }

        /// <summary>
        /// Method to demonstrate how to use find all
        /// </summary>
        public void FindAll()
        {
            UIAElement.Search.WithName("Calculator").WithAutomationId("CalculatorResults").FindAll();
        }
    }
}
