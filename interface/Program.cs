using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces;

namespace @interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //InterfacesVeri();
            Console.ReadLine();
        }

        private static void InterfacesVeri()
        {
            Menangement menajer = new Menangement();
            menajer.ADD(new SqlServer());
            menajer.ADD(new OracleServer());
        }


        private static void InterfacesIntro()
        {
            PersonMenager menager = new PersonMenager();
            menager.ADD(new Customer {ID = 1, FirstName = "Şafii", LastName = "ERİĞ", Adress = "MARDİN"});

            Student orengeStudent = new Student
            {
                ID = 5, FirstName = "Orange", LastName = "Stu", Department = "nwwwww"
            };

            menager.ADD(orengeStudent);
            
        }





        interface IPerson
        {
             int ID { get; set; }
             string FirstName { get; set; }
             string LastName { get; set; }

        }

        class Customer : IPerson
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Adress { get; set; }
        }
        class Student : IPerson
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public string Department { get; set; }
        }

        class PersonMenager
        {
            public void ADD(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
	}
}
