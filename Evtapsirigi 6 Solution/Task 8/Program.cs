using System;
using System.Globalization;

namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            // 8) Verilmish metnde ilk qabagima cixan { a} simvolundan sonra gelen simvolu 10 defe dalbadal cap et.

            string word = "Azərbaycan Azərbaycan Üçrəngli bayrağınla məsud yaşa!";
            word = word.ToLower();
            char[] mass = { 'a' };
            int Kara = word.IndexOfAny(mass);
            Console.WriteLine($"a indeksinin yeri {Kara}");
            word =word.Substring(Kara+1,1);
            Console.WriteLine(word);

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(word);
            }

       
          
           
            
           
        }
    }
}
