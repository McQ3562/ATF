USE ATF_Config
GO
IF(EXISTS(SELECT 1 FROM sys.procedures WHERE name = 'sp_AddTestPlan'))
	DROP PROCEDURE sp_AddTestPlan
GO
CREATE PROC sp_AddTestPlan
	@TestPlanName VARCHAR(50),
	@Browser VARCHAR(50),
	@TestPlanID INT OUT
AS
INSERT INTO TestPlan (TestPlanName, Browser)
VALUES(@TestPlanName, @Browser)

SET @TestPlanID = @@IDENTITY
GO

IF(EXISTS(SELECT 1 FROM sys.procedures WHERE name = 'sp_DeleteTestPlan'))
	DROP PROCEDURE sp_DeleteTestPlan
GO
CREATE PROC sp_DeleteTestPlan
	@TestPlanID INT
AS
DELETE FROM TestPlan
WHERE TestPlanID=@TestPlanID
GO

IF(EXISTS(SELECT 1 FROM sys.procedures WHERE name = 'sp_AddTestCase'))
	DROP PROCEDURE sp_AddTestCase
GO
CREATE PROC sp_AddTestCase
	@TestPlanID INT,
	@TestCaseName VARCHAR(50),
	@TestCaseID INT OUT
AS

INSERT INTO TestCase (TestPlanID, TestCaseName)
VALUES(@TestPlanID, @TestCaseName)

SET @TestCaseID = @@IDENTITY
GO

IF(EXISTS(SELECT 1 FROM sys.procedures WHERE name = 'sp_AddTestCaseStep'))
	DROP PROCEDURE sp_AddTestCaseStep
GO
CREATE PROC sp_AddTestCaseStep
	@TestCaseID INT,
	@TestCaseStepSeqNum INT,
	@TestCaseActionName VARCHAR(50),
	@TestCaseResponseName VARCHAR(50),
	@ValidationText VARCHAR(MAX),
	@TestCaseStepID INT OUT
AS

DECLARE @ActionID INT
DECLARE @ResponseID INT

SET @ActionID = (SELECT ActionID FROM LK_Action WHERE ActionName=@TestCaseActionName)
SET @ResponseID = (SELECT ResponseID FROM LK_Response WHERE ResponseName =@TestCaseResponseName)

INSERT INTO TestCaseStep (TestCaseID, TestCaseSeqNum, ActionID, ResponseID, ValidationText)
VALUES (@TestCaseID, @TestCaseStepSeqNum, @ActionID, @ResponseID, @ValidationText)

SET @TestCaseStepID = @@IDENTITY
GO

IF(EXISTS(SELECT 1 FROM sys.procedures WHERE name = 'sp_AddActionOption'))
	DROP PROCEDURE sp_AddActionOption
GO
CREATE PROC sp_AddActionOption
	@TestCaseStepID INT,
	@ActionOptionName VARCHAR(50),
	@ActionOptionValue VARCHAR(MAX)
AS
INSERT INTO ActionOptions (TestCaseStepID, ActionOptionName, ActionOptionValue)
VALUES (@TestCaseStepID, @ActionOptionName, @ActionOptionValue)

GO

IF(EXISTS(SELECT 1 FROM sys.procedures WHERE name = 'sp_AddResponseOption'))
	DROP PROCEDURE sp_AddResponseOption
GO
CREATE PROC sp_AddResponseOption
	@TestCaseStepID INT,
	@ResponseOptionName VARCHAR(50),
	@ResponseOptionValue VARCHAR(MAX)
AS
INSERT INTO ActionOptions (TestCaseStepID, ActionOptionName, ActionOptionValue)
VALUES (@TestCaseStepID, @ResponseOptionName, @ResponseOptionValue)
GO

IF(EXISTS(SELECT 1 FROM sys.procedures WHERE name = 'sp_GetTestPlan'))
	DROP PROCEDURE sp_GetTestPlan
GO
CREATE PROC sp_GetTestPlan
	@TestPlanID INT
AS
SELECT TestPlanID, TestPlanName, Browser
FROM TestPlan
WHERE TestPlanID=@TestPlanID
GO

IF(EXISTS(SELECT 1 FROM sys.procedures WHERE name = 'sp_GetTestPlanList'))
	DROP PROCEDURE sp_GetTestPlanList
GO
CREATE PROC sp_GetTestPlanList
AS
SELECT TestPlanID, TestPlanName, Browser
FROM TestPlan
ORDER BY TestPlanID
GO

IF(EXISTS(SELECT 1 FROM sys.procedures WHERE name = 'sp_GetTestCaseIDList'))
	DROP PROCEDURE sp_GetTestCaseIDList
GO
CREATE PROC sp_GetTestCaseIDList
AS
SELECT TestCaseID, TestCaseName
FROM TestCase
ORDER BY TestCaseID
GO

IF(EXISTS(SELECT 1 FROM sys.procedures WHERE name = 'sp_GetTestCaseList'))
	DROP PROCEDURE sp_GetTestCaseList
GO
CREATE PROC sp_GetTestCaseList
AS
SELECT TestCaseID, TestCaseName
FROM TestCase
ORDER BY TestCaseID
GO

IF(EXISTS(SELECT 1 FROM sys.procedures WHERE name = 'sp_GetTestCaseStepIDList'))
	DROP PROCEDURE sp_GetTestCaseStepIDList
GO
CREATE PROC sp_GetTestCaseStepIDList
	@TestCaseID INT
AS
SELECT TestCaseStepID
FROM TestCaseStep
ORDER BY TestCaseStepID
GO

IF(EXISTS(SELECT 1 FROM sys.procedures WHERE name = 'sp_GetBrowserList'))
	DROP PROCEDURE sp_GetBrowserList
GO
CREATE PROC sp_GetBrowserList
AS
SELECT BrowserID, BrowserName
FROM LK_Browser
GO

