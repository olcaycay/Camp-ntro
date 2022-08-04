using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "yazılımci gelistirme kursu", "temel kurs", "java","C++" ,"sql" };

  
            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
                

            }
            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
