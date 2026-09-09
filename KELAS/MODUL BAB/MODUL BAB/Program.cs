using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        bool jalan = true;

        while (jalan)
        {
            Console.Clear();
            Console.WriteLine("PROGRAM PEMBELAJARAN C#");
            Console.WriteLine();
            Console.WriteLine("Nama    : MUHAMMAD ALFIAN AKBAR");
            Console.WriteLine("Kelas   : XI RPL");
            Console.WriteLine("Umur    : 17");
            Console.WriteLine("Sekolah : SMKN 2 BUDURAN");
            Console.WriteLine("Alamat  : SIDOARJO");
            Console.WriteLine();
            Console.WriteLine("1. BAB 1  - Pengenalan Pemrograman");
            Console.WriteLine("2. BAB 2  - Algoritma");
            Console.WriteLine("3. BAB 5  - Variabel dan Teks");
            Console.WriteLine("4. BAB 6  - Struktur Program C#");
            Console.WriteLine("5. BAB 8  - Operator");
            Console.WriteLine("6. BAB 9  - Input");
            Console.WriteLine("7. BAB 10 - Percabangan");
            Console.WriteLine("8. BAB 11 - Perulangan");
            Console.WriteLine("9. BAB 12 - Array dan List");
            Console.WriteLine("10. BAB 13 - Method");
            Console.WriteLine("11. BAB 14 - Class dan Object");
            Console.WriteLine("0. Keluar");
            Console.WriteLine();

            Console.Write("Pilih Bab: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Bab1();
                    break;
                case "2":
                    Bab2();
                    break;
                case "3":
                    Bab5();
                    break;
                case "4":
                    Bab6();
                    break;
                case "5":
                    Bab8();
                    break;
                case "6":
                    Bab9();
                    break;
                case "7":
                    Bab10();
                    break;
                case "8":
                    Bab11();
                    break;
                case "9":
                    Bab12();
                    break;
                case "10":
                    Bab13();
                    break;
                case "11":
                    Bab14();
                    break;
                case "0":
                    jalan = false;
                    break;
                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    Pause();
                    break;
            }
        }
    }

    // ============================================================
    // BAB 1
    // ============================================================

    static void Bab1()
    {
        bool kembali = false;

        while (!kembali)
        {
            Console.Clear();
            Console.WriteLine("BAB 1 - PENGENALAN PEMROGRAMAN");
            Console.WriteLine();
            Console.WriteLine("1. Jelaskan Hardware dan Software");
            Console.WriteLine("2. Lima Bahasa Pemrograman");
            Console.WriteLine("3. Hello World");
            Console.WriteLine("0. Kembali");
            Console.WriteLine();

            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Console.Clear();

                    Console.WriteLine("PERBEDAAN HARDWARE DAN SOFTWARE");
                    Console.WriteLine();

                    Console.WriteLine("Hardware adalah perangkat keras komputer");
                    Console.WriteLine("yang dapat dilihat dan disentuh.");

                    Console.WriteLine();
                    Console.WriteLine("Contoh Hardware:");
                    Console.WriteLine("- Keyboard");
                    Console.WriteLine("- Mouse");
                    Console.WriteLine("- Monitor");
                    Console.WriteLine("- CPU");

                    Console.WriteLine();

                    Console.WriteLine("Software adalah perangkat lunak berupa");
                    Console.WriteLine("program yang digunakan untuk menjalankan");
                    Console.WriteLine("perintah pada komputer.");

                    Console.WriteLine();
                    Console.WriteLine("Contoh Software:");
                    Console.WriteLine("- Windows");
                    Console.WriteLine("- Microsoft Word");
                    Console.WriteLine("- Google Chrome");
                    Console.WriteLine("- Visual Studio");

                    Pause();
                    break;

                case "2":
                    Console.Clear();

                    Console.WriteLine("LIMA BAHASA PEMROGRAMAN");
                    Console.WriteLine();
                    Console.WriteLine("1. C#");
                    Console.WriteLine("2. Java");
                    Console.WriteLine("3. Python");
                    Console.WriteLine("4. C++");
                    Console.WriteLine("5. JavaScript");

                    Pause();
                    break;

                case "3":
                    Console.Clear();

                    Console.WriteLine("HELLO WORLD!");

                    Pause();
                    break;

                case "0":
                    kembali = true;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    Pause();
                    break;
            }
        }
    }

    // ============================================================
    // BAB 2
    // ============================================================

    static void Bab2()
    {
        bool kembali = false;

        while (!kembali)
        {
            Console.Clear();
            Console.WriteLine("BAB 2 - ALGORITMA");
            Console.WriteLine();
            Console.WriteLine("1. Studi Kasus");
            Console.WriteLine("2. Latihan");
            Console.WriteLine("0. Kembali");
            Console.WriteLine();

            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Bab2StudiKasus();
                    break;

                case "2":
                    Bab2Latihan();
                    break;

                case "0":
                    kembali = true;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    Pause();
                    break;
            }
        }
    }

    static void Bab2StudiKasus()
    {
        bool kembali = false;

        while (!kembali)
        {
            Console.Clear();
            Console.WriteLine("BAB 2 - STUDI KASUS");
            Console.WriteLine();
            Console.WriteLine("1. Algoritma Login Sederhana");
            Console.WriteLine("2. Algoritma Rata-rata Tiga Nilai");
            Console.WriteLine("3. Algoritma Ganjil atau Genap");
            Console.WriteLine("0. Kembali");
            Console.WriteLine();

            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Console.Clear();

                    Console.WriteLine("ALGORITMA LOGIN SEDERHANA");
                    Console.WriteLine();
                    Console.WriteLine("1. Mulai");
                    Console.WriteLine("2. Masukkan username");
                    Console.WriteLine("3. Masukkan password");
                    Console.WriteLine("4. Periksa username dan password");
                    Console.WriteLine("5. Jika benar, Login berhasil");
                    Console.WriteLine("6. Jika salah, Login gagal");
                    Console.WriteLine("7. Selesai");

                    Pause();
                    break;

                case "2":
                    Console.Clear();

                    Console.WriteLine("ALGORITMA RATA-RATA TIGA NILAI");
                    Console.WriteLine();
                    Console.WriteLine("1. Mulai");
                    Console.WriteLine("2. Masukkan nilai pertama");
                    Console.WriteLine("3. Masukkan nilai kedua");
                    Console.WriteLine("4. Masukkan nilai ketiga");
                    Console.WriteLine("5. Jumlahkan ketiga nilai");
                    Console.WriteLine("6. Bagi jumlah dengan 3");
                    Console.WriteLine("7. Tampilkan rata-rata");
                    Console.WriteLine("8. Selesai");

                    Pause();
                    break;

                case "3":
                    Console.Clear();

                    Console.WriteLine("ALGORITMA GANJIL ATAU GENAP");
                    Console.WriteLine();
                    Console.WriteLine("1. Mulai");
                    Console.WriteLine("2. Masukkan bilangan");
                    Console.WriteLine("3. Hitung bilangan % 2");
                    Console.WriteLine("4. Jika hasil 0 = Genap");
                    Console.WriteLine("5. Jika bukan 0 = Ganjil");
                    Console.WriteLine("6. Selesai");

                    Pause();
                    break;

                case "0":
                    kembali = true;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    Pause();
                    break;
            }
        }
    }

    static void Bab2Latihan()
    {
        bool kembali = false;

        while (!kembali)
        {
            Console.Clear();
            Console.WriteLine("BAB 2 - LATIHAN");
            Console.WriteLine();
            Console.WriteLine("1. Algoritma Membuat Teh");
            Console.WriteLine("2. Algoritma Menarik Uang di ATM");
            Console.WriteLine("3. Algoritma Luas Segitiga");
            Console.WriteLine("0. Kembali");
            Console.WriteLine();

            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Console.Clear();

                    Console.WriteLine("ALGORITMA MEMBUAT TEH");
                    Console.WriteLine();
                    Console.WriteLine("1. Siapkan gelas");
                    Console.WriteLine("2. Masukkan teh");
                    Console.WriteLine("3. Panaskan air");
                    Console.WriteLine("4. Tuangkan air panas");
                    Console.WriteLine("5. Tambahkan gula");
                    Console.WriteLine("6. Aduk hingga rata");
                    Console.WriteLine("7. Teh siap diminum");

                    Pause();
                    break;

                case "2":
                    Console.Clear();

                    Console.WriteLine("ALGORITMA MENARIK UANG DI ATM");
                    Console.WriteLine();
                    Console.WriteLine("1. Masukkan kartu ATM");
                    Console.WriteLine("2. Masukkan PIN");
                    Console.WriteLine("3. Pilih Tarik Tunai");
                    Console.WriteLine("4. Masukkan jumlah uang");
                    Console.WriteLine("5. Konfirmasi transaksi");
                    Console.WriteLine("6. Ambil uang");
                    Console.WriteLine("7. Ambil kartu ATM");

                    Pause();
                    break;

                case "3":
                    Console.Clear();

                    Console.WriteLine("ALGORITMA LUAS SEGITIGA");
                    Console.WriteLine();
                    Console.WriteLine("1. Masukkan alas");
                    Console.WriteLine("2. Masukkan tinggi");
                    Console.WriteLine("3. Hitung luas");
                    Console.WriteLine("4. Tampilkan luas");
                    Console.WriteLine("5. Selesai");

                    Pause();
                    break;

                case "0":
                    kembali = true;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    Pause();
                    break;
            }
        }
    }

    // ============================================================
    // BAB 5
    // ============================================================

    static void Bab5()
    {
        Console.Clear();

        Console.WriteLine("BAB 5 - VARIABEL DAN TEKS");
        Console.WriteLine();

        string nama = "MUHAMMAD ALFIAN AKBAR";

        Console.WriteLine(nama);

        Pause();
    }

    // ============================================================
    // BAB 6
    // ============================================================

    static void Bab6()
    {
        bool kembali = false;

        while (!kembali)
        {
            Console.Clear();
            Console.WriteLine("BAB 6 - STRUKTUR PROGRAM C#");
            Console.WriteLine();
            Console.WriteLine("1. Studi Kasus");
            Console.WriteLine("2. Latihan");
            Console.WriteLine("0. Kembali");
            Console.WriteLine();

            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Bab6StudiKasus();
                    break;

                case "2":
                    Bab6Latihan();
                    break;

                case "0":
                    kembali = true;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    Pause();
                    break;
            }
        }
    }

    static void Bab6StudiKasus()
    {
        bool kembali = false;

        while (!kembali)
        {
            Console.Clear();
            Console.WriteLine("BAB 6 - STUDI KASUS");
            Console.WriteLine();
            Console.WriteLine("1. Menampilkan Nama Sekolah");
            Console.WriteLine("2. Input Nama dan Sapaan");
            Console.WriteLine("3. Menampilkan Tiga Baris Informasi");
            Console.WriteLine("0. Kembali");
            Console.WriteLine();

            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Console.Clear();

                    Console.WriteLine("Nama Sekolah: SMKN 2 BUDURAN");

                    Pause();
                    break;

                case "2":
                    Console.Clear();

                    Console.Write("Masukkan nama: ");
                    string nama = Console.ReadLine();

                    Console.WriteLine("Halo, " + nama + "!");
                    Console.WriteLine("Selamat belajar C#.");

                    Pause();
                    break;

                case "3":
                    Console.Clear();

                    Console.WriteLine("Nama    : MUHAMMAD ALFIAN AKBAR");
                    Console.WriteLine("Kelas   : XI RPL");
                    Console.WriteLine("Sekolah : SMKN 2 BUDURAN");
                    Console.WriteLine("Alamat  : SIDOARJO");
                    Console.WriteLine("Umur    : 17");

                    Pause();
                    break;

                case "0":
                    kembali = true;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    Pause();
                    break;
            }
        }
    }

    static void Bab6Latihan()
    {
        bool kembali = false;

        while (!kembali)
        {
            Console.Clear();
            Console.WriteLine("BAB 6 - LATIHAN");
            Console.WriteLine();
            Console.WriteLine("1. Fungsi using System");
            Console.WriteLine("2. Fungsi Main()");
            Console.WriteLine("3. Perbedaan Write() dan WriteLine()");
            Console.WriteLine("0. Kembali");
            Console.WriteLine();

            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Console.Clear();

                    Console.WriteLine("FUNGSI using System");
                    Console.WriteLine();
                    Console.WriteLine("using System digunakan untuk mengakses");
                    Console.WriteLine("namespace System pada C#.");

                    Pause();
                    break;

                case "2":
                    Console.Clear();

                    Console.WriteLine("FUNGSI Main()");
                    Console.WriteLine();
                    Console.WriteLine("Main() adalah method utama yang menjadi");
                    Console.WriteLine("titik awal eksekusi program C#.");

                    Pause();
                    break;

                case "3":
                    Console.Clear();

                    Console.WriteLine("PERBEDAAN Write() DAN WriteLine()");
                    Console.WriteLine();
                    Console.WriteLine("Write() tidak pindah baris.");
                    Console.WriteLine("WriteLine() pindah ke baris berikutnya.");

                    Pause();
                    break;

                case "0":
                    kembali = true;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    Pause();
                    break;
            }
        }
    }

    // ============================================================
    // BAB 8
    // ============================================================

    static void Bab8()
    {
        bool kembali = false;

        while (!kembali)
        {
            Console.Clear();
            Console.WriteLine("BAB 8 - OPERATOR");
            Console.WriteLine();
            Console.WriteLine("1. Studi Kasus");
            Console.WriteLine("2. Latihan");
            Console.WriteLine("3. Mini Project");
            Console.WriteLine("0. Kembali");
            Console.WriteLine();

            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Bab8StudiKasus();
                    break;

                case "2":
                    Bab8Latihan();
                    break;

                case "3":
                    Bab8MiniProject();
                    break;

                case "0":
                    kembali = true;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    Pause();
                    break;
            }
        }
    }

    static void Bab8StudiKasus()
    {
        bool kembali = false;

        while (!kembali)
        {
            Console.Clear();
            Console.WriteLine("BAB 8 - STUDI KASUS");
            Console.WriteLine();
            Console.WriteLine("1. Total Belanja Tiga Barang");
            Console.WriteLine("2. Menentukan Siswa Lulus");
            Console.WriteLine("3. Sisa Pembagian");
            Console.WriteLine("0. Kembali");
            Console.WriteLine();

            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Console.Clear();

                    Console.Write("Harga barang 1: ");
                    double h1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Harga barang 2: ");
                    double h2 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Harga barang 3: ");
                    double h3 = Convert.ToDouble(Console.ReadLine());

                    double total = h1 + h2 + h3;

                    Console.WriteLine();
                    Console.WriteLine("Total belanja = " + total);

                    Pause();
                    break;

                case "2":
                    Console.Clear();

                    Console.Write("Masukkan nilai: ");
                    int nilai = Convert.ToInt32(Console.ReadLine());

                    if (nilai >= 75)
                        Console.WriteLine("Siswa LULUS.");
                    else
                        Console.WriteLine("Siswa TIDAK LULUS.");

                    Pause();
                    break;

                case "3":
                    Console.Clear();

                    Console.Write("Bilangan pertama: ");
                    int a = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Bilangan kedua: ");
                    int b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Sisa pembagian = " + (a % b));

                    Pause();
                    break;

                case "0":
                    kembali = true;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    Pause();
                    break;
            }
        }
    }

    static void Bab8Latihan()
    {
        bool kembali = false;

        while (!kembali)
        {
            Console.Clear();
            Console.WriteLine("BAB 8 - LATIHAN");
            Console.WriteLine();
            Console.WriteLine("1. Luas Persegi Panjang");
            Console.WriteLine("2. Rata-rata Tiga Nilai");
            Console.WriteLine("3. Bilangan Genap atau Ganjil");
            Console.WriteLine("0. Kembali");
            Console.WriteLine();

            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Console.Clear();

                    Console.Write("Panjang: ");
                    double panjang = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Lebar: ");
                    double lebar = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Luas = " + (panjang * lebar));

                    Pause();
                    break;

                case "2":
                    Console.Clear();

                    Console.Write("Nilai 1: ");
                    double n1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Nilai 2: ");
                    double n2 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Nilai 3: ");
                    double n3 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(
                        "Rata-rata = " + ((n1 + n2 + n3) / 3)
                    );

                    Pause();
                    break;

                case "3":
                    Console.Clear();

                    Console.Write("Bilangan: ");
                    int bilangan = Convert.ToInt32(Console.ReadLine());

                    if (bilangan % 2 == 0)
                        Console.WriteLine("Bilangan GENAP.");
                    else
                        Console.WriteLine("Bilangan GANJIL.");

                    Pause();
                    break;

                case "0":
                    kembali = true;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    Pause();
                    break;
            }
        }
    }

    static void Bab8MiniProject()
    {
        Console.Clear();

        Console.WriteLine("BAB 8 - MINI PROJECT");
        Console.WriteLine();

        Console.Write("Harga Barang : ");
        double harga = Convert.ToDouble(Console.ReadLine());

        Console.Write("Jumlah : ");
        int jumlah = Convert.ToInt32(Console.ReadLine());

        double total = harga * jumlah;

        Console.WriteLine("Total = " + total);

        Pause();
    }

    // ============================================================
    // BAB 9
    // ============================================================

    static void Bab9()
    {
        bool kembali = false;

        while (!kembali)
        {
            Console.Clear();
            Console.WriteLine("BAB 9 - INPUT");
            Console.WriteLine();
            Console.WriteLine("1. Studi Kasus");
            Console.WriteLine("2. Latihan");
            Console.WriteLine("0. Kembali");
            Console.WriteLine();

            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Bab9StudiKasus();
                    break;

                case "2":
                    Bab9Latihan();
                    break;

                case "0":
                    kembali = true;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    Pause();
                    break;
            }
        }
    }

    static void Bab9StudiKasus()
    {
        bool kembali = false;

        while (!kembali)
        {
            Console.Clear();
            Console.WriteLine("BAB 9 - STUDI KASUS");
            Console.WriteLine();
            Console.WriteLine("1. Input Biodata Siswa");
            Console.WriteLine("2. Luas Persegi Panjang");
            Console.WriteLine("3. Rata-rata Tiga Nilai");
            Console.WriteLine("0. Kembali");
            Console.WriteLine();

            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Console.Clear();

                    Console.WriteLine("BIODATA SISWA");
                    Console.WriteLine();

                    Console.WriteLine("Nama    : MUHAMMAD ALFIAN AKBAR");
                    Console.WriteLine("Kelas   : XI RPL");
                    Console.WriteLine("Umur    : 17");
                    Console.WriteLine("Sekolah : SMKN 2 BUDURAN");
                    Console.WriteLine("Alamat  : SIDOARJO");

                    Pause();
                    break;

                case "2":
                    Console.Clear();

                    Console.Write("Panjang: ");
                    double p = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Lebar: ");
                    double l = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Luas = " + (p * l));

                    Pause();
                    break;

                case "3":
                    Console.Clear();

                    Console.Write("Nilai 1: ");
                    double nilai1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Nilai 2: ");
                    double nilai2 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Nilai 3: ");
                    double nilai3 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(
                        "Rata-rata = " +
                        ((nilai1 + nilai2 + nilai3) / 3)
                    );

                    Pause();
                    break;

                case "0":
                    kembali = true;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    Pause();
                    break;
            }
        }
    }

    static void Bab9Latihan()
    {
        bool kembali = false;

        while (!kembali)
        {
            Console.Clear();
            Console.WriteLine("BAB 9 - LATIHAN");
            Console.WriteLine();
            Console.WriteLine("1. Perbedaan Write() dan WriteLine()");
            Console.WriteLine("2. Input Nama dan Sapaan");
            Console.WriteLine("3. Menghitung Umur dari Tahun Lahir");
            Console.WriteLine("0. Kembali");
            Console.WriteLine();

            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Console.Clear();

                    Console.WriteLine("Write() menampilkan teks tanpa");
                    Console.WriteLine("pindah baris.");
                    Console.WriteLine();
                    Console.WriteLine("WriteLine() menampilkan teks kemudian");
                    Console.WriteLine("pindah ke baris berikutnya.");

                    Pause();
                    break;

                case "2":
                    Console.Clear();

                    Console.Write("Masukkan nama: ");
                    string nama = Console.ReadLine();

                    Console.WriteLine("Halo, " + nama + "!");
                    Console.WriteLine("Selamat datang di program C#.");

                    Pause();
                    break;

                case "3":
                    Console.Clear();

                    Console.Write("Masukkan tahun lahir: ");
                    int tahunLahir =
                        Convert.ToInt32(Console.ReadLine());

                    int umur = DateTime.Now.Year - tahunLahir;

                    Console.WriteLine(
                        "Umur sekitar " + umur + " tahun."
                    );

                    Pause();
                    break;

                case "0":
                    kembali = true;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    Pause();
                    break;
            }
        }
    }

    // ============================================================
    // BAB 10
    // ============================================================

    static void Bab10()
    {
        bool kembali = false;

        while (!kembali)
        {
            Console.Clear();
            Console.WriteLine("BAB 10 - PERCABANGAN");
            Console.WriteLine();
            Console.WriteLine("1. Studi Kasus");
            Console.WriteLine("2. Mini Project");
            Console.WriteLine("3. Latihan");
            Console.WriteLine("0. Kembali");
            Console.WriteLine();

            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Bab10StudiKasus();
                    break;

                case "2":
                    Bab10MiniProject();
                    break;

                case "3":
                    Bab10Latihan();
                    break;

                case "0":
                    kembali = true;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    Pause();
                    break;
            }
        }
    }

    static void Bab10StudiKasus()
    {
        bool kembali = false;

        while (!kembali)
        {
            Console.Clear();
            Console.WriteLine("BAB 10 - STUDI KASUS");
            Console.WriteLine();
            Console.WriteLine("1. Bilangan Ganjil atau Genap");
            Console.WriteLine("2. Diskon Berdasarkan Total Belanja");
            Console.WriteLine("3. Kategori Nilai Siswa");
            Console.WriteLine("0. Kembali");
            Console.WriteLine();

            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Console.Clear();

                    Console.Write("Masukkan bilangan: ");
                    int angka =
                        Convert.ToInt32(Console.ReadLine());

                    if (angka % 2 == 0)
                        Console.WriteLine("Bilangan GENAP.");
                    else
                        Console.WriteLine("Bilangan GANJIL.");

                    Pause();
                    break;

                case "2":
                    Console.Clear();

                    Console.Write("Total belanja: ");
                    double belanja =
                        Convert.ToDouble(Console.ReadLine());

                    double diskon = 0;

                    if (belanja >= 1000000)
                        diskon = 20;
                    else if (belanja >= 500000)
                        diskon = 10;
                    else if (belanja >= 250000)
                        diskon = 5;
                    else
                        diskon = 0;

                    double potongan = belanja * diskon / 100;
                    double totalBayar = belanja - potongan;

                    Console.WriteLine();
                    Console.WriteLine("HASIL PERHITUNGAN DISKON");
                    Console.WriteLine();
                    Console.WriteLine("Total Belanja : Rp " + belanja.ToString("N0"));
                    Console.WriteLine("Diskon        : " + diskon.ToString("0") + "%");
                    Console.WriteLine("Potongan      : Rp " + potongan.ToString("N0"));
                    Console.WriteLine("Total Bayar   : Rp " + totalBayar.ToString("N0"));

                    Pause();
                    break;

                case "3":
                    Console.Clear();

                    Console.Write("Masukkan nilai: ");
                    int nilai =
                        Convert.ToInt32(Console.ReadLine());

                    if (nilai >= 90)
                        Console.WriteLine("Kategori A");
                    else if (nilai >= 80)
                        Console.WriteLine("Kategori B");
                    else if (nilai >= 70)
                        Console.WriteLine("Kategori C");
                    else if (nilai >= 60)
                        Console.WriteLine("Kategori D");
                    else
                        Console.WriteLine("Kategori E");

                    Pause();
                    break;

                case "0":
                    kembali = true;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    Pause();
                    break;
            }
        }
    }

    static void Bab10MiniProject()
    {
        Console.Clear();

        Console.WriteLine("BAB 10 - MINI PROJECT");
        Console.WriteLine();

        Console.Write("Masukkan Umur: ");
        int umur =
            Convert.ToInt32(Console.ReadLine());

        if (umur >= 17)
            Console.WriteLine("Boleh membuat KTP");
        else
            Console.WriteLine("Belum memenuhi syarat");

        Pause();
    }

    static void Bab10Latihan()
    {
        bool kembali = false;

        while (!kembali)
        {
            Console.Clear();
            Console.WriteLine("BAB 10 - LATIHAN");
            Console.WriteLine();
            Console.WriteLine("1. Login Sederhana");
            Console.WriteLine("2. Menentukan Hari dengan Switch");
            Console.WriteLine("3. Menentukan Nilai A, B, C, D");
            Console.WriteLine("0. Kembali");
            Console.WriteLine();

            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    LoginSederhana();
                    break;

                case "2":
                    Console.Clear();

                    Console.Write("Nomor hari (1-7): ");
                    int hari =
                        Convert.ToInt32(Console.ReadLine());

                    switch (hari)
                    {
                        case 1:
                            Console.WriteLine("Senin");
                            break;
                        case 2:
                            Console.WriteLine("Selasa");
                            break;
                        case 3:
                            Console.WriteLine("Rabu");
                            break;
                        case 4:
                            Console.WriteLine("Kamis");
                            break;
                        case 5:
                            Console.WriteLine("Jumat");
                            break;
                        case 6:
                            Console.WriteLine("Sabtu");
                            break;
                        case 7:
                            Console.WriteLine("Minggu");
                            break;
                        default:
                            Console.WriteLine("Nomor tidak valid.");
                            break;
                    }

                    Pause();
                    break;

                case "3":
                    Console.Clear();

                    Console.Write("Masukkan nilai: ");
                    int nilai =
                        Convert.ToInt32(Console.ReadLine());

                    if (nilai >= 90)
                        Console.WriteLine("Nilai A");
                    else if (nilai >= 80)
                        Console.WriteLine("Nilai B");
                    else if (nilai >= 70)
                        Console.WriteLine("Nilai C");
                    else if (nilai >= 60)
                        Console.WriteLine("Nilai D");
                    else
                        Console.WriteLine("Di bawah D");

                    Pause();
                    break;

                case "0":
                    kembali = true;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    Pause();
                    break;
            }
        }
    }

    static void LoginSederhana()
    {
        Console.Clear();

        Console.WriteLine("LOGIN SEDERHANA");
        Console.WriteLine();

        string usernameBenar = "admin";
        string passwordBenar = "12345";

        Console.Write("Username: ");
        string username = Console.ReadLine();

        Console.Write("Password: ");
        string password = Console.ReadLine();

        Console.WriteLine();

        if (username == usernameBenar &&
            password == passwordBenar)
        {
            Console.WriteLine("Login berhasil!");
        }
        else
        {
            Console.WriteLine("Username atau password salah.");
        }

        Pause();
    }

    // ============================================================
    // BAB 11 - PERULANGAN
    // ============================================================

    static void Bab11()
    {
        bool kembali = false;

        while (!kembali)
        {
            Console.Clear();
            Console.WriteLine("BAB 11 - PERULANGAN");
            Console.WriteLine();
            Console.WriteLine("1. Studi Kasus");
            Console.WriteLine("2. Mini Project");
            Console.WriteLine("3. Latihan");
            Console.WriteLine("0. Kembali");
            Console.WriteLine();

            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Bab11StudiKasus();
                    break;

                case "2":
                    Bab11MiniProject();
                    break;

                case "3":
                    Bab11Latihan();
                    break;

                case "0":
                    kembali = true;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    Pause();
                    break;
            }
        }
    }

    static void Bab11StudiKasus()
    {
        bool kembali = false;

        while (!kembali)
        {
            Console.Clear();
            Console.WriteLine("BAB 11 - STUDI KASUS");
            Console.WriteLine();
            Console.WriteLine("1. Menampilkan Angka 1-100");
            Console.WriteLine("2. Menjumlahkan Bilangan 1-50");
            Console.WriteLine("3. Pola Segitiga Bintang");
            Console.WriteLine("4. Tabel Perkalian");
            Console.WriteLine("0. Kembali");
            Console.WriteLine();

            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Console.Clear();

                    for (int i = 1; i <= 100; i++)
                    {
                        Console.Write(i + " ");
                    }

                    Console.WriteLine();

                    Pause();
                    break;

                case "2":
                    Console.Clear();

                    int total = 0;

                    for (int i = 1; i <= 50; i++)
                    {
                        total += i;
                    }

                    Console.WriteLine(
                        "Jumlah 1-50 = " + total
                    );

                    Pause();
                    break;

                case "3":
                    Console.Clear();

                    Console.Write("Jumlah baris: ");
                    int baris =
                        Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <= baris; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }

                    Pause();
                    break;

                case "4":
                    Console.Clear();

                    Console.Write("Masukkan angka: ");
                    int angka =
                        Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine(
                            angka + " x " + i +
                            " = " + (angka * i)
                        );
                    }

                    Pause();
                    break;

                case "0":
                    kembali = true;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    Pause();
                    break;
            }
        }
    }

    static void Bab11MiniProject()
    {
        Console.Clear();

        Console.WriteLine("BAB 11 - MINI PROJECT");
        Console.WriteLine();

        Console.Write("Masukkan jumlah siswa: ");
        int n =
            Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write(
                $"Nama siswa ke-{i}: "
            );

            string nama = Console.ReadLine();

            Console.WriteLine(
                "Siswa: " + nama
            );
        }

        Pause();
    }

    static void Bab11Latihan()
    {
        bool kembali = false;

        while (!kembali)
        {
            Console.Clear();
            Console.WriteLine("BAB 11 - LATIHAN");
            Console.WriteLine();
            Console.WriteLine("1. Menghitung Faktorial");
            Console.WriteLine("2. Bilangan Genap 1-100");
            Console.WriteLine("3. Pola Persegi Nested Loop");
            Console.WriteLine("0. Kembali");
            Console.WriteLine();

            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Console.Clear();

                    Console.Write("Masukkan angka: ");
                    int angka =
                        Convert.ToInt32(Console.ReadLine());

                    long faktorial = 1;

                    for (int i = 1; i <= angka; i++)
                    {
                        faktorial *= i;
                    }

                    Console.WriteLine(
                        angka + "! = " + faktorial
                    );

                    Pause();
                    break;

                case "2":
                    Console.Clear();

                    Console.WriteLine(
                        "Bilangan genap 1-100:"
                    );

                    for (int i = 1; i <= 100; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write(i + " ");
                        }
                    }

                    Console.WriteLine();

                    Pause();
                    break;

                case "3":
                    Console.Clear();

                    Console.Write("Ukuran persegi: ");
                    int ukuran =
                        Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <= ukuran; i++)
                    {
                        for (int j = 1; j <= ukuran; j++)
                        {
                            Console.Write("* ");
                        }

                        Console.WriteLine();
                    }

                    Pause();
                    break;

                case "0":
                    kembali = true;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    Pause();
                    break;
            }
        }
    }

    // ============================================================
    // BAB 12 - ARRAY DAN LIST
    // ============================================================

    static void Bab12()
    {
        bool kembali = false;

        while (!kembali)
        {
            Console.Clear();
            Console.WriteLine("BAB 12 - ARRAY DAN LIST");
            Console.WriteLine();
            Console.WriteLine("1. Studi Kasus");
            Console.WriteLine("2. Mini Project");
            Console.WriteLine("3. Latihan");
            Console.WriteLine("0. Kembali");
            Console.WriteLine();

            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Bab12StudiKasus();
                    break;

                case "2":
                    Bab12MiniProject();
                    break;

                case "3":
                    Bab12Latihan();
                    break;

                case "0":
                    kembali = true;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    Pause();
                    break;
            }
        }
    }

    static void Bab12StudiKasus()
    {
        bool kembali = false;

        while (!kembali)
        {
            Console.Clear();
            Console.WriteLine("BAB 12 - STUDI KASUS");
            Console.WriteLine();
            Console.WriteLine("1. Array 10 Nilai Siswa");
            Console.WriteLine("2. Daftar Nama menggunakan List<T>");
            Console.WriteLine("0. Kembali");
            Console.WriteLine();

            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Console.Clear();

                    int[] nilai = new int[10];
                    int total = 0;
                    int tertinggi = 0;

                    for (int i = 0;
                         i < nilai.Length;
                         i++)
                    {
                        Console.Write(
                            "Nilai siswa ke-" +
                            (i + 1) + ": "
                        );

                        nilai[i] =
                            Convert.ToInt32(
                                Console.ReadLine()
                            );

                        total += nilai[i];

                        if (i == 0 ||
                            nilai[i] > tertinggi)
                        {
                            tertinggi = nilai[i];
                        }
                    }

                    double rata =
                        (double)total /
                        nilai.Length;

                    Console.WriteLine();
                    Console.WriteLine(
                        "Nilai tertinggi = " +
                        tertinggi
                    );

                    Console.WriteLine(
                        "Rata-rata = " + rata
                    );

                    Pause();
                    break;

                case "2":
                    Console.Clear();

                    List<string> nama =
                        new List<string>();

                    Console.Write("Jumlah nama: ");
                    int jumlah =
                        Convert.ToInt32(
                            Console.ReadLine()
                        );

                    for (int i = 0;
                         i < jumlah;
                         i++)
                    {
                        Console.Write(
                            "Nama ke-" +
                            (i + 1) + ": "
                        );

                        nama.Add(
                            Console.ReadLine()
                        );
                    }

                    Console.WriteLine();
                    Console.WriteLine(
                        "DAFTAR NAMA"
                    );

                    foreach (string item in nama)
                    {
                        Console.WriteLine(item);
                    }

                    Pause();
                    break;

                case "0":
                    kembali = true;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    Pause();
                    break;
            }
        }
    }

    static void Bab12MiniProject()
    {
        Console.Clear();

        Console.WriteLine("BAB 12 - MINI PROJECT");
        Console.WriteLine();

        int[] nilai =
        {
            75, 80, 90, 85, 70
        };

        int total = 0;

        foreach (int n in nilai)
        {
            total += n;
        }

        Console.WriteLine(
            $"Rata-rata = {(double)total / nilai.Length}"
        );

        Pause();
    }

    static void Bab12Latihan()
    {
        bool kembali = false;

        while (!kembali)
        {
            Console.Clear();
            Console.WriteLine("BAB 12 - LATIHAN");
            Console.WriteLine();
            Console.WriteLine("1. Nilai Terbesar dalam Array");
            Console.WriteLine("2. Jumlah Bilangan Genap dalam Array");
            Console.WriteLine("3. Aplikasi Daftar Nama");
            Console.WriteLine("0. Kembali");
            Console.WriteLine();

            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Console.Clear();

                    int[] angka =
                    {
                        10, 25, 7, 40, 15
                    };

                    int terbesar = angka[0];

                    foreach (int nilai in angka)
                    {
                        if (nilai > terbesar)
                        {
                            terbesar = nilai;
                        }
                    }

                    Console.WriteLine(
                        "Nilai terbesar = " +
                        terbesar
                    );

                    Pause();
                    break;

                case "2":
                    Console.Clear();

                    int[] data =
                    {
                        2, 5, 8, 11, 14, 20
                    };

                    int jumlahGenap = 0;

                    foreach (int nilai in data)
                    {
                        if (nilai % 2 == 0)
                        {
                            jumlahGenap++;
                        }
                    }

                    Console.WriteLine(
                        "Jumlah bilangan genap = " +
                        jumlahGenap
                    );

                    Pause();
                    break;

                case "3":
                    Console.Clear();

                    List<string> daftarNama =
                        new List<string>();

                    bool tambah = true;

                    while (tambah)
                    {
                        Console.Write(
                            "Masukkan nama: "
                        );

                        daftarNama.Add(
                            Console.ReadLine()
                        );

                        Console.Write(
                            "Tambah nama lagi? (y/n): "
                        );

                        string jawaban =
                            Console.ReadLine();

                        if (jawaban.ToLower() != "y")
                        {
                            tambah = false;
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine(
                        "DAFTAR NAMA:"
                    );

                    for (int i = 0;
                         i < daftarNama.Count;
                         i++)
                    {
                        Console.WriteLine(
                            (i + 1) +
                            ". " +
                            daftarNama[i]
                        );
                    }

                    Pause();
                    break;

                case "0":
                    kembali = true;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    Pause();
                    break;
            }
        }
    }

    // ============================================================
    // BAB 13 - METHOD
    // ============================================================

    static void Bab13()
    {
        bool kembali = false;

        while (!kembali)
        {
            Console.Clear();
            Console.WriteLine("BAB 13 - METHOD");
            Console.WriteLine();
            Console.WriteLine("1. Studi Kasus");
            Console.WriteLine("2. Mini Project");
            Console.WriteLine("3. Latihan");
            Console.WriteLine("0. Kembali");
            Console.WriteLine();

            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Bab13StudiKasus();
                    break;

                case "2":
                    Bab13MiniProject();
                    break;

                case "3":
                    Bab13Latihan();
                    break;

                case "0":
                    kembali = true;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    Pause();
                    break;
            }
        }
    }

    static void Bab13StudiKasus()
    {
        bool kembali = false;

        while (!kembali)
        {
            Console.Clear();
            Console.WriteLine("BAB 13 - STUDI KASUS");
            Console.WriteLine();
            Console.WriteLine("1. Method Luas Persegi Panjang");
            Console.WriteLine("2. Method Luas Lingkaran");
            Console.WriteLine("3. Method Genap atau Ganjil");
            Console.WriteLine("0. Kembali");
            Console.WriteLine();

            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Console.Clear();

                    Console.Write("Panjang: ");
                    double panjang =
                        Convert.ToDouble(
                            Console.ReadLine()
                        );

                    Console.Write("Lebar: ");
                    double lebar =
                        Convert.ToDouble(
                            Console.ReadLine()
                        );

                    Console.WriteLine(
                        "Luas = " +
                        HitungLuasPersegiPanjang(
                            panjang,
                            lebar
                        )
                    );

                    Pause();
                    break;

                case "2":
                    Console.Clear();

                    Console.Write("Jari-jari: ");
                    double r =
                        Convert.ToDouble(
                            Console.ReadLine()
                        );

                    Console.WriteLine(
                        "Luas lingkaran = " +
                        HitungLuasLingkaran(r)
                    );

                    Pause();
                    break;

                case "3":
                    Console.Clear();

                    Console.Write("Bilangan: ");
                    int angka =
                        Convert.ToInt32(
                            Console.ReadLine()
                        );

                    Console.WriteLine(
                        TentukanGanjilGenap(angka)
                    );

                    Pause();
                    break;

                case "0":
                    kembali = true;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    Pause();
                    break;
            }
        }
    }

    static double HitungLuasPersegiPanjang(
        double panjang,
        double lebar)
    {
        return panjang * lebar;
    }

    static double HitungLuasLingkaran(
        double jariJari)
    {
        return Math.PI *
               jariJari *
               jariJari;
    }

    static string TentukanGanjilGenap(
        int angka)
    {
        if (angka % 2 == 0)
            return "Bilangan GENAP";
        else
            return "Bilangan GANJIL";
    }

    static void Bab13MiniProject()
    {
        Console.Clear();

        Console.WriteLine("BAB 13 - MINI PROJECT");
        Console.WriteLine();

        Console.WriteLine(
            "Rata-rata = " +
            HitungRata(80, 90, 85)
        );

        Pause();
    }

    static double HitungRata(
        int a,
        int b,
        int c)
    {
        return (a + b + c) / 3.0;
    }

    static void Bab13Latihan()
    {
        bool kembali = false;

        while (!kembali)
        {
            Console.Clear();
            Console.WriteLine("BAB 13 - LATIHAN");
            Console.WriteLine();
            Console.WriteLine("1. Method Keliling Persegi");
            Console.WriteLine("2. Method Faktorial");
            Console.WriteLine("3. Method Pangkat Bilangan");
            Console.WriteLine("0. Kembali");
            Console.WriteLine();

            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Console.Clear();

                    Console.Write("Sisi persegi: ");
                    double sisi =
                        Convert.ToDouble(
                            Console.ReadLine()
                        );

                    Console.WriteLine(
                        "Keliling = " +
                        KelilingPersegi(sisi)
                    );

                    Pause();
                    break;

                case "2":
                    Console.Clear();

                    Console.Write("Angka: ");
                    int angka =
                        Convert.ToInt32(
                            Console.ReadLine()
                        );

                    Console.WriteLine(
                        angka + "! = " +
                        Faktorial(angka)
                    );

                    Pause();
                    break;

                case "3":
                    Console.Clear();

                    Console.Write("Bilangan: ");
                    double bilangan =
                        Convert.ToDouble(
                            Console.ReadLine()
                        );

                    Console.Write("Pangkat: ");
                    int pangkat =
                        Convert.ToInt32(
                            Console.ReadLine()
                        );

                    Console.WriteLine(
                        "Hasil = " +
                        Pangkat(bilangan, pangkat)
                    );

                    Pause();
                    break;

                case "0":
                    kembali = true;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    Pause();
                    break;
            }
        }
    }

    static double KelilingPersegi(
        double sisi)
    {
        return 4 * sisi;
    }

    static long Faktorial(
        int angka)
    {
        long hasil = 1;

        for (int i = 1;
             i <= angka;
             i++)
        {
            hasil *= i;
        }

        return hasil;
    }

    static double Pangkat(
        double bilangan,
        int pangkat)
    {
        return Math.Pow(
            bilangan,
            pangkat
        );
    }

    // ============================================================
    // BAB 14 - CLASS DAN OBJECT
    // ============================================================

    static void Bab14()
    {
        bool kembali = false;

        while (!kembali)
        {
            Console.Clear();
            Console.WriteLine("BAB 14 - CLASS DAN OBJECT");
            Console.WriteLine();
            Console.WriteLine("1. Studi Kasus");
            Console.WriteLine("2. Mini Project");
            Console.WriteLine("3. Latihan");
            Console.WriteLine("0. Kembali");
            Console.WriteLine();

            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Bab14StudiKasus();
                    break;

                case "2":
                    Bab14MiniProject();
                    break;

                case "3":
                    Bab14Latihan();
                    break;

                case "0":
                    kembali = true;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    Pause();
                    break;
            }
        }
    }

    static void Bab14StudiKasus()
    {
        bool kembali = false;

        while (!kembali)
        {
            Console.Clear();
            Console.WriteLine("BAB 14 - STUDI KASUS");
            Console.WriteLine();
            Console.WriteLine("1. Class Siswa");
            Console.WriteLine("2. Class PersegiPanjang");
            Console.WriteLine("3. Class Rekening");
            Console.WriteLine("0. Kembali");
            Console.WriteLine();

            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Console.Clear();

                    Siswa siswa =
                        new Siswa();

                    siswa.Nama =
                        "MUHAMMAD ALFIAN AKBAR";

                    siswa.Nilai = 90;

                    siswa.Tampil();

                    Pause();
                    break;

                case "2":
                    Console.Clear();

                    PersegiPanjang persegi =
                        new PersegiPanjang();

                    Console.Write("Panjang: ");
                    persegi.Panjang =
                        Convert.ToDouble(
                            Console.ReadLine()
                        );

                    Console.Write("Lebar: ");
                    persegi.Lebar =
                        Convert.ToDouble(
                            Console.ReadLine()
                        );

                    Console.WriteLine();

                    Console.WriteLine(
                        "Luas = " +
                        persegi.HitungLuas()
                    );

                    Pause();
                    break;

                case "3":
                    Console.Clear();

                    Rekening rekening =
                        new Rekening();

                    Console.Write("Setor uang: ");
                    double setor =
                        Convert.ToDouble(
                            Console.ReadLine()
                        );

                    rekening.Setor(setor);

                    rekening.LihatSaldo();

                    Pause();
                    break;

                case "0":
                    kembali = true;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    Pause();
                    break;
            }
        }
    }

    static void Bab14MiniProject()
    {
        Console.Clear();

        Console.WriteLine("BAB 14 - MINI PROJECT");
        Console.WriteLine();

        Mobil m =
            new Mobil();

        m.Merk = "Toyota";

        m.Jalan();

        Pause();
    }

    static void Bab14Latihan()
    {
        bool kembali = false;

        while (!kembali)
        {
            Console.Clear();
            Console.WriteLine("BAB 14 - LATIHAN");
            Console.WriteLine();
            Console.WriteLine("1. Class Buku");
            Console.WriteLine("2. Class Mahasiswa");
            Console.WriteLine("3. Constructor Dua Parameter");
            Console.WriteLine("0. Kembali");
            Console.WriteLine();

            Console.Write("Pilih: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Console.Clear();

                    Buku buku =
                        new Buku();

                    Console.Write("Judul: ");
                    buku.Judul =
                        Console.ReadLine();

                    Console.Write("Penulis: ");
                    buku.Penulis =
                        Console.ReadLine();

                    buku.TampilData();

                    Pause();
                    break;

                case "2":
                    Console.Clear();

                    Mahasiswa mahasiswa =
                        new Mahasiswa();

                    Console.Write("Nama: ");
                    mahasiswa.Nama =
                        Console.ReadLine();

                    Console.Write("NIM: ");
                    mahasiswa.NIM =
                        Console.ReadLine();

                    mahasiswa.TampilData();

                    Pause();
                    break;

                case "3":
                    Console.Clear();

                    Console.Write("Nama: ");
                    string nama =
                        Console.ReadLine();

                    Console.Write("Umur: ");
                    int umur =
                        Convert.ToInt32(
                            Console.ReadLine()
                        );

                    Orang orang =
                        new Orang(
                            nama,
                            umur
                        );

                    orang.TampilData();

                    Pause();
                    break;

                case "0":
                    kembali = true;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak tersedia.");
                    Pause();
                    break;
            }
        }
    }

    // ============================================================
    // PAUSE
    // ============================================================

    static void Pause()
    {
        Console.WriteLine();
        Console.WriteLine(
            "Tekan ENTER untuk kembali..."
        );

        Console.ReadLine();
    }
}


// ================================================================
// CLASS BAB 14
// ================================================================

class Siswa
{
    public string Nama { get; set; }
    public int Nilai { get; set; }

    public void Tampil()
    {
        Console.WriteLine(
            "Nama  : " + Nama
        );

        Console.WriteLine(
            "Nilai : " + Nilai
        );
    }
}


class PersegiPanjang
{
    public double Panjang { get; set; }
    public double Lebar { get; set; }

    public double HitungLuas()
    {
        return Panjang * Lebar;
    }
}


class Rekening
{
    private double saldo = 0;

    public void Setor(
        double jumlah)
    {
        saldo += jumlah;

        Console.WriteLine(
            "Uang berhasil disetor."
        );
    }

    public void LihatSaldo()
    {
        Console.WriteLine(
            "Saldo = " + saldo
        );
    }
}


class Mobil
{
    public string Merk { get; set; }

    public void Jalan()
    {
        Console.WriteLine(
            $"{Merk} sedang berjalan."
        );
    }
}


class Buku
{
    public string Judul { get; set; }
    public string Penulis { get; set; }

    public void TampilData()
    {
        Console.WriteLine();
        Console.WriteLine("DATA BUKU");
        Console.WriteLine(
            "Judul   : " + Judul
        );
        Console.WriteLine(
            "Penulis : " + Penulis
        );
    }
}


class Mahasiswa
{
    public string Nama { get; set; }
    public string NIM { get; set; }

    public void TampilData()
    {
        Console.WriteLine();
        Console.WriteLine("DATA MAHASISWA");
        Console.WriteLine(
            "Nama : " + Nama
        );
        Console.WriteLine(
            "NIM  : " + NIM
        );
    }
}


class Orang
{
    public string Nama { get; set; }
    public int Umur { get; set; }

    public Orang(
        string nama,
        int umur)
    {
        Nama = nama;
        Umur = umur;
    }

    public void TampilData()
    {
        Console.WriteLine();
        Console.WriteLine("DATA ORANG");
        Console.WriteLine(
            "Nama : " + Nama
        );
        Console.WriteLine(
            "Umur : " + Umur
        );
    }
}