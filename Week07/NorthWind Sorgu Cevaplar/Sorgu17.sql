-- Her bir kategorideki ürünlerin ortalama fiyatını bulun.

SELECT 
c.CategoryName as 'Kategori Adı',
AVG(p.UnitPrice) as 'Ortalama Fiyat'
FROM Products p 
JOIN Categories c ON c.CategoryID=p.CategoryID
GROUP BY c.CategoryName