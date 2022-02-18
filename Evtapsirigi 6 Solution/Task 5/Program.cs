using System;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string word = "Azərbaycan Azərbaycan Üçrəngli bayrağınla məsud yaşa!";
            word = word.ToLower();

            char[] sozler = { 'a', 'b', 'c' };

            int index =word.IndexOfAny(sozler);

            Console.WriteLine(index);
            Console.WriteLine(word[index]);


            
        }
    }
}
