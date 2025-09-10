select id, name,salary,
ROW_NUMBER() over (order by salary desc) as popularity,
RANK() over (order by salary desc) as popularity_rank,
DENSE_RANK() over (partition by branch order by salary desc) as popularity_dense_rank
from employee

select * from employee
select id, name,salary, branch,
DENSE_RANK() over (partition by branch order by salary desc)  as popularity_dense_rank
from employee
Insert into employee values 
(8,'Gopal','SDE',1200000),
(9,'Swaraj','SDE',1200000),
(10,'NVK','SDE',1100000)