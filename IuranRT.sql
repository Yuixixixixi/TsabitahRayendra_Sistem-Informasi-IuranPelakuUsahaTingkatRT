-- 1. Buat Tabel Log
CREATE TABLE Log_Aktivitas (
    id_log INT IDENTITY(1,1) PRIMARY KEY,
    aksi VARCHAR(50),
    deskripsi VARCHAR(255),
    waktu_kejadian DATETIME DEFAULT GETDATE()
);
GO

-- 2. Buat Trigger Otomatis (Contoh: Setiap ada INSERT di tabel pelaku usaha)
-- *Sesuaikan 'pelaku_usaha' dengan nama tabel pelaku usahamu di DB*
CREATE TRIGGER trg_AfterInsertUsaha
ON pelaku_usaha 
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Log_Aktivitas (aksi, deskripsi)
    SELECT 'INSERT', 'Warga baru masuk: ' + nama_pemilik + ' (Usaha: ' + nama_usaha + ')'
    FROM inserted;
END;
GO

SELECT * FROM Log_Aktivitas;

-- Trigger untuk UPDATE Warga
CREATE TRIGGER trg_AfterUpdateUsaha
ON pelaku_usaha 
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Log_Aktivitas (aksi, deskripsi)
    SELECT 'UPDATE', 'Mengubah data warga: ' + nama_pemilik + ' (Usaha: ' + nama_usaha + ')'
    FROM inserted;
END;
GO

-- Trigger untuk DELETE Warga
CREATE TRIGGER trg_AfterDeleteUsaha
ON pelaku_usaha 
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Log_Aktivitas (aksi, deskripsi)
    SELECT 'DELETE', 'Menghapus data warga: ' + nama_pemilik + ' (Usaha: ' + nama_usaha + ')'
    FROM deleted;
END;
GO

CREATE TRIGGER trg_AfterSavePembayaran
ON dbo.pembayaran 
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Log_Aktivitas (aksi, deskripsi)
    SELECT 'IURAN', 'Update status iuran Bulan ' + CAST(bulan AS VARCHAR) + ' Tahun ' + CAST(tahun AS VARCHAR) + ' menjadi: ' + status_bayar
    FROM inserted;
END;
GO

USE DB_iuranRT;
GO

-- 1. Pastikan SP Insert Pelaku Usaha sudah diperbarui dengan validasi duplikasi
ALTER PROCEDURE sp_InsertPelakuUsaha
    @NamaPemilik VARCHAR(100),
    @NamaUsaha VARCHAR(100),
    @NoWa VARCHAR(20),
    @Tahun INT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM dbo.pelaku_usaha WHERE nama_pemilik = @NamaPemilik AND nama_usaha = @NamaUsaha)
    BEGIN
        RAISERROR('Gagal! Pelaku usaha dengan nama pemilik dan nama usaha tersebut sudah terdaftar.', 16, 1);
        RETURN;
    END

    INSERT INTO dbo.pelaku_usaha (nama_pemilik, nama_usaha, no_wa, is_aktif, tahun)
    VALUES (@NamaPemilik, @NamaUsaha, @NoWa, 1, @Tahun);
END;
GO

-- 2. TRIGGER T-SQL: Otomatis generate iuran bulanan kosong setelah sukses insert pelaku usaha baru
CREATE TRIGGER trG_GeneratePembayaranAwal
ON dbo.pelaku_usaha
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @IdUsaha INT, @TahunUsaha INT;
    SELECT @IdUsaha = id_usaha, @TahunUsaha = tahun FROM inserted;

    -- Lakukan looping otomatis memasukkan bulan 1 sampai 12 dengan status awal NULL / Belum Lunas
    DECLARE @Bulan INT = 1;
    WHILE @Bulan <= 12
    BEGIN
        INSERT INTO dbo.pembayaran (id_usaha, bulan, tahun, jumlah_bayar, status_bayar)
        VALUES (@IdUsaha, @Bulan, @TahunUsaha, 0.00, 'Belum Lunas');
        
        SET @Bulan = @Bulan + 1;
    END
END;
GO

CREATE PROCEDURE sp_ReportIuranRT
    @Tahun INT
AS
BEGIN
    SELECT nama_pemilik, nama_usaha, no_wa, tahun FROM dbo.pelaku_usaha WHERE tahun = @Tahun;
