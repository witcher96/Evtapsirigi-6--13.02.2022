using System;
using System.Text;

namespace Task_12
{
    internal class Program
       
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //12) Verilmish metinde en ilk ve en son {a} simvolundan bashqa yerde qalan butun {a} simvollarini yox et.
            string word = "Azararcara";
            word = word.ToLower();
            char[] simvol = {'a'};
            int firstindex=word.IndexOfAny(simvol);
            int lastindex = word.LastIndexOfAny(simvol);
            Console.WriteLine(firstindex);
            Console.WriteLine(lastindex);
            
            
                word = word.Insert(firstindex,"@");
                word = word.Insert(lastindex+2, "@");
                word = word.Replace('a', '-');
                word = word.Replace('@', 'a');
                Console.WriteLine(word);

        }
    }
}
