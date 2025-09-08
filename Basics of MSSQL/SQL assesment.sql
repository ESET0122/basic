-- Find all the books, all the users and all the users
select * from books b FULL OUTER JOIN orders o on b.product_id = o.product_id FULL OUTER JOIN users u on u.users_id = o.users_id

--Find all orders with book names
select * from orders o LEFT JOIN books b on b.product_id = o.product_id

-- Find particular users who ordered these books (How to read a book, Bhagwat gita, How to quit smoking)
--book name, name of user and price
select b.title, u.names, b.price from users u inner join orders o on u.users_id = o.users_id inner join books b on o.product_id = b.product_id where (b.product_id in (20,60,70))

--Find books users have ordered display book name, user name, price
select b.title, u.names, b.price from users u inner join orders o on u.users_id = o.users_id inner join books b on o.product_id = b.product_id

-- Find total price of books user has ordered 

SELECT sum(b.price) as 'Ramus total' from users u inner join orders o on u.users_id = o.users_id inner join books b on o.product_id = b.product_id where u.users_id = 1