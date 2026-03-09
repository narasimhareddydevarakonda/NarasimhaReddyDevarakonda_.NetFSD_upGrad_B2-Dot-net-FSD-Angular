-- Creating Product Summary View --

GO
CREATE VIEW vw_ProductSummary
AS
SELECT 
    p.product_name,
    b.brand_name,
    c.category_name,
    p.model_year,
    p.list_price
FROM products p
INNER JOIN brands b
ON p.brand_id = b.brand_id
INNER JOIN categories c
ON p.category_id = c.category_id;
GO

SELECT * 
FROM vw_ProductSummary;
GO


--Creating Order Summary View --
CREATE VIEW vw_OrderSummary
AS
SELECT
    o.order_id,
    c.first_name + ' ' + c.last_name AS customer_name,
    s.store_name,
    st.first_name + ' ' + st.last_name AS staff_name,
    o.order_date
FROM orders o
INNER JOIN customers c
ON o.customer_id = c.customer_id
INNER JOIN stores s
ON o.store_id = s.store_id
INNER JOIN staffs st
ON o.staff_id = st.staff_id;
GO

SELECT * 
FROM vw_OrderSummary;
GO


-- Creating Indexes on Foreign Keys --

CREATE INDEX idx_products_brand_id
ON products(brand_id);

CREATE INDEX idx_products_category_id
ON products(category_id);

CREATE INDEX idx_orders_customer_id
ON orders(customer_id);

CREATE INDEX idx_orders_store_id
ON orders(store_id);
GO


-- Checking Existing Indexes --

EXEC sp_helpindex 'products';
EXEC sp_helpindex 'customers';
EXEC sp_helpindex 'stores';
GO


-- Checking Performance Using Execution Plan --

SET STATISTICS IO ON;

SELECT *
FROM products
WHERE brand_id = 1;
GO