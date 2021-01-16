using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerMenager customerMenager = new CustomerMenager();
            //customerMenager.List();

            EmployeeMenager employeeMenager=new EmployeeMenager(new DatabaseLogger());
            
            employeeMenager.Add();

            PersonMenager personMenager = new PersonMenager("uuuuuuuuuu");
            personMenager.Add();

            Product product = new Product {id = 1, Name = "Engin"}; 
            Product product2 = new Product(2,"Derin");

            Teacher.Number = 10;
            Menager.DoSomething();
           // Menager.DoSomething2();//dindt work because it is not static
            Menager menager = new Menager();
            menager.DoSomething2();

            Console.ReadLine();
        }
    }

    class CustomerMenager
    {
        private int _count;

        public CustomerMenager()
        {
            
        }
        public CustomerMenager(int count)
        {
            _count = count;
        }
        public void List()
        {
            Console.WriteLine("Listed {0}",_count);
        }

        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }

    class Product
    {
        private int _id;
        private string _Name;

        public Product()
        {
            
        }

        public Product(int id,string Name)
        {
            _id = id;
            _Name = Name;
        }
        public int id { get; set; }
        public string Name { get; set; }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File");
        }
    }

    class EmployeeMenager
    {
        private ILogger _logger;
        public EmployeeMenager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Logged!!");          
        }
    }

    class BaseClass
    {
        private string _entity;

        public BaseClass(string entity)
        {
            _entity = entity;
        }

        public void Message()
        {
            Console.WriteLine("{0} message",_entity);
        }
    }
    class PersonMenager:BaseClass

    {

        public PersonMenager(string entity):base(entity)
        {
            
        }

        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
        }
    }

   static class Teacher
    {
        public static int Number { get; set; }
    }

   static class Utilities
   {
       public static void Validate()
       {
           Console.WriteLine("Validation is done");
       }
   }

   class Menager
   {
       public static void DoSomething()
       {
           Console.WriteLine("Done");
       }

       public void DoSomething2()
       {
           Console.WriteLine("Done22");
       }
   }
}