END;

USE DB_iuranRT;
GO

CREATE PROCEDURE sp_SearchPelakuUsaha
    @Keyword VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        id_usaha,
        nama_pemilik,
        nama_usaha,
        no_wa,
        is_aktif,
        tahun
    FROM 
        dbo.pelaku_usaha
    WHERE 
        nama_pemilik LIKE '%' + @Keyword + '%'
        OR nama_usaha LIKE '%' + @Keyword + '%';
END;
GO
EXEC sp_SearchPelakuUsaha @Keyword = 'Budi';

USE DB_iuranRT;
GO

-- Pilihan A: Mencegah nama pemilik dan nama usaha yang sama persis
ALTER TABLE dbo.pelaku_usaha
ADD CONSTRAINT UQ_Pemilik_Usaha UNIQUE (nama_pemilik, nama_usaha);

-- Pilihan B: Mencegah nomor WA yang sama digunakan kembali (jika WA wajib unik)
-- Catatan: Karena no_wa bertipe NULL, Unique di SQL Server versi lama akan mengizinkan hanya satu NULL. 
-- Jika menggunakan SQL Server modern (seperti 16.0 pada gambar Anda), Anda bisa menggunakan Filtered Unique Index:
CREATE UNIQUE NONCLUSTERED INDEX UQ_NoWa_Unique
ON dbo.pelaku_usaha(no_wa)
WHERE no_wa IS NOT NULL;


CREATE PROCEDURE sp_InsertPelakuUsaha
    @nama_pemilik VARCHAR(100),
    @nama_usaha VARCHAR(100),
    @no_wa VARCHAR(20),
    @is_aktif BIT,
    @tahun INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Validasi duplikasi sebelum melakukan insert
    IF EXISTS (SELECT 1 FROM dbo.pelaku_usaha WHERE nama_pemilik = @nama_pemilik AND nama_usaha = @nama_usaha)
    BEGIN
        RAISERROR('Error: Pelaku usaha dengan nama pemilik dan nama usaha tersebut sudah terdaftar!', 16, 1);
        RETURN;
    END

    -- Jika lolos validasi, lakukan insert
    INSERT INTO dbo.pelaku_usaha (nama_pemilik, nama_usaha, no_wa, is_aktif, tahun)
    VALUES (@nama_pemilik, @nama_usaha, @no_wa, @is_aktif, @tahun);
END;
GO

USE DB_iuranRT;
GO

ALTER PROCEDURE sp_SearchPelakuUsaha
    @Keyword VARCHAR(100) -- Kita hapus parameter @Tahun dari definisi awal
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        id_usaha,
        nama_pemilik,
        nama_usaha,
        no_wa,
        is_aktif,
        tahun
    FROM 
        dbo.pelaku_usaha
    WHERE 
        (nama_pemilik LIKE '%' + @Keyword + '%'
        OR nama_usaha LIKE '%' + @Keyword + '%');
END
GO


USE DB_iuranRT;
GO

-- Ubah ke ALTER karena prosedurnya sudah ada di database
ALTER PROCEDURE sp_InsertPelakuUsaha
    @NamaPemilik VARCHAR(100),
    @NamaUsaha VARCHAR(100),
    @NoWa VARCHAR(20),
    @Tahun INT
AS
BEGIN
    SET NOCOUNT ON;

    -- 1. CEK DUPLIKASI: Jika nama pemilik DAN nama usaha yang sama persis sudah ada
    IF EXISTS (
        SELECT 1 
        FROM dbo.pelaku_usaha 
        WHERE nama_pemilik = @NamaPemilik AND nama_usaha = @NamaUsaha
    )
    BEGIN
        -- Lempar error ke C# agar masuk ke blok 'catch (SqlException)'
        RAISERROR('Gagal! Pelaku usaha dengan nama pemilik dan nama usaha tersebut sudah terdaftar.', 16, 1);
        RETURN;
    END

    -- 2. Jika lolos pengecekan, baru lakukan INSERT ke tabel
    INSERT INTO dbo.pelaku_usaha (nama_pemilik, nama_usaha, no_wa, is_aktif, tahun)
    VALUES (@NamaPemilik, @NamaUsaha, @NoWa, 1, @Tahun);
END;
GO
