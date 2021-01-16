using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces

{
    interface ICustomerDal
    {
        void Add();

    }

    class SqlServer : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SQL added!");
        }
    }

    class OracleServer : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added!");
        }
    }

    class Menangement
    {
        public void ADD(ICustomerDal cusuzumu)
        {
            cusuzumu.Add();
        }
    }

}
