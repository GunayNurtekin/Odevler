-- En çok satılan 5 ürünü ve satış miktarlarını listeleyin.

SELECT TOP 5
p.ProductID AS 'ÜRÜN NUMARASI' , 
p.ProductName AS 'ÜRÜN ADI',
SUM(ord.Quantity) AS 'TOPLAM SATIŞ ADETİ'
FROM OrderDetails ord
JOIN Products p ON p.ProductID = ord.ProductID
GROUP BY p.ProductID , p.ProductName
ORDER BY SUM(ord.Quantity) DESC