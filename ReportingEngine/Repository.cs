using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportingEngine
{
    public class Repository
    {
        DataTable data;
        public Repository()
        {
            data = new DataTable();
            data.Columns.Add("Name");
            data.Columns.Add("Address");
            data.Columns.Add("City");

            data.Rows.Add(new object[] { "Basharat Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Arif Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Saadat Ali", "Sofipora, Wallarhama", "Anantnag" });
            data.Rows.Add(new object[] { "Mohsen Hassan", "Arabal, Shalimar", "Anantnag" });
            data.Rows.Add(new object[] { "Basharat Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Arif Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Saadat Ali", "Sofipora, Wallarhama", "Anantnag" });
            data.Rows.Add(new object[] { "Mohsen Hassan", "Arabal, Shalimar", "Anantnag" });
            data.Rows.Add(new object[] { "Basharat Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Arif Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Saadat Ali", "Sofipora, Wallarhama", "Anantnag" });
            data.Rows.Add(new object[] { "Mohsen Hassan", "Arabal, Shalimar", "Anantnag" });
            data.Rows.Add(new object[] { "Basharat Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Arif Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Saadat Ali", "Sofipora, Wallarhama", "Anantnag" });
            data.Rows.Add(new object[] { "Mohsen Hassan", "Arabal, Shalimar", "Anantnag" });
            data.Rows.Add(new object[] { "Basharat Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Arif Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Saadat Ali", "Sofipora, Wallarhama", "Anantnag" });
            data.Rows.Add(new object[] { "Mohsen Hassan", "Arabal, Shalimar", "Anantnag" });
            data.Rows.Add(new object[] { "Basharat Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Arif Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Saadat Ali", "Sofipora, Wallarhama", "Anantnag" });
            data.Rows.Add(new object[] { "Mohsen Hassan", "Arabal, Shalimar", "Anantnag" });
            data.Rows.Add(new object[] { "Basharat Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Arif Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Saadat Ali", "Sofipora, Wallarhama", "Anantnag" });
            data.Rows.Add(new object[] { "Mohsen Hassan", "Arabal, Shalimar", "Anantnag" });
            data.Rows.Add(new object[] { "Basharat Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Arif Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Saadat Ali", "Sofipora, Wallarhama", "Anantnag" });
            data.Rows.Add(new object[] { "Mohsen Hassan", "Arabal, Shalimar", "Anantnag" });
            data.Rows.Add(new object[] { "Basharat Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Arif Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Saadat Ali", "Sofipora, Wallarhama", "Anantnag" });
            data.Rows.Add(new object[] { "Mohsen Hassan", "Arabal, Shalimar", "Anantnag" });
            data.Rows.Add(new object[] { "Basharat Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Arif Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Saadat Ali", "Sofipora, Wallarhama", "Anantnag" });
            data.Rows.Add(new object[] { "Mohsen Hassan", "Arabal, Shalimar", "Anantnag" });
            data.Rows.Add(new object[] { "Basharat Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Arif Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Saadat Ali", "Sofipora, Wallarhama", "Anantnag" });
            data.Rows.Add(new object[] { "Mohsen Hassan", "Arabal, Shalimar", "Anantnag" });
            data.Rows.Add(new object[] { "Basharat Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Arif Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Saadat Ali", "Sofipora, Wallarhama", "Anantnag" });
            data.Rows.Add(new object[] { "Mohsen Hassan", "Arabal, Shalimar", "Anantnag" });
            data.Rows.Add(new object[] { "Basharat Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Arif Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Saadat Ali", "Sofipora, Wallarhama", "Anantnag" });
            data.Rows.Add(new object[] { "Mohsen Hassan", "Arabal, Shalimar", "Anantnag" });
            data.Rows.Add(new object[] { "Basharat Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Arif Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Saadat Ali", "Sofipora, Wallarhama", "Anantnag" });
            data.Rows.Add(new object[] { "Mohsen Hassan", "Arabal, Shalimar", "Anantnag" });
            data.Rows.Add(new object[] { "Basharat Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Arif Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Saadat Ali", "Sofipora, Wallarhama", "Anantnag" });
            data.Rows.Add(new object[] { "Mohsen Hassan", "Arabal, Shalimar", "Anantnag" });
            data.Rows.Add(new object[] { "Basharat Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Arif Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Saadat Ali", "Sofipora, Wallarhama", "Anantnag" });
            data.Rows.Add(new object[] { "Mohsen Hassan", "Arabal, Shalimar", "Anantnag" });
            data.Rows.Add(new object[] { "Basharat Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Arif Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Saadat Ali", "Sofipora, Wallarhama", "Anantnag" });
            data.Rows.Add(new object[] { "Mohsen Hassan", "Arabal, Shalimar", "Anantnag" });
            data.Rows.Add(new object[] { "Basharat Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Arif Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Saadat Ali", "Sofipora, Wallarhama", "Anantnag" });
            data.Rows.Add(new object[] { "Mohsen Hassan", "Arabal, Shalimar", "Anantnag" });
            data.Rows.Add(new object[] { "Basharat Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Arif Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Saadat Ali", "Sofipora, Wallarhama", "Anantnag" });
            data.Rows.Add(new object[] { "Mohsen Hassan", "Arabal, Shalimar", "Anantnag" });
            data.Rows.Add(new object[] { "Basharat Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Arif Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Saadat Ali", "Sofipora, Wallarhama", "Anantnag" });
            data.Rows.Add(new object[] { "Mohsen Hassan", "Arabal, Shalimar", "Anantnag" });
            data.Rows.Add(new object[] { "Basharat Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Arif Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Saadat Ali", "Sofipora, Wallarhama", "Anantnag" });
            data.Rows.Add(new object[] { "Mohsen Hassan", "Arabal, Shalimar", "Anantnag" });
            data.Rows.Add(new object[] { "Basharat Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Arif Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Saadat Ali", "Sofipora, Wallarhama", "Anantnag" });
            data.Rows.Add(new object[] { "Mohsen Hassan", "Arabal, Shalimar", "Anantnag" });
            data.Rows.Add(new object[] { "Basharat Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Arif Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Saadat Ali", "Sofipora, Wallarhama", "Anantnag" });
            data.Rows.Add(new object[] { "Mohsen Hassan", "Arabal, Shalimar", "Anantnag" });
            data.Rows.Add(new object[] { "Basharat Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Arif Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Saadat Ali", "Sofipora, Wallarhama", "Anantnag" });
            data.Rows.Add(new object[] { "Mohsen Hassan", "Arabal, Shalimar", "Anantnag" });
            data.Rows.Add(new object[] { "Basharat Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Arif Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Saadat Ali", "Sofipora, Wallarhama", "Anantnag" });
            data.Rows.Add(new object[] { "Mohsen Hassan", "Arabal, Shalimar", "Anantnag" });
            data.Rows.Add(new object[] { "Basharat Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Arif Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Saadat Ali", "Sofipora, Wallarhama", "Anantnag" });
            data.Rows.Add(new object[] { "Mohsen Hassan", "Arabal, Shalimar", "Anantnag" });
            data.Rows.Add(new object[] { "Basharat Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Arif Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Saadat Ali", "Sofipora, Wallarhama", "Anantnag" });
            data.Rows.Add(new object[] { "Mohsen Hassan", "Arabal, Shalimar", "Anantnag" });
            data.Rows.Add(new object[] { "Basharat Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Arif Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Saadat Ali", "Sofipora, Wallarhama", "Anantnag" });
            data.Rows.Add(new object[] { "Mohsen Hassan", "Arabal, Shalimar", "Anantnag" });
            data.Rows.Add(new object[] { "Basharat Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Arif Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Saadat Ali", "Sofipora, Wallarhama", "Anantnag" });
            data.Rows.Add(new object[] { "Mohsen Hassan", "Arabal, Shalimar", "Anantnag" });
            data.Rows.Add(new object[] { "Basharat Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Arif Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Saadat Ali", "Sofipora, Wallarhama", "Anantnag" });
            data.Rows.Add(new object[] { "Mohsen Hassan", "Arabal, Shalimar", "Anantnag" });
            data.Rows.Add(new object[] { "Basharat Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Arif Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Saadat Ali", "Sofipora, Wallarhama", "Anantnag" });
            data.Rows.Add(new object[] { "Mohsen Hassan", "Arabal, Shalimar", "Anantnag" });
            data.Rows.Add(new object[] { "Basharat Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Arif Hussain", "Arabal, Shalimar", "Srinagar" });
            data.Rows.Add(new object[] { "Saadat Ali", "Sofipora, Wallarhama", "Anantnag" });
            data.Rows.Add(new object[] { "Mohsen Hassan", "Arabal, Shalimar", "Anantnag" });



        }

        public DataTable GetData()
        {
            return data;
        }
    }
}
