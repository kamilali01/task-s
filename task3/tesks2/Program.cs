using System;
using System.Xml.Schema;

namespace tesks2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1)İstifadəçidən input alınsın. Alınmış inputdakı başlanğıcdan olan boşluqlar silinsin. 
            /*  Console.WriteLine("Daxil edin: ");
              string st1 = Console.ReadLine();
              Console.WriteLine(st1.Length);
              string stt = st1.TrimStart();
              Console.WriteLine(stt);
              Console.WriteLine(stt.Length);*/




            //2)İstifadəçidən alınmış inputda “e” və “q” hərfləri varsa,
            //ekrana “Can not enter e or q symbol” yazılsın. 
            /* Console.WriteLine("Daxil edin:");
             string st2=Console.ReadLine();
             if(st2.Contains("q") && st2.Contains("e")){
                 Console.WriteLine("Can not enter e or q symbol");

             }
             else
             {
                 Console.WriteLine("Correct!");
             }*/


            //3)İstifadəçidən alınmış inputdakı bütün boşluqlar silinsin.
            //(yalnız başlanğıc və sondakı deyil, hamısı)
            //Daha sonra dəyərin bütün hərfləri böyüklə əvəzlənib ekrana yazdırılsın. 
            /*Console.Write("Daxil edin:");
            string st3=Console.ReadLine();
            string str3 = st3.Trim();
            Console.WriteLine(str3.ToUpper());*/

            //4)İstifadəçidən input alınsın. Alınmış inputun 2ci simvolundan sonra 5 simvol ekrana çap edilsin.
            //Əgər əmliyyatın icrası mümkün deyilsə, “can not execute operation” mesajı yazdırılsın.
            //(Əməliyyatın icrası niyə mümkün olmaya bilər???, bunu if ilə yoxlayın)
            /* Console.Write("Daxil edin:");
             string st4=Console.ReadLine();
             if (st4.Length >= 7)
             {
                 string str4 = st4.Substring(2, 5);
             }
             else 
             {
                 Console.WriteLine("can not execute operation");
             }*/


            //5)Istifadəçidən input alınsın. Alınmış input null və ya boşluqlardan ibarətdirsə,
            //ekrana “value can not be empty or whitespace” yazılsın.
            /* Console.Write("Daxil edin:");
             string st5 = Console.ReadLine();
             var str5 = st5 ?? "Null-dir";
             Console.WriteLine(str5);*/

            //6.String tipli constant variable yaradın və dəyərini ekrana yazdırın.
            /* const string st6 = "Salam";
             Console.WriteLine(st6);*/

            //7)0-100 arasında integer tipli Random dəyər generasiya edin və ekrana yazdırın.
            /*Random r = new Random();            
            Console.WriteLine(r.Next(0,100));*/

            //8)10-2333 arasında integer tipli Random dəyər generasiya edin və ekrana yazdırın.
            /*Random r = new Random();            
           Console.WriteLine(r.Next(10,233));*/

            //9)GUİD generasiya edin və ekrana yazdırın.
            /*Guid guid = Guid.NewGuid();
            Console.WriteLine(guid);*/

            //10)İstidadəçidən ədəd daxil etməsini tələb edin və daxil edilmiş ədəd 10-dan böyüksə,
            //ekrana “10-dan böyük”, 10-dan kiçiksə ekrana “10-dan kiçik”, digər halda isə “10-a bərabər”
            //yazılsın.
            /*Console.WriteLine("Eded daxil edin:");
            int i=Convert.ToInt32(Console.ReadLine());
            if (i > 10)
            {
                Console.WriteLine("10-dan boyuk");
            }
            else if (i < 10)
            {
                Console.WriteLine("10-dan kicik");
            }
            else
            {
                Console.WriteLine("10-beraber");
            }*/

            //11)Istifadəçidən string dəyər daxil etməsini tələb edin.
            //Daxil edilmiş dəyərin uzunluğu 6-dan böyüksə, ekrana “6-dan böyük”,
            //6-dan kiçiksə ekrana “6-dan kiçik”, digər halda isə “6-a bərabər” yazılsın.
            /* Console.WriteLine("Daxil edin:");
             string st11=Console.ReadLine();
             int i11 = st11.Length;
             if (i11 > 6)
             {
                 Console.WriteLine("6-dan boyuk");
             }
             else if (i11 < 6)
             {
                 Console.WriteLine("6-dan kicik");
             }
             else
             {
                 Console.WriteLine("6-beraber");
             }*/

            //12)İstifadəçidən dəyər alınsın, alınmış dəyər 6 və ya 7-dirsə,
            //ekrana “düzgün cavab” yazdırılsın.

            /* Console.WriteLine("Daxil edin: ");
             int i12 = Convert.ToInt32(Console.ReadLine());
             if(i12==6 || i12 == 7)
             {
                 Console.WriteLine("düzgün cavab");
             }*/

            //13)İstifadəçidən dəyər alınsın, alınmış dəyər 1 və 10 aralığındadırsa,
            //ekrana “1 - 10 aralığı”, 10 - 20 aralığındadırsa “10 - 20 aralığı”, əks halda “nəticə tapılmadı”
            //yazılsın.
            /* Console.WriteLine("Daxil edin: ");
             int i13 = Convert.ToInt32(Console.ReadLine());
             if(i13>1 && i13 < 10)
             {
                 Console.WriteLine("1-10 araligi");
             }
             else if (i13 > 10 && i13 < 20)
             {
                 Console.WriteLine("10-20 araligi");
             }
             else
             {
                 Console.WriteLine("netice tapilmadi");
             }*/

            //14)Ədədin tək və ya cüt olduğunu tapın. Əgər ədəd cütdürsə ekrana “cüt ədəd”,
            //əks halda “tək ədəd” yazılsın.
            /* Console.WriteLine("Daxil edin: ");
             int i14 = Convert.ToInt32(Console.ReadLine());
             if (i14 % 2 == 0)
             {
                 Console.WriteLine("cut");
             }
             else
             {
                 Console.WriteLine("tek");
             }*/

            //15)0-100 arasi random ədəd generasiya edilsin və əgər generasiya olunmuş ədəd 50-dən böyükdürsə,
            //ekrana yazdırılsın.
            /* Random r15 = new Random();
             int ran = r15.Next();
             if (ran > 50)
             {
                 Console.WriteLine(ran);
             }*/


            //16)Ədədin tək və ya cüt olduğunu tapın. Əgər ədəd cütdürsə ekrana “cüt ədəd”,
            //əks halda “tək ədəd” yazılsın. Bunun üçün ternary operator istifadə edilsin.
            /*Console.WriteLine("Daxil edin: ");
            int i16 = Convert.ToInt32(Console.ReadLine());
            var f16 = i16 % 2 == 0 ? "Cut" : "Tek";
            Console.WriteLine(f16);*/

            //17)İstifadəçidən dəyər daxil etməsi tələb edilsin və daxil edilmiş dəyərdə yalnız 1
            //“t” hərfinin olub olmamasını yoxlayın. Əgər yalnız 1 “t” hərfi varsa, “dəyərdə tək t hərfi var”
            //yazısı ekrana yazdırılsın.
            /*Console.WriteLine("Daxil edin:");
            string st17=Console.ReadLine();
            int la=st17.LastIndexOf("t");
            int fi = st17.IndexOf("t");
            if (la == fi)
            {
                Console.WriteLine("tek t herfi var");
            }*/
        }
    }
}
