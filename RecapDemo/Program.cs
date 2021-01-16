using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CuustomerMenager cuustomerMenager = new CuustomerMenager();
            cuustomerMenager.Logger = new FileLogger();
                cuustomerMenager.Add();

            Console.ReadLine();
        }
    }

    class CuustomerMenager
    {
        public ILogger Logger { get; set; }
        public void Add()
        {
            
            Logger.Log();
            Console.WriteLine("Customer added!");
        }
    }

    interface ILogger
    {
        void Log();
    }
    class DatabaseLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Database Looggged!!");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("File Looggged!!");
        }
    }



}
