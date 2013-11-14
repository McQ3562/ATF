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
    public partial class Form_Add_TestCase : Form
    {
        TestCase currentTestCase;
        string testPlanID;
        string testPlanName;

        public Form_Add_TestCase(string TestPlanID, string TestPlanName)
        {
            testPlanID = TestPlanID;
            testPlanName = TestPlanName;
            InitializeComponent();
        }

        private void Form_Add_TestCase_Load(object sender, EventArgs e)
        {
            label_TestPlan.Text = testPlanName;
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            TestCase.AddTestCase(testPlanID, testPlanName);

            this.Close();
        }


    }
}
