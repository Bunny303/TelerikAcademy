USE master
GO
CREATE DATABASE BankHOMEWORK
GO

-- 1. Create a database with two tables: Persons(Id(PK), FirstName, LastName, SSN) 
-- and Accounts(Id(PK), PersonId(FK), Balance). Insert few records for testing. 
-- Write a stored procedure that selects the full names of all persons.

USE BankHOMEWORK
GO

CREATE TABLE Persons (
	Id int IDENTITY,
	FirstName varchar(50),
	LastName varchar(50),
	SSN varchar(50)
	CONSTRAINT PK_Persons PRIMARY KEY(Id)
	)
GO

CREATE TABLE Accounts (
	Id int IDENTITY,
	PersonId int NOT NULL,
	Balance money 
	CONSTRAINT PK_Accounts PRIMARY KEY(Id),
	)
GO

ALTER TABLE Accounts
ADD CONSTRAINT FK_Accounts_Persons FOREIGN KEY (PersonId) REFERENCES Persons(Id)

INSERT INTO Persons (FirstName, LastName, SSN) VALUES ('Ivancho', 'Ivanov', '34567');
INSERT INTO Persons (FirstName, LastName, SSN) VALUES ('Petkancho', 'Petkov', '12346');
INSERT INTO Persons (FirstName, LastName, SSN) VALUES ('Mariika', 'Marinkova', '78967');

INSERT INTO Accounts (PersonID, Balance) VALUES (1, 5000);
INSERT INTO Accounts (PersonID, Balance) VALUES (2, 7500);
INSERT INTO Accounts (PersonID, Balance) VALUES (3, 10);
GO

CREATE PROC dbo.usp_SelectPersonsNames
AS
        SELECT FirstName + ' ' + LastName
        FROM Persons
GO

EXEC dbo.usp_SelectPersonsNames
GO

-- 2. Create a stored procedure that accepts a number as a parameter and returns all persons who have more money 
-- in their accounts than the supplied number.

CREATE PROC dbo.usp_ShowBalance (@balance money = 0)
AS
	SELECT p.FirstName + ' ' + p.LastName, a.Balance
	FROM Persons p
		JOIN Accounts a
		ON p.Id = a.PersonId
	WHERE a.Balance > @balance
GO

EXEC dbo.usp_ShowBalance 1000
GO
-- 3. Create a function that accepts as parameters – sum, yearly interest rate and number of months. 
-- It should calculate and return the new sum. Write a SELECT to test whether the function works as expected.

CREATE FUNCTION ufn_CalculateYearlyInterestRate (@sum money, @rate money, @months int)
RETURNS money
AS
BEGIN
	RETURN @sum + (@sum  *(@rate/100) * @months / 12)
END
GO

SELECT p.FirstName, p.LastName, dbo.ufn_CalculateYearlyInterestRate(a.Balance, 4, 6) AS NewBalance
FROM Persons p
	JOIN Accounts a
	ON p.Id = a.PersonId
GO

-- 4. Create a stored procedure that uses the function from the previous example to give an interest 
-- to a person's account for one month. It should take the AccountId and the interest rate as parameters.
CREATE PROC dbo.usp_CalculateMonthlyInterestRate (@accountId int, @rate money)
AS
	SELECT Id, Balance AS OldBalance, dbo.ufn_CalculateYearlyInterestRate(Balance, @rate, 1) AS NewBalance
	FROM Accounts
	WHERE Id = @accountId
GO

EXEC dbo.usp_CalculateMonthlyInterestRate 1, 4
GO

-- 5. Add two more stored procedures WithdrawMoney( AccountId, money) and 
-- DepositMoney (AccountId, money) that operate in transactions.

CREATE PROC dbo.usp_WithdrawMoney (@accountId int, @sum money)
AS
	UPDATE Accounts SET Balance = Balance - @sum
	WHERE Id = @accountId
GO

EXEC dbo.usp_WithdrawMoney 2, 5
GO

CREATE PROC dbo.usp_DepositMoney (@accountId int, @sum money)
AS
	UPDATE Accounts SET Balance = Balance + @sum
	WHERE Id = @accountId
GO

EXEC dbo.usp_DepositMoney 3, 10000
GO

SELECT * FROM Accounts
GO

-- 6. Create another table – Logs(LogID, AccountID, OldSum, NewSum). 
-- Add a trigger to the Accounts table that enters a new entry into the Logs table every time 
-- the sum on an account changes.

CREATE TABLE Logs (
	LogID int IDENTITY,
	AccountID int NOT NULL,
	OldSum money,
	NewSum money 
	CONSTRAINT PK_Logs PRIMARY KEY(LogID),
	CONSTRAINT FK_Logs_Accounts FOREIGN KEY (AccountID) REFERENCES Accounts(Id)
	)
