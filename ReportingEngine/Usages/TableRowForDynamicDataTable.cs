

using ReportingEngine.Interfaces;
using System.Windows.Documents;

namespace ReportingEngine.Usages
{
    /// <summary>
    /// Class for fillable table row values
    /// </summary>
    public class TableRowForDynamicDataTable : TableRow, ITableRowForDynamicDataTable
    {
        private string _tableName;
        /// <summary>
        /// Gets or sets the table name
        /// </summary>
        public string TableName
        {
            get { return _tableName; }
            set { _tableName = value; }
        }
    }
}
