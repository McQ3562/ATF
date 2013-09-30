using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATF
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            List<List<string>> results = new List<List<string>>();
            DB_Connection conn = new DB_Connection(DB_ConnectionString.GetAFT_ConfigConnectionString());
            results = conn.ReturnQuery("EXEC sp_GetTestCaseList");

            if (results.Count > 0)
            {
                for (int counter = 1; counter < results[0].Count; counter++)
                {
                    comboBox_TestPlan.Items.Add(results[0][counter]);
                }
            }
        }
    }
}
