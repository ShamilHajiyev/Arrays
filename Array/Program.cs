using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task: Bir string arrayinin icersinde uzunlugu 5 den boyuk olan sozleri ekrana cixardan bir alqoritm yazin.

            Console.WriteLine("How many words you want to enter: ");
            int wordsCount = Convert.ToInt32(Console.ReadLine());
            string[] words = new string [wordsCount];
            Console.WriteLine("\nEnter words:");
            for (int i = 0; i < wordsCount; i++)
            {
                words[i] = Console.ReadLine();
            }
            Console.WriteLine("\nWords with length more than 5:");
            bool isExist = false;
            foreach (string str in words)
            {
                if (str.Length > 5)
                {
                    isExist = true;
                    Console.WriteLine(str);
                }
            }
            if (!isExist)
            {
                Console.WriteLine("none");
            }
        }
    }
}
