using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CreateDAO
{
    class TestDAO
    {
        static void Main()
        {
            Console.WriteLine(DAO.InsertCustomer("ABDDW", "Nlqlqlq"));
            Console.WriteLine(DAO.InsertCustomer("ABDDW", "Nlqlqlq"));
            Console.WriteLine(DAO.ModifyCustomer("ABDDW", "aaaa", "tetstt"));
            Console.WriteLine(DAO.DeleteCustomer("ABDDW"));
            //Console.WriteLine(DAO.DeleteCustomer("ALFKI"));
        }
    }
}
