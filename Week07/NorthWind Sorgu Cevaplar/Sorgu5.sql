-- 1998 yılında yapılan siparişleri listeleyin.

SELECT 
OrderID AS 'Sipariş Numarasi' , 
OrderDate AS 'Sipariş Tarihi',
ShipCountry AS 'Siparişin Gittiği Ülke'
FROM Orders
WHERE YEAR(Orders.OrderDate) = 1998;