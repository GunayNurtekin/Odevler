-- Her bir siparişin toplam tutarını hesaplayın.

SELECT 
o.OrderID AS 'Sipariş Numarasi',
SUM((ord.UnitPrice*ord.Quantity)-(ord.UnitPrice*ord.Quantity*Discount)) AS 'TOPLAM TUTAR'
FROM Orders o
JOIN OrderDetails ord ON o.OrderID = ord.OrderID
GROUP BY o.OrderID 