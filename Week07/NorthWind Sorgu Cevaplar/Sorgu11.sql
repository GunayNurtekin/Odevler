-- Ürünleri kategorileriyle birlikte listeleyin.

SELECT 
c.CategoryName,
p.ProductName
FROM Products p
JOIN Categories c ON p.CategoryID = c.CategoryID
GROUP BY c.CategoryName , p.ProductName