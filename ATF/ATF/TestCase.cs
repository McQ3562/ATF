using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATF
{
    class TestCase
    {
        string testCaseName;
        List<TestCaseStep> testStepList = new List<TestCaseStep>();

        public void Load(string TestCaseID)
        {
            foreach(int StepID in TestCaseStep.GetTestCaseStepIDList(TestCaseID))
            {
                TestCaseStep tmpCaseStep = new TestCaseStep();
                tmpCaseStep.Load(StepID);
                testStepList.Add(tmpCaseStep);
            }
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
}
