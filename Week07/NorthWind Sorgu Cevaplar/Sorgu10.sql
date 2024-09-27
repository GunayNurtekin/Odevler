-- Her bir çalışanın toplam sipariş sayısını bulun.

SELECT 
e.FirstName + ' ' + e.LastName AS 'Ad Soyad' , 
Count(e.EmployeeID) AS 'Toplam Sipariş Sayısı'
FROM Orders o 
JOIN Employees e ON o.EmployeeID = e.EmployeeID
GROUP BY e.FirstName , e.LastName