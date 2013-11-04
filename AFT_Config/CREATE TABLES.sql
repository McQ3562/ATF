
IF(EXISTS(SELECT 1 FROM sys.databases WHERE name = 'ATF_Config'))
BEGIN
	USE master
	
	ALTER DATABASE ATF_Config
	SET SINGLE_USER
	WITH ROLLBACK IMMEDIATE;
	
	DROP DATABASE ATF_Config
	
	--ALTER DATABASE ATF_Config
	--SET MULTI_USER;
END
GO
CREATE DATABASE ATF_Config
GO
/*	
IF(EXISTS(SELECT 1 FROM sys.tables WHERE name = ''))
	DROP TABLE 
GO
CREATE TABLE 
*/

USE ATF_Config
GO
IF(EXISTS(SELECT 1 FROM sys.tables WHERE name = 'TestPlan'))
	DROP TABLE TestPlan
GO
CREATE TABLE TestPlan (
	TestPlanID INT IDENTITY(1,1),
	TestPlanName VARCHAR(50),
	Browser VARCHAR(50)
)
GO
IF(EXISTS(SELECT 1 FROM sys.tables WHERE name = 'TestCase'))
	DROP TABLE TestCase
GO
CREATE TABLE TestCase (
	TestCaseID INT IDENTITY(1,1),
	TestCaseName VARCHAR(50)
)
GO
IF(EXISTS(SELECT 1 FROM sys.tables WHERE name = 'TestCaseStep'))
	DROP TABLE TestCaseStep
GO
CREATE TABLE TestCaseStep (
	TestCaseStepID INT IDENTITY(1,1),
	TestCaseID INT,
	TestCaseSeqNum INT,
	ActionID INT,
	ResponseID INT,
	ValidationText VARCHAR(MAX)
)

IF(EXISTS(SELECT 1 FROM sys.tables WHERE name = 'LK_Action'))
	DROP TABLE LK_Action
GO
CREATE TABLE LK_Action (
	ActionID INT IDENTITY(1,1),
	ActionName VARCHAR(50)
)

IF(EXISTS(SELECT 1 FROM sys.tables WHERE name = 'ActionOptions'))
	DROP TABLE ActionOptions
GO
CREATE TABLE ActionOptions (
	ActionOptionsID INT IDENTITY(1,1),
	TestCaseStepID INT,
	ActionOptionName VARCHAR(50),
	ActionOptionValue VARCHAR(MAX)
)

IF(EXISTS(SELECT 1 FROM sys.tables WHERE name = 'LK_Response'))
	DROP TABLE LK_Response
GO
CREATE TABLE LK_Response (
	ResponseID INT IDENTITY(1,1),
	ResponseName VARCHAR(50)
)

IF(EXISTS(SELECT 1 FROM sys.tables WHERE name = 'ResponseOptions'))
	DROP TABLE ResponseOptions
GO
CREATE TABLE ResponseOptions (
	ResponseOptionsID INT IDENTITY(1,1),
	TestCaseStepID INT,
	ResponseOptionName VARCHAR(50),
	ResponseOptionValue VARCHAR(MAX)
)

IF(EXISTS(SELECT 1 FROM sys.tables WHERE name = 'LK_Browser'))
	DROP TABLE LK_Browser
GO
CREATE TABLE LK_Browser (
	BrowserID INT IDENTITY(1,1),
	BrowserName VARCHAR(100)
)