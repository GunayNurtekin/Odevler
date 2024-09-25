CREATE TABLE Kulüpler (
    KulupID INT PRIMARY KEY IDENTITY(1,1),
    KulupAdi NVARCHAR(50) NOT NULL,
    KurulusYili INT 
)

CREATE TABLE OgrenciKulüp (
    OgrenciID INT PRIMARY KEY IDENTITY (1,1) , 
    KulupID INT NOT NULL,
    Rol NVARCHAR(50) NOT NULL,
    KatilimTarihi DATE,
    FOREIGN KEY (KulupID) REFERENCES Kulüpler ( KulupID)
    )

-- 5 kulüp oluşturun (örneğin: Tiyatro Kulübü, Müzik Kulübü, Spor Kulübü vb.).

INSERT INTO  Kulüpler ( KulupAdi , KurulusYili )
             VALUES ('Tiyatro Kulübü',2008),
                    ('Müzik Kulübü',2010),
                    ('Spor Kulübü',2005),
                    ('Bilgisayar Kulübü',2014),
                    ('Santranç Kulübü',2012)

-- En az 15
-- Her kulübe en az 3 öğrenci ekleyin. Öğrencilerin farklı rollerde yer almasını sağlayın.

                

INSERT INTO OgrenciKulüp (KulupID, Ad, Soyad, Rol, KatilimTarihi)
VALUES
    (1, 'Can', 'Güneş', 'Başkan', '2008-12-03'),
    (1, 'Ayşe', 'Eren', 'Üye', '2009-05-26'),
    (1, 'Kadir', 'Türkmen', 'Üye', '2012-12-12'),
    (1, 'Veli', 'Taş', 'Üye', '2011-09-05'),
    (1, 'Ayşe', 'Bayrak', 'Sekreter', '2010-11-25'),

    (2, 'Hasan', 'Çiçek', 'Başkan', '2010-03-27'),
    (2, 'Neşe', 'Ari', 'Üye', '2012-05-06'),
    (2, 'Leyla', 'Türkmen', 'Üye', '2013-07-03'),
    (2, 'Neşe', 'Şahin', 'Sekreter', '2012-12-30'),
    (2, 'Zeynep', 'Eren', 'Sekreter', '2011-05-07'),
    (2, 'Nazan', 'Erdoğan', 'Üye', '2015-12-03'),
    (2, 'Mustafa', 'Yıldız', 'Üye', '2016-09-22'),

    (3, 'Kadir', 'Polat', 'Başkan', '2006-08-14'),
    (3, 'Hülya', 'Aslan', 'Üye', '2008-11-03'),
    (3, 'Hülya', 'Demirtaş', 'Üye', '2009-01-12'),
    (3, 'Onur', 'Aksoy', 'Üye', '2011-02-24'),
    (3, 'Cansu', 'Baş', 'Sekreter', '2010-10-10'),
    (3, 'Zeynep', 'Öztürk', 'Başkan', '2008-02-12'),
    (3, 'Emine', 'Erdoğan', 'Üye', '2009-03-15'),
    (3, 'Seda', 'Ari', 'Üye', '2012-10-07'),
    (3, 'Hasan', 'Duman', 'Üye', '2011-05-04'),
    (3, 'Veli', 'Can', 'Sekreter', '2010-03-30'),

    (4, 'Emine', 'Eren', 'Başkan', '2014-01-01'),
    (4, 'Hasan', 'Çelik', 'Üye', '2014-05-03'),
    (4, 'Hale', 'Aydın', 'Üye', '2015-07-12'),
    (4, 'Selin', 'Özer', 'Üye', '2016-11-04'),
    (4, 'Elif', 'Kaya', 'Sekreter', '2015-06-03'),
    (4, 'Fatma', 'Bulut', 'Üye', '2018-12-28'),

    (5, 'Hakan', 'Koç', 'Başkan', '2010-02-03'),
    (5, 'Yasin', 'Duman', 'Üye', '2011-01-06'),
    (5, 'Betül', 'Çiçek', 'Sekreter', '2012-02-13'),
    (5, 'Fikret', 'Çiftçi', 'Üye', '2014-07-12'),
    (5, 'Bahar', 'Öztürk', 'Sekreter', '2015-03-22');



DROP TABLE OgrenciKulup