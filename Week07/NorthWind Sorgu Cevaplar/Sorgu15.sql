-- Hangi kargo şirketinin kaç sipariş taşıdığını listeleyin.

SELECT 
sh.CompanyName AS 'Kargo Şirketi',
Count(o.OrderID) AS 'Sipariş Adeti'
FROM Orders o
JOIN Shippers sh ON sh.shipperID=o.ShipVia
GROUP BY sh.CompanyName