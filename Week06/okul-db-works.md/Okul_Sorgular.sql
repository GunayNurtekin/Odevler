-- Bölüm Bazında Not Ortalaması: Her bölümdeki tüm öğrencilerin aldıkları derslerden elde ettikleri notların ortalamasını bulun. Her bir bölüm için ortalama notu listeleyin.
-- İpucu: AVG fonksiyonu ve GROUP BY kullanarak sorgu yazın.

SELECT  
b.BolumAdi AS 'Bölüm Adi ',
AVG (Notlar) AS ' Not Ortalamalari'
FROM Ogrenciler o
JOIN Bolumler b ON b.BolumID = o.BolumID
GROUP BY b.BolumAdi


-- En Yüksek Notu Alan Öğrenciyi Bulma: Tüm bölümler arasından en yüksek notu alan öğrenciyi 
--ve hangi dersten bu notu aldığını listeleyin. Öğrencinin adını, soyadını, bölümünü, dersi ve notunu sonuç olarak getirin.
-- İpucu: MAX ve JOIN kullanarak öğrenci, ders ve not bilgilerini birleştirin.


SELECT  
    o.Ad + ' ' + o.Soyad AS 'Ad Soyad',
    b.BolumAdi AS 'Bölüm Adi',
    d.DersAdi AS 'Ders Adi',
    o.Notlar AS 'En Yüksek Not'
FROM Ogrenciler o
JOIN Bolumler b ON b.BolumID = o.BolumID 
JOIN Dersler d ON o.BolumID = d.BolumID
WHERE o.Notlar = (SELECT MAX(Notlar) FROM Ogrenciler);



-- Başarısız Öğrencilerin Listesi: Notu 50'nin altında olan tüm öğrencilerin listesini oluşturun. 
--Öğrencinin adı, soyadı, bölümü, dersi ve aldığı notu gösteren bir sorgu yazın.
-- İpucu: WHERE ile not filtresi ekleyin ve birden fazla tabloyu JOIN ile birleştirin.

SELECT  
    o.Ad + ' ' + o.Soyad AS 'Ad Soyad',
    b.BolumAdi AS 'Bölüm Adi',
    d.DersAdi AS 'Ders Adi',
    o.Notlar AS 'Not'
FROM Ogrenciler o
JOIN Bolumler b ON b.BolumID = o.BolumID 
JOIN Dersler d ON o.BolumID = d.BolumID
WHERE o.Notlar <50 



-- Ogretmenler Tablosunu Oluşturma: Öğretmenlerin ID, Ad, Soyad ve Bölüm bilgilerini tutan yeni bir tablo oluşturun.


CREATE TABLE Ogretmenler 
(OgretmenID INT PRIMARY KEY IDENTITY (1,1), 
OgretmenAd NVARCHAR(50) NOT NULL,
OgretmenSoyad NVARCHAR(50) NOT NULL,
BolumID INT NOT NULL
)

-- Ogretmenler tablosunu oluşturun ve öğretim üyelerinin bilgilerini ekleyin (en az 5 öğretmen ekleyin).
-- OgretmenID, Ad, Soyad, BolumID alanlarını içersin.

INSERT INTO Ogretmenler (OgretmenAd,OgretmenSoyad,BolumID)
                VALUES  ('Hakki','Bulut',1),
                        ('Hatice','Diken',2),
                        ('Sebahattin','Tunca',3),
                        ('Yaşar','Kara',1),
                        ('Aslihan','Karaca',3)




-- OgretmenDersler Tablosunu Oluşturma: Her öğretmenin hangi dersleri verdiğini kaydetmek için yeni bir tablo oluşturun. Bu tabloda, öğretmenlerin ID'leri ve verdikleri derslerin ID'leri yer alsın.
-- OgretmenDersler tablosunu oluşturun. OgretmenID ve DersID bilgilerini içersin.

CREATE TABLE OgretmenDersler 
(OgretmenID INT NOT NULL, 
DersID INT NOT NULL
)


-- 5 farklı öğretim üyesine, en az 2 farklı ders atayın.

INSERT INTO OgretmenDersler (OgretmenID,DersID)
                VALUES  (1,1), (1,2), (1,3),(1,4),
                        (2,5), (2,6), (2,7),
                        (3,9), (3,10),
                        (4,1), (4,2), (4,4),
                        (5,9), (5,10),(5,11),(5,12)
                    

-- Sorgulama: Her öğretmenin verdiği dersleri ve bu derslere kayıtlı olan öğrencilerin listesini getiren bir sorgu yazın. 
-- Sorgu sonuçları, öğretmen adı, ders adı ve öğrenci adını içermelidir.

SELECT 
ogr.OgretmenAd+' '+ogr.OgretmenSoyad AS 'Öğretmen Ad Soyad',
d.DersAdi AS 'Ders Adi',
o.Ad+' '+o.SoyAd AS 'Öğrenci Ad Soyad'

FROM Ogretmenler ogr
JOIN Bolumler b On b.BolumID = ogr.BolumID
JOIN Dersler d On d.BolumID = ogr.BolumID
JOIN Ogrenciler o On o.BolumID = ogr.BolumID
ORDER BY ogr.OgretmenAd




DROP TABLE Ogretmenler