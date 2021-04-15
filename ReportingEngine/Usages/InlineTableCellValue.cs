
using ReportingEngine.Interfaces;
using System.IO;

namespace ReportingEngine.Usages
{
    /// <summary>
    /// Ccontains a single report value that is to be displayed on the report (e.g. report title)
    /// </summary>
    public class InlineTableCellValue : InlinePropertyValue, ITableCellValue
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
