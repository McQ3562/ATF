using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATF
{
    class TestCaseStep
    {
        string testCaseStepID;
        Action action;
        Response response;

        public void Load(string TestCaseStepID)
        {
            testCaseStepID = TestCaseStepID;
        }

        public void Delete()
        {
            List<List<string>> results = new List<List<string>>();
            DB_Connection conn = new DB_Connection(DB_ConnectionString.GetAFT_ConfigConnectionString());

            results = conn.ReturnQuery("EXEC sp_DeleteTestCaseStep @TestCaseStepID="+testCaseStepID);
        }

        public bool verify()
        {

            return true;
        }

        public static List<string> GetTestCaseStepIDList(string TestCaseID)
        {
            List<string> StepIDList = new List<string>();
            List<List<string>> results = new List<List<string>>();
            DB_Connection conn = new DB_Connection(DB_ConnectionString.GetAFT_ConfigConnectionString());

            results = conn.ReturnQuery("EXEC sp_GetTestCaseStepIDList");
            if (results.Count > 0)
            {
                for (int counter = 1; counter < results[0].Count; counter++)
                {
                    StepIDList.Add(results[0][counter]);
                }
            }

            return StepIDList;
        }
    }
}
