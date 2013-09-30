using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATF
{
    class Action
    {
        int actionID;
        int testCaseStepID;
        string actionName;
        List<string> actionNames = new List<string>();
        List<string> actionOptions = new List<string>();


        public Action(int TestCaseStepID, int ActionID)
        {
            actionID = ActionID;
            testCaseStepID = TestCaseStepID;

            LoadActionName(ActionID);
            LoadOptions(TestCaseStepID);
        }

        public void go()
        {

        }

        private void LoadActionName(int ActionID)
        {

        }

        private void LoadOptions(int TestCaseStepID)
        {

        }
    }
}
