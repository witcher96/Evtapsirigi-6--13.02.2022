using System;

namespace Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //11) Verilmish metinde butun {a} simvollarinin qabagina {b} simvolunu ve eyni zamandan butun { b}simvollarinin qabagina { a} simvolunu yaz.
            string word = "AAABBB";
            word = word.ToLower();
            int len = word.Length;

            string newWord = "";
            


            for (int i = 0; i < len; i++)
            {
                newWord = newWord + word[i];
                if (word[i] =='a')
                {

                    newWord = newWord + 'b';


                }
                if (word[i] == 'b')
                {

                    newWord = newWord + 'a';

                }
            }
                    Console.WriteLine(newWord);



        }
    }
}
