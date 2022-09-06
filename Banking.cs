using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Person
{
    public static class Banking
    {

        public static void deposit(this System.Object s, int bal)
        {
            Console.WriteLine("Enter the amount to be deposited");
            int amt = int.Parse(Console.ReadLine());
            if (amt > 0)
            {
                bal = bal - amt;
                Console.WriteLine("Deposit successfully");
            }
            else
            {
                Console.WriteLine(" 0 can't be a amount");
            }
        }
        public void TotNoOfDaysDeposit(object NoOfDays)
        {
            Console.WriteLine($" NoOfdays: {NoOfDays}");
        }
    }
}
    

