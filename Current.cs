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
            throw new NotImplementedException();
        }

        public void PrintBalance()
        {
            throw new NotImplementedException();
        }
    }
}
