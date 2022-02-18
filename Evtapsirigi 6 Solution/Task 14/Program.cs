using System;

namespace Task_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14) Verilmish metinde butun tek yerde dayanan simvollari ondan sonra gelen simvolun BOYUK formasi ile evez et.
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string word = "AzerbaycanRespublikasi";
            word=word.ToLower();
            int u = word.Length;
            for (int i = 0; i < u; i++)
            {
                if (i%2==0)
                {
                    word = word.Replace(word[i], word[i + 1]);
                    
                }
                if (i % 2 == 0)
                {
                    Console.Write(word.ToUpper()[i]);

                }
                else if(i % 2 == 1){
                    Console.Write(word.ToLower()[i]);
                }

            }
            
        }
    }
}
