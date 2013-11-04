using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATF
{
    public partial class Form_Add_TestPlan : Form
    {
        public Form_Add_TestPlan()
        {
            InitializeComponent();
        }

        private void Form_Add_TestPlan_Load(object sender, EventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            TestPlan.AddTestPlan(textBox_Text.Text, comboBox_Browser.Text);
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class BrowserList
    {

        ArrayList browserList = new ArrayList();

        public void Load()
        {
            List<List<string>> results = new List<List<string>>();
            DB_Connection conn = new DB_Connection(DB_ConnectionString.GetAFT_ConfigConnectionString());
            results = conn.ReturnQuery("EXEC sp_GetBrowserList");

            if (results.Count > 0)
            {
                ArrayList testPlanList = new ArrayList();
                for (int counter = 1; counter < results[0].Count; counter++)
                {
                    //comboBox_TestPlan.Items.Add(results[1][counter]);
                    testPlanList.Add(new TestPlanList(results[2][counter],results[1][counter]));
                }

                comboBox_TestPlan.DataSource = testPlanList;
                comboBox_TestPlan.DisplayMember = "TestPlanName";
                comboBox_TestPlan.ValueMember = "TestPlanID";
            }
        }
    }

    public class Browser
    {
        string browserID;
        string browserName;

        public string BrowserID { get { return browserID;} set { browserID = value;} }
        public string BrowserName { get { return browserName; } set { browserName = value; } }

        public Browser(string BrowserID, string BrowserName)
        {
            browserID = BrowserID;
            browserName = BrowserName;
        }


    }
}
