using System;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4) Verilmish metnde sol terefden ilk rast gelinen { a}  simvolunun yeri tek ededdi yoxsa cut ?

            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            string word = "Azərbaycan Azərbaycan Üçrəngli bayrağınla məsud yaşa!";
            word = word.ToLower();

            char[] mass = {'a'};

            int index = word.IndexOfAny(mass);
            bool istrue = (word[index]) % 2 == 0;

            if (istrue)
            {
                Console.WriteLine("Cutdur");
            }
            else
            {
                Console.WriteLine("Tekdir");
            }

            
        }
    }
}
