-- Nakliye ücreti 50'den fazla olan siparişleri listeleyin.

SELECT 
o.OrderID AS 'Sipariş Numarasi' , 
o.Freight AS 'Nakliye Ücreti'
FROM Orders o 
WHERE o.Freight > 50
ORDER BY o.Freight DESC