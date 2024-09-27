SELECT 
cus.CustomerID AS 'Müşteri No' ,
cus.ContactName AS 'Müşteri Adı' ,
COUNT(o.OrderID) as 'Sipariş Adeti'
FROM Customers cus
JOIN Orders o ON o.CustomerID = cus.CustomerID
GROUP BY cus.CustomerID , cus.ContactName