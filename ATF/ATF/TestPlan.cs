using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATF
{
    class TestPlan
    {
        string testPlanID;
        string testPlanName;
        string browserName;
        List<TestCase> TestCaseList = new List<TestCase>();

        public string TestPlanID { get { return testPlanID; } set { testPlanID = value; } }
        public string TestPlanName { get { return testPlanName; } set{browserName = value;} }
        public string BrowserName { get { return browserName; } set { browserName = value;} }

        public TestPlan(string TestPlanID)
        {
            testPlanID = TestPlanID;
        }

        public TestPlan(string TestPlanID, string TestPlanName)
        {
            testPlanID = TestPlanID;    
            testPlanName = TestPlanName;
        }

        public void Load()
        {
            //Load Test Plan Dat
            List<List<string>> results = new List<List<string>>();
            DB_Connection conn = new DB_Connection(DB_ConnectionString.GetAFT_ConfigConnectionString());

            results = conn.ReturnQuery("EXEC sp_GetTestPlan @TestPlanID=" + testPlanID);
            if (results.Count > 0)
            {
                if (results[0][0].IndexOf("Error") == -1)
                {
                    testPlanID = results[0][1];
                    testPlanName = results[1][1];
                    browserName = results[2][1];
                }
            }

            //Load Test Cases
            List<int> IDListResults = TestCase.GetTestCaseIDList(testPlanID);
            foreach (int listID in IDListResults)
            {
                TestCase tmpTestCase = new TestCase();
                tmpTestCase.Load(listID.ToString());

                TestCaseList.Add(tmpTestCase);
            }
        }

        public void Delete(string TestPlanID)
        {
            //Delete Test Cases
            foreach (TestCase tmpTestCase in TestCaseList)
            {
                tmpTestCase.Delete();
            }
            //Delete Test Plan
            List<List<string>> results = new List<List<string>>();
            DB_Connection conn = new DB_Connection(DB_ConnectionString.GetAFT_ConfigConnectionString());

            results = conn.ReturnQuery("EXEC sp_DeleteTestPlan @TestPlanID="+testPlanID);
        }

        public static List<List<string>> GetTestPlanIDList()
        {
            List<List<string>> results = new List<List<string>>();
            DB_Connection conn = new DB_Connection(DB_ConnectionString.GetAFT_ConfigConnectionString());

            results = conn.ReturnQuery("EXEC sp_GetTestPlanIDList");
            if (results.Count > 0)
            {
                return results;
            }

            return null;
        }

        public static TestPlan GetTestPlan(string TestPlanID)
        {
            TestPlan tmpTestPlan = new TestPlan(TestPlanID);
            tmpTestPlan.Load();

            return tmpTestPlan;
        }

        public static void AddTestPlan(string TestPlanName, string BrowserName)
        {
            List<List<string>> results = new List<List<string>>();
            DB_Connection conn = new DB_Connection(DB_ConnectionString.GetAFT_ConfigConnectionString());

            results = conn.ReturnQuery("DECLARE @TestPlanID INT; EXEC sp_AddTestPlan '" + TestPlanName + "', '" + BrowserName + "', @TestPlanID OUT");
        }
    }

    public class TestPlanList
    {
        List<TestPlan> testPlanList = new List<TestPlan>();

        public void Load(ComboBox ComboBoxReferance)
        {
            List<List<string>> results = new List<List<string>>();
            DB_Connection conn = new DB_Connection(DB_ConnectionString.GetAFT_ConfigConnectionString());
            results = conn.ReturnQuery("EXEC sp_GetTestPlanList");

            if (results.Count > 0)
            {

                for (int counter = 1; counter < results[0].Count; counter++)
                {
                    testPlanList.Add(new TestPlan(results[0][counter], results[1][counter]));
                }

                ComboBoxReferance.DataSource = testPlanList;
                ComboBoxReferance.DisplayMember = "TestPlanName";
                ComboBoxReferance.ValueMember = "TestPlanID";
            }
        }
    }
}
