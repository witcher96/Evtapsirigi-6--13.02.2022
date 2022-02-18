using System;

namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //10) Verilmish metinde butun reqemleri legv et.

            string soz="Alma4 armud3 heyva223 3a4rkajz2"; 
            int len =soz.Length;

            soz = soz.Replace("1", " ");
            soz = soz.Replace("2", " ");
            soz = soz.Replace("3", " ");
            soz = soz.Replace("4", " ");
            soz = soz.Replace("5", " ");
            Console.WriteLine(soz);


            //for (int i = 0; i < len; i++)
            //{
            //    if (i >= 0)
            //    {
            //        soz = soz.Remove(i,i);
            //    }
            //}
            //Console.WriteLine(soz);

        }
    }
}
