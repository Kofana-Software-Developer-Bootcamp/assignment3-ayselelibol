using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleAppPatika
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //kullanıcı bilgileri tanımlandı
            musteri information = new musteri();
            information.MusteriNo = 1234;
            information.KullaniciAdi = "Ayşe Yılmaz";
            information.Tel = "5555555555";
            musteri information2 = new musteri();
            information2.MusteriNo = 3456;
            information2.KullaniciAdi = "Mehmet Öztürk";
            information2.Tel = "5556667788";
            musteri information5 = new musteri();
            information5.MusteriNo = 4567;
            information5.KullaniciAdi = "Ali Şahin";
            information5.Tel = "5557778899";
            musteri information6 = new musteri();
            information6.MusteriNo = 5568;
            information6.KullaniciAdi = "Elif Kutay";
            information6.Tel = "5559998877";




            List<musteri> kullanicilistesi = new List<musteri>();

            kullanicilistesi.Add(information);
            kullanicilistesi.Add(information2);
            kullanicilistesi.Add(information5);
            kullanicilistesi.Add(information6);


            // { 12345, 23456, 34567, 45678, 56789 };
            //string[] names = { "Ayşe Yılmaz", "Ahmet Çelik", "Ali Yalçın", "Mustafa Kara", "Mert Selim" };
            //string[] tel = { "5555555555", "5554443322", "5544441112", "5533322112", "5508887766" };


            Console.WriteLine("Sitemize Hoşgeldiniz!");
            Console.WriteLine("Lütfen Devam Edebilmek İçin Müşteri Numaranızı Giriniz..");
            int Question1 = int.Parse(Console.ReadLine());
            //burada kayıtlı olup olmadığının kontrolünü yaptım
            if (information.MusteriNo == Question1 || information2.MusteriNo == Question1 || information5.MusteriNo == Question1 || information6.MusteriNo == Question1)
            {

                Console.WriteLine("Hoşgeldiniz ");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Kaydınız Bulunmamaktadır Lütfen Kayıt Oluşturunuz");
                musteri information3 = new musteri();

                Console.WriteLine("Lütfen adınızı giriniz");
                string kullaniciadi = Console.ReadLine();
                information3.KullaniciAdi = kullaniciadi;
                Console.WriteLine("Lütfen kullanıcı numaranızı seçiniz");
                int selectednumber = int.Parse(Console.ReadLine());

                if (information.MusteriNo == selectednumber || information2.MusteriNo == selectednumber || information5.MusteriNo == selectednumber || information6.MusteriNo == selectednumber)
                {
                    //kullanıcı numaralarının çakışmaması için kontrol yaptım
                    Console.WriteLine("Bu numara kullanılmaktadır. Lütfen Başka numara giriniz");
                    information3.MusteriNo = int.Parse(Console.ReadLine());


                }

                Console.WriteLine("Telefon Numaranızı giriniz");
                information3.Tel = Console.ReadLine();
                kullanicilistesi.Add(information3);
                Console.WriteLine("Hoşgeldiniz " + information3.KullaniciAdi);

            }

            //foreach (var item in kullanicilistesi)
            //{
            //    if (item.MusteriNo == Question1) 
            //    {
            //        Console.WriteLine("Hoşgeldiniz " + item.KullaniciAdi);
            //        break;

            //    }
            //    else if (item.MusteriNo != Question1)
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("Kaydınız Bulunmamaktadır Lütfen Kayıt Oluşturunuz");
            //        musteri information3 = new musteri();

            //        Console.WriteLine("Lütfen adınızı giriniz");
            //        string kullaniciadi = Console.ReadLine();
            //        information3.KullaniciAdi = kullaniciadi;
            //        Console.WriteLine("Lütfen kullanıcı numaranızı seçiniz");
            //        int selectednumber = int.Parse(Console.ReadLine());

            //        if (item.MusteriNo == selectednumber)
            //        {
            //            //kullanıcı numaralarının çakışmaması için kontrol yaptım
            //            Console.WriteLine("Bu numara kullanılmaktadır. Lütfen Başka numara giriniz");
            //            information3.MusteriNo = int.Parse(Console.ReadLine());


            //        }

            //        Console.WriteLine("Telefon Numaranızı giriniz");
            //        information3.Tel= Console.ReadLine();
            //        kullanicilistesi.Add(information3);
            //        Console.WriteLine("Hoşgeldiniz " + information3.KullaniciAdi);
            //        break;
            //    }


            //}



            //üyelik adımlarının bitiminde sipariş seçeneklerinin sunulduğu konsol kısmı;


            Console.WriteLine("Menü:");
            char ch;
            Console.SetCursorPosition(19, 13);
            Console.WriteLine("1. Tiramisu");

            Console.SetCursorPosition(19, 14);
            Console.WriteLine("2. Cheesecake");

            Console.SetCursorPosition(19, 15);
            Console.WriteLine("3. Trileçe");

            Console.SetCursorPosition(19, 16);
            Console.WriteLine("4. Sütlaç");

            Console.SetCursorPosition(19, 17);
            Console.WriteLine("5. Kazandibi");


            Console.SetCursorPosition(19, 18);
            Console.WriteLine("Lütfen yukarıdaki tatlılardan sipariş vermek istediğinizin numarasını giriniz");
            ch = char.Parse(Console.ReadLine());
            if (ch == '1')
            {
                Console.WriteLine("Kaç adet Tiramisu sipariş vermek istiyorsunuz?");
                string adet = Console.ReadLine();
                Console.WriteLine("Sipariş Notu Eklemek İster Misiniz?(evet-hayır)");
                string yanit = Console.ReadLine();
                if (yanit == "evet")
                {
                    Console.WriteLine("Eklemek istediğiniz notu yazınız :)");
                    string note = Console.ReadLine();
                    Console.WriteLine("Notunuz başarıyla kaydedilmiştir :) ");

                }

                Console.WriteLine(adet + " Adet Tiramisu Siparişiniz Alınmıştır :)");


            }
            if (ch == '2')
            {
                Console.WriteLine("Kaç adet Cheesecake sipariş vermek istiyorsunuz?");
                string adet = Console.ReadLine();
                Console.WriteLine("Sipariş Notu Eklemek İster Misiniz?(evet-hayır)");
                string yanit = Console.ReadLine();
                if (yanit == "evet")
                {
                    Console.WriteLine("Eklemek istediğiniz notu yazınız :)");
                    string note = Console.ReadLine();
                    Console.WriteLine("Notunuz başarıyla kaydedilmiştir :) ");

                }
                Console.WriteLine(adet + " Adet Cheesecake Siparişiniz Alınmıştır :)");


            }
            if (ch == '3')
            {
                Console.WriteLine("Kaç adet Trileçe sipariş vermek istiyorsunuz?");
                string adet = Console.ReadLine();
                Console.WriteLine("Sipariş Notu Eklemek İster Misiniz?(evet-hayır)");
                string yanit = Console.ReadLine();
                if (yanit == "evet")
                {
                    Console.WriteLine("Eklemek istediğiniz notu yazınız :)");
                    string note = Console.ReadLine();
                    Console.WriteLine("Notunuz başarıyla kaydedilmiştir :) ");

                }
                Console.WriteLine(adet + " Adet Trileçe Siparişiniz Alınmıştır :)");

            }
            if (ch == '4')
            {
                Console.WriteLine("Kaç adet Sütlaç sipariş vermek istiyorsunuz?");
                string adet = Console.ReadLine();
                Console.WriteLine("Sipariş Notu Eklemek İster Misiniz?(evet-hayır)");
                string yanit = Console.ReadLine();
                if (yanit == "evet")
                {
                    Console.WriteLine("Eklemek istediğiniz notu yazınız :)");
                    string note = Console.ReadLine();
                    Console.WriteLine("Notunuz başarıyla kaydedilmiştir :) ");

                }
                Console.WriteLine(adet + " Adet Sütlaç Siparişiniz Alınmıştır :)");

            }
            if (ch == '5')
            {
                Console.WriteLine("Kaç adet Kazandibi sipariş vermek istiyorsunuz?");
                string adet = Console.ReadLine();
                Console.WriteLine("Sipariş Notu Eklemek İster Misiniz?(evet-hayır)");
                string yanit = Console.ReadLine();
                if (yanit == "evet")
                {
                    Console.WriteLine("Eklemek istediğiniz notu yazınız :)");
                    string note = Console.ReadLine();
                    Console.WriteLine("Notunuz başarıyla kaydedilmiştir :) ");

                }
                Console.WriteLine(adet + " Adet Kazandibi Siparişiniz Alınmıştır :)");

            }



        }
    }
}
