using System;

namespace Task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //9) Verilmish metinde ilk 3 simvol, son 3 simvolun tersine formasina beraberdirmi.?
            string word = "Azerbaycanaze";
             word=word.ToLower();
            string ilk = word.Substring(0, 3);
            int u=word.Length;
            Console.WriteLine($"Ilk 3 simvol: {ilk}");
            string son= word.Substring(u-3);
            Console.WriteLine($"Son 3 simvol {son}");
                                
           
         int len = son.Length;
           
            for (int i = len-1 ; i >=0 ; i--)
            {

            if (ilk==son)
            {
                Console.WriteLine("Beli");
                    break;
            }
            else
            {
                Console.WriteLine("Xeyr");
                    break;
                
            }
                
               
            }
            

            



        }
    }
}
