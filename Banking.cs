using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public static class Banking
    {
        public static void withdraw(this System.Object s,int bal)
        {
            Console.WriteLine("Enter the amount to be withdrawn");
            int amt = int.Parse(Console.ReadLine());
            if (bal > amt)
            {
                bal = bal - amt;
                Console.WriteLine("Amount withdraw successfully");
            }
            else
            {
                Console.WriteLine("Insufficent balance");
            }
        }
    }
}
