using System;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //6) Verilmish metnde {a} simvolunun sol terefden ve sag terefden indexleri eydidirmi?

            string word = "Azərbaycan Azərbaycan Üçrəngli bayrağınla məsud yaşa!";
            word = word.ToLower();

            char[] sozler = {'a'};

            int sag=word.IndexOfAny(sozler);
            Console.WriteLine($"Sag indeks {sag}");
            int sol=word.LastIndexOfAny(sozler);
            Console.WriteLine($"Sol indeks {sol}");
            if (sag == sol)
            {
                Console.WriteLine("eynidir");
            }
            else
            {
                Console.WriteLine("eyni deyil");
            }
        }
    }
}
