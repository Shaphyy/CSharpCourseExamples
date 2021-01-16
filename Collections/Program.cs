using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();

            List<string> sources = new List<string>();
            sources.Add("adas");
            sources.Add("asdasd");
            sources.Add("lalala");

            foreach (var source in sources)
            {
                Console.WriteLine(source);
            }




            List<strawberry> cilek = new List<strawberry>
            {
                new strawberry{id=1,name = "birinci",surname = "ikinci"}
            };

            cilek.Add(new strawberry(){id = 2,name = "ikinci",surname = "birinci"});




        Console.ReadLine();
        }






        private static void ArrayList()
        {
            ArrayList halls = new ArrayList();

            halls.Add("YALIN");
            halls.Add("-e");
            halls.Add("-i");
            halls.Add("-de");
            halls.Add("-den");

            foreach (var hall in halls)
            {
                Console.WriteLine(hall);
            }
        }
    }


    class strawberry
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }

    }


}
