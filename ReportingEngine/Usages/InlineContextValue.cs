

using ReportingEngine.Interfaces;
using System.IO;

namespace ReportingEngine.Usages
{
    /// <summary>
    /// Contains a single report context value that is to be displayed on the report
    /// </summary>
    public class InlineContextValue : InlinePropertyValue, IAggregateValue, IInlineContextValue, IInlinePropertyValue
    {
        private string _aggregateGroup;
        /// <summary>
        /// Gets or sets the aggregate group
        /// </summary>
        public string AggregateGroup
        {
            get { return _aggregateGroup; }
            set { _aggregateGroup = value; }
        }
    }
}
