using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Birinci_tsk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //Console.WriteLine("Adinizi daxil edin:");
            //string ad=Console.ReadLine();

            //Console.WriteLine("Yasinizi daxil edin:");
            //string yas_metni=Console.ReadLine();
            //int.TryParse(yas_metni,out int yas);

            //Console.WriteLine("Boyunuzu daxil edin:");
            //String boy_metni= Console.ReadLine();
            //double.TryParse(boy_metni, out double boy);

            //Console.WriteLine("Salam, menim adim " + ad + "dir.Menim " + yas + " yasim var.Boyum " + boy + " m-dir");



            //2
            //const double Pi = 3.14159;
            //Console.WriteLine("Radius daxil edin:");
            //string radius_metni=Console.ReadLine();
            //double.TryParse(radius_metni, out double  r);

            //double S = Pi * r * r;
            //Console.WriteLine("Dairenin sahesi: " + S);


            //3
            //const double USD = 1.7;
            //const double EUR = 1.82;

            //Console.WriteLine("Manat meblegini daxil edin:");
            //string manat_metni=Console.ReadLine();
            //double manat = Convert.ToDouble(manat_metni);

            //double dollar = manat / USD;
            //double euro = manat/ EUR;

            //Console.WriteLine("Dollar: "+ dollar);
            //Console.WriteLine("Euro: "+ euro);


            //4
            //Console.WriteLine("Azerbaycan dili balini daxil edin:");
            //string az_dili_metni=Console.ReadLine();
            //int az_dili=int.Parse(az_dili_metni);

            //Console.WriteLine("Riyaziyyat balini daxil edin:");
            //string riy_bali_metni= Console.ReadLine();
            //int riy_bali = int.Parse(riy_bali_metni);

            //Console.WriteLine("Ingilis dili balini daxil edin:");
            //string ing_dili_metni=Console.ReadLine();
            //int ing_dili = int.Parse(ing_dili_metni);

            //Console.WriteLine("Fizika balini daxil edin:");
            //string fizika_bali_metni=Console.ReadLine();
            //int fizika_bali=int.Parse(fizika_bali_metni);

            //Console.WriteLine("Informatika balini daxil edin:");
            //string info_bali_metni=Console.ReadLine();
            //int info_bali=int.Parse(info_bali_metni);

            //double orta_bal=(az_dili+riy_bali+ing_dili+fizika_bali+info_bali)/5;
            //string esas_qiymet;

            //if (orta_bal > 90)
            //    esas_qiymet = "Ela netice!";
            //else if (orta_bal < 51)
            //    esas_qiymet = "Kesildiniz!";
            //else
            //    esas_qiymet = "Orta netice!";

            //Console.WriteLine("Netice:" + esas_qiymet);



            //5
            //const double faiz = 0.12;
            //Console.WriteLine("Ilkin meblegi daxil edin:");
            //string ilkin_mebleg_metni=Console.ReadLine();
            //double.TryParse(ilkin_mebleg_metni, out double ilkin_mebleg);

            //Console.WriteLine("Nece il saxlanacagini qeyd edin:");
            //string il_sayi_metni= Console.ReadLine();
            //int.TryParse(il_sayi_metni, out int il_sayi);

            //double gelecek_mebleg = ilkin_mebleg * (1 + faiz * il_sayi);
            //Console.WriteLine("Gelecek mebleg:" + gelecek_mebleg);



            //6
            //Console.WriteLine("Mesafeni daxil edin:");
            //string mesafe_metni=Console.ReadLine();
            //double.TryParse(mesafe_metni,out double mesafe);

            //Console.WriteLine("Serf olunan yanacagi daxil edin:");
            //string yanacag_metni=Console.ReadLine();
            //double.TryParse(yanacag_metni, out double yanacag);

            //string melumat;
            //if (mesafe <= 0 || yanacag < 0)
            //{
            //    melumat = "Daxil edilen melumat yanlisdir!";
            //    Console.WriteLine("Melumat yoxlanisi:" + melumat);
            //}
            //else
            //{
            //    double serfiyyat = (yanacag / mesafe) * 100;
            //    Console.WriteLine("100 km ucun serfiyyat miqdari:" + serfiyyat);
            //}

        }
    }
}
