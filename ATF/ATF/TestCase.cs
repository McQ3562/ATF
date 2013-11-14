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

        public TestCase(string TestCaseID)
        {
            testCaseID = TestCaseID;
        }

        public TestCase(string TestCaseID, string TestCaseName)
        {
            testCaseID = TestCaseID;
            testCaseName = TestCaseName;
        }

        public void Load()
        {
            foreach(string StepID in TestCaseStep.GetTestCaseStepIDList(testCaseID))
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

        public static List<string> GetTestCaseIDList(string TestPlanID)
        {
            List<string> CaseIDList = new List<string>();
            List<List<string>> results = new List<List<string>>();
            DB_Connection conn = new DB_Connection(DB_ConnectionString.GetAFT_ConfigConnectionString());

            results = conn.ReturnQuery("EXEC sp_GetTestCaseIDList");
            if (results.Count > 0)
            {
                for (int counter = 1; counter < results[0].Count; counter++)
                {
                    CaseIDList.Add(results[0][counter]);
                }
            }

            return CaseIDList;
        }

        public static void AddTestCase(string TestPlanID, string TestCaseName)
        {
            List<List<string>> results = new List<List<string>>();
            DB_Connection conn = new DB_Connection(DB_ConnectionString.GetAFT_ConfigConnectionString());

            results = conn.ReturnQuery("DECLARE @TestCaseID INT; EXEC sp_AddTestCase '" + TestPlanID + "', '" + TestCaseName + "', @TestCaseID OUT");
        }
    }

    class TestCaseList
    {
        string testPlanID;
        List<TestCase> testCaseList = new List<TestCase>();

        public void Load(ComboBox ComboBoxReferance, string TestPlanID)
        {
            testPlanID = TestPlanID;

            List<List<string>> results = new List<List<string>>();
            DB_Connection conn = new DB_Connection(DB_ConnectionString.GetAFT_ConfigConnectionString());
            results = conn.ReturnQuery("EXEC sp_GetTestCaseList @TestPlanID="+testPlanID);

            if (results.Count > 0)
            {

                for (int counter = 1; counter < results[0].Count; counter++)
                {
                    testCaseList.Add(new TestCase(results[0][counter],results[1][counter]));
                }

            }
        }
    }
}
