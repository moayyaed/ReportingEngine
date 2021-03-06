

using ReportingEngine.Usages;

namespace ReportingEngine.Interfaces
{
    /// <summary>
    /// Condition interface
    /// </summary>
    public interface IDocumentCondition
    {
        /// <summary>
        /// Invert the condition
        /// </summary>
        bool ConditionInvert { get; set; }

        /// <summary>
        /// Condition property name
        /// </summary>
        string ConditionPropertyName { get; set; }

        /// <summary>
        /// Condition property value
        /// </summary>
        object ConditionPropertyValue { get; set; }

        /// <summary>
        /// Checks if a condition is fulfilled
        /// </summary>
        /// <param name="reportData">report data</param>
        /// <returns>true, if condition is fulfilled</returns>
        bool CheckConditionFulfilled(ReportData reportData);

        /// <summary>
        /// Perform the needed action to change the rendering
        /// </summary>
        /// <param name="reportData">report data</param>
        void PerformRenderUpdate(ReportData reportData);
    }
}
