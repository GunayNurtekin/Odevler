--TÜM SORGULAR

-- Tüm ürünlerin adlarını ve birim fiyatlarını listeleyin.

SELECT 
ProductName ,
UnitPrice
FROM Products


-- Müşterilerin şirket adlarını ve bulundukları şehirleri alfabetik sırayla listeleyin.

SELECT
CompanyName,
City
FROM Customers
ORDER BY City

-- Çalışanların ad ve soyadlarını birleştirerek tam isimlerini listeleyin.

SELECT 
Firstname + ' ' + LastName AS 'Ad Soyad'
FROM Employees


-- Stok miktarı 10'dan az olan ürünleri listeleyin.

SELECT 
ProductName as 'Ürün Adi' ,
UnitsInStock as "Stogu 10 dan az olan ürünler"
FROM Products
WHERE UnitsInStock<10
ORDER BY UnitsInStock DESC


-- 1998 yılında yapılan siparişleri listeleyin.

SELECT 
OrderID AS 'Sipariş Numarasi' , 
OrderDate AS 'Sipariş Tarihi',
ShipCountry AS 'Siparişin Gittiği Ülke'
FROM Orders
WHERE YEAR(Orders.OrderDate) = 1998;

-- Her bir kategorideki ürün sayısını bulun.

SELECT 
c.CategoryName,
SUM(p.UnitsInStock) AS 'Ürün Adeti'
FROM Products p
JOIN Categories c ON c.CategoryID = p.CategoryID
GROUP BY c.CategoryName 

-- En pahalı 5 ürünü fiyatlarıyla birlikte listeleyin.

SELECT TOP 5
p.ProductName,
p.UnitPrice
FROM Products p
ORDER BY p.UnitPrice DESC

-- Her bir ülkedeki müşteri sayısını bulun ve müşteri sayısına göre azalan sırayla listeleyin.

SELECT
c.Country AS 'Ülke' ,
COUNT(CustomerID) AS 'Müşteri Sayisi'
FROM Customers c
GROUP BY c.Country
ORDER BY COUNT(CustomerID) DESC


-- Nakliye ücreti 50'den fazla olan siparişleri listeleyin.

SELECT 
o.OrderID AS 'Sipariş Numarasi' , 
o.Freight AS 'Nakliye Ücreti'
FROM Orders o 
WHERE o.Freight > 50
ORDER BY o.Freight DESC

-- Her bir çalışanın toplam sipariş sayısını bulun.

SELECT 
e.FirstName + ' ' + e.LastName AS 'Ad Soyad' , 
Count(e.EmployeeID) AS 'Toplam Sipariş Sayısı'
FROM Orders o 
JOIN Employees e ON o.EmployeeID = e.EmployeeID
GROUP BY e.FirstName , e.LastName

-- Ürünleri kategorileriyle birlikte listeleyin.

SELECT 
c.CategoryName,
p.ProductName
FROM Products p
JOIN Categories c ON p.CategoryID = c.CategoryID
GROUP BY c.CategoryName , p.ProductName


-- Her bir siparişin toplam tutarını hesaplayın.

SELECT 
o.OrderID AS 'Sipariş Numarasi',
SUM((ord.UnitPrice*ord.Quantity)-(ord.UnitPrice*ord.Quantity*Discount)) AS 'TOPLAM TUTAR'
FROM Orders o
JOIN OrderDetails ord ON o.OrderID = ord.OrderID
GROUP BY o.OrderID 

-- En çok satılan 5 ürünü ve satış miktarlarını listeleyin.

SELECT TOP 5
p.ProductID AS 'ÜRÜN NUMARASI' , 
p.ProductName AS 'ÜRÜN ADI',
SUM(ord.Quantity) AS 'TOPLAM SATIŞ ADETİ'
FROM OrderDetails ord
JOIN Products p ON p.ProductID = ord.ProductID
GROUP BY p.ProductID , p.ProductName
ORDER BY SUM(ord.Quantity) DESC

-- Her bir müşterinin verdiği sipariş sayısını bulun.

SELECT 
cus.CustomerID AS 'Müşteri No' ,
cus.ContactName AS 'Müşteri Adı' ,
COUNT(o.OrderID) as 'Sipariş Adeti'
FROM Customers cus
JOIN Orders o ON o.CustomerID = cus.CustomerID
GROUP BY cus.CustomerID , cus.ContactName

-- Hangi kargo şirketinin kaç sipariş taşıdığını listeleyin.
SELECT 
sh.CompanyName AS 'Kargo Şirketi',
Count(o.OrderID) AS 'Sipariş Adeti'
FROM Orders o
JOIN Shippers sh ON sh.shipperID=o.ShipVia
GROUP BY sh.CompanyName

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

-- Her bir kategorideki ürünlerin ortalama fiyatını bulun.

SELECT 
c.CategoryName as 'Kategori Adı',
AVG(p.UnitPrice) as 'Ortalama Fiyat'
FROM Products p 
JOIN Categories c ON c.CategoryID=p.CategoryID
GROUP BY c.CategoryName

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

-- Her bir ülke için toplam satış tutarını hesaplayın.

SELECT 
c.Country,
ROUND(SUM((ord.UnitPrice*ord.Quantity)-(ord.UnitPrice*ord.Quantity*Discount)),2) AS 'TOPLAM TUTAR'
FROM Orders o
JOIN OrderDetails ord ON o.OrderID = ord.OrderID
JOIN Customers c ON c.CustomerID=o.CustomerID
GROUP BY c.Country
ORDER BY ROUND(SUM((ord.UnitPrice*ord.Quantity)-(ord.UnitPrice*ord.Quantity*Discount)),2) DESC

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

