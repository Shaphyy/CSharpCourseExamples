using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Customer
    {
         int id;
         protected int ia { set; get; }
    }

    class Student:Customer
    {
        public void Save()
        {
            
            Console.WriteLine(id);//didn't work
            Console.WriteLine(ia);//works
        }
    }

    class Course
    {
        public string AddName { get; set; }
    }

    public class HalkaAcik
    {
        public string Name { get; set; }
    }
}
