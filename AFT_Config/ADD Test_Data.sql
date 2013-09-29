USE ATF_Config

DECLARE @TestCaseID INT
DECLARE @TestCaseStepID INT

EXEC sp_AddTestCase 'GoogleTest', @TestCaseID OUT

EXEC dbo.sp_AddTestCaseStep
@TestCaseID=@TestCaseID,
@TestCaseStepSeqNum = 1,
@TestCaseActionName='Open Browser',
@TestCaseResponseName='No Check',
@ValidationText='',
@TestCaseStepID=@TestCaseStepID OUT

EXEC dbo.sp_AddActionOption 
@TestCaseStepID = 1,
@ActionOptionName = 'BrowserType',
@ActionOptoinValue = 'FireFox'
EXEC dbo.sp_AddResponseOption 
@TestCaseStepID = 1,
@ResponseOptionName = 'None',
@ResponseOptoinValue = 'None'

EXEC dbo.sp_AddTestCaseStep
@TestCaseID=@TestCaseID,
@TestCaseStepSeqNum = 2,
@TestCaseActionName='Navigate',
@TestCaseResponseName='Browser URL Check',
@ValidationText='https://www.google.com/',
@TestCaseStepID=@TestCaseStepID OUT

EXEC dbo.sp_AddActionOption 
@TestCaseStepID = 2,
@ActionOptionName = 'Navigate',
@ActionOptoinValue = 'https://www.google.com/'
EXEC dbo.sp_AddResponseOption 
@TestCaseStepID = 2,
@ResponseOptionName = 'Browser Title Check',
@ResponseOptoinValue = 'Google'

