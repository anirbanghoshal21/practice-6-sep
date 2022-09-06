using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_oops
{
    interface Ibank
    {
        void Printbalance();

        void CalculateInterest();
    }

    static void Main(string[] args)
    {
        Manager m = new Manager();
        Employee e = new Employee();
        Clerk c = new Clerk();

        Console.WriteLine(" HDFC Bank");
    }
}
