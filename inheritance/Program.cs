using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {


            Cocuk evlat1 =new Cocuk();
            evlat1.tip();

            Anne evlat2 = new Kiz();
            evlat2.Burc();







            Console.ReadLine();
        }


    }






    class Baba
    {
        public void genler()
        {
            Console.WriteLine("Babanın genleri");
        }

        public virtual void tip()
        {
            Console.WriteLine("Tip babadan");
        }
    }

    class Cocuk : Baba
    {
        public override void tip()
        {
            base.tip();
            Console.WriteLine("kayık");
        }

    }

    abstract class Anne
    {
        public abstract void Burc();
    }

    class Kiz : Anne
    {
        public override void Burc()
        {
            Console.WriteLine("Kızın burccu annesinden bağımsızdır..");
        }
    }

}
