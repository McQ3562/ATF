using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATF
{
    class TestPlan
    {
        List<TestCase> TestCaseList = new List<TestCase>();

        public List<List<string>> GetTestCaseList()
        {
            List<List<string>> results = new List<List<string>>();
            DB_Connection conn = new DB_Connection(DB_ConnectionString.GetAFT_ConfigConnectionString());

            results = conn.ReturnQuery("EXEC sp_GetTestCaseStepIDList");
            if (results.Count > 0)
            {
                return results;
            }

            return null;
        }

    }
}
