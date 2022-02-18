using System;

namespace Task_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            // 13) Verilimish metinde butun simvollari ardicil shekilde biri balaca, biri boyuk formada cap et.
            string word = "Azərbaycan Azərbaycan Üçrəngli bayrağınla məsud yaşa";
            word=word.ToLower();
            Console.WriteLine(word);
            int u=word.Length;

            for(int i = 0; i < u; i++)
            {





                if (i % 2 == 1)
                {

                    Console.Write(word.ToLower()[i]);


                }
                else if (i % 2 == 0)
                {

                    Console.Write(word.ToUpper()[i]);
                    Console.CursorTop=0;
                }


            }
           
        }
    }
}
