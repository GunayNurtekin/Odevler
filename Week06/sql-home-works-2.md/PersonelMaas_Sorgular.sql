-- Her personelin mevcut maaşını listeleyin (En son güncelleme tarihine göre).

SELECT 
p.Ad + ' '+ p.SoyAd AS 'AdSoyad' ,
m.MaasMiktari,
m.GuncellemeTarihi
FROM Maas m
JOIN Personel p ON m.PersonelID = p.PersonelID
WHERE m.GuncellemeTarihi = (
    SELECT MAX(m2.GuncellemeTarihi)
    FROM Maas m2
    WHERE m2.PersonelID = m.PersonelID
);


-- Tüm personelin ortalama maaşını hesaplayan bir sorgu yazın.

SELECT 
m.PersonelID,
p.Ad + ' '+ p.SoyAd AS 'AdSoyad' ,
AVG(MaasMiktari) AS OrtalamaMaas
FROM Maas m
JOIN Personel p ON m.PersonelID = p.PersonelID
GROUP BY p.Ad , p.Soyad , m.PersonelID


-- Aynı pozisyonda çalışan personelin maaşlarını karşılaştırarak en yüksek ve en düşük maaşları getirin.

SELECT
p.Pozisyon ,
MAX(m.MaasMiktari) AS 'En Yüksek Maaş',
MIN(m.MaasMiktari) AS 'En Düşük Maaş'
FROM personel p
JOIN maas m ON m.PersonelID = p.personelID
GROUP BY p.Pozisyon


-- Tüm personelin adını, soyadını ve pozisyonunu listeleyin. (SELECT ve FROM)

SELECT
Ad ,
Soyad,
Pozisyon
FROM personel

-- Hangi pozisyonda kaç personel çalıştığını gösteren bir liste oluşturun. (GROUP BY ve COUNT)

SELECT
Pozisyon,
Count(*) AS ' Çalışan Sayisi'
FROM personel
GROUP BY pozisyon

-- Her personelin en son maaş miktarını ve güncelleme tarihini listeleyin. (JOIN ve MAX)

SELECT 
    m1.PersonelID,
    m1.MaasMiktari,
    m1.GuncellemeTarihi
FROM Maas m1
JOIN (
    SELECT PersonelID, MAX(GuncellemeTarihi) AS SonGuncellemeTarihi
    FROM Maas
    GROUP BY PersonelID
) m2 ON m1.PersonelID = m2.PersonelID AND m1.GuncellemeTarihi = m2.SonGuncellemeTarihi;


-- "Öğretmen" pozisyonunda çalışan tüm personelleri listeleyin. (WHERE)

SELECT
p.ad + ' ' + p.Soyad AS 'Ad Soyad',
Pozisyon
FROM personel p
JOIN maas m ON m.PersonelID = p.personelID
WHERE p.pozisyon = 'Öğretmen'


-- Tüm personelin ortalama maaşını hesaplayın. (AVG)

SELECT 
m.PersonelID,
p.Ad + ' '+ p.SoyAd AS 'AdSoyad' ,
AVG(MaasMiktari) AS OrtalamaMaas
FROM Maas m
JOIN Personel p ON m.PersonelID = p.PersonelID
GROUP BY p.Ad , p.Soyad , m.PersonelID

-- En yüksek maaş alan personelin adını, soyadını ve maaşını listeleyin. (ORDER BY ve LIMIT)

SELECT TOP 1
p.ad + ' ' + p.Soyad AS 'Ad Soyad',
Pozisyon ,
m.MaasMiktari
FROM personel p
JOIN maas m ON m.PersonelID = p.personelID
ORDER BY m.MaasMiktari DESC

-- Bir personelin tüm maaş değişikliklerini kronolojik sırayla listeleyin. (WHERE ve ORDER BY)

SELECT
p.ad + ' ' + p.Soyad AS 'Ad Soyad',
Pozisyon ,
m.MaasMiktari,
m.GuncellemeTarihi
FROM personel p
JOIN maas m ON m.PersonelID = p.personelID
WHERE p.ad='Ahmet' AND p.Soyad='Yilmaz'
ORDER BY m.MaasMiktari DESC


-- Aynı pozisyondaki personellerin maaşlarını karşılaştırarak en yüksek ve en düşük maaşı listeleyin. (GROUP BY ve HAVING)

SELECT
p.Pozisyon ,
MAX(m.MaasMiktari) AS 'En Yüksek Maaş',
MIN(m.MaasMiktari) AS 'En Düşük Maaş'
FROM personel p
JOIN maas m ON m.PersonelID = p.personelID
GROUP BY p.Pozisyon


-- Son 6 ay içinde maaşı güncellenen personelleri listeleyin. (WHERE ve DATEADD)

SELECT
p.ad + ' ' + p.Soyad AS 'Ad Soyad',
p.Pozisyon,
m.GuncellemeTarihi
FROM personel p
JOIN maas m ON m.PersonelID = p.personelID
WHERE m.GuncellemeTarihi <= DATEADD(MONTH, -6, p.BaslangicTarihi)


-- Maaşı en az iki kez güncellenmiş olan personelleri listeleyin. (GROUP BY ve HAVING)

SELECT 
    
    p.ad + ' ' + p.Soyad AS 'Ad Soyad',
    COUNT(*) AS GuncellemeSayisi
FROM Maas m
JOIN Personel p ON m.PersonelID = p.personelID
GROUP BY m.PersonelID ,  p.ad , p.Soyad
HAVING COUNT(*) >= 2