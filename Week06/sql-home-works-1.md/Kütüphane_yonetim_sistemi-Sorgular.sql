-- Tüm kitapların adını, yazarını ve yayın yılını listeleyin. (SELECT ve FROM)

SELECT 
KitapAdi AS 'Kitap Adi',
Yazar AS 'Yazar',
YayinYili AS 'Yayin Yili'
FROM Kitaplar


-- Yayın yılı 2000’den sonra olan kitapların isimlerini ve yazarlarını listeleyin. (WHERE)

SELECT 
KitapAdi AS 'Kitap Adi',
Yazar AS 'Yazar',
YayinYili AS 'Yayin Yili'
FROM Kitaplar k 
WHERE k.YayinYili>2000

-- Hangi öğrencinin hangi kitapları ödünç aldığını gösteren bir liste oluşturun. (JOIN)

SELECT
o.Ad + ' ' + o.SoyAd As 'Ad Soyad',
k.KitapAdi AS 'Kitap Adi'
FROM Kitaplar k 
JOIN OduncAlmalar oa ON k.KitapID = oa.KitapID 
JOIN Ogrenciler o ON o.OgrenciID = oa.OgrenciID
ORDER by (k.KitapAdi)

-- En fazla sayfa sayısına sahip 5 kitabı sayfa sayısına göre azalan sırayla listeleyin. (ORDER BY ve LIMIT)

SELECT TOP 5
KitapAdi AS 'Kitap Adi',
SayfaSayisi AS 'Sayfa Sayisi'
FROM Kitaplar k
ORDER BY (k.SayfaSayisi) DESC


-- "Orhan Pamuk" adlı yazarın kitaplarını listeleyin. (WHERE)

SELECT
Yazar AS 'Yazar Adi',
KitapAdi AS 'Kitap Adi',
SayfaSayisi AS 'Sayfa Sayisi'
FROM Kitaplar k
WHERE (k.Yazar='Orhan Pamuk')
ORDER BY (SayfaSayisi) DESC

-- Öğrencilerin ödünç aldığı dergileri ve bu dergilerin yayıncılarını listeleyin. (JOIN)

SELECT 

o.ad + ' ' + O.Soyad AS 'Ad Soyad',
d.DergiAdi AS ' Dergi Adı',
d.Yayinci AS 'Yayinci'

FROM Dergiler d 
JOIN OduncAlmalar Oa ON d.DergiID = oa.DergiID 
JOIN Ogrenciler o ON o.OgrenciId = oa.OgrenciID
ORDER BY (d.DergiAdi)


-- Henüz hiçbir materyal ödünç almayan öğrencileri listeleyin. (LEFT JOIN ve IS NULL)

SELECT
o.ad + ' ' + O.Soyad AS 'Ad Soyad'
FROM Ogrenciler o 
LEFT JOIN OduncAlmalar oa
ON o.OgrenciID = oa.OgrenciID
WHERE oa.OgrenciID IS NULL


-- Her kitabın, derginin ve DVD'nin kaç kez ödünç alındığını gruplandırarak listeleyin. (GROUP BY)

SELECT 
KitapID,
COUNT(*) AS 'Kitap Odunc Sayisi'
FROM OduncAlmalar oa
WHERE KitapID IS NOT NULL
GROUP BY KitapID;

SELECT 
DergiID,
COUNT(*) AS 'Dergi Odunc Sayisi'
FROM OduncAlmalar oa
WHERE DergiID IS NOT NULL
GROUP BY DergiID;

SELECT 
DVDID,
COUNT(*) AS 'DVD Odunc Sayisi'
FROM OduncAlmalar oa
WHERE DVDID IS NOT NULL
GROUP BY DVDID;


-- Yayın tarihi en eski olan 3 kitabı listeleyin. (ORDER BY ve LIMIT)

SELECT TOP 3 
KitapAdi AS 'Kitap Adı',
Yazar , 
YayinYili AS 'Yayin Yili'
FROM Kitaplar
ORDER BY YayinYili

-- "Ali Yılmaz" adlı öğrencinin ödünç aldığı tüm materyalleri listeleyin. (WHERE ve JOIN)

SELECT 

o.ad + ' ' + O.Soyad AS 'Ad Soyad',

k.KitapAdi AS 'Kitap Adi',
d.DergiAdi AS 'Dergi Adi',
dv.DVDAdi AS 'DVD Adi'

FROM Ogrenciler o
JOIN OduncAlmalar oa ON oa.OgrenciID = o.OgrenciID
JOIN Dergiler d ON oa.DergiID = d.DergiID
JOIN Kitaplar k ON oa.KitapID = k.KitapID
JOIN DVDler dv ON oa.DVDID = dv.DVDID

WHERE o.ad='Ali' AND o.SoyAd='Yılmaz'