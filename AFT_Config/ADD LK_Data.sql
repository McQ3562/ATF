USE ATF_Config

TRUNCATE TABLE LK_Action
DBCC CHECKIDENT('LK_Action', RESEED, 0)
INSERT INTO LK_Action (ActionName) VALUES ('Open Browser')
INSERT INTO LK_Action (ActionName) VALUES ('Navigate')
INSERT INTO LK_Action (ActionName) VALUES ('Close Browser')
INSERT INTO LK_Action (ActionName) VALUES ('Write TextBox')
INSERT INTO LK_Action (ActionName) VALUES ('Read TextBox')
INSERT INTO LK_Action (ActionName) VALUES ('Select DropDownList')
INSERT INTO LK_Action (ActionName) VALUES ('Read DropDownList')
INSERT INTO LK_Action (ActionName) VALUES ('Read Selected DropDownList')
INSERT INTO LK_Action (ActionName) VALUES ('Click CheckBox')
INSERT INTO LK_Action (ActionName) VALUES ('Read CheckBox')
INSERT INTO LK_Action (ActionName) VALUES ('Click RadioButton')
INSERT INTO LK_Action (ActionName) VALUES ('Read RadioButton')
INSERT INTO LK_Action (ActionName) VALUES ('Click Button')
INSERT INTO LK_Action (ActionName) VALUES ('Close Browser')
GO

TRUNCATE TABLE LK_Response
DBCC CHECKIDENT('LK_Response', RESEED, 0)
INSERT INTO LK_Response (ResponseName) VALUES ('No Check')
INSERT INTO LK_Response (ResponseName) VALUES ('Browser Title Check')
INSERT INTO LK_Response (ResponseName) VALUES ('Browser URL Check')
INSERT INTO LK_Response (ResponseName) VALUES ('Read TextBox')
INSERT INTO LK_Response (ResponseName) VALUES ('Read DropDownList')
INSERT INTO LK_Response (ResponseName) VALUES ('Read Selected DropDownList')
INSERT INTO LK_Response (ResponseName) VALUES ('Read CheckBox')
INSERT INTO LK_Response (ResponseName) VALUES ('Read RadioButton')
GO

TRUNCATE TABLE LK_Browser
DBCC CHECKIDENT('LK_Response', RESEED, 0)
INSERT INTO LK_Response (ResponseName) VALUES ('Internet Explorer')
INSERT INTO LK_Response (ResponseName) VALUES ('Firefox')
INSERT INTO LK_Response (ResponseName) VALUES ('Chrome')
INSERT INTO LK_Response (ResponseName) VALUES ('Opera')
GO

