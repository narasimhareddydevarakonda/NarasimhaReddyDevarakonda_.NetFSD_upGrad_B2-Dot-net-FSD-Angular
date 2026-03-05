--2. Display only orders with status Pending (1) or Completed (4).

select * from orders where order_status=1 or order_status=4;

--3. Sort the results by order_date in descending order.

select * from orders order by order_date desc;