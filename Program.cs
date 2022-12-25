using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rastgelelig
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TURNUVAYA HOŞGELDİNİZ");
            Console.WriteLine("KATILAN TÜM TAKIMLARA BAŞARILAR...\n");
            
            int gs = 0;
            int fb = 0;
            int bjk = 0;
            int ts = 0;
            int hty = 0;
            int mlt = 0;
            int bur = 0;
            int bsk = 0;
            int sayac = 1;
            Random rastgele = new Random();
            int a1, a2, a3;
            int b1, b2, b3;
            int c1, c2, c3;
            int d1, d2, d3;

            a1 = rastgele.Next(0, 6);
            b1 = rastgele.Next(0, 6);
            c1 = rastgele.Next(0, 6);
            d1 = rastgele.Next(0, 6);
         


            a2 = rastgele.Next(0, 6);
            b2 = rastgele.Next(0, 6);
            c2 = rastgele.Next(0, 6);
            d2 = rastgele.Next(0, 6);

            a3 = rastgele.Next(0, 6);
            b3 = rastgele.Next(0, 6);
            c3 = rastgele.Next(0, 6);
            d3 = rastgele.Next(0, 6);

            if (sayac==1)
            {
   Console.WriteLine("1.HAFTA SKORLARI");
            Console.WriteLine("----------------");

            Console.WriteLine("GALATASARAY "+a1+"-"+b1+" FENERBAHÇE");
            Console.WriteLine("BEŞİKTAŞ " + d1 + "-" + c1 + " TRABZONSPOR");
            Console.WriteLine("HATAYSPOR " + a2 + "-" + b2 + " MALATYASPOR");
            Console.WriteLine("BURSASPOR " + d2 + "-" + c2 + " BAŞAKŞEHİR\n");
                sayac++;
            Console.ReadLine();
            }
         
            if(sayac==2)
            {
                Console.WriteLine("2.HAFTA SKORLARI");
                Console.WriteLine("----------------");

                Console.WriteLine("FENERBAHÇE " + a2 + "-" + b2 + " TRABZONSPOR");
                Console.WriteLine("BEŞİKTAŞ " + d2 + "-" + c2 + " GALATASARAY");
                Console.WriteLine("HATAYSPOR " + a3 + "-" + b3 + " BURSASPOR");
                Console.WriteLine("MALATYASPOR " + d3 + "-" + c3 + " BAŞAKŞEHİR\n");
                sayac++;
                Console.ReadLine();

            }
            //GALATASARAY-FENERBAHÇE

            if (a1>b1)
            {
                gs += 3;
            }
            else if(b1>a1) 
            {
                fb += 3;
            }
            else if(a1==b1)
            {
                gs += 1;
                fb += 1;
            }

            //BEŞİKTAŞ TRABZONSPOR
            if (d1 > c1)
            {
                bjk += 3;
            }
            else if (c1 > d1)
            {
                ts += 3;
            }
            else if (d1 == c1)
            {
                bjk += 1;
                ts += 1;
            }

            //HATAY-MALATYA
            if (a2 > b2)
            {
              hty += 3;
            }
            else if (b2 > a2)
            {
               mlt += 3;
            }
            else if (d1 == c1)
            {
                hty += 1;
               mlt += 1;
            }

            //BURSASPOR-BASAKSEHİR

            if (d2 > c2)
            {
               bur += 3;
            }
            else if (c2 > d2)
            {
                bsk += 3;
            }

            else if (d2 == c2)
            {
                bsk += 1;
               bur += 1;
            }

            //FENERBAHÇE-TRABZONSPOR
            if (a2 >b2)
            {
                fb += 3;
            }
            else if (b2 > a2)
            {
                ts += 3;
            }

            else if (a2 == b2)
            {
               fb += 1;
                ts += 1;
            }

            //BEŞİKTAŞ-GALATASARAY
            if (d2 > c2)
            {
                bjk += 3;
            }
            else if (c2 > d2)
            {
                gs += 3;
            }

            else if (d2 ==c2)
            {
               bjk += 1;
               gs += 1;
            }

            //HATAYSPOR-BURSASPOR
            if (a3 > b3)
            {
                hty += 3;
            }
            else if (b3 > a3)
            {
                bur += 3;
            }

            else if (a3 == b3)
            {
                hty += 1;
              bur += 1;
            }

            //MALATYASPOR-BASAKSEHİR
            if (d3 > c3)
            {
                mlt += 3;
            }
            else if (c3 > d3)
            {
               bsk += 3;
            }

            else if (c3 == d3)
            {
                bsk += 1;
              mlt += 1;
            }

            Console.WriteLine("----------------");
            Console.WriteLine("PUAN DURUMU");
            Console.WriteLine("-----------");
            Console.WriteLine("GALATASARAY=" + gs);
            Console.WriteLine("FENERBAHÇE=" + fb);
            Console.WriteLine("BEŞİKTAŞ=" + bjk);
            Console.WriteLine("TRABZONSPORI=" + ts);

            Console.WriteLine("HATAYSPOR=" +hty);
            Console.WriteLine("MALATYASPOR=" + mlt);

            Console.WriteLine("BURSASPOR=" +bur);
            Console.WriteLine("BAŞAKŞEHİRI=" + bsk);

            Console.WriteLine();

            if(gs==6)
            {
                Console.WriteLine("-_-ŞAMPİYON GALATASARAY");
            }

            if (bjk == 6)
            {
                Console.WriteLine("ŞAMPİYON BEŞİKTAŞ");
            }

            if(fb == 6)
            {
                Console.WriteLine("♛ŞAMPİYON FENER❤️️");
            }

            if (ts ==6)
            {
                Console.WriteLine("♛ŞAMPİYON TRABB❤️️");
            }

            if (bur == 6)
            {
                Console.WriteLine("♛ŞAMPİYON BURSA");
            }
            if (bsk== 6)
            {
                Console.WriteLine("♛ŞAMPİYON BASAK");
            }
            if (hty==6)
            {
                Console.WriteLine("♛ŞAMPİYON HATAY");
            }

            if (mlt==6)
            {
                Console.WriteLine("♛ŞAMPİYON MALATYA");
            }
            Console.Read();



        }
    }
}
