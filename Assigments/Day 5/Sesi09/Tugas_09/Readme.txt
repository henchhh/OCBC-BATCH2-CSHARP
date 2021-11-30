Kode peserta: FSDO002ONL013
Nama peserta: Deandri Firdaus
Struktur Folder:
- Sesi09/Kantor_WebAPI
- Sesi09/Tugas_09

Tata cara penggunaan aplikasi Tugas 9:
* CRUD menggunakan Swagger:
- Buka di terminal (vscode atau cmd langsung) dan arahkan ke direktori projek Tugas_09
- Jalankan perintah = dotnet run watch
- Buka di browser link berikut = https://localhost:5001/swagger/index.html
- Get tanpa {id} adalah untuk menampilkan seluruh data di tabel employee.
- Post tanpa {id} adalah untuk memasukkan data di tabel employee.
- Get dengan {id} adalah untuk menampilkan data di tabel employee berdasarkan id.
- Put dengan {id} adalah untuk mengupdate atau mengedit sebuah data atau baris di tabel employee berdasarkan id.
- Delete dengan {id} adalah untuk menghapus sebuah data atau baris di tabel employee berdasarkan id.

* CRUD menggunakan Postman dengan Collection atau Workspace:
- Jalankan postman 
- Klik Collection
- Klik Create new Collection (tanda +)

[Get All Employees]
- Pilih Get
- Masukkan link berikut di kotak request URL = https://localhost:5001/api/employee
- Klik Send

[Get Employee]
- Pilih Get
- Masukkan link berikut di kotak request URL = https://localhost:5001/api/employee/[id_yang_diinginkan] (contoh /api/employee/1)
- Klik Send

[Create Employee]
- Pilih Get
- Masukkan link berikut di kotak request URL = https://localhost:5001/api/employee/
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

[Update Employee]
- Pilih Get
- Masukkan link berikut di kotak request URL = https://localhost:5001/api/employee/[id_yang_diinginkan]
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

[Delete Employee]
- Pilih Get
- Masukkan link berikut di kotak request URL = https://localhost:5001/api/employee/
- Pilih Delete
- Masukkan link berikut di kotak request URL = https://localhost:5001/api/employee/[id_yang_diinginkan]
- Klik Send