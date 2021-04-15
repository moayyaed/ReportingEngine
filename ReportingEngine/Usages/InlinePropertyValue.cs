

using ReportingEngine.Interfaces;
using System.Windows;

namespace ReportingEngine.Usages
{
    /// <summary>
    /// Abstract class for fillable run values
    /// </summary>
    public abstract class InlinePropertyValue : InlineHasValue, IPropertyValue
    {
        /// <summary>
        /// Gets or sets the property name
        /// </summary>
        public virtual string PropertyName
        {
            get { return (string)GetValue(PropertyNameProperty); }
            set { SetValue(PropertyNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PropertyName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PropertyNameProperty =
            DependencyProperty.Register("PropertyName", typeof(string), typeof(InlinePropertyValue), new UIPropertyMetadata(null));
    }
}
