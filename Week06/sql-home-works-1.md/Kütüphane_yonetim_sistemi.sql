-- kitaplar, dergiler ve DVD'ler
--Kitaplar tablosunu oluşturun: KitapID, KitapAdi, Yazar, YayınYılı, SayfaSayisi, ISBN.
--Dergiler tablosunu oluşturun: DergiID, DergiAdi, Yayınci, YayınTarihi, Sayı.
--DVDler tablosunu oluşturun: DVDID, DVDAdi, Yönetmen, YayınYılı, Süre.
--Ogrenciler tablosunu kullanın (mevcut Ogrenciler tablosu ile devam edebilir).


CREATE TABLE Kitaplar (
KitapID INT PRIMARY KEY IDENTITY (1,1),
KitapAdi NVARCHAR(50) NOT NULL,
Yazar NVARCHAR(50) NOT NULL ,
YayinYili INT NOT NULL,
SayfaSayisi INT ,
ISBN INT
)


CREATE TABLE Dergiler (
DergiID INT PRIMARY KEY IDENTITY (1,1),
DergiAdi NVARCHAR(50) NOT NULL,
Yayinci NVARCHAR(50) NOT NULL ,
YayinYili INT NOT NULL,
Sayi INT ,
)

CREATE TABLE DVDler (
DVDID INT PRIMARY KEY IDENTITY (1,1),
DVDAdi NVARCHAR(50) NOT NULL,
Yönetmen NVARCHAR(50) NOT NULL ,
YayinYili INT NOT NULL,
Süre INT
)

CREATE TABLE Ogrenciler (
    OgrenciID INT PRIMARY KEY IDENTITY (1,1) , 
    Ad NVARCHAR(50) NOT NULL,
    SoyAd NVARCHAR(50) NOT NULL,
    BolumID INT NOT NULL,
    )

--Kitaplar tablosuna 20 kitap ekleyin. Türkçe yazar ve kitap adlarını kullanarak örnek veriler oluşturun.
--Dergiler tablosuna 5 dergi ekleyin. Dergi adları ve yayıncıları Türkçe olsun.
--DVDler tablosuna 5 DVD ekleyin. Türkçe film isimleri ve yönetmenlerle doldurun.

INSERT INTO Kitaplar(KitapAdi,Yazar,YayinYili)
VALUES
    ('Kürk Mantolu Madonna', 'Sabahattin Ali', 1943),
    ('İnce Memed', 'Yasar Kemal', 1955),
    ('Tutunamayanlar', 'Oğuz Atay', 1971),
    ('Saatleri Ayarlama Enstitüsü', 'Ahmet Hamdi Tanpınar', 1961),
    ('Aşk', 'Elif Şafak', 2009),
    ('Beyaz Gemi', 'Cengiz Aytmatov', 1970),
    ('Efsane', 'Abdülhak Şinasi Hisar', 1942),
    ('Huzur', 'Ahmet Hamdi Tanpınar', 1949),
   ('Cevdet Bey ve Oğulları', 'Orhan Pamuk', 1982),
    ('Kuyucaklı Yusuf', 'Sabahattin Ali', 1937),
    ('Baba ve Piç', 'Elif Şafak', 1943),
    ('Solgun Bir Sarı Gül', 'Sabahattin Ali', 2006),
    ('Fatih Harbiye', 'Peyami Safa', 1931),
    ('Yaban', 'Yakup Kadri Karaosmanoğlu', 1932),
    ('Sergüzeşt', 'Samipaşazade Sezai', 1988),
    ('Kar', 'Orhan Pamuk', 2002),
    ('Yaşar Ne Yaşar Ne Yaşamaz', 'Aziz Nesin', 1977),
    ('Benim Adım Kırmızı', 'Orhan Pamuk', 1998)

    

INSERT INTO Dergiler (DergiAdi, Yayinci, YayinYili) 
VALUES
('Bilim ve Teknik', 'TÜBİTAK', 1967),
('Atlas', 'Doğan Burda', 1993),
('National Geographic Türkiye', 'Doğuş Yayın Grubu', 2001),
('Kafasına Göre', 'Dergi Komitesi', 2015),
('Psikeart', 'Psikiyatri Derneği', 2008);

INSERT INTO DVDler (DVDAdi, Yönetmen, YayinYili) 
VALUES
('Ahlat Ağacı', 'Nuri Bilge Ceylan', 2018),
('Babam ve Oğlum', 'Çağan Irmak', 2005),
('Kış Uykusu', 'Nuri Bilge Ceylan', 2014),
('Vizontele', 'Yılmaz Erdoğan', 2001),
('Eşkıya', 'Yavuz Turgul', 1996);

INSERT INTO Ogrenciler(Ad,Soyad,BolumID)
VALUES
    ('Ali','Yılmaz',1),
    ('Ayşe','Kara',1),
    ('Mehmet','Çelik',1),
    ('Fatma','Demir',1),
    ('Ahmet','Öztürk',2),
    ('Elif','Aydın',2),
    ('Mustafa','Koç',2),
    ('Zeynep','Arslan',2),
    ('Emre','Yalçın',2),
    ('Seda','Tekin',3),
    ('Burak','Polat',3),
    ('Cem','Güler',3),
    ('Derya','Uçar',3),
    ('Aliye','Sönmez',3),
    ('Oğuz','Çetin',3)



-- OduncAlmalar adında bir tablo oluşturun. Bu tabloda OgrenciID, KitapID, DergiID, DVDID ve OduncTarihi bilgileri yer alsın.
-- Öğrencilerin kütüphaneden ödünç aldıkları materyalleri kaydedecek 10 örnek veri ekleyin.

CREATE TABLE OduncAlmalar (
    OduncID INT PRIMARY KEY IDENTITY(1,1),
    OgrenciID INT NOT NULL,
    KitapID INT NULL,
    DergiID INT NULL,
    DVDID INT NULL,
    OduncTarihi DATE NOT NULL,
    FOREIGN KEY (OgrenciID) REFERENCES Ogrenciler(OgrenciID),
    FOREIGN KEY (KitapID) REFERENCES Kitaplar(KitapID),
    FOREIGN KEY (DergiID) REFERENCES Dergiler(DergiID),
    FOREIGN KEY (DVDID) REFERENCES DVDler(DVDID)
);


INSERT INTO OduncAlmalar (OgrenciID, KitapID, DergiID, DVDID, OduncTarihi)
VALUES (1, 2, 1, 2, '2024-09-18'),
     (2, 3, 1, NULL, '2024-09-05'),
     (3, 2, 1, 1, '2024-09-17'),
     (4, 3, 2, 2, '2024-09-04'),
     (5, 2, 1, NULL, '2024-09-05'),
     (6, 1, NULL, 2, '2024-09-10'),
     (7, NULL, 1, 1, '2024-09-14'),
     (8, 1, NULL, NULL, '2024-09-12'),
     (9, 2, 2, 2, '2024-09-15'),
     (10, 1, NULL, 1, '2024-09-09')



DROP TABLE Dergiler