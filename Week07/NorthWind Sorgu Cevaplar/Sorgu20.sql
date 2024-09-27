-- Siparişleri, sipariş tarihine göre yıllar ve aylar bazında gruplayarak toplam satış tutarlarını listeleyin.

SELECT 
YEAR(OrderDate) as 'Yıl',
MONTH(OrderDate) as 'Ay',
ROUND(SUM((ord.UnitPrice*ord.Quantity)-(ord.UnitPrice*ord.Quantity*Discount)),2) AS 'Toplam Satış tutar'
FROM Orders o
JOIN OrderDetails ord ON o.OrderID = ord.OrderID
JOIN Customers c ON c.CustomerID=o.CustomerID
GROUP BY YEAR(OrderDate) , MONTH(OrderDate)
ORDER BY YEAR(OrderDate) DESC , MONTH(OrderDate) DESC