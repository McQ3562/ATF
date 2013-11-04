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
            TestPlanList testPlanList = new TestPlanList();
            testPlanList.Load(comboBox_TestPlan);
        }

        private void comboBox_TestPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTestPlanID = ((ATF.TestPlan)(comboBox_TestPlan.SelectedItem)).TestPlanID;

            currentTestPlan = new TestPlan(selectedTestPlanID);
            currentTestPlan.Load();
        }

        private void button_AddPlan_Click(object sender, EventArgs e)
        {
            Form_Add_TestPlan AddTestPlan = new Form_Add_TestPlan();
            AddTestPlan.ShowDialog();
        }

        private void button_DeletePlan_Click(object sender, EventArgs e)
        {

        }

    }
}
