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

        public void Load()
        {
            foreach(int StepID in GetTestCaseStepIDList())
            {
                TestCaseStep tmpCaseStep = new TestCaseStep();
                tmpCaseStep.Load(StepID);
                testStepList.Add(tmpCaseStep);
            }
        }

        public void Go()
        {

        }

        private List<int> GetTestCaseStepIDList()
        {
            List<int> StepIDList = new List<int>();
            List<List<string>> results = new List<List<string>>();
            DB_Connection conn = new DB_Connection(DB_ConnectionString.GetAFT_ConfigConnectionString());
            
            results = conn.ReturnQuery("EXEC sp_GetTestCaseIDList");
            if (results.Count > 0)
            {
                for (int counter = 1; counter < results[0].Count; counter++)
                {
                    StepIDList.Add(Convert.ToInt32(results[0][counter]));
                }
            }

            return StepIDList;
        }
    }
}
