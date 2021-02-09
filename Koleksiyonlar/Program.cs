using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler= new string[]{"asdasd","asdaddd","asddddaa"};
            List<string> isimler2 = new List<string>() { "asdasd", "asdaddd", "asddddaa" };
            isimler2.Add("Deneeemişkım");
     //       isimler2[4] = "bu da çalışsın hadi";//Çalşmadı hshsh
            Console.WriteLine(isimler2[4]);

        }
    }
}
