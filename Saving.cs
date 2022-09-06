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
        public void CalInterest()
        {
            throw new NotImplementedException();
        }

        public void PrintBalance()
        {
            throw new NotImplementedException();
        }

    }
}
