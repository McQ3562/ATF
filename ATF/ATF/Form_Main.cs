using System;
using System.Collections.Generic;
using System.Collections;
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
        TestPlan currentTestPlan = new TestPlan();

        public Form_Main()
        {


            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            List<List<string>> results = new List<List<string>>();
            DB_Connection conn = new DB_Connection(DB_ConnectionString.GetAFT_ConfigConnectionString());
            results = conn.ReturnQuery("EXEC sp_GetTestPlanList");

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

        private void comboBox_TestPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            //currentTestPlan.Load();
        }

        private void button_AddPlan_Click(object sender, EventArgs e)
        {
            Form_Add_TestPlan AddTestPlan = new Form_Add_TestPlan();
            AddTestPlan.ShowDialog();
        }
    }

    public class TestPlanList
    {
        string testPlanID;
        string testPlanName;

        public TestPlanList(string TestPlanID, string TestPlanName)
        {
            testPlanID = TestPlanID;
            testPlanName = TestPlanName;
        }

        public string TestPlanID
        {
            get { return testPlanID; }
        }

        public string TestPlanName
        {
            get { return testPlanName; }
        }
    }
}
