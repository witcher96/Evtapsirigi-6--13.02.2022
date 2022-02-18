using System;

namespace Evtapsirigi_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            //1) Verilmish metnde {a} simvolun sayi {b} simvolun sayinda nece defe coxdur?


            string word = "Azərbaycan Azərbaycan Üçrəngli bayrağınla məsud yaşa!";
            word = word.ToLower();

            int a = 0;
            int b = 0;
            int c;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                {
                    a++;
                }
                else if (word[i] == 'b')
                {
                    b++;
                }
            }
            c = a / b;
            Console.WriteLine($"a larin sayi {a}");
            Console.WriteLine($"b larin sayi {b}");
            Console.WriteLine($"a simvolu b simvolundan {c} defe coxdur");
        }
    }
}
