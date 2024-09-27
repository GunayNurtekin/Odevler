-- En az 5 sipariş veren müşterileri ve sipariş sayılarını listeleyin.
SELECT 
c.CustomerID,
c.ContactName,
COUNT(c.CustomerID) AS 'Sipariş Adeti'
FROM Orders o
JOIN Customers c ON c.CustomerID=o.CustomerID
GROUP BY c.CustomerID , c.ContactName
HAVING COUNT(c.CustomerID)>4
ORDER BY COUNT(c.CustomerID) DESC