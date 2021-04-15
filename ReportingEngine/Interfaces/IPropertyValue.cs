
namespace ReportingEngine.Interfaces
{
    /// <summary>
    /// Interface for property values
    /// </summary>
    public interface IPropertyValue : IHasValue
    {
        /// <summary>
        /// Gets or sets the property name
        /// </summary>
        string PropertyName { get; set; }
    }
}
