-- Her bir kategorideki ürün sayısını bulun.

SELECT 
c.CategoryName,
SUM(p.UnitsInStock) AS 'Ürün Adeti'
FROM Products p
JOIN Categories c ON c.CategoryID = p.CategoryID
GROUP BY c.CategoryName 