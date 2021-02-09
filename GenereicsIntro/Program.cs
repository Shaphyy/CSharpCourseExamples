using System;

namespace GenereicsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimlerList = new MyList<string>();
            isimlerList.Add("aaaaaaa");
            isimlerList.Add("bbbb");
            isimlerList.Add("ccccccc");
            isimlerList.Add("dddddd");


            isimlerList.ShowList();
        }
    }
}
