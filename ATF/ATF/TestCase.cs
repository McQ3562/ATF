using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATF
{
    class TestCase
    {
        string testCaseID;
        string testCaseName;
        List<TestCaseStep> testStepList = new List<TestCaseStep>();

        public string TestCaseID { get { return testCaseID; } set { testCaseID = value; } }
        public string TestCaseName { get { return testCaseName; } set { testCaseName = value; } }

        public void Load(string TestCaseID)
        {
            foreach(int StepID in TestCaseStep.GetTestCaseStepIDList(TestCaseID))
            {
                TestCaseStep tmpCaseStep = new TestCaseStep();
                tmpCaseStep.Load(StepID);
                testStepList.Add(tmpCaseStep);
            }
        }

        public void Delete()
        {
            foreach (TestCaseStep tmpTestCaseStep in testStepList)
            {
                tmpTestCaseStep.Delete();
            }

            List<int> CaseIDList = new List<int>();
            List<List<string>> results = new List<List<string>>();
            DB_Connection conn = new DB_Connection(DB_ConnectionString.GetAFT_ConfigConnectionString());

            results = conn.ReturnQuery("EXEC sp_DeleteTestCase @TestCaseID="+testCaseID);
        }

        public void Go()
        {

        }

        public static List<int> GetTestCaseIDList(string TestPlanID)
        {
            List<int> CaseIDList = new List<int>();
            List<List<string>> results = new List<List<string>>();
            DB_Connection conn = new DB_Connection(DB_ConnectionString.GetAFT_ConfigConnectionString());

            results = conn.ReturnQuery("EXEC sp_GetTestCaseIDList");
            if (results.Count > 0)
            {
                for (int counter = 1; counter < results[0].Count; counter++)
                {
                    CaseIDList.Add(Convert.ToInt32(results[0][counter]));
                }
            }

            return CaseIDList;
        }
    }

    class TestCaseList
    {
        string testPlanID;
        List<TestCaseList> testCaseList = new List<TestCaseList>();

        public void Load(ComboBox ComboBoxReferance, string TestPlanID)
        {
            testPlanID = TestPlanID;

            List<List<string>> results = new List<List<string>>();
            DB_Connection conn = new DB_Connection(DB_ConnectionString.GetAFT_ConfigConnectionString());
            results = conn.ReturnQuery("EXEC sp_GetTestPlanList");

            if (results.Count > 0)
            {

                for (int counter = 1; counter < results[0].Count; counter++)
                {
                    //testCaseList.Add(new TestCase(results[0][counter]));
                }

            }
        }
    }
}
