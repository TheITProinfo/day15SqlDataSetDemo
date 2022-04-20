using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day15SqlDataSetDemo
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet("DS19");

            DataTable dt1 = new DataTable("dt1");

            #region First data table
            ds.Tables.Add(dt1);
            // define column

            DataColumn dcName = new DataColumn("Name", typeof(string));
            DataColumn dcAge = new DataColumn("Age", typeof(int));
            DataColumn dcID = new DataColumn("ID", typeof(int));

            dt1.Columns.AddRange(new DataColumn[] { dcID, dcAge, dcName });
            dt1.Rows.Add(1, 20, "Tom");
            dt1.Rows.Add(2, 30, "Jerry");
            dt1.Rows.Add(3, 40, "Alice");
            #endregion
            
            // create 2nd table dt2
            DataTable dt2 = new DataTable("dt2");
            ds.Tables.Add(dt2);
            // define column

            DataColumn dcName2 = new DataColumn("Name", typeof(string));
            DataColumn dcAge2 = new DataColumn("Age", typeof(int));
            DataColumn dcID2 = new DataColumn("ID", typeof(int));

            dt2.Columns.AddRange(new DataColumn[] { dcID2, dcAge2, dcName2 });
            dt2.Rows.Add(1, 18, "John");
            dt2.Rows.Add(2, 28, "Petter");
            dt2.Rows.Add(3, 38, "Harry");


            foreach (DataTable tb in ds.Tables)
            {
                foreach (DataRow  dataRow in  tb.Rows)
                {
                    Console.WriteLine(dataRow[0]+"   "+dataRow[1]+"  "+dataRow[2]);
                }
            }





        }
    }
}
