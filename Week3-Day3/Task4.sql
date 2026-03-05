USE EcommAppDb;

SELECT 
    P.product_name,S.store_name,ST.quantity AS available_stock,SUM(OI.quantity) AS total_quantity_sold
FROM stocks ST INNER JOIN products P ON ST.product_id = P.product_id INNER JOIN stores S ON ST.store_id = S.store_id
    LEFT JOIN order_items OI ON ST.product_id = OI.product_id
GROUP BY P.product_name,S.store_name, ST.quantity ORDER BY P.product_name;