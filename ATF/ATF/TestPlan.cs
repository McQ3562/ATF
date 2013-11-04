using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATF
{
    class TestPlan
    {
        string testPlanName;
        string browserName;
        List<TestCase> TestCaseList = new List<TestCase>();

        public string TestPlanName { get { return testPlanName; } set{browserName = value;} }
        public string BrowserName { get { return browserName; } set { browserName = value;} }

        public void Load(string testPlanID)
        {
            List<int> results = TestCase.GetTestCaseIDList(testPlanID);
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

        public static void AddTestPlan(string TestPlanName, string BrowserName)
        {
            List<List<string>> results = new List<List<string>>();
            DB_Connection conn = new DB_Connection(DB_ConnectionString.GetAFT_ConfigConnectionString());

            results = conn.ReturnQuery("EXEC sp_AddTestPlan '"+TestPlanName+"', '"+BrowserName+"', @TestPlanID OUT");
            if (results.Count > 0)
            {
                // results;
            }
        }
    }
}
