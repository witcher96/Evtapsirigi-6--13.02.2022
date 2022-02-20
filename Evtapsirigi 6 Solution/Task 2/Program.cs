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
            string word = "alfadeltabravo";//"Azərbaycan Azərbaycan Üçrəngli bayrağınla məsud yaşa!"
            word=word.ToLower();
            int len=word.Length;
            char a = 'a';
            bool okey = true;


            for (int i = 0; i < len; i++)
            {
                if (i % 2 == 0)
                {
                    if(word[i] != a)
                    {
                        okey = false;
                        break;
                    }
                }

            }
            if (okey == true)
            {
                Console.WriteLine("dogrudur");
            }
            else
            {
                Console.WriteLine("yanlisdir");
            }
             
            
        }
    }
}