GO

CREATE TRIGGER tr_AccountsChangeBalance ON Accounts AFTER UPDATE
AS
  IF EXISTS(SELECT * FROM deleted) 
    BEGIN
		DECLARE @personId int, @oldBalance money, @newBlanace money
		SELECT @personId = del.Id, @oldBalance = del.Balance FROM deleted del
		SELECT @newBlanace = ins.Balance FROM inserted ins

		INSERT INTO Logs
		VALUES (@personId, @oldBalance, @newBlanace)
    END
GO

-- 7. Define a function in the database TelerikAcademy that returns all Employee's names 
-- (first or middle or last name) and all town's names that are comprised of given set of letters. 
-- Example 'oistmiahf' will return 'Sofia', 'Smith', … but not 'Rob' and 'Guy'.

USE [TelerikAcademy]
GO

CREATE FUNCTION ufn_CheckIsIncludeLetters (@word nvarchar(50), @letters nvarchar(50))
RETURNS BIT
AS
BEGIN
DECLARE 
	@length int = LEN(@letters), 
	@matches int = 0,
	@currentLetter varchar(1)

WHILE (@length > 0)
	BEGIN
		SET @currentLetter = SUBSTRING(@letters, @length, 1)
		IF (CHARINDEX(@currentLetter, @word, 0) > 0)
			BEGIN
				SET @matches = @matches + 1;
				SET @length = @length - 1;
			END
		ELSE
			SET @length = @length - 1;
	END

	IF (@matches >= LEN(@word) OR @matches >= LEN(@letters))
		RETURN 1
	RETURN 0
END
GO

CREATE FUNCTION ufn_SearchWordsIncludingLetters (@letters nvarchar(50))
RETURNS @Results TABLE (Result nvarchar(50) NOT NULL)
AS
BEGIN
	INSERT INTO @Results
	SELECT FirstName
	FROM Employees
	WHERE dbo.ufn_CheckIsIncludeLetters(LOWER(FirstName), @letters) = 1

	INSERT INTO @Results
	SELECT MiddleName
	FROM Employees
	WHERE dbo.ufn_CheckIsIncludeLetters(LOWER(MiddleName), @letters) = 1

	INSERT INTO @Results
	SELECT LastName
	FROM Employees
	WHERE dbo.ufn_CheckIsIncludeLetters(LOWER(LastName), @letters) = 1

	INSERT INTO @Results
	SELECT Name
	FROM Towns
	WHERE dbo.ufn_CheckIsIncludeLetters(LOWER(Name), @letters) = 1

	RETURN
END
GO

SELECT * FROM dbo.ufn_SearchWordsIncludingLetters('oistmiahf')

-- 8. Using database cursor write a T-SQL script that scans all employees and their addresses and prints all pairs 
-- of employees that live in the same town.

DECLARE empCursor CURSOR READ_ONLY FOR
	SELECT a.FirstName, a.LastName, t1.Name, b.FirstName, b.LastName
	FROM Employees a
	JOIN Addresses adr
	ON a.AddressID = adr.AddressID
	JOIN Towns t1
	ON adr.TownID = t1.TownID,
	 Employees b
	JOIN Addresses ad
	ON b.AddressID = ad.AddressID
	JOIN Towns t2
	ON ad.TownID = t2.TownID
	WHERE t1.Name = t2.Name
	  AND a.EmployeeID <> b.EmployeeID
	ORDER BY a.FirstName, b.FirstName

OPEN empCursor
DECLARE @firstName1 nvarchar(50), @lastName1 nvarchar(50), @town nvarchar(50), @firstName2 nvarchar(50), @lastName2 nvarchar(50)
FETCH NEXT FROM empCursor INTO @firstName1, @lastName1, @town, @firstName2, @lastName2

WHILE @@FETCH_STATUS = 0
  BEGIN
    PRINT @firstName1 + ' ' + @lastName1 + ' ' + @town + ' ' + @firstName2 + ' ' + @lastName2
    FETCH NEXT FROM empCursor 
    INTO @firstName1, @lastName1, @town, @firstName2, @lastName2

  END

CLOSE empCursor
DEALLOCATE empCursor

-- 9. * Write a T-SQL script that shows for each town a list of all employees that live in it. 
-- Sample output:	Sofia -> Svetlin Nakov, Martin Kulov, George Denchev
--					Ottawa -> Jose Saraiva

-- 10. Define a .NET aggregate function StrConcat that takes as input a sequence of strings and return a single string 
-- that consists of the input strings separated by ','. For example the following SQL statement should return a single string:
-- SELECT StrConcat(FirstName + ' ' + LastName)
-- FROM Employees

