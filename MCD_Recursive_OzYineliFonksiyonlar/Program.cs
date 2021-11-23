using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_Recursive_OzYineliFonksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 15; i++)
            {
                long sayiFaktoriyel = Faktoriyel(i);
                Console.WriteLine($"{i} sayısının faktöriyeli= "+sayiFaktoriyel);
            }

            Console.ReadLine();
            
        }

        static long Faktoriyel(long sayac)
        {
            //Metod kendi içinde kendisini çağırıyor.
            //Böyle metodlara recursive öz yineli fonksiyon denir.

            if (sayac<=1)
            {
                return 1;
            }
            return sayac * Faktoriyel(sayac - 1);

        }
    }
}
