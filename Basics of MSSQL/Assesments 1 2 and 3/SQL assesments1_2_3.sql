-- Task 0
-- Creating  TABLES Customers and SmartMeterReadings
CREATE TABLE Customers (CustomerId int primary key, Name varchar(50), Address varchar(200), Region varchar(10))

CREATE TABLE SmartMeterReadings(MeterId int, CustomerId int, Location varchar(50),InstalledDate date, ReadingDateTime datetime, EnergyConsumed float, foreign key(CustomerId) references Customers(CustomerId))
--Inserting values in both tables
INSERT INTO Customers VALUES (1, 'Reetu Raj Chauhan', 'Hajipur,Bihar','North'), (2, 'Adil', 'Raibareily, UP','North'), (3, 'Badshah', 'Malegaon, Maharastra','West'), (4, 'Supriya', 'Guwahati,Assam','East')

INSERT INTO SmartMeterReadings VALUES
(105,1,'rooftop','2023-04-10','2025-05-01 12:12:12',50.9),
(106,4,'rooftop','2023-12-10','2025-01-05 12:12:12',10.6),
(107,3,'rooftop','2024-04-10','2025-04-01 12:12:12',125.8),
(110,3,'rooftop','2024-04-10','2025-05-01 12:12:12',115.1),
(108,2,'basement','2023-04-10','2025-01-01 12:12:12',2.5),
(109,1,'rooftop','2023-04-10','2025-06-01 12:12:12',100.8)
--Viewing the entries
select * from Customers
select * from SmartMeterReadings
-- Task 1
-- Fetch all readings where energy consumed between 10 and 50, Reading date time withing given constraints and exclude meters installed after 2024-06-30
SELECT * FROM SmartMeterReadings where EnergyConsumed BETWEEN 10 AND 50 AND ReadingDateTime between '2024-01-01' AND '2024-12-31' AND InstalledDate<'2024-06-30' 

-- Task 2
-- Calculate avg energy, max energy for each customer for current year
SELECT CustomerId, AVG(EnergyConsumed) as AvgEnergyConsumed ,MAX(EnergyConsumed) as MaxEnergyConsumed FROM SmartMeterReadings WHERE ReadingDateTime >'2025-01-01' GROUP BY CustomerId


