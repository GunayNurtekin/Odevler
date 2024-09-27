-- Her bir ülkedeki müşteri sayısını bulun ve müşteri sayısına göre azalan sırayla listeleyin.
SELECT
c.Country AS 'Ülke' ,
COUNT(CustomerID) AS 'Müşteri Sayisi'
FROM Customers c
GROUP BY c.Country
ORDER BY COUNT(CustomerID) DESC