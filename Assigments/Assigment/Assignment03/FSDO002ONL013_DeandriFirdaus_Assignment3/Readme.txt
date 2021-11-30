Kode peserta: FSDO002ONL013
Nama peserta: Deandri Firdaus
Assignment: Assignment3

Tata cara penggunaan aplikasi Assignment 3:
* CRUD menggunakan Swagger:
- Buka di terminal (vscode atau cmd langsung) dan arahkan ke direktori projek FSDO002ONL013_DeandriFirdaus_Assignment3
- Jalankan perintah = dotnet run watch
- Buka di browser link berikut = https://localhost:5001/swagger/index.html
- Get tanpa {id} adalah untuk menampilkan seluruh data di tabel movie.
- Post tanpa {id} adalah untuk memasukkan data di tabel movie.
- Get dengan {id} adalah untuk menampilkan data di tabel movie berdasarkan id.
- Put dengan {id} adalah untuk mengupdate atau mengedit sebuah data atau baris di tabel movie berdasarkan id.
- Delete dengan {id} adalah untuk menghapus sebuah data atau baris di tabel movie berdasarkan id.

* CRUD menggunakan Postman dengan Collection atau Workspace:
- Jalankan postman 
- Klik Collection
- Klik Create new Collection (tanda +)

[Get All Movies]
- Pilih Get
- Masukkan link berikut di kotak request URL = https://localhost:5001/api/movie
- Klik Send

[Get Movie]
- Pilih Get
- Masukkan link berikut di kotak request URL = https://localhost:5001/api/movie/[id_yang_diinginkan] (contoh /api/movie/1)
- Klik Send

[Create Movie]
- Pilih Get
- Masukkan link berikut di kotak request URL = https://localhost:5001/api/movie/
- Klik Send
- Pilih Post
- Pilih Body
- Pilih raw
- Ganti opsi/ekstensi dari Text menjadi JSON
- Masukkan data per baris, misal:
{
 "id" = 1,
 "nama" = "John Doe",
 "jenisKelamin = "Laki-Laki",
 "alamat" = "Jakarta"
}
- Klik Send

[Update Movie]
- Pilih Get
- Masukkan link berikut di kotak request URL = https://localhost:5001/api/movie/[id_yang_diinginkan]
- Klik Send
- Pilih Put
- Pilih Body
- Pilih raw
- Ganti opsi/ekstensi dari Text menjadi JSON
- Update data/baris tersebut menjadi data yang diinginkan, misal:
{
 "id" = 1,
 "nama" = "John Doe EDITED",
 "jenisKelamin = "Laki-Laki",
 "alamat" = "Jakarta EDITED"
}
- Klik Send

[Delete Movie]
- Pilih Get
- Masukkan link berikut di kotak request URL = https://localhost:5001/api/movie/
- Pilih Delete
- Masukkan link berikut di kotak request URL = https://localhost:5001/api/movie/[id_yang_diinginkan]
- Klik Send