using System;

namespace JADWAL
{
    class Home
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Jadwal Pelajaran\n");

            Console.WriteLine("SENIN\n");
            Senin senin = new Senin();
            senin.sesi1();
            senin.sesi2();
            senin.sesi3();

            Console.WriteLine("SELASA\n");
            Selasa selasa = new Selasa();
            selasa.sesi1();
            selasa.sesi2();
            selasa.sesi3();

            Console.WriteLine("RABU\n");
            Rabu rabu = new Rabu();
            rabu.sesi1();
            rabu.sesi2();
            rabu.sesi3();

            Console.WriteLine("KAMIS\n");
            Kamis.sesi1();
            Kamis.sesi2();
            Kamis.sesi3();

            Console.WriteLine("JUMAT\n");
            Jumat.sesi1();
            Jumat.sesi2();
        }
    }

    class Senin
    {
        public void sesi1()
        {
            Console.WriteLine(" SESI 1");
            Console.WriteLine("0.Upacara (07:00 - 07:35)");
            Console.WriteLine("1.Bahasa Jepang (07:35 - 08:10)");
            Console.WriteLine("2.Bahasa Jepang (08:10 - 08:45)");
            Console.WriteLine("3.Bahasa Inggris (08:45 - 09:20)");
            Console.WriteLine("4.Bahasa Inggris (09:20 - 09:55)\n");
        }

        public void sesi2()
        {
            Console.WriteLine(" SESI 2");
            Console.WriteLine("5.Matematika (10:10 - 10:40)");
            Console.WriteLine("6.Matematika (10:40 - 11:10)");
            Console.WriteLine("7.Matematika (11:10 - 11:40)\n");
        }

        public void sesi3()
        {
            Console.WriteLine(" SESI 3");
            Console.WriteLine("8.PPLG (12:30 - 13:00)");
            Console.WriteLine("9.PPLG (13:00 - 13:30)");
            Console.WriteLine("10.PPLG (13:30 - 14:00)");
            Console.WriteLine("11.PPLG (14:00 - 14:30) \n");
        }
    }

    class Selasa
    {
        public void sesi1()
        {
            Console.WriteLine(" SESI 1");
            Console.WriteLine("1.PKWU (07:00 - 07:35)");
            Console.WriteLine("2.PKWU (07:35 - 08:10)");
            Console.WriteLine("3.PJOK (08:10 - 08:45)");
            Console.WriteLine("4.PJOK (08:45 - 09:20)\n");
        }

        public void sesi2()
        {
            Console.WriteLine(" SESI 2");
            Console.WriteLine("5.Bahasa Indonesia (09:30 - 10:05)");
            Console.WriteLine("6.Bahasa Indonesia (10:05 - 10:35)");
            Console.WriteLine("7.Bahasa Indonesia (10:35 - 11:05)\n");
        }

        public void sesi3()
        {
            Console.WriteLine(" SESI 3");
            Console.WriteLine("8.PPLG (12:35 - 13:00)");
            Console.WriteLine("9.PPLG (13:00 - 13:30)");
            Console.WriteLine("10.PPLG (13:30 - 14:00)");
            Console.WriteLine("11.PPLG (14:00 - 14:30)\n");
        }
    }

    class Rabu
    {
        public void sesi1()
        {
            Console.WriteLine(" SESI 1");
            Console.WriteLine("1.PPLG (07:00 - 07:35)");
            Console.WriteLine("2.PPLG (07:35 - 08:10)");
            Console.WriteLine("3.PPLG (08:10 - 08:45)");
            Console.WriteLine("4.PPLG (08:45 - 09:20)\n");
        }

        public void sesi2()
        {
            Console.WriteLine(" SESI 2");
            Console.WriteLine("5.PPLG (09:30 - 10:05)");
            Console.WriteLine("6.PPLG (10:05 - 10:35)");
            Console.WriteLine("6.PPLG (10:35 - 11:05)");
            Console.WriteLine("7.PPLG (11:05 - 11:35)\n");
        }

        public void sesi3()
        {
            Console.WriteLine(" SESI 3");
            Console.WriteLine("8.PPLG (12:35 - 13:00)");
            Console.WriteLine("9.PPLG (13:00 - 13:30)");
            Console.WriteLine("10.PPLG (13:30 - 14:00)");
            Console.WriteLine("11.BK (14:00 - 14:30)\n");
        }
    }

    class Kamis
    {
        public static void sesi1()
        {
            Console.WriteLine(" SESI 1");
            Console.WriteLine("1.Bahasa Jerman (07:00 - 07:35)");
            Console.WriteLine("2.Bahasa Jerman (07:35 - 08:10)");
            Console.WriteLine("3.Bahasa Jawa (08:10 - 08:45)");
            Console.WriteLine("4.Bahasa Jawa (08:45 - 09:20)\n");
        }

        public static void sesi2()
        {
            Console.WriteLine(" SESI 2");
            Console.WriteLine("5.PKWU (09:30 - 10:05)");
            Console.WriteLine("6.PKWU (10:05 - 10:35)");
            Console.WriteLine("7.PKWU (10:35 - 11:05)");
            Console.WriteLine("8.PAI (11:05 - 11:35)\n");
        }

        public static void sesi3()
        {
            Console.WriteLine(" SESI 3");
            Console.WriteLine("9.PAI (12:35 - 13:00)");
            Console.WriteLine("10.PAI (13:00 - 13:30)\n");
        }
    }

    class Jumat
    {
        public static void sesi1()
        {
            Console.WriteLine(" SESI 1");
            Console.WriteLine("0.Acara Sekolah (Kebersihan/Senam/Istingosah) (06:30 - 08:00)");
            Console.WriteLine("1.Bahasa Inggris (08:00 - 08:30)");
            Console.WriteLine("2.Bahasa Inggris (08:30 - 09:00)");
            Console.WriteLine("3.Sejarah (09:00 - 09:30)\n");
        }

        public static void sesi2()
        {
            Console.WriteLine(" SESI 2");
            Console.WriteLine("4.Sejarah (09:45 - 10:15)");
            Console.WriteLine("5.PPKN (10:15 - 10:45)");
            Console.WriteLine("6.PPKN (10:45 - 11:15)\n");
        }
    }
}

