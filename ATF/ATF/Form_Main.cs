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
        TestPlan currentTestPlan;

        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            populateForm_Main();
        }

        private void comboBox_TestPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_TestPlan.SelectedItem != null)
            {
                string selectedTestPlanID = ((ATF.TestPlan)(comboBox_TestPlan.SelectedItem)).TestPlanID;

                currentTestPlan = new TestPlan(selectedTestPlanID);
                currentTestPlan.Load();
            }
        }

        private void button_AddPlan_Click(object sender, EventArgs e)
        {
            Form_Add_TestPlan AddTestPlan = new Form_Add_TestPlan();
            AddTestPlan.ShowDialog();

            populateForm_Main();
        }

        private void button_DeletePlan_Click(object sender, EventArgs e)
        {
            currentTestPlan.Delete();

            populateForm_Main();
        }

        private void button_AddCase_Click(object sender, EventArgs e)
        {
            Form_Add_TestCase tmpfrmAddTestCase = new Form_Add_TestCase(currentTestPlan.TestPlanID, currentTestPlan.TestPlanName);
            tmpfrmAddTestCase.ShowDialog();

            populateForm_Main();
        }

        private void button_DeleteCase_Click(object sender, EventArgs e)
        {

        }

        private void button_RunSelected_Click(object sender, EventArgs e)
        {

        }

        private void button_RunAll_Click(object sender, EventArgs e)
        {

        }

        public void populateForm_Main()
        {
            TestPlanList testPlanList = new TestPlanList();
            testPlanList.Load(comboBox_TestPlan);

            if (currentTestPlan != null)
            {
                //pop test cases
                TestCaseList testCaseList = new TestCaseList();

                testCaseList.Load(listView_TestCaseList, currentTestPlan.TestPlanID);
            }
        }
    }
}
