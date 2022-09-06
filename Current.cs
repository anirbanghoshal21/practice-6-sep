using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Current : Ibank
    {
        public Current()
        {
            Console.WriteLine("Opening of new current account");
        }
        public void CalInterest()
        {
            double interest = bal * (0.02);
            Console.WriteLine($"interest: {interest}");
        }

        public void PrintBalance()
        {
            Console.WriteLine($"Balance: {bal}");
        }
    }
}
