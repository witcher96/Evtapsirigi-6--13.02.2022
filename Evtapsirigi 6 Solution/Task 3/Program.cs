using System;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            // 3) Verilmish metnde sol terefden tek yerde dayanan simvollardan necesi { b } -ye beraberdir.

            string word = "Azərbaycan Azərbaycan Üçrəngli bayrağınla məsud yaşa!";
            word = word.ToLower();
            int u =word.Length;
            int counter=0;


            for (int i = 0; i < u; i++)
            {
                if ( word[i]=='b')
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
