-- Her bir ülke için toplam satış tutarını hesaplayın.

SELECT 
c.Country,
ROUND(SUM((ord.UnitPrice*ord.Quantity)-(ord.UnitPrice*ord.Quantity*Discount)),2) AS 'TOPLAM TUTAR'
FROM Orders o
JOIN OrderDetails ord ON o.OrderID = ord.OrderID
JOIN Customers c ON c.CustomerID=o.CustomerID
GROUP BY c.Country
ORDER BY ROUND(SUM((ord.UnitPrice*ord.Quantity)-(ord.UnitPrice*ord.Quantity*Discount)),2) DESC