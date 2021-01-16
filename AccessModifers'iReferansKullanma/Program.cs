using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessModifiers;

namespace AccessModifers_iReferansKullanma
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course();//it is not work (internal)
            HalkaAcik halkaAcik = new HalkaAcik();// it is work (public)
        }
    }
}
