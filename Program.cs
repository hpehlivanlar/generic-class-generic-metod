using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_class_generic_metot
{
    // Generic Metot kendisine müracaat edildiği zaman müracaat snasında gönderilen deger tipini baz alır ve ona göre davrenıa işlemyapar
    //generic metot tanımladığında içerisine gelen değerlerin ne tipli olacağını belirlemek için aşağıdaki tanımlamalar kullanılabilir.
    /*
     * 
        where T:<İfade>
        
        where T:class = Tnin System.ValueType tipinde olması gerektiğini belirtmenk için kullanılır
        where T:new() Tnin defoult constructor (yapıcı metot) olması gerektiğini belirtmek için kullnaılır
        where T:struct : Tnin System.ValueType tipinde olması gerktiğini belirtmek için 

        where:NameOfBaseClass : yerine bir sınıf ismi yazılır ve T nşn bundan türetilmiş olası gerekiyor 
        where T :NameOfInterface = bunun yetinde interface ismi yazılır Tnın bu interface veya birden çok interfaceleri implement etmiş olması gerekir.





    */

    public class Koordinat<T> where T : new()
    {
        private T x;
        private T y;

        public Koordinat(T xdeger, T ydeger)
        {

            x = xdeger;
            y = ydeger;


            Console.WriteLine(x);
            Console.WriteLine(y);
        }


    }




    class Program
    {
        static void DegisMetin(ref string b, ref string c)
        {
            string a;
            a = b;
            c = a;

            Console.WriteLine(c);

        }
        static void DegisSayi(ref int b, ref int c)
        {
            int a;
            a = b;
            c = a;

            Console.WriteLine(c);
        }

        static void Degis<T>(ref T ifadebir, ref T ifadeiki)
        {
            T a;
            a = ifadebir;
            ifadebir = ifadeiki;

            Console.WriteLine(ifadebir);


        }






        static void Main(string[] args)
        {
            string deger1 = "metin1";
            string deger2 = "metin2";


            //DegisMetin(ref deger1, ref deger2);

            //Console.WriteLine("----");

            int deger11 = 1;
            int deger22 = 3;
            int deger33 = 5;

            //DegisSayi(ref deger11, ref deger22);

            Console.WriteLine("----");

            Console.WriteLine("Değiş string-");

            Degis<string>(ref deger1, ref deger2);

            Console.WriteLine("----");

            Console.WriteLine("Değiş int-");



            Degis<int>(ref deger22, ref deger33);


            Console.WriteLine("----");


            Koordinat<int> koordinat = new Koordinat<int>(50, 30);

            Koordinat<double> koordinat1 = new Koordinat<double>(50.5, 60.50);

            //Koordinat<string> koordinat2 = new Koordinat<string>("metin1", "metin2");








        }
    }
}
