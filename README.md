•	Form koneksi
<img width="468" height="538" alt="image" src="https://github.com/user-attachments/assets/6aa79172-02a4-4dc6-b564-161190c643a1" />

•	Form input data
<img width="1222" height="703" alt="image" src="https://github.com/user-attachments/assets/babf4210-92ae-46f7-8de7-16d332c896e0" />

•	Form tampilan data
<img width="1249" height="712" alt="image" src="https://github.com/user-attachments/assets/f54e6701-b056-4ce4-a664-9be696f15860" />

•	Bukti insert, update, delete, dan search
- Insert
  <img width="1240" height="700" alt="image" src="https://github.com/user-attachments/assets/576f2c50-ea4b-4752-928f-cf71bf86420d" />

- Update
  <img width="1245" height="722" alt="image" src="https://github.com/user-attachments/assets/89e9af29-e5a6-4aa5-b86c-a69152233b41" />

- Delete
  <img width="1251" height="697" alt="image" src="https://github.com/user-attachments/assets/0c6d2ba1-3a18-4c42-a149-677576433f87" />

- Search

# Sistem Informasi Iuran Pelaku Usaha Tingkat RT (UCP 2)

Projek ini adalah aplikasi desktop berbasis Windows Forms (C#) dan SQL Server untuk mengelola data serta rekapitulasi iuran bulanan pelaku usaha di lingkungan RT. Dibuat untuk memenuhi tugas **UCP 2 - Pengembangan Aplikasi Basis Data (PABD)**.

## Fitur & Arsitektur UCP 2

### 1. Stored Procedure
Semua operasi manipulasi dan pencarian data di aplikasi diproses lewat Stored Procedure di database, bukan query mentah di kodingan C#:
* `sp_InsertPelakuUsaha`: Menambah data pelaku usaha baru dikunci per tahun aktif.
* `sp_UpdatePelakuUsaha`: Mengubah data profil pelaku usaha.
* `sp_DeletePelakuUsaha`: Menghapus permanen data pelaku usaha per tahun.
* `sp_SearchPelakuUsaha`: Mencari pelaku usaha berdasarkan kata kunci di tahun berjalan.
* `sp_SavePembayaran`: Menyimpan atau memperbarui status iuran bulanan (Upsert).

### 2. SQL Server VIEW
Proses menampilkan data rekap iuran bulanan (Januari - Desember) menggunakan objek VIEW untuk membatasi akses langsung ke tabel utama:
* `vw_LaporanBulanan`: Menggabungkan data profil dengan riwayat pembayaran dan mengubah baris transaksi menjadi kolom horizontal (`CASE WHEN`).

### 3. Binding & Binding Navigator
* **BindingSource & DataTable:** Menghubungkan data dari VIEW di database ke UI secara sinkron.
* **Binding Navigator:** Digunakan untuk navigasi perpindahan data baris demi baris pada DataGridView secara otomatis.

---

## Skenario SQL Injection

Aplikasi ini menyediakan fitur simulasi untuk menguji celah keamanan SQL Injection beserta cara pemulihannya.

### A. Celah Keamanan (Vulnerability)
Celah ini dibuat pada tombol **Test Injection** (`btnTestInjection`) yang kodingannya sengaja menggunakan penyambungan string langsung (*string concatenation*) tanpa parameter:

```csharp
string query = "UPDATE pelaku_usaha SET nama_pemilik = ' HACKED ' WHERE nama_pemilik = '" + txtNamaPemilik.Text + "'";

Payload Serangan  : ' OR 1=1 --
-- Test Injection
<img width="1412" height="706" alt="image" src="https://github.com/user-attachments/assets/75a327dd-9639-49de-9942-301d4ab212fd" />
<img width="423" height="403" alt="image" src="https://github.com/user-attachments/assets/36f3f0bb-cd8b-4bd4-96e6-0645a4eaa179" />

-- Backup
<img width="1389" height="691" alt="image" src="https://github.com/user-attachments/assets/a4ab0d69-4bb0-4fce-b63f-73bb6a3b07bb" />

-- laporan
<img width="1391" height="684" alt="image" src="https://github.com/user-attachments/assets/0154b8bd-6da7-47a0-8960-7f73e7ad63d0" />


