-- Tüm kulüp üyelerinin adlarını, soyadlarını ve hangi kulüpte yer aldıklarını listeleyin. (JOIN)

SELECT 
ö.Ad + ' ' + ö.Soyad AS 'Ad Soyad',
k.KulupAdi
FROM OgrenciKulüp ö
JOIN Kulüpler k ON k.KulupID = ö.KulupID


-- "Tiyatro Kulübü" üyelerini ve rollerini listeleyin. (WHERE ve JOIN)

SELECT 
ö.Ad + ' ' + ö.Soyad AS 'Ad Soyad',
k.KulupAdi,
ö.Rol
FROM OgrenciKulüp ö
JOIN Kulüpler k ON k.KulupID = ö.KulupID
WHERE k.KulupAdi='Tiyatro Kulübü'


-- Tüm kulüplerde başkan olarak görev yapan öğrencileri listeleyin. (WHERE)

SELECT 
ö.Ad + ' ' + ö.Soyad AS 'Ad Soyad',
k.KulupAdi,
ö.Rol
FROM OgrenciKulüp ö
JOIN Kulüpler k ON k.KulupID = ö.KulupID
WHERE ö.Rol='Başkan'


-- Her kulübün kaç üyesi olduğunu listeleyin. (GROUP BY ve COUNT)

SELECT 
K.KulupAdi,
Count(*) AS 'Üye Sayisi'
FROM OgrenciKulüp ö
JOIN Kulüpler k ON k.KulupID = ö.KulupID
WHERE ö.Rol ='Üye'
GROUP BY K.KulupAdi

-- Kuruluş yılı en eski olan kulübün üyelerini listeleyin. (ORDER BY ve JOIN)

SELECT 
ö.Ad + ' ' + ö.Soyad AS 'Ad Soyad',
K.KulupAdi,
k.KurulusYili
FROM OgrenciKulüp ö
JOIN Kulüpler k ON k.KulupID = ö.KulupID
WHERE k.kulupID=3
ORDER BY k.KurulusYili


-- Öğrencilerin hangi tarihte hangi kulübe katıldıklarını listeleyin. (SELECT ve JOIN)

SELECT 
ö.Ad + ' ' + ö.Soyad AS 'Ad Soyad',
K.KulupAdi,
ö.KatilimTarihi
FROM OgrenciKulüp ö
JOIN Kulüpler k ON k.KulupID = ö.KulupID


-- "Müzik Kulübü"nde bulunan tüm rollerin bir listesini çıkarın. (WHERE ve DISTINCT)

SELECT DISTINCT Rol,
K.KulupAdi
FROM OgrenciKulüp ö
JOIN Kulüpler k ON k.KulupID = ö.KulupID
WHERE k.KulupAdi='Müzik Kulübü'

-- Her kulüpte kaç başkan olduğunu gruplandırarak listeleyin. (GROUP BY ve COUNT)

SELECT 
k.KulupAdi,
Count(k.KulupAdi) AS 'Başkan Sayıları'
FROM OgrenciKulüp ö
JOIN Kulüpler k ON k.KulupID = ö.KulupID
WHERE ö.rol='Başkan'
GROUP BY k.KulupAdi


-- Hangi öğrenci en son hangi kulübe katılmış, bu bilgiyi listeleyin. (JOIN ve ORDER BY)

SELECT TOP 1
ö.Ad + ' ' + ö.Soyad AS 'Ad Soyad',
K.KulupAdi,
ö.KatilimTarihi
FROM OgrenciKulüp ö
JOIN Kulüpler k ON k.KulupID = ö.KulupID
ORDER BY ö.KatilimTarihi



-- Birden fazla kulüpte yer alan öğrencileri ve katıldıkları kulüpleri listeleyin. (GROUP BY ve HAVING)

SELECT 
    ö.Ad + ' ' + ö.Soyad AS 'Ad Soyad',
    k.KulupAdi,
    ö.KatilimTarihi,
    COUNT(ö.OgrenciID) AS 'Katilim Sayisi'
FROM OgrenciKulüp ö
JOIN Kulüpler k ON k.KulupID = ö.KulupID
GROUP BY ö.Ad, ö.Soyad, k.KulupAdi, ö.KatilimTarihi;
