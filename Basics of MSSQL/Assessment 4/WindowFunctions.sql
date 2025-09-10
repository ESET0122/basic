use entity
-- Task 1
-- Top N books per user
-- Find the top 2 most expensive books purchased by each user
SELECT * FROM (SELECT  u.names, b.title , ROW_NUMBER() over (partition by u.names order by b.price)
as expensive_book FROM users u INNER JOIN orders o ON o.users_id = u.users_id
INNER JOIN books b ON b.product_id = o.product_id) as list_of_books WHERE expensive_book<3

--Task 2
--Ranking users by total spending
--Find how much each user spent and rank them

SELECT u.users_id, u.names, sum(b.price) as total_amount,DENSE_RANK() over (order by sum(b.price) desc) as spender_ranking from users u inner join
orders o on u.users_id = o.users_id inner join books b on 
o.product_id = b.product_id group by u.names, u.users_id

