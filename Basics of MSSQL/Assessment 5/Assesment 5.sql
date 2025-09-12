--Tasks:
--Show a list of all student names (unique only).
select Name from Students2024 union select Name from Students2025
--Show a list of all student names (including duplicates).
select Name from Students2024 union all select Name from Students2025
--Display employee names in UPPERCASE and LOWERCASE.
select upper(Name) as uppercase_name, lower(Name) as lowercase_name from Employees
--Find the length of each employee’s name.
select len(Name) as length_employee_name from Employees
--Show only the first 3 letters of each name.
select SUBSTRING(Name,1,3) as first_3_letters from Employees
--Replace Finance department with Accounts.
select replace(Department,'Finance','Accounts') as Department from Employees
--Create a new column showing "Name - Department" using CONCAT.
select concat(Name,'-',Department) as name_dept from Employees
--Show today’s date using GETDATE().
select getdate() as todays_date
--Find the duration (in days) of each project using DATEDIFF.
select ProjectID,Name , DATEDIFF(d,StartDate,EndDate) as duration from Projects
--Add 10 days to each project’s EndDate using DATEADD.
select ProjectID,Name , DATEADD(day,10,EndDate) as newEndDate from Projects
--Find how many days are left until each project ends. (Hint: Use DATEDIFF with GETDATE())
select ProjectID,Name, DATEDIFF(d,GETDATE(),EndDate) as remainingDays from Projects
--Convert today’s date into DD/MM/YYYY format using CONVERT.
select CONVERT(varchar(10),getdate(),103) as date_DDMMYYYY
--Convert a float 123.456 into an integer using CAST.
select CAST(123.456 AS int) AS new_int
--For employees (from Employees table above), categorize them:
--If Dept = IT → show Tech Team
--If Dept = HR → show Human Resources
--Else → Other
select EmpID,Name, 
CASE WHEN Department = 'IT' THEN 'Tech Team'
	WHEN Department = 'HR' THEN 'Human Resources'
	ELSE 'Other'
END AS Dept
from Employees 