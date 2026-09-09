using System;

namespace DataSiswa
{
    class Home
    {
        static void Main(String[] args)
        {
            int pilih;

            
            {
                Console.Clear();
                Console.WriteLine("DATA SISWA");
                Console.WriteLine("1. Identitas");
                Console.WriteLine("2. Mata Pelajaran");
                Console.WriteLine("3. Absensi");
                Console.WriteLine("4. Nilai");
                Console.WriteLine("5. Keluar");
                Console.Write("Pilih : ");
                pilih = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (pilih)
                {
                    case 1:
                        Identitas identitas = new Identitas();
                        identitas.siswa();
                        identitas.wali();
                        identitas.sekolah();
                        break;

                    case 2:
                        MataPelajaran mataPelajaran = new MataPelajaran();
                        mataPelajaran.nonProduktif();
                        mataPelajaran.produktif();
                        break;

                    case 3:
                        Absensi absensi = new Absensi();
                        absensi.bulan();
                        break;

                    case 4:
                        Nilai.nilai();
                        break;

                    case 5:
                        Console.WriteLine("Program selesai.");
                        break;

                    default:
                        Console.WriteLine("Pilihan tidak tersedia.");
                        break;
                }

                if (pilih != 5)
                {
                    Console.WriteLine("\nTekan ENTER untuk kembali...");
                    Console.ReadLine();
                }

            } while (pilih != 5);
        }
    }

    class Identitas
    {
        public void siswa()
        {
            Console.WriteLine("SISWA");
            Console.WriteLine("Nama Siswa : fian ");
            Console.WriteLine("Umur : 17");
            Console.WriteLine("Kelas : XI ");
            Console.WriteLine("Nisn : 0092184818");
            Console.WriteLine("Tempat Tanggal Lahir : Sidoarjo, 5 Agustus 2009");
            Console.WriteLine("Alamat : Sidoarjo \n");
        }

        public void wali()
        {
            Console.WriteLine("WALI");
            Console.WriteLine("Nama Wali : BUDI ");
            Console.WriteLine("Umur : 42 ");
            Console.WriteLine("Pekerjaan : SWASTA \n");
        }

        public void sekolah()
        {
            Console.WriteLine("SEKOLAH");
            Console.WriteLine("Nama Sekolah TK : TK MENARA ILMU");
            Console.WriteLine("Nama Sekolah SD : SDN BANJARKEMANTREN 2");
            Console.WriteLine("Nama Sekolah SMP : SMPN 1 BUDURAN");
            Console.WriteLine("Nama Sekolah SMK : SMKN 2 BUDURAN\n");
        }
    }

    class MataPelajaran
    {
        public void nonProduktif()
        {
            Console.WriteLine("NONPRODUKTIF");
            Console.WriteLine("Bahasa Indonesia");
            Console.WriteLine("Bahasa Inggris");
            Console.WriteLine("Matematika");
            Console.WriteLine("Pai");
            Console.WriteLine("Bahasa Jepang");
            Console.WriteLine("PJOK");
            Console.WriteLine("Bahasa Jerman");
            Console.WriteLine("Bahasa Jawa");
            Console.WriteLine("Sejarah");
            Console.WriteLine("Ppkn\n");
        }

        public void produktif()
        {
            Console.WriteLine("PRODUKTIF");
            Console.WriteLine("Pemrograman Web");
            Console.WriteLine("Data Base\n");
        }
    }

    class Absensi
    {
        public void bulan()
        {
            Console.WriteLine("Bulan       Masuk   Alpha   Sakit");
            Console.WriteLine("Januari       20       1       0");
            Console.WriteLine("Februari      19       0       1");
            Console.WriteLine("Maret         21       0       0");
            Console.WriteLine("April         20       1       0");
            Console.WriteLine("Mei           18       1       1");
            Console.WriteLine("Juni          20       0       0");
            Console.WriteLine("Juli          21       0       0");
            Console.WriteLine("Agustus       20       1       0");
            Console.WriteLine("September     19       0       1");
            Console.WriteLine("Oktober       21       0       0");
            Console.WriteLine("November      20       1       0");
            Console.WriteLine("Desember      18       0       1");
        }
    }

    class Nilai
    {
        public static void nilai()
        {
            Console.WriteLine("NILAI\n");
            Console.WriteLine("Bahasa Indonesia  : 85");
            Console.WriteLine("Bahasa Inggris    : 80");
            Console.WriteLine("Matematika        : 90");
            Console.WriteLine("Pai               : 85");
            Console.WriteLine("Bahasa Jepang     : 80");
            Console.WriteLine("PJOK              : 90");
            Console.WriteLine("Bahasa Jerman     : 85");
            Console.WriteLine("Bahasa Jawa       : 80");
            Console.WriteLine("Sejarah           : 90");
            Console.WriteLine("Ppkn              : 85");
        }
    }
}