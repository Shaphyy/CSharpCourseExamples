
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            //forDongusu();
            //SehirToplama();

            Random random = new Random();
            int deger; 


            for (int i = 0; i < 10; i++)
            {
                deger = random.Next(75,150);

                if (deger<100)
                {
                    deger=deger+200;
                }
                else if (deger <125)
                {
                    deger = deger + 500;
                }
                else
                {
                    deger = deger - 200;
                }
                
                
                
                
                
                Console.WriteLine(deger);
            }
            



            Console.ReadLine();
        }




        private static void SehirToplama()
        {
            string city = "Ankara";
            string city2 = "İstanbul";

            Console.WriteLine("{0} {1}", city, city2);
        }

        private static void forDongusu()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
