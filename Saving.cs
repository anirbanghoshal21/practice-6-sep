using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Saving : Ibank
    {
        public Saving()
        {
            Console.WriteLine("Opening of new saving account");
        }
        public static int bal = 0;

        public int balance
        {
            get { return bal; }
            set { bal = value; }
        }

        public void CalInterest()
        {
            double interest = bal * (0.04);
            Console.WriteLine($"interest: {interest}");
        }

        public void PrintBalance()
        {
            Console.WriteLine($"Balance: {bal}");
        }

    }
}
