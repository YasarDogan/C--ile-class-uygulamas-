using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Personel
    {

        static public int Adet;

        static public void PersonelAdetYaz()
        {
            Console.WriteLine("Şu anda {0} adet Personel değişkeni oluşturuldu", Personel.Adet);
        }


        private string m_TC;
        private string m_Ad;
        private string m_Soyad;
        private string m_Adres;

        public string TC
        {
            get
            {
                return m_TC;
            }
            set
            {
                if (value.Length == 11)
                {
                    m_TC = value;
                }
                else
                {
                    m_TC = "11111111111";
                    Console.WriteLine("TC hatalı");
                }
            }
        }
        public string Ad
        {
            get
            {
                return m_Ad;
            }
            set
            {
                if (value.Length >= 3 && value.Length < 50)
                {
                    m_Ad = value;
                }
                else
                {
                    if (value.Length > 50)
                    {
                        m_Ad = value.Substring(0, 50);
                    }
                    else
                    {
                        m_Ad = "CAN";
                        Console.WriteLine("İsim hatalı");
                    }
                }
            }
        }
        public string Soyad
        {
            get
            {
                return m_Soyad;
            }
            set
            {
                if (value.Length >= 3 && value.Length < 50 && !value.Contains(" "))
                {
                    m_Soyad = value;
                }
                else
                {
                    if (value.Contains(" "))
                    {
                        value = value.Replace(" ", "_");
                    }

                    if (value.Length > 50)
                    {
                        m_Soyad = value.Substring(0, 50);
                    }
                    else
                    {
                        m_Soyad = "CAN";
                        Console.WriteLine("Soyisim hatalı");
                    }
                }

                m_Soyad = m_Soyad.ToUpper();
            }
        }
        public string Adres
        {
            get
            {
                return m_Adres;
            }
            set
            {
                if (value.Contains("Mahalle") && value.Contains("Cadde") && value.Contains("Sokak"))
                {
                    m_Adres = value;
                }
                else
                {
                    m_Adres = value;
                    Console.WriteLine("Adreste hata var");
                }
            }
        }
        public void dokum()
        {
            Console.WriteLine("\n=================");
            Console.WriteLine(m_TC);
            Console.WriteLine(m_Ad);
            Console.WriteLine(m_Soyad);
            Console.WriteLine(m_Adres);
            Console.WriteLine("=================");
        }

        public Personel()
        {
            //  Console.WriteLine("Bir personel değişkeni oluşturuldu");
            m_Ad = "Muhittin";
            m_Soyad = "Karabiber";
            m_TC = "11122233344";
            m_Adres = "Söğüte git, kime sorsan gösterir.";
            Adet++;
        }
        public Personel(string TC)
        {
            m_Ad = "Muhittin";
            m_Soyad = "Karabiber";
            this.TC = TC;
            m_Adres = "Söğüte git, kime sorsan gösterir.";
            Adet++;
        }
        public Personel(string TC, string Ad)
        {
            this.Ad = Ad;
            m_Soyad = "Karabiber";
            this.TC = TC;
            m_Adres = "Söğüte git, kime sorsan gösterir.";
            Adet++;
        }
        public Personel(string TC, string Ad, string Soyad)
        {
            this.Ad = Ad;
            this.Soyad = Soyad;
            this.TC = TC;
            m_Adres = "Söğüte git, kime sorsan gösterir.";
            Adet++;
        }
        public Personel(string TC, string Ad, string Soyad, string Adres)
        {
            this.Ad = Ad;
            this.Soyad = Soyad;
            this.TC = TC;
            this.Adres = Adres;
            Adet++;
        }

        public Personel(Personel P1)
        {
            this.Ad = P1.Ad;
            this.Soyad = P1.Soyad;
            this.TC = P1.TC;
            this.Adres = P1.Adres;
            Adet++;
        }

        ~Personel()
        {

            Console.WriteLine("Sistem kapanıyor.");
        }

        public static Personel operator -(Personel P1)
        {
            P1.Adres = "";
            return P1;
        }

        public static Personel operator +(Personel P1,Personel P2)
        {
            Personel PX = new Personel();
            PX.Ad = P1.Ad + " " + P2.Ad;
            PX.Soyad = P1.Soyad + "" + P2.Soyad;
            PX.Adres = P1.Adres + " " + P2.Adres;
            PX.TC = P1.TC.Substring(0, 5) + P2.TC.Substring(5, 6);

            return PX;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Personel p1 = new Personel();
            //Personel.PersonelAdetYaz();

            //p1.dokum();
            p1.Ad = "Ahmet Temel";
            p1.TC = "48796563322";
            p1.Soyad = "Duran";
            p1.Adres = "Söğüt MYO Söğüt/Bilecik";
            p1.dokum();

            //Personel p2 = new Personel();
            //p2.dokum();

            //Personel.PersonelAdetYaz();

            Personel p3 = new Personel("11111222223", "Ahmet", "Dağdelen", "İzmir Bornova");
            p3.dokum();


            Personel p10 = p1 + p3;
            p10.dokum();

            //Personel per1 = new Personel(p3);
            //per1.dokum();
            //per1.Ad = "hasan";

            //per1.dokum();
            //p3.dokum();

            //p3 = -p3;
            //p3.dokum();



            //Personel pX = new Personel();
            //Personel PY = new Personel("56456464565");
            //Personel PG = new Personel("112334687963", "Hasan");

            //Personel.PersonelAdetYaz();


            Console.ReadKey();
        }
    }
}
