using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //2) Verilmish metnde sol terefden tek yerde dayanan simvollarin hamisi {a} simvoludurmu?
            string word = "AAAAAAAAAAAaaaaa";//"Azərbaycan Azərbaycan Üçrəngli bayrağınla məsud yaşa!"
            string a = word.Substring(1);
            int len=word.Length;
            int counter=0;


            for (int i = 0; i < len; i++)
            {
                if (word[len-1] == 'a')
                {
                    Console.WriteLine("Beraberdir");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Beraber deyil");
                    Console.ReadKey();
                }
            }
            Console.CursorTop = 1;
            
        }
    }
}
