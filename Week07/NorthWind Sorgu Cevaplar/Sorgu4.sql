-- Stok miktarı 10'dan az olan ürünleri listeleyin.

SELECT 
ProductName as 'Ürün Adi' ,
UnitsInStock as "Stogu 10 dan az olan ürünler"
FROM Products
WHERE UnitsInStock<10
ORDER BY UnitsInStock DESC