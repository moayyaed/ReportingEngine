

namespace ReportingEngine.Interfaces
{
    /// <summary>
    /// Interface for values
    /// </summary>
    public interface IHasValue
    {
        /// <summary>
        /// Gets or sets the value format
        /// </summary>
        string Format { get; set; }

        /// <summary>
        /// Gets or sets the object value
        /// </summary>
        object Value { get; set; }
    }
}
