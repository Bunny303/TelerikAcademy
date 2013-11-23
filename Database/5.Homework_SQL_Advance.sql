USE [TelerikAcademy]

-- 1. Find the names and salaries of the employees that take the minimal salary in the company. Use a nested SELECT statement.
SELECT FirstName + ' ' + LastName AS Name, Salary 
FROM Employees
WHERE Salary = 
	(SELECT MIN(Salary) FROM Employees)

-- 2. Find the names and salaries of the employees that have a salary that is up to 10% higher than the minimal salary for the company.
SELECT FirstName + ' ' + LastName AS Name, Salary 
FROM Employees
WHERE Salary <  
	(SELECT MIN(Salary) FROM Employees) * 1.1

-- 3. Find the full name, salary and department of the employees that take the minimal salary in their department. Use a nested SELECT statement.
SELECT FirstName + ' ' + MiddleName + ' ' + LastName AS FullName, Salary, DepartmentID
FROM Employees e
WHERE Salary =  
	(SELECT MIN(Salary) FROM Employees
	WHERE e.DepartmentID = DepartmentID)

-- 4. Write a SQL query to find the average salary in the department #1.
SELECT AVG(Salary) AS AverageSalary  
FROM Employees
WHERE DepartmentID = 1

-- 5. Write a SQL query to find the average salary  in the "Sales" department.
SELECT AVG(e.Salary) AS AverageSalary, d.Name AS Deparment
FROM Employees e
	JOIN Departments d
	ON e.DepartmentID=d.DepartmentID
WHERE d.Name= 'Sales'
GROUP BY d.Name

-- 6. Write a SQL query to find the number of employees in the "Sales" department.
SELECT COUNT(*) AS NumberEmployees, d.Name
FROM Employees e
	JOIN Departments d
	ON e.DepartmentID=d.DepartmentID
WHERE d.Name= 'Sales'
GROUP BY d.Name	

-- 7. Write a SQL query to find the number of all employees that have manager.
SELECT COUNT(*) AS NumberEmployees
FROM Employees
WHERE ManagerID IS NOT NULL

-- 8. Write a SQL query to find the number of all employees that have no manager.
SELECT COUNT(*) AS NumberEmployees
FROM Employees
WHERE ManagerID IS NULL

-- 9. Write a SQL query to find all departments and the average salary for each of them.
SELECT AVG(e.Salary) AS AverageSalary, d.Name AS Deparment
FROM Employees e
	JOIN Departments d
	ON e.DepartmentID=d.DepartmentID
GROUP BY d.Name

-- 10. Write a SQL query to find the count of all employees in each department and for each town.
SELECT COUNT(*) AS NumberEmployees, d.Name AS Deparment, t.Name AS Town
FROM Employees e
	JOIN Departments d
	ON e.DepartmentID=d.DepartmentID
	JOIN Addresses a
    ON a.AddressID = e.AddressID
    JOIN Towns t
	ON a.TownID = t.TownID
GROUP BY d.Name, t.Name
ORDER BY t.Name

-- 11. Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.
SELECT e.FirstName, e.LastName
FROM Employees e
	JOIN Employees m
	ON e.EmployeeID = m.ManagerID
GROUP BY e.FirstName, e.LastName
HAVING COUNT(*) = 5

-- 12. Write a SQL query to find all employees along with their managers. For employees that do not have manager display the value "(no manager)".
SELECT e.FirstName + ' ' + e.LastName AS EmployeesName, COALESCE (m.FirstName + ' ' + m.LastName , '(no manager)') AS ManagersName
FROM Employees e
	LEFT OUTER JOIN Employees m
	ON e.EmployeeID = m.ManagerID

-- 13. Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. Use the built-in LEN(str) function.
SELECT FirstName, LastName FROM Employees
WHERE LEN(LastName) = 5

--TASK 14 Write a SQL query to display the current date and time in the following format 
--"day.month.year hour:minutes:seconds:milliseconds". Search in  Google to find how to format dates in SQL Server.
SELECT CONVERT(VARCHAR(24), GETDATE(), 113)
SELECT FORMAT(getdate(), 'dd.mm.yyyy hh:mm:ss:ff')