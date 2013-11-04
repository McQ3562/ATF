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
            BrowserList browserList = new BrowserList();
            browserList.Load(comboBox_Browser);
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

        public void Load(ComboBox ComboBoxReferance)
        {
            List<List<string>> results = new List<List<string>>();
            DB_Connection conn = new DB_Connection(DB_ConnectionString.GetAFT_ConfigConnectionString());
            results = conn.ReturnQuery("EXEC sp_GetBrowserList");

            if (results.Count > 0)
            {
                List<Browser> browserList = new List<Browser>();
                for (int counter = 1; counter < results[0].Count; counter++)
                {
                    browserList.Add(new Browser(results[0][counter],results[1][counter]));
                }

                ComboBoxReferance.DataSource = browserList;
                ComboBoxReferance.DisplayMember = "BrowserName";
                ComboBoxReferance.ValueMember = "BrowserID";
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
