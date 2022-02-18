using System;

namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //7) Verilmish metnde { a}simvolu { b} simvolundan qabaq ve oda { c} simvolundan qabaq gelirmi ?
            string word = "Azərbaycan Azərbaycan Üçrəngli bayrağınla məsud yaşa!";
            char[] mass = {'a'};
            int a =word.IndexOfAny(mass);
            Console.WriteLine($"a indeksinin yeri {a}");
            
            char[] mass2 = {'b'};
            int b=word.IndexOfAny(mass2);
            Console.WriteLine($"b indeksinin yeri {b}");
           
            char[] mass3 = { 'c' };
            int c = word.IndexOfAny(mass3);
            Console.WriteLine($"c indeksinin yeri {c}");

            for (int i = 0; i < word.Length; i++)
            {
            if ('a'>'b'&& 'b'>'c'&&'a'>'c')
            {
                Console.WriteLine("Beli");
                    break;
            }
            else
            {
                Console.WriteLine("Xeyr");
                    break;
                }

            }






        }
    }
}
