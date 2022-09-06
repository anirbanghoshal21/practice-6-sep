using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    abstract class Person
    {
        public abstract void work();
    }

    class Manager : Person
    {
        public override void work()
        {
            Console.WriteLine("Manager");
        }

        class Employee : Person
        {
            public override void work()
            {
                Console.WriteLine("Employee");
            }
        }

        class Clerk : Person
        {
            public override void work()
            {
                Console.WriteLine("Clerk");
            }
        }
    }
}
