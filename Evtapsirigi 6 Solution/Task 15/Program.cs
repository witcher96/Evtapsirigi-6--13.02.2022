using System;

namespace Task_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //15)* Verilmish metinde ilk ve son simvol eynidirse,
            //ve metn daxilinde yanashi gelen { a}simvolu varsa,ve metn daxilinde { b}simvolu yoxdursa
            //o zaman bu metnde butun { c}simvollari yox et veneticede alinan metn zerkalni olub olmadigini yoxla.
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string word = "raccaar";
            string firstindex =word.Substring(0,1);
            string lastindex=word.Substring(word.Length-1,1);
            char[] a = { 'a' };
            string alpha=word.IndexOfAny('a');


            for (int i = 0; i < word.Length-1; i++)
            {
                if (firstindex == lastindex && word[i] != 'b')
            {
                    word = word.Replace('c', ' ');
                    Console.WriteLine(word);
                    Console.ReadKey();
             }
            else
            {
                    Console.WriteLine(":(");
                    break;
                }

            }
            

        }
    }
}
