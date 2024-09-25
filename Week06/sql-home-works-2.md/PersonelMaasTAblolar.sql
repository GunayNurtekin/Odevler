-- Personel tablosunu oluşturun: PersonelID, Ad, Soyad, Pozisyon, BaslangicTarihi.

CREATE TABLE Personel 
(
PersonelID INT PRIMARY KEY IDENTITY (1,1) ,
Ad NVARCHAR(50) NOT NULL,
SoyAd NVARCHAR(50) NOT NULL,
Pozisyon NVARCHAR(50) ,
BaslangicTarihi DATE ,
)

--Maaslar tablosunu oluşturun: MaasID, PersonelID, MaasMiktari, GuncellemeTarihi. (Maaşlar tabloda her maaş değişikliğinde güncellenecek, bu yüzden her güncelleme ayrı bir kayıt olacak.)

CREATE TABLE Maas
(
MaasID INT PRIMARY KEY IDENTITY (1,1) ,
PersonelID INT NOT NULL,
MaasMiktari INT,
GuncellemeTarihi DATE,
FOREIGN KEY (PersonelID) REFERENCES Personel(PersonelID)
)

-- 10 personel ekleyin. Personelin pozisyonları okul müdürü, öğretmen, sekreter gibi roller olsun.

INSERT INTO Personel (Ad, Soyad, Pozisyon, BaslangicTarihi)
VALUES 
('Ahmet', 'Yılmaz', 'Okul Müdürü', '2010-09-01'),
('Ayşe', 'Kaya', 'Öğretmen', '2015-08-20'),
('Mehmet', 'Demir', 'Öğretmen', '2012-04-10'),
('Fatma', 'Çelik', 'Sekreter', '2017-10-15'),
('Ali', 'Aydın', 'Öğretmen', '2016-02-28'),
('Zeynep', 'Polat', 'Sekreter', '2018-11-12'),
('Hasan', 'Gül', 'Öğretmen', '2014-05-19'),
('Elif', 'Şahin', 'Okul Müdürü', '2013-03-22'),
('Kemal', 'Öztürk', 'Öğretmen', '2011-06-30'),
('Hülya', 'Aslan', 'Sekreter', '2019-01-14')


INSERT INTO Maas (PersonelID, MaasMiktari, GuncellemeTarihi)
VALUES
(1, 7000, '2010-09-01'), 
(2, 5000, '2015-08-20'),
(3, 4800, '2012-04-10'),
(4, 4700, '2017-10-15'),
(5, 4600, '2016-02-28'),
(6, 3500, '2018-11-12'),
(7, 4700, '2014-05-19'),
(8, 6000, '2013-03-22'),
(9, 5500, '2011-06-30'),
(10, 4800, '2019-01-14'),
(1, 7500, '2021-09-01'),  -- Ahmet Yılmaz (Okul Müdürü)
(2, 5200, '2017-01-01'),  -- Ayşe Kaya (Öğretmen)
(3, 5000, '2013-06-15'),  -- Mehmet Demir (Öğretmen)
(4, 4900, '2018-12-20'),  -- Fatma Çelik (Öğretmen)
(5, 4800, '2019-03-01'),  -- Ali Aydın (Öğretmen)
(6, 3700, '2020-01-10'),  -- Zeynep Polat (Sekreter)
(7, 4900, '2016-05-05'),  -- Hasan Gül (Öğretmen)
(8, 6500, '2016-07-12'),  -- Elif Şahin (Müdür Yardımcısı)
(9, 5800, '2014-09-30'),  -- Kemal Öztürk (Rehberlik Öğretmeni)
(10,5000, '2020-06-20'), -- Hülya Aslan (Öğretmen)
(1, 8500, '2022-10-01'),  -- Ahmet Yılmaz (Okul Müdürü)
(2, 6000, '2018-01-01'),  -- Ayşe Kaya (Öğretmen)
(3, 5800, '2014-06-15'),  -- Mehmet Demir (Öğretmen)
(6, 4200, '2020-07-10')  -- Zeynep Polat (Sekreter)





DROP TABLE Maas