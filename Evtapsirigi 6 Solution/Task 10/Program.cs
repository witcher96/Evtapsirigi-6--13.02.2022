using System;
using System.Linq;

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
            soz=soz.ToLower();
            int len =soz.Length;
            int[] charcodes=Enumerable.Range(48,10).ToArray();
            string karak = "";

            for (int i = 0; i < len; i++)
            {
                byte bit=Convert.ToByte(soz[i]);

                if (Array.IndexOf(charcodes,bit)==-1)
                {
                karak = karak + soz[i];

                }
            }
            Console.WriteLine(karak);
          

        }
    }
}
