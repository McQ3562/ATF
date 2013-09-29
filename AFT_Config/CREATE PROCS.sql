USE ATF_Config
GO
IF(EXISTS(SELECT 1 FROM sys.procedures WHERE name = 'sp_AddTestCase'))
	DROP PROCEDURE sp_AddTestCase
GO
CREATE PROC sp_AddTestCase
	@TestCaseName VARCHAR(50),
	@TestCaseID INT OUT
AS

INSERT INTO TestCase (TestCaseName)
VALUES(@TestCaseName)

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

IF(EXISTS(SELECT 1 FROM sys.procedures WHERE name = 'sp_GetTestCaseIDList'))
	DROP PROCEDURE sp_GetTestCaseIDList
GO
CREATE PROC sp_GetTestCaseIDList
AS
SELECT TestCaseID
FROM TestCase
ORDER BY TestCaseID
GO

