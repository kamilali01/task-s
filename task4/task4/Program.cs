using System;
using System.Text;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1) İstifadəçidən number formatlı dəyər daxil edilməsi istənilsin.
            //Daxil edilmiş dəyər qədər 0 - la 200 arasında ədəd generasiya olunsun və bu ədədlərin cəmi ekrana yazdırılsın.

            /*  int say, cem = 0, eded;
              Console.Write("Eded sayi: ");
              say = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("!Eded 0-200 arasinda olmalidir!");
              for (int i = 0; i < say; i++)
              {
              tekrar: Console.Write("Eded: ");
                  eded = Convert.ToInt32(Console.ReadLine());
                  cem += eded;
                  if (eded > 200 || eded < 0)
                  {
                      Console.WriteLine("Xeta!"); goto tekrar;
                  }

              }
              Console.WriteLine(cem);*/

            //2) 1-dən 20-ə kimi  ədədlərin kvadları cəmi ekrana yazdırılsın.

            /* double eded2,cem2=0;

             for (int i = 1; i <= 20; i++)
             {
                 eded2=Math.Pow(i, 2);
                 cem2 += eded2;
             }
             Console.WriteLine(cem2);*/

            //3) 1-dən 100-ə kimi ədədlər ekrana yazdırılsın. ( ) +++

            /* for(int i = 1; i <= 100; i++)
             {
                 Console.WriteLine(i);
             }*/

            //4) 1-dən 100-ə qədər ancaq 3-ə bölünən ədədlər ekrana yazdırılsın. (for ilə)+++

            /* for(int i = 1; i <= 100; i++)
             {
                 if (i % 3 == 0)
                 {
                     Console.WriteLine(i);
                 }
             }*/

            //5) 1-dən 100-ə qədər ədədlər ekrana yazdırılsın. (36 və 67 istisna olmaqla)+++

            /* for (int i = 1; i <= 100; i++)
             {
                 if (i!=36 && i!=67)
                 {
                     Console.WriteLine(i);
                 }
             }*/

            //6) 1-dən 100-ə ədədlər dövrə salınsın. İlk 17-ə bölünən ədəd tapılanda proqram ekrana “17-ə bölünən ilk ədəd tapıldı” yazılsın +++

            /* bool yoxlama = false;
             for (int i = 1; i <= 100; i++)
             {
                 Console.WriteLine(i);
                 if (i % 17 == 0 && yoxlama==false)
                 {
                     Console.WriteLine("17-e bolunen ilk eded tapildi");
                     yoxlama = true;
                 }
             }*/

            //7)  String dəyər təyin edilsin. 1000 iterasiyalı dövr qurulsun. Hər iterasiyada  təyin etdiyimiz dəyərin üzərinə “iteration number i” gəlsin. i dinamik olaraq iterasiya nömrəsindən alınsın. Dövr tamamlandıqdan sonra ən sonda ekrana təyin edilmiş dəyər(başlanğıcda təyin etdiyimiz, dövrdə üzərinə iteration number əlavə edilən dəyər) yazılsın.  

            /*string it = "Iteration Number: ";
            int itn=0;

            for(int i = 0; i <= 1000; i++)
            {
                itn += i;
                Console.WriteLine(it+itn);
            }*/

            //8) 100-dən 1-ə kimi ədədləri azalan qaydada ekrana yazdırın.

            /*for(int i = 100; i >= 1; i--)
            {
                Console.WriteLine(i);
            }*/

            //9) Math bütün funksionallıqlarına aid nümunə yazın.

            /*Console.WriteLine(Math.PI);
            Console.WriteLine(Math.Min(5,25));
            Console.WriteLine(Math.Max(5,25));
            Console.WriteLine(Math.Abs(-15));
            Console.WriteLine(Math.Floor(5.8));
            Console.WriteLine(Math.Round(5.8));
            Console.WriteLine(Math.Pow(2,5));*/

            //!! //10) String name adlı variable təyin edilsin. Daha sonra yeni string variable yaradın və əgər name nulldursa “test”, əks halda name-in dəyərini alsın.

            /* string name = null;
             name = "salam";

             var yoxla = name ?? "test"; Console.WriteLine(name); */

            //11) Istifadəçidən dəyər alınsın. Daxil edilmiş dəyər “bir” dirsə, ekrana “bir”, “iki”dirsə ekrana “iki”, “üç”dürsə ekrana “üç”, heç biri deyilsə, “tapılmadı”yazılsın.

            /*Console.Write("Eded daxil edin:");
            int eded11=Convert.ToInt32(Console.ReadLine());
            switch (eded11)
            {
                case 1: Console.WriteLine("Bir");break;
                    case 2: Console.WriteLine("Iki");break;
                case 3: Console.WriteLine("Uc"); break;
                    default: Console.WriteLine("tapilmadi");break;
            }*/

            //12) Switch  -ya aid nümunə yazın. (11)

            //13) Nullable double dəyişəni təyin edin. Əgər dəyişənin dəyəri “null”dursa, ekrana “nulldur”, əks halda dəyəri yazdırılsın.

            /*double? dob13 = null;
            if (dob13 == null)
            {
                Console.WriteLine("null-dir");
            }
            else
            {
                Console.WriteLine(dob13);
            }*/

            //14) 10-dən 300-ə kimi ədədləri 2 vahid artmaqla ekrana yazdırın.

            /*for(int i = 10; i <= 300; i++)
            {
                Console.WriteLine(i+2);
            }*/

            //15) 200-dən 40-a kimi ədədləri 12 vahid azalmaqla ekrana yazdırın.

            /*for (int i = 10; i <= 300; i++)
            {
                Console.WriteLine(i - 12);
            }*/

            //16) İstifadəçidən dəyər daxil etməsi tələb edilsin. Əgər dəyər üzərində riyazi əməliyyat aparmaq mümkündürsə, “siz ədəd daxil etdiniz”, əks halda “siz mətn daxil etdiniz” yazısı console-a yazdırılsın.

            Console.WriteLine("Eded daxil edin:");
            string str16=Console.ReadLine();
            
            bool check= int.TryParse(str16, out int b);
            if (check)
            {
                Console.WriteLine("eded daxil etdiniz");
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine("Duzgun daxil etmediniz");
            }
        }
    }
}
