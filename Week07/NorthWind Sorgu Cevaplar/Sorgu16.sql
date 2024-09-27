-- Her bir çalışanın toplam satış tutarını hesaplayın.

SELECT 
e.EmployeeID AS 'Çalışan Numarası',
e.FirstName + ' ' + e.LastName AS 'Ad Soyad',
ROUND(SUM((ord.UnitPrice*ord.Quantity)-(ord.UnitPrice*ord.Quantity*Discount)),2) AS 'TOPLAM TUTAR'
FROM Orders o 
JOIN Employees e ON e.EmployeeID=o.EmployeeID
JOIN OrderDetails ord ON ord.OrderID=o.OrderID
GROUP BY e.EmployeeID , e.FirstName , e.LastName
ORDER BY ROUND(SUM((ord.UnitPrice*ord.Quantity)-(ord.UnitPrice*ord.Quantity*Discount)),2) DESC