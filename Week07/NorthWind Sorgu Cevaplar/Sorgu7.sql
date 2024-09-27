-- En pahalı 5 ürünü fiyatlarıyla birlikte listeleyin.

SELECT TOP 5
p.ProductName,
p.UnitPrice
FROM Products p
ORDER BY p.UnitPrice DESC